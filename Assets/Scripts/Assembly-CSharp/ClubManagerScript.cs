using UnityEngine;

public class ClubManagerScript : MonoBehaviour
{
	public ShoulderCameraScript ShoulderCamera;

	public StudentManagerScript StudentManager;

	public ComputerGamesScript ComputerGames;

	public BloodCleanerScript BloodCleaner;

	public RefrigeratorScript Refrigerator;

	public ClubWindowScript ClubWindow;

	public ContainerScript Container;

	public PromptBarScript PromptBar;

	public TranqCaseScript TranqCase;

	public YandereScript Yandere;

	public RPG_Camera MainCamera;

	public DoorScript ShedDoor;

	public PoliceScript Police;

	public GloveScript Gloves;

	public UISprite Darkness;

	public GameObject Reputation;

	public GameObject Heartrate;

	public GameObject Watermark;

	public GameObject Padlock;

	public GameObject Ritual;

	public GameObject Clock;

	public AudioClip[] MotivationalQuotes;

	public Transform[] ClubPatrolPoints;

	public Transform[] ClubVantages;

	public MaskScript[] Masks;

	public Transform[] Club4ActivitySpots;

	public Transform[] Club6ActivitySpots;

	public Transform Club7ActivitySpot;

	public Transform[] Club8ActivitySpots;

	public Transform[] Club10ActivitySpots;

	public int[] Club3Students;

	public int[] Club4Students;

	public int[] Club6Students;

	public int[] Club7Students;

	public int[] Club8Students;

	public int[] Club9Students;

	public int[] Club10Students;

	public bool ClubEffect;

	public AudioClip OccultAmbience;

	public int ClubPhase;

	public int Phase = 1;

	public ClubType Club;

	public int ID;

	public float TimeLimit;

	public float Timer;

	public ClubType[] ClubArray;

	public bool LeaderMissing;

	public bool LeaderDead;

	public int ClubMembers;

	public int[] Club3IDs;

	public int[] Club4IDs;

	public int[] Club6IDs;

	public int[] Club7IDs;

	public int[] Club8IDs;

	public int[] Club9IDs;

	public int[] Club10IDs;

	public int[] ClubIDs;

	public bool LeaderGrudge;

	public bool ClubGrudge;

	private void Start()
	{
		ClubWindow.ActivityWindow.localScale = Vector3.zero;
		ClubWindow.ActivityWindow.gameObject.SetActive(false);
		ActivateClubBenefit();
		for (ID = 0; ID < ClubArray.Length; ID++)
		{
			if (ClubGlobals.GetClubClosed(ClubArray[ID]))
			{
				if (ClubArray[ID] == ClubType.Gardening)
				{
					ClubPatrolPoints[ID].transform.position = new Vector3(-56f, ClubPatrolPoints[ID].transform.position.y, ClubPatrolPoints[ID].transform.position.z);
				}
				else if (ClubArray[ID] != ClubType.Sports)
				{
					ClubPatrolPoints[ID].transform.position = new Vector3(ClubPatrolPoints[ID].transform.position.x, ClubPatrolPoints[ID].transform.position.y, 20f);
				}
			}
		}
		if (ClubGlobals.GetClubClosed(ClubArray[2]))
		{
			StudentManager.HidingSpots.List[56] = StudentManager.Hangouts.List[56];
			StudentManager.HidingSpots.List[57] = StudentManager.Hangouts.List[57];
			StudentManager.HidingSpots.List[58] = StudentManager.Hangouts.List[58];
			StudentManager.HidingSpots.List[59] = StudentManager.Hangouts.List[59];
			StudentManager.HidingSpots.List[60] = StudentManager.Hangouts.List[60];
			StudentManager.SleuthPhase = 3;
		}
		ID = 0;
	}

	private void Update()
	{
		if (Club == ClubType.None)
		{
			return;
		}
		if (Phase == 1)
		{
			Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, Mathf.MoveTowards(Darkness.color.a, 0f, Time.deltaTime));
		}
		AudioSource component = GetComponent<AudioSource>();
		if (Darkness.color.a == 0f)
		{
			if (Phase == 1)
			{
				PromptBar.ClearButtons();
				PromptBar.Label[0].text = "Continue";
				PromptBar.UpdateButtons();
				PromptBar.Show = true;
				ClubWindow.PerformingActivity = true;
				ClubWindow.ActivityWindow.gameObject.SetActive(true);
				ClubWindow.ActivityLabel.text = ClubWindow.ActivityDescs[(int)Club];
				Phase++;
			}
			else if (Phase == 2)
			{
				if (ClubWindow.ActivityWindow.localScale.x > 0.9f)
				{
					if (Club == ClubType.MartialArts)
					{
						if (ClubPhase == 0)
						{
							component.clip = MotivationalQuotes[Random.Range(0, MotivationalQuotes.Length)];
							component.Play();
							ClubEffect = true;
							ClubPhase++;
							TimeLimit = component.clip.length;
						}
						else if (ClubPhase == 1)
						{
							Timer += Time.deltaTime;
							if (Timer > TimeLimit)
							{
								for (ID = 0; ID < Club6Students.Length; ID++)
								{
									if (StudentManager.Students[ID] != null && !StudentManager.Students[ID].Tranquil)
									{
										StudentManager.Students[Club6Students[ID]].GetComponent<AudioSource>().volume = 1f;
									}
								}
								ClubPhase++;
							}
						}
					}
					if (ControlFreak2.CF2Input.GetButtonDown("A"))
					{
						ClubWindow.PerformingActivity = false;
						PromptBar.Show = false;
						Phase++;
					}
				}
			}
			else if (ClubWindow.ActivityWindow.localScale.x < 0.1f)
			{
				Police.Darkness.enabled = true;
				Police.ClubActivity = false;
				Police.FadeOut = true;
			}
		}
		if (Club == ClubType.Occult)
		{
			component.volume = 1f - Darkness.color.a;
		}
	}

	public void ClubActivity()
	{
		StudentManager.StopMoving();
		ShoulderCamera.enabled = false;
		MainCamera.enabled = false;
		MainCamera.transform.position = ClubVantages[(int)Club].position;
		MainCamera.transform.rotation = ClubVantages[(int)Club].rotation;
		if (Club == ClubType.Occult)
		{
			for (ID = 0; ID < Club3Students.Length; ID++)
			{
				StudentScript studentScript = StudentManager.Students[Club3Students[ID]];
				if (studentScript != null && !studentScript.Tranquil)
				{
					studentScript.gameObject.SetActive(false);
				}
			}
			MainCamera.GetComponent<AudioListener>().enabled = true;
			AudioSource component = GetComponent<AudioSource>();
			component.clip = OccultAmbience;
			component.loop = true;
			component.volume = 0f;
			component.Play();
			Yandere.gameObject.SetActive(false);
			Ritual.SetActive(true);
		}
		else if (Club == ClubType.Art)
		{
			for (ID = 0; ID < Club4Students.Length; ID++)
			{
				StudentScript studentScript2 = StudentManager.Students[Club4Students[ID]];
				if (studentScript2 != null && !studentScript2.Tranquil && studentScript2.Alive)
				{
					studentScript2.transform.position = Club4ActivitySpots[ID].position;
					studentScript2.transform.rotation = Club4ActivitySpots[ID].rotation;
					studentScript2.ClubActivity = true;
					studentScript2.Talking = false;
					studentScript2.Routine = true;
					studentScript2.GetComponent<AudioSource>().volume = 0.1f;
					if (!studentScript2.ClubAttire)
					{
						studentScript2.ChangeClubwear();
					}
				}
			}
			Yandere.Talking = false;
			Yandere.CanMove = false;
			Yandere.ClubActivity = true;
			Yandere.transform.position = Club4ActivitySpots[5].position;
			Yandere.transform.rotation = Club4ActivitySpots[5].rotation;
			if (!Yandere.ClubAttire)
			{
				Yandere.ChangeClubwear();
			}
		}
		else if (Club == ClubType.MartialArts)
		{
			for (ID = 0; ID < Club6Students.Length; ID++)
			{
				StudentScript studentScript3 = StudentManager.Students[Club6Students[ID]];
				if (studentScript3 != null && !studentScript3.Tranquil && studentScript3.Alive)
				{
					studentScript3.transform.position = Club6ActivitySpots[ID].position;
					studentScript3.transform.rotation = Club6ActivitySpots[ID].rotation;
					studentScript3.ClubActivity = true;
					studentScript3.GetComponent<AudioSource>().volume = 0.1f;
					if (!studentScript3.ClubAttire)
					{
						studentScript3.ChangeClubwear();
					}
				}
			}
			Yandere.CanMove = false;
			Yandere.ClubActivity = true;
			Yandere.transform.position = Club6ActivitySpots[5].position;
			Yandere.transform.rotation = Club6ActivitySpots[5].rotation;
			if (!Yandere.ClubAttire)
			{
				Yandere.ChangeClubwear();
			}
		}
		else if (Club == ClubType.Photography)
		{
			for (ID = 0; ID < Club7Students.Length; ID++)
			{
				StudentScript studentScript4 = StudentManager.Students[Club7Students[ID]];
				if (studentScript4 != null && !studentScript4.Tranquil && studentScript4.Alive)
				{
					studentScript4.transform.position = StudentManager.Clubs.List[studentScript4.StudentID].position;
					studentScript4.transform.rotation = StudentManager.Clubs.List[studentScript4.StudentID].rotation;
					studentScript4.CharacterAnimation[studentScript4.SocialSitAnim].weight = 1f;
					studentScript4.GetComponent<AudioSource>().volume = 0.1f;
					studentScript4.SmartPhone.SetActive(false);
					studentScript4.ClubActivity = true;
					studentScript4.SpeechLines.Play();
					studentScript4.Talking = false;
					studentScript4.Routine = true;
					studentScript4.Hearts.Stop();
				}
			}
			Yandere.CanMove = false;
			Yandere.Talking = false;
			Yandere.ClubActivity = true;
			Yandere.transform.position = Club7ActivitySpot.position;
			Yandere.transform.rotation = Club7ActivitySpot.rotation;
			if (!Yandere.ClubAttire)
			{
				Yandere.ChangeClubwear();
			}
		}
		else if (Club == ClubType.Science)
		{
			for (ID = 0; ID < Club8Students.Length; ID++)
			{
				StudentScript studentScript5 = StudentManager.Students[Club8Students[ID]];
				if (studentScript5 != null && !studentScript5.Tranquil && studentScript5.Alive)
				{
					studentScript5.transform.position = Club8ActivitySpots[ID].position;
					studentScript5.transform.rotation = Club8ActivitySpots[ID].rotation;
					studentScript5.ClubActivity = true;
					studentScript5.Talking = false;
					studentScript5.Routine = true;
					studentScript5.GetComponent<AudioSource>().volume = 0.1f;
					if (!studentScript5.ClubAttire)
					{
						studentScript5.ChangeClubwear();
					}
				}
			}
			Yandere.Talking = false;
			Yandere.CanMove = false;
			Yandere.ClubActivity = true;
			if (!Yandere.ClubAttire)
			{
				Yandere.ChangeClubwear();
			}
		}
		else if (Club == ClubType.Sports)
		{
			for (ID = 0; ID < Club9Students.Length; ID++)
			{
				StudentScript studentScript6 = StudentManager.Students[Club9Students[ID]];
				if (studentScript6 != null && !studentScript6.Tranquil && studentScript6.Alive)
				{
					studentScript6.transform.position = studentScript6.CurrentDestination.position;
					studentScript6.transform.rotation = studentScript6.CurrentDestination.rotation;
					studentScript6.ClubActivity = true;
					studentScript6.Talking = false;
					studentScript6.Routine = true;
					studentScript6.GetComponent<AudioSource>().volume = 0.1f;
				}
			}
			Yandere.Talking = false;
			Yandere.CanMove = false;
			Yandere.ClubActivity = true;
			Yandere.Schoolwear = 2;
			Yandere.ChangeSchoolwear();
		}
		else if (Club == ClubType.Gardening)
		{
			for (ID = 0; ID < Club10Students.Length; ID++)
			{
				StudentScript studentScript7 = StudentManager.Students[Club10Students[ID]];
				if (studentScript7 != null && !studentScript7.Tranquil && studentScript7.Alive)
				{
					studentScript7.transform.position = studentScript7.CurrentDestination.position;
					studentScript7.transform.rotation = studentScript7.CurrentDestination.rotation;
					studentScript7.ClubActivity = true;
					studentScript7.Talking = false;
					studentScript7.Routine = true;
					studentScript7.GetComponent<AudioSource>().volume = 0.1f;
				}
			}
			Yandere.Talking = false;
			Yandere.CanMove = false;
			Yandere.ClubActivity = true;
			if (!Yandere.ClubAttire)
			{
				Yandere.ChangeClubwear();
			}
		}
		Clock.SetActive(false);
		Reputation.SetActive(false);
		Heartrate.SetActive(false);
		Watermark.SetActive(false);
	}

	public void CheckClub(ClubType Check)
	{
		switch (Check)
		{
		case ClubType.Occult:
			ClubIDs = Club3IDs;
			break;
		case ClubType.Art:
			ClubIDs = Club4IDs;
			break;
		case ClubType.MartialArts:
			ClubIDs = Club6IDs;
			break;
		case ClubType.Photography:
			ClubIDs = Club7IDs;
			break;
		case ClubType.Science:
			ClubIDs = Club8IDs;
			break;
		case ClubType.Sports:
			ClubIDs = Club9IDs;
			break;
		case ClubType.Gardening:
			ClubIDs = Club10IDs;
			break;
		}
		LeaderMissing = false;
		LeaderDead = false;
		ClubMembers = 0;
		for (ID = 1; ID < ClubIDs.Length; ID++)
		{
			if (!StudentGlobals.GetStudentDead(ClubIDs[ID]) && !StudentGlobals.GetStudentDying(ClubIDs[ID]) && !StudentGlobals.GetStudentKidnapped(ClubIDs[ID]) && !StudentGlobals.GetStudentArrested(ClubIDs[ID]) && StudentGlobals.GetStudentReputation(ClubIDs[ID]) > -100)
			{
				ClubMembers++;
			}
		}
		if (TranqCase.VictimClubType == Check)
		{
			ClubMembers--;
		}
		if (ClubGlobals.Club == Check)
		{
			ClubMembers++;
		}
		switch (Check)
		{
		case ClubType.Occult:
		{
			int num3 = 26;
			if (StudentGlobals.GetStudentDead(num3) || StudentGlobals.GetStudentDying(num3) || StudentGlobals.GetStudentArrested(num3) || StudentGlobals.GetStudentReputation(num3) <= -100)
			{
				LeaderDead = true;
			}
			if (StudentGlobals.GetStudentMissing(num3) || StudentGlobals.GetStudentKidnapped(num3) || TranqCase.VictimID == num3)
			{
				LeaderMissing = true;
			}
			break;
		}
		case ClubType.Art:
		{
			int num7 = 41;
			if (StudentGlobals.GetStudentDead(num7) || StudentGlobals.GetStudentDying(num7) || StudentGlobals.GetStudentArrested(num7) || StudentGlobals.GetStudentReputation(num7) <= -100)
			{
				LeaderDead = true;
			}
			if (StudentGlobals.GetStudentMissing(num7) || StudentGlobals.GetStudentKidnapped(num7) || TranqCase.VictimID == num7)
			{
				LeaderMissing = true;
			}
			break;
		}
		case ClubType.MartialArts:
		{
			int num5 = 21;
			if (StudentGlobals.GetStudentDead(num5) || StudentGlobals.GetStudentDying(num5) || StudentGlobals.GetStudentArrested(num5) || StudentGlobals.GetStudentReputation(num5) <= -100)
			{
				LeaderDead = true;
			}
			if (StudentGlobals.GetStudentMissing(num5) || StudentGlobals.GetStudentKidnapped(num5) || TranqCase.VictimID == num5)
			{
				LeaderMissing = true;
			}
			break;
		}
		case ClubType.Photography:
		{
			int num6 = 56;
			if (StudentGlobals.GetStudentDead(num6) || StudentGlobals.GetStudentDying(num6) || StudentGlobals.GetStudentArrested(num6) || StudentGlobals.GetStudentReputation(num6) <= -100)
			{
				LeaderDead = true;
			}
			if (StudentGlobals.GetStudentMissing(num6) || StudentGlobals.GetStudentKidnapped(num6) || TranqCase.VictimID == num6)
			{
				LeaderMissing = true;
			}
			break;
		}
		case ClubType.Science:
		{
			int num4 = 61;
			if (StudentGlobals.GetStudentDead(num4) || StudentGlobals.GetStudentDying(num4) || StudentGlobals.GetStudentArrested(num4) || StudentGlobals.GetStudentReputation(num4) <= -100)
			{
				LeaderDead = true;
			}
			if (StudentGlobals.GetStudentMissing(num4) || StudentGlobals.GetStudentKidnapped(num4) || TranqCase.VictimID == num4)
			{
				LeaderMissing = true;
			}
			break;
		}
		case ClubType.Sports:
		{
			int num2 = 66;
			if (StudentGlobals.GetStudentDead(num2) || StudentGlobals.GetStudentDying(num2) || StudentGlobals.GetStudentArrested(num2) || StudentGlobals.GetStudentReputation(num2) <= -100)
			{
				LeaderDead = true;
			}
			if (StudentGlobals.GetStudentMissing(num2) || StudentGlobals.GetStudentKidnapped(num2) || TranqCase.VictimID == num2)
			{
				LeaderMissing = true;
			}
			break;
		}
		case ClubType.Gardening:
		{
			int num = 71;
			if (StudentGlobals.GetStudentDead(num) || StudentGlobals.GetStudentDying(num) || StudentGlobals.GetStudentArrested(num) || StudentGlobals.GetStudentReputation(num) <= -100)
			{
				LeaderDead = true;
			}
			if (StudentGlobals.GetStudentMissing(num) || StudentGlobals.GetStudentKidnapped(num) || TranqCase.VictimID == num)
			{
				LeaderMissing = true;
			}
			break;
		}
		}
	}

	public void CheckGrudge(ClubType Check)
	{
		switch (Check)
		{
		case ClubType.Occult:
			ClubIDs = Club3IDs;
			break;
		case ClubType.MartialArts:
			ClubIDs = Club6IDs;
			break;
		case ClubType.Photography:
			ClubIDs = Club7IDs;
			break;
		case ClubType.Science:
			ClubIDs = Club8IDs;
			break;
		case ClubType.Sports:
			ClubIDs = Club9IDs;
			break;
		case ClubType.Gardening:
			ClubIDs = Club10IDs;
			break;
		}
		LeaderGrudge = false;
		ClubGrudge = false;
		for (ID = 1; ID < ClubIDs.Length; ID++)
		{
			if (StudentManager.Students[ClubIDs[ID]] != null && StudentManager.Students[ClubIDs[ID]].Grudge)
			{
				ClubGrudge = true;
			}
		}
		switch (Check)
		{
		case ClubType.Occult:
			if (StudentManager.Students[26].Grudge)
			{
				LeaderGrudge = true;
			}
			break;
		case ClubType.MartialArts:
			if (StudentManager.Students[21].Grudge)
			{
				LeaderGrudge = true;
			}
			break;
		case ClubType.Photography:
			if (StudentManager.Students[56].Grudge)
			{
				LeaderGrudge = true;
			}
			break;
		case ClubType.Science:
			if (StudentManager.Students[61].Grudge)
			{
				LeaderGrudge = true;
			}
			break;
		case ClubType.Sports:
			if (StudentManager.Students[66].Grudge)
			{
				LeaderGrudge = true;
			}
			break;
		case ClubType.Gardening:
			if (StudentManager.Students[71].Grudge)
			{
				LeaderGrudge = true;
			}
			break;
		}
	}

	public void ActivateClubBenefit()
	{
		if (ClubGlobals.Club == ClubType.Cooking)
		{
			if (!Refrigerator.CookingEvent.EventActive)
			{
				Refrigerator.enabled = true;
				Refrigerator.Prompt.enabled = true;
			}
		}
		else if (ClubGlobals.Club == ClubType.Drama)
		{
			for (ID = 1; ID < Masks.Length; ID++)
			{
				Masks[ID].enabled = true;
				Masks[ID].Prompt.enabled = true;
			}
			Gloves.enabled = true;
			Gloves.Prompt.enabled = true;
		}
		else if (ClubGlobals.Club == ClubType.Occult)
		{
			StudentManager.UpdatePerception();
			Yandere.Numbness -= 0.5f;
		}
		else if (ClubGlobals.Club == ClubType.Art)
		{
			StudentManager.UpdateBooths();
		}
		else if (ClubGlobals.Club == ClubType.LightMusic)
		{
			Container.enabled = true;
			Container.Prompt.enabled = true;
		}
		else if (ClubGlobals.Club == ClubType.MartialArts)
		{
			StudentManager.UpdateBooths();
		}
		else
		{
			if (ClubGlobals.Club == ClubType.Photography)
			{
				return;
			}
			if (ClubGlobals.Club == ClubType.Science)
			{
				BloodCleaner.Prompt.enabled = true;
			}
			else if (ClubGlobals.Club == ClubType.Sports)
			{
				Yandere.RunSpeed += 1f;
				if (Yandere.Armed)
				{
					Yandere.EquippedWeapon.SuspicionCheck();
				}
			}
			else if (ClubGlobals.Club == ClubType.Gardening)
			{
				ShedDoor.Prompt.Label[0].text = "     Open";
				Padlock.SetActive(false);
				ShedDoor.Locked = false;
				if (Yandere.Armed)
				{
					Yandere.EquippedWeapon.SuspicionCheck();
				}
			}
			else if (ClubGlobals.Club == ClubType.Gaming)
			{
				ComputerGames.EnableGames();
			}
		}
	}

	public void DeactivateClubBenefit()
	{
		if (ClubGlobals.Club == ClubType.Cooking)
		{
			Refrigerator.enabled = false;
			Refrigerator.Prompt.Hide();
			Refrigerator.Prompt.enabled = false;
		}
		else if (ClubGlobals.Club == ClubType.Drama)
		{
			for (ID = 1; ID < Masks.Length; ID++)
			{
				if (Masks[ID] != null)
				{
					Masks[ID].enabled = false;
					Masks[ID].Prompt.Hide();
					Masks[ID].Prompt.enabled = false;
				}
			}
			Gloves.enabled = false;
			Gloves.Prompt.Hide();
			Gloves.Prompt.enabled = false;
		}
		else if (ClubGlobals.Club == ClubType.Occult)
		{
			ClubGlobals.Club = ClubType.None;
			StudentManager.UpdatePerception();
			Yandere.Numbness += 0.5f;
		}
		else
		{
			if (ClubGlobals.Club == ClubType.Art)
			{
				return;
			}
			if (ClubGlobals.Club == ClubType.LightMusic)
			{
				Container.enabled = false;
				Container.Prompt.Hide();
				Container.Prompt.enabled = false;
			}
			else
			{
				if (ClubGlobals.Club == ClubType.MartialArts || ClubGlobals.Club == ClubType.Photography)
				{
					return;
				}
				if (ClubGlobals.Club == ClubType.Science)
				{
					BloodCleaner.enabled = false;
					BloodCleaner.Prompt.Hide();
					BloodCleaner.Prompt.enabled = false;
				}
				else if (ClubGlobals.Club == ClubType.Sports)
				{
					Yandere.RunSpeed -= 1f;
					if (Yandere.Armed)
					{
						ClubGlobals.Club = ClubType.None;
						Yandere.EquippedWeapon.SuspicionCheck();
					}
				}
				else if (ClubGlobals.Club == ClubType.Gardening)
				{
					if (!Yandere.Inventory.ShedKey)
					{
						ShedDoor.Prompt.Label[0].text = "     Locked";
						Padlock.SetActive(true);
						ShedDoor.Locked = true;
						ShedDoor.CloseDoor();
					}
					if (Yandere.Armed)
					{
						ClubGlobals.Club = ClubType.None;
						Yandere.EquippedWeapon.SuspicionCheck();
					}
				}
				else if (ClubGlobals.Club == ClubType.Gaming)
				{
					ComputerGames.DeactivateAllBenefits();
					ComputerGames.DisableGames();
				}
			}
		}
	}

	public void UpdateMasks()
	{
		bool flag = Yandere.Mask != null;
		for (ID = 1; ID < Masks.Length; ID++)
		{
			Masks[ID].Prompt.HideButton[0] = flag;
		}
	}
}
