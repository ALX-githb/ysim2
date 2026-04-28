#pragma warning disable 618 // Unity-deprecated APIs (AIBase.target, AIPath.speed, WWW, GetInstanceID, CF2Input.GetKeyDown(string), Physics2D.OverlapPointNonAlloc) still functional; full migration would change behavior or require coroutine refactors.
using UnityEngine;

public class NoteLockerScript : MonoBehaviour
{
	public StudentManagerScript StudentManager;

	public NoteWindowScript NoteWindow;

	public PromptBarScript PromptBar;

	public StudentScript Student;

	public YandereScript Yandere;

	public ListScript MeetSpots;

	public PromptScript Prompt;

	public GameObject NewBall;

	public GameObject NewNote;

	public GameObject Locker;

	public GameObject Ball;

	public GameObject Note;

	public AudioClip NoteSuccess;

	public AudioClip NoteFail;

	public AudioClip NoteFind;

	public bool CheckingNote;

	public bool CanLeaveNote = true;

	public bool SpawnedNote;

	public bool NoteLeft;

	public bool Success;

	public float MeetTime;

	public float Timer;

	public int LockerOwner;

	public int MeetID;

	public int Phase = 1;

	private void Start()
	{
		if (StudentGlobals.GetStudentDead(LockerOwner))
		{
			base.gameObject.SetActive(false);
		}
	}

	private void Update()
	{
		if (Student != null)
		{
			Vector3 b = new Vector3(base.transform.position.x, Student.transform.position.y, base.transform.position.z);
			if (Prompt.enabled)
			{
				if (Vector3.Distance(Student.transform.position, b) < 1f || Yandere.Armed)
				{
					Prompt.Hide();
					Prompt.enabled = false;
				}
			}
			else if (CanLeaveNote && Vector3.Distance(Student.transform.position, b) > 1f && !Yandere.Armed)
			{
				Prompt.enabled = true;
			}
		}
		else
		{
			Student = StudentManager.Students[LockerOwner];
		}
		if (Prompt != null && Prompt.Circle[0].fillAmount == 0f)
		{
			Prompt.Circle[0].fillAmount = 1f;
			NoteWindow.NoteLocker = this;
			Yandere.Blur.enabled = true;
			NoteWindow.gameObject.SetActive(true);
			Yandere.CanMove = false;
			NoteWindow.Show = true;
			Yandere.HUD.alpha = 0f;
			PromptBar.Show = true;
			Time.timeScale = 0.0001f;
			PromptBar.Label[0].text = "Confirm";
			PromptBar.Label[1].text = "Cancel";
			PromptBar.Label[4].text = "Select";
			PromptBar.UpdateButtons();
		}
		if (!NoteLeft)
		{
			return;
		}
		if (Student != null && (Student.Phase == 2 || Student.Phase == 8) && Student.Routine && Vector3.Distance(base.transform.position, Student.transform.position) < 2f && !Student.InEvent)
		{
			Student.Character.GetComponent<Animation>().cullingType = AnimationCullingType.AlwaysAnimate;
			if (!Success)
			{
				Student.Character.GetComponent<Animation>().CrossFade("f02_tossNote_00");
				Locker.GetComponent<Animation>().CrossFade("lockerTossNote");
			}
			else
			{
				Student.Character.GetComponent<Animation>().CrossFade("f02_keepNote_00");
				Locker.GetComponent<Animation>().CrossFade("lockerKeepNote");
			}
			Student.Pathfinding.canSearch = false;
			Student.Pathfinding.canMove = false;
			Student.CheckingNote = true;
			Student.Routine = false;
			Student.InEvent = true;
			CheckingNote = true;
		}
		if (!CheckingNote)
		{
			return;
		}
		Timer += Time.deltaTime;
		Student.MoveTowardsTarget(Student.MyLocker.position);
		Student.transform.rotation = Quaternion.Slerp(Student.transform.rotation, Student.MyLocker.rotation, 10f * Time.deltaTime);
		if (Student != null)
		{
			Animation component = Student.Character.GetComponent<Animation>();
			if (component["f02_tossNote_00"].time >= component["f02_tossNote_00"].length)
			{
				Finish();
			}
			if (component["f02_keepNote_00"].time >= component["f02_keepNote_00"].length)
			{
				DetermineSchedule();
				Finish();
			}
		}
		if (Timer > 4.6666665f && !SpawnedNote)
		{
			NewNote = Object.Instantiate(Note, base.transform.position, Quaternion.identity);
			NewNote.transform.parent = Student.LeftHand;
			NewNote.transform.localPosition = new Vector3(-0.06f, -0.01f, 0f);
			NewNote.transform.localEulerAngles = new Vector3(-75f, -90f, 180f);
			NewNote.transform.localScale = new Vector3(0.1f, 0.2f, 1f);
			SpawnedNote = true;
		}
		if (!Success)
		{
			if (Timer > 11.666667f && NewNote != null)
			{
				if (NewNote.transform.localScale.z > 0.1f)
				{
					NewNote.transform.localScale = Vector3.MoveTowards(NewNote.transform.localScale, Vector3.zero, Time.deltaTime);
				}
				else
				{
					Object.Destroy(NewNote);
				}
			}
			if (Timer > 13.333333f && NewBall == null)
			{
				NewBall = Object.Instantiate(Ball, Student.LeftHand.position, Quaternion.identity);
				Rigidbody component2 = NewBall.GetComponent<Rigidbody>();
				component2.AddRelativeForce(Vector3.right * 100f);
				component2.AddRelativeForce(Vector3.up * 100f);
				Phase++;
			}
		}
		else if (Timer > 12.833333f && NewNote != null)
		{
			if (NewNote.transform.localScale.z > 0.1f)
			{
				NewNote.transform.localScale = Vector3.MoveTowards(NewNote.transform.localScale, Vector3.zero, Time.deltaTime);
			}
			else
			{
				Object.Destroy(NewNote);
			}
		}
		if (Phase == 1)
		{
			if (Timer > 2.3333333f)
			{
				Yandere.Subtitle.UpdateLabel(SubtitleType.NoteReaction, 1, 3f);
				Phase++;
			}
		}
		else
		{
			if (Phase != 2)
			{
				return;
			}
			if (!Success)
			{
				if (Timer > 9.666667f)
				{
					Yandere.Subtitle.UpdateLabel(SubtitleType.NoteReaction, 2, 3f);
					Phase++;
				}
			}
			else if (Timer > 10.166667f)
			{
				Yandere.Subtitle.UpdateLabel(SubtitleType.NoteReaction, 3, 3f);
				Phase++;
			}
		}
	}

	private void Finish()
	{
		if (Success && Student.Clock.HourTime > Student.MeetTime)
		{
			Student.CurrentDestination = Student.MeetSpot;
			Student.Pathfinding.target = Student.MeetSpot;
			Student.Pathfinding.canSearch = true;
			Student.Pathfinding.canMove = true;
			Student.Meeting = true;
			Student.MeetTime = 0f;
		}
		Animation component = Student.Character.GetComponent<Animation>();
		component.cullingType = AnimationCullingType.BasedOnRenderers;
		component.CrossFade(Student.IdleAnim);
		Student.DistanceToDestination = 100f;
		Student.CheckingNote = false;
		Student.InEvent = false;
		Student.Routine = true;
		CheckingNote = false;
		NoteLeft = false;
		Phase++;
	}

	private void DetermineSchedule()
	{
		Student.MeetSpot = MeetSpots.List[MeetID];
		Student.MeetTime = MeetTime;
	}
}
