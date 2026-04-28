using UnityEngine;

public class GiggleScript : MonoBehaviour
{
	public GameObject EmptyGameObject;

	public GameObject Giggle;

	public StudentScript Student;

	public bool StudentIsBusy;

	public bool Distracted;

	public int Frame;

	private void Start()
	{
		float num = 500f * (2f - SchoolGlobals.SchoolAtmosphere);
		base.transform.localScale = new Vector3(num, base.transform.localScale.y, num);
	}

	private void Update()
	{
		if (Frame > 0)
		{
			Object.Destroy(base.gameObject);
		}
		Frame++;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer != 9 || Distracted)
		{
			return;
		}
		Student = other.gameObject.GetComponent<StudentScript>();
		if (!(Student != null) || !(Student.Giggle == null))
		{
			return;
		}
		if (Student.Clock.Period == 3 && Student.BusyAtLunch)
		{
			StudentIsBusy = true;
		}
		if ((Student.StudentID == 22 || Student.StudentID == 24) && Student.StudentManager.ConvoManager.Confirmed)
		{
			StudentIsBusy = true;
		}
		if (Student.YandereVisible || Student.Alarmed || Student.Distracted || Student.Wet || Student.Slave || Student.WitnessedMurder || Student.WitnessedCorpse || Student.Investigating || Student.InEvent || Student.Following || Student.Confessing || Student.Meeting || Student.TurnOffRadio || Student.Fleeing || Student.Distracting || Student.GoAway || Student.FocusOnYandere || StudentIsBusy || Student.Actions[Student.Phase] == StudentActionType.Teaching || Student.Actions[Student.Phase] == StudentActionType.SitAndTakeNotes || Student.Actions[Student.Phase] == StudentActionType.Graffiti || Student.Actions[Student.Phase] == StudentActionType.Bully || !Student.Routine || Student.Persona == PersonaType.Protective)
		{
			return;
		}
		Student.Character.GetComponent<Animation>().CrossFade(Student.IdleAnim);
		Giggle = Object.Instantiate(EmptyGameObject, new Vector3(base.transform.position.x, Student.transform.position.y, base.transform.position.z), Quaternion.identity);
		Student.Giggle = Giggle;
		if (Student.Pathfinding != null && !Student.Nemesis)
		{
			Student.Pathfinding.canSearch = false;
			Student.Pathfinding.canMove = false;
			Student.InvestigationPhase = 0;
			Student.InvestigationTimer = 0f;
			Student.Investigating = true;
			Student.SpeechLines.Stop();
			Student.DiscCheck = true;
			Student.Routine = false;
			Student.ReadPhase = 0;
			Student.StopPairing();
			if (Student.Persona != PersonaType.PhoneAddict && !Student.Sleuthing)
			{
				Student.SmartPhone.SetActive(false);
			}
			else
			{
				Student.SmartPhone.SetActive(true);
			}
			Student.OccultBook.SetActive(false);
			Student.Pen.SetActive(false);
			if (!Student.Male)
			{
				Student.Cigarette.SetActive(false);
				Student.Lighter.SetActive(false);
			}
		}
		Distracted = true;
	}
}
