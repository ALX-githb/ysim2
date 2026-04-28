using System;
using UnityEngine;

public class PoliceScript : MonoBehaviour
{
	public LowRepGameOverScript LowRepGameOver;

	public StudentManagerScript StudentManager;

	public ClubManagerScript ClubManager;

	public HeartbrokenScript Heartbroken;

	public PauseScreenScript PauseScreen;

	public ReputationScript Reputation;

	public TranqCaseScript TranqCase;

	public EndOfDayScript EndOfDay;

	public JukeboxScript Jukebox;

	public YandereScript Yandere;

	public ClockScript Clock;

	public JsonScript JSON;

	public UIPanel Panel;

	public GameObject HeartbeatCamera;

	public GameObject DetectionCamera;

	public GameObject SuicideStudent;

	public GameObject UICamera;

	public GameObject Icons;

	public GameObject FPS;

	public Transform BloodParent;

	public RagdollScript[] CorpseList;

	public UILabel[] ResultsLabels;

	public UILabel ContinueLabel;

	public UILabel TimeLabel;

	public UISprite ContinueButton;

	public UISprite Darkness;

	public UISprite BloodIcon;

	public UISprite UniformIcon;

	public UISprite WeaponIcon;

	public UISprite CorpseIcon;

	public UISprite PartsIcon;

	public UISprite SanityIcon;

	public string ElectrocutedStudentName = string.Empty;

	public string DrownedStudentName = string.Empty;

	public bool BloodDisposed;

	public bool UniformDisposed;

	public bool WeaponDisposed;

	public bool CorpseDisposed;

	public bool PartsDisposed;

	public bool SanityRestored;

	public bool MurderSuicideScene;

	public bool ElectroScene;

	public bool SuicideScene;

	public bool PoisonScene;

	public bool MurderScene;

	public bool DrownScene;

	public bool TeacherReport;

	public bool ClubActivity;

	public bool CouncilDeath;

	public bool MaskReported;

	public bool FadeResults;

	public bool ShowResults;

	public bool GameOver;

	public bool Delayed;

	public bool FadeOut;

	public bool Suicide;

	public bool Called;

	public bool LowRep;

	public bool Show;

	public int IncineratedWeapons;

	public int BloodyClothing;

	public int BloodyWeapons;

	public int MurderWeapons;

	public int HiddenCorpses;

	public int BodyParts;

	public int Witnesses;

	public int Corpses;

	public int Deaths;

	public float ResultsTimer;

	public float Timer;

	public int Minutes;

	public int Seconds;

	private void Start()
	{
		if (SchoolGlobals.SchoolAtmosphere > 0.5f)
		{
			Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, 0f);
			Darkness.enabled = false;
		}
		base.transform.localPosition = new Vector3(-260f, base.transform.localPosition.y, base.transform.localPosition.z);
		UILabel[] resultsLabels = ResultsLabels;
		foreach (UILabel uILabel in resultsLabels)
		{
			uILabel.color = new Color(uILabel.color.r, uILabel.color.g, uILabel.color.b, 0f);
		}
		ContinueLabel.color = new Color(ContinueLabel.color.r, ContinueLabel.color.g, ContinueLabel.color.b, 0f);
		ContinueButton.color = new Color(ContinueButton.color.r, ContinueButton.color.g, ContinueButton.color.b, 0f);
		Icons.SetActive(false);
	}

	private void Update()
	{
		if (Show)
		{
			if (PoisonScene)
			{
			}
			if (!Icons.activeInHierarchy)
			{
				Icons.SetActive(true);
			}
			base.transform.localPosition = new Vector3(Mathf.Lerp(base.transform.localPosition.x, 0f, Time.deltaTime * 10f), base.transform.localPosition.y, base.transform.localPosition.z);
			if (BloodParent.childCount == 0)
			{
				if (!BloodDisposed)
				{
					BloodIcon.spriteName = "Yes";
					BloodDisposed = true;
				}
			}
			else if (BloodDisposed)
			{
				BloodIcon.spriteName = "No";
				BloodDisposed = false;
			}
			if (BloodyClothing == 0)
			{
				if (!UniformDisposed)
				{
					UniformIcon.spriteName = "Yes";
					UniformDisposed = true;
				}
			}
			else if (UniformDisposed)
			{
				UniformIcon.spriteName = "No";
				UniformDisposed = false;
			}
			if (IncineratedWeapons == MurderWeapons)
			{
				if (!WeaponDisposed)
				{
					WeaponIcon.spriteName = "Yes";
					WeaponDisposed = true;
				}
			}
			else if (WeaponDisposed)
			{
				WeaponIcon.spriteName = "No";
				WeaponDisposed = false;
			}
			if (Corpses == 0)
			{
				if (!CorpseDisposed)
				{
					CorpseIcon.spriteName = "Yes";
					CorpseDisposed = true;
				}
			}
			else if (CorpseDisposed)
			{
				CorpseIcon.spriteName = "No";
				CorpseDisposed = false;
			}
			if (BodyParts == 0)
			{
				if (!PartsDisposed)
				{
					PartsIcon.spriteName = "Yes";
					PartsDisposed = true;
				}
			}
			else if (PartsDisposed)
			{
				PartsIcon.spriteName = "No";
				PartsDisposed = false;
			}
			if (Yandere.Sanity == 100f)
			{
				if (!SanityRestored)
				{
					SanityIcon.spriteName = "Yes";
					SanityRestored = true;
				}
			}
			else if (SanityRestored)
			{
				SanityIcon.spriteName = "No";
				SanityRestored = false;
			}
			Timer = Mathf.MoveTowards(Timer, 0f, Time.deltaTime);
			if (Timer <= 0f)
			{
				Timer = 0f;
				if (!Yandere.Attacking && !Yandere.Struggling && !Yandere.Egg && !FadeOut)
				{
					BeginFadingOut();
				}
			}
			int num = Mathf.CeilToInt(Timer);
			Minutes = num / 60;
			Seconds = num % 60;
			TimeLabel.text = string.Format("{0:00}:{1:00}", Minutes, Seconds);
		}
		if (FadeOut)
		{
			if (Yandere.Laughing)
			{
				Yandere.StopLaughing();
			}
			if (Clock.TimeSkip || Yandere.CanMove)
			{
				if (Clock.TimeSkip)
				{
					Clock.EndTimeSkip();
				}
				Yandere.StopAiming();
				Yandere.CanMove = false;
				Yandere.YandereVision = false;
				Yandere.PauseScreen.enabled = false;
				Yandere.Character.GetComponent<Animation>().CrossFade("f02_idleShort_00");
				for (int i = 1; i < 4; i++)
				{
					if (Yandere.Weapon[i] != null)
					{
					}
				}
			}
			PauseScreen.Panel.alpha = Mathf.MoveTowards(PauseScreen.Panel.alpha, 0f, Time.deltaTime);
			Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, Mathf.MoveTowards(Darkness.color.a, 1f, Time.deltaTime));
			if (Darkness.color.a >= 1f && !ShowResults)
			{
				HeartbeatCamera.SetActive(false);
				DetectionCamera.SetActive(false);
				if (ClubActivity)
				{
					ClubManager.Club = ClubGlobals.Club;
					ClubManager.ClubActivity();
					FadeOut = false;
				}
				else
				{
					Yandere.MyController.enabled = false;
					Yandere.enabled = false;
					DetermineResults();
					ShowResults = true;
					Time.timeScale = 2f;
					Jukebox.Volume = 0f;
				}
			}
		}
		if (ShowResults)
		{
			ResultsTimer += Time.deltaTime;
			if (ResultsTimer > 1f)
			{
				UILabel uILabel = ResultsLabels[0];
				uILabel.color = new Color(uILabel.color.r, uILabel.color.g, uILabel.color.b, uILabel.color.a + Time.deltaTime);
			}
			if (ResultsTimer > 2f)
			{
				UILabel uILabel2 = ResultsLabels[1];
				uILabel2.color = new Color(uILabel2.color.r, uILabel2.color.g, uILabel2.color.b, uILabel2.color.a + Time.deltaTime);
			}
			if (ResultsTimer > 3f)
			{
				UILabel uILabel3 = ResultsLabels[2];
				uILabel3.color = new Color(uILabel3.color.r, uILabel3.color.g, uILabel3.color.b, uILabel3.color.a + Time.deltaTime);
			}
			if (ResultsTimer > 4f)
			{
				UILabel uILabel4 = ResultsLabels[3];
				uILabel4.color = new Color(uILabel4.color.r, uILabel4.color.g, uILabel4.color.b, uILabel4.color.a + Time.deltaTime);
			}
			if (ResultsTimer > 5f)
			{
				UILabel uILabel5 = ResultsLabels[4];
				uILabel5.color = new Color(uILabel5.color.r, uILabel5.color.g, uILabel5.color.b, uILabel5.color.a + Time.deltaTime);
			}
			if (ResultsTimer > 6f)
			{
				ContinueButton.color = new Color(ContinueButton.color.r, ContinueButton.color.g, ContinueButton.color.b, ContinueButton.color.a + Time.deltaTime);
				ContinueLabel.color = new Color(ContinueLabel.color.r, ContinueLabel.color.g, ContinueLabel.color.b, ContinueLabel.color.a + Time.deltaTime);
				if (ContinueButton.color.a > 1f)
				{
					ContinueButton.color = new Color(ContinueButton.color.r, ContinueButton.color.g, ContinueButton.color.b, 1f);
				}
				if (ContinueLabel.color.a > 1f)
				{
					ContinueLabel.color = new Color(ContinueLabel.color.r, ContinueLabel.color.g, ContinueLabel.color.b, 1f);
				}
			}
			if (ResultsTimer > 7f && Input.GetButtonDown("A"))
			{
				ShowResults = false;
				FadeResults = true;
				FadeOut = false;
				ResultsTimer = 0f;
			}
		}
		UILabel[] resultsLabels = ResultsLabels;
		foreach (UILabel uILabel6 in resultsLabels)
		{
			if (uILabel6.color.a > 1f)
			{
				uILabel6.color = new Color(uILabel6.color.r, uILabel6.color.g, uILabel6.color.b, 1f);
			}
		}
		if (!FadeResults)
		{
			return;
		}
		UILabel[] resultsLabels2 = ResultsLabels;
		foreach (UILabel uILabel7 in resultsLabels2)
		{
			uILabel7.color = new Color(uILabel7.color.r, uILabel7.color.g, uILabel7.color.b, uILabel7.color.a - Time.deltaTime);
		}
		ContinueButton.color = new Color(ContinueButton.color.r, ContinueButton.color.g, ContinueButton.color.b, ContinueButton.color.a - Time.deltaTime);
		ContinueLabel.color = new Color(ContinueLabel.color.r, ContinueLabel.color.g, ContinueLabel.color.b, ContinueLabel.color.a - Time.deltaTime);
		if (!(ResultsLabels[0].color.a <= 0f))
		{
			return;
		}
		if (GameOver)
		{
			Heartbroken.transform.parent.transform.parent = null;
			Heartbroken.transform.parent.gameObject.SetActive(true);
			Heartbroken.Noticed = false;
			base.transform.parent.transform.parent.gameObject.SetActive(false);
			if (!EndOfDay.gameObject.activeInHierarchy)
			{
				Time.timeScale = 1f;
			}
		}
		else if (LowRep)
		{
			Yandere.RPGCamera.enabled = false;
			Yandere.RPGCamera.transform.parent = LowRepGameOver.MyCamera;
			Yandere.RPGCamera.transform.localPosition = new Vector3(0f, 0f, 0f);
			Yandere.RPGCamera.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
			LowRepGameOver.gameObject.SetActive(true);
			UICamera.SetActive(false);
			FPS.SetActive(false);
			Time.timeScale = 1f;
			base.enabled = false;
		}
		else if (!TeacherReport)
		{
			if (EndOfDay.Phase == 1)
			{
				EndOfDay.gameObject.SetActive(true);
				EndOfDay.enabled = true;
				EndOfDay.Phase = 11;
				if (EndOfDay.PreviouslyActivated)
				{
					EndOfDay.Start();
				}
				for (int l = 0; l < 5; l++)
				{
					ResultsLabels[l].text = string.Empty;
				}
				base.enabled = false;
			}
		}
		else
		{
			DetermineResults();
			TeacherReport = false;
			FadeResults = false;
			ShowResults = true;
		}
	}

	private void DetermineResults()
	{
		ResultsLabels[0].transform.parent.gameObject.SetActive(true);
		if (Show)
		{
			EndOfDay.gameObject.SetActive(true);
			base.enabled = false;
			for (int i = 0; i < 5; i++)
			{
				ResultsLabels[i].text = string.Empty;
			}
		}
		else if (Reputation.Reputation <= -100f)
		{
			ResultsLabels[0].text = "Unfortunately...";
			ResultsLabels[1].text = "Yandere-chan's unusual behavior has been observed by many people.";
			ResultsLabels[2].text = "Word has spread throughout the school of Yandere-chan's bizarre conduct.";
			ResultsLabels[3].text = "The entire school is now aware of Yandere-chan's true nature.";
			ResultsLabels[4].text = "From this day forward, nothing will be the same.";
			LowRep = true;
		}
		else if (DateGlobals.Weekday == DayOfWeek.Friday)
		{
			ResultsLabels[0].text = "This is the part where the game will determine whether or not the player has eliminated their rival.";
			ResultsLabels[1].text = "This game is still in development.";
			ResultsLabels[2].text = "The ''player eliminated rival'' state has not yet been implemented.";
			ResultsLabels[3].text = "Thank you for playtesting Yandere Simulator!";
			ResultsLabels[4].text = "Please check back soon for more updates!";
			GameOver = true;
		}
		else if (!Suicide && !PoisonScene)
		{
			if (Clock.HourTime < 18f)
			{
				if (Yandere.InClass)
				{
					ResultsLabels[0].text = "Yandere-chan attempts to attend class without disposing of a corpse.";
				}
				else if (Yandere.Resting)
				{
					ResultsLabels[0].text = "Yandere-chan rests without disposing of a corpse.";
				}
				else
				{
					ResultsLabels[0].text = "Yandere-chan stands near the school gate and waits for Senpai to leave school.";
				}
			}
			else
			{
				ResultsLabels[0].text = "The school day has ended. Faculty members must walk through the school and tell any lingering students to leave.";
			}
			if (Corpses == 0 && BloodParent.childCount == 0 && BloodyWeapons == 0 && BloodyClothing == 0 && !SuicideScene)
			{
				if (Yandere.Sanity > 66.66666f && Yandere.Bloodiness == 0f)
				{
					if (Clock.HourTime < 18f)
					{
						ResultsLabels[1].text = "Finally, Senpai exits the school.";
						ResultsLabels[2].text = "Yandere-chan's heart skips a beat when she sees him.";
						ResultsLabels[3].text = "Yandere-chan leaves school and watches Senpai walk home.";
						ResultsLabels[4].text = "Once he is safely home, Yandere-chan returns to her own home.";
					}
					else
					{
						ResultsLabels[1].text = "Like all other students, Yandere-chan is instructed to leave school.";
						ResultsLabels[2].text = "Senpai leaves school, too.";
						ResultsLabels[3].text = "Yandere-chan leaves school and watches Senpai walk home.";
						ResultsLabels[4].text = "Once he is safely home, Yandere-chan returns to her own home.";
					}
					return;
				}
				ResultsLabels[1].text = "Yandere-chan is approached by a faculty member.";
				if (Yandere.Bloodiness > 0f)
				{
					ResultsLabels[2].text = "The faculty member immediately notices the blood staining her clothing.";
					ResultsLabels[3].text = "Yandere-chan is not able to convince the faculty member that nothing is wrong.";
					ResultsLabels[4].text = "The faculty member calls the police.";
					TeacherReport = true;
					Show = true;
				}
				else
				{
					ResultsLabels[2].text = "Yandere-chan exhibited extremely erratic behavior, frightening the faculty member.";
					ResultsLabels[3].text = "The faculty member becomes angry with Yandere-chan, but Yandere-chan leaves before the situation gets worse.";
					ResultsLabels[4].text = "Yandere-chan returns home.";
				}
			}
			else if (Corpses == 0)
			{
				if (BloodParent.childCount > 0 || BloodyClothing > 0)
				{
					if (BloodyWeapons == 0)
					{
						ResultsLabels[1].text = "While walking around the school, a faculty member discovers a mysterious blood stain.";
						ResultsLabels[2].text = "The faculty member decides to call the police.";
						ResultsLabels[3].text = "The faculty member informs the rest of the faculty about her discovery.";
						ResultsLabels[4].text = "The faculty do not allow any students to leave the school until a police investigation has taken place.";
						TeacherReport = true;
						Show = true;
					}
					else
					{
						ResultsLabels[1].text = "While walking around the school, a faculty member discovers a mysterious bloody weapon.";
						ResultsLabels[2].text = "The faculty member decides to call the police.";
						ResultsLabels[3].text = "The faculty member informs the rest of the faculty about her discovery.";
						ResultsLabels[4].text = "The faculty do not allow any students to leave the school until a police investigation has taken place.";
						TeacherReport = true;
						Show = true;
					}
				}
				else if (BloodyWeapons > 0)
				{
					ResultsLabels[1].text = "While walking around the school, a faculty member discovers a mysterious bloody weapon.";
					ResultsLabels[2].text = "The faculty member decides to call the police.";
					ResultsLabels[3].text = "The faculty member informs the rest of the faculty about her discovery.";
					ResultsLabels[4].text = "The faculty do not allow any students to leave the school until a police investigation has taken place.";
					TeacherReport = true;
					Show = true;
				}
				else if (SuicideScene)
				{
					ResultsLabels[1].text = "While walking around the school, a faculty member discovers a pair of shoes on the rooftop.";
					ResultsLabels[2].text = "The faculty member fears that there has been a suicide, but cannot find a corpse anywhere. The faculty member does not take any action.";
					ResultsLabels[3].text = "Yandere-chan leaves school and watches Senpai walk home.";
					ResultsLabels[4].text = "Once he is safely home, Yandere-chan returns to her own home.";
				}
			}
			else
			{
				ResultsLabels[1].text = "While walking around the school, a faculty member discovers a corpse.";
				ResultsLabels[2].text = "The faculty member immediately calls the police.";
				ResultsLabels[3].text = "The faculty member informs the rest of the faculty about her discovery.";
				ResultsLabels[4].text = "The faculty do not allow any students to leave the school until a police investigation has taken place.";
				TeacherReport = true;
				Show = true;
			}
		}
		else if (Suicide)
		{
			if (!Yandere.InClass)
			{
				ResultsLabels[0].text = "The school day has ended. Faculty members must walk through the school and tell any lingering students to leave.";
			}
			else
			{
				ResultsLabels[0].text = "Yandere-chan attempts to attend class without disposing of a corpse.";
			}
			ResultsLabels[1].text = "While walking around the school, a faculty member discovers a corpse.";
			ResultsLabels[2].text = "It appears as though a student has committed suicide.";
			ResultsLabels[3].text = "The faculty member informs the rest of the faculty about her discovery.";
			ResultsLabels[4].text = "The faculty members agree to call the police and report the student's death.";
			TeacherReport = true;
			Show = true;
		}
		else if (PoisonScene)
		{
			ResultsLabels[0].text = "A faculty member discovers the student who Yandere-chan poisoned.";
			ResultsLabels[1].text = "The faculty member calls for an ambulance immediately.";
			ResultsLabels[2].text = "The faculty member suspects that the student's death was a murder.";
			ResultsLabels[3].text = "The faculty member also calls for the police.";
			ResultsLabels[4].text = "The school's students are not allowed to leave until a police investigation has taken place.";
			TeacherReport = true;
			Show = true;
		}
	}

	public void KillStudents()
	{
		if (Deaths > 0)
		{
			for (int i = 2; i < StudentManager.NPCsTotal + 1; i++)
			{
				if (StudentGlobals.GetStudentDying(i))
				{
					if (i < 90)
					{
						SchoolGlobals.SchoolAtmosphere -= 0.05f;
					}
					else
					{
						SchoolGlobals.SchoolAtmosphere -= 0.15f;
					}
					SchoolGlobals.SchoolAtmosphere -= (float)Corpses * 0.05f;
					if (JSON.Students[i].Club == ClubType.Council)
					{
						SchoolGlobals.SchoolAtmosphere -= 1f;
						SchoolGlobals.HighSecurity = true;
					}
					StudentGlobals.SetStudentDead(i, true);
					PlayerGlobals.Kills++;
				}
			}
		}
		else if (!SchoolGlobals.HighSecurity)
		{
			SchoolGlobals.SchoolAtmosphere += 0.2f;
		}
		SchoolGlobals.SchoolAtmosphere = Mathf.Clamp01(SchoolGlobals.SchoolAtmosphere);
		for (int j = 1; j < StudentManager.StudentsTotal; j++)
		{
			StudentScript studentScript = StudentManager.Students[j];
			if (studentScript != null && studentScript.Grudge && studentScript.Persona != PersonaType.Evil)
			{
				StudentGlobals.SetStudentGrudge(j, true);
				if (studentScript.OriginalPersona == PersonaType.Sleuth)
				{
					StudentGlobals.SetStudentGrudge(56, true);
					StudentGlobals.SetStudentGrudge(57, true);
					StudentGlobals.SetStudentGrudge(58, true);
					StudentGlobals.SetStudentGrudge(59, true);
					StudentGlobals.SetStudentGrudge(60, true);
				}
			}
		}
	}

	public void BeginFadingOut()
	{
		StudentManager.StopMoving();
		Darkness.enabled = true;
		Yandere.StopLaughing();
		Clock.StopTime = true;
		FadeOut = true;
		if (!EndOfDay.gameObject.activeInHierarchy)
		{
			Time.timeScale = 1f;
		}
	}
}
