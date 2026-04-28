using UnityEngine;

public class CounselorScript : MonoBehaviour
{
	public CutsceneManagerScript CutsceneManager;

	public StudentManagerScript StudentManager;

	public InputManagerScript InputManager;

	public PromptBarScript PromptBar;

	public EndOfDayScript EndOfDay;

	public SubtitleScript Subtitle;

	public SchemesScript Schemes;

	public StudentScript Student;

	public YandereScript Yandere;

	public PromptScript Prompt;

	public AudioClip[] CounselorGreetingClips;

	public AudioClip[] CounselorLectureClips;

	public AudioClip[] CounselorReportClips;

	public AudioClip[] RivalClips;

	public AudioClip CounselorFarewellClip;

	public readonly string CounselorFarewellText = "Don't misbehave.";

	public AudioClip CounselorBusyClip;

	public readonly string CounselorBusyText = "I'm sorry, I've got my hands full for the rest of today. I won't be available until tomorrow.";

	public readonly string[] CounselorGreetingText = new string[3]
	{
		string.Empty,
		"What can I help you with?",
		"Can I help you?"
	};

	public readonly string[] CounselorLectureText = new string[7]
	{
		string.Empty,
		"Your \"after-school activities\" are completely unacceptable. You should not be conducting yourself in such a manner. This kind of behavior could cause a scandal! You could run the school's reputation into the ground!",
		"May I take a look inside your bag? ...this doesn't belong to you, does it?! What are you doing with someone else's property?",
		"I need to take a look in your bag. ...cigarettes?! You have absolutely no excuse to be carrying something like this around!",
		"May I see your phone for a moment? ...what is THIS?! Would you care to explain why something like this is on your phone?",
		"Obviously, we need to have a long talk about the kind of behavior that will not tolerated at this school!",
		"That's it! I've given you enough second chances. You have repeatedly broken school rules and ignored every warning that I have given you. You have left me with no choice but to permanently expel you!"
	};

	public readonly string[] CounselorReportText = new string[6]
	{
		string.Empty,
		"This is...! Thank you for bringing this to my attention. This kind of conduct will definitely harm the school's reputation. I'll have to have a word with her later today.",
		"Is that true? I'd hate to think we have a thief here at school. Don't worry - I'll get to the bottom of this.",
		"That's a clear violation of school rules, not to mention completely illegal. If what you're saying is true, she will face serious consequences. I'll confront her about this.",
		"That's a very serious accusation. I hope you're not lying to me. Hopefully, it's just a misunderstanding. I'll investigate the matter.",
		"That's a bold claim. Are you certain? I'll investigate the matter. If she is cheating, I'll catch her in the act."
	};

	public readonly string[] LectureIntro = new string[6]
	{
		string.Empty,
		"The guidance counselor asks Kokona to visit her office after school ends...",
		"The guidance counselor asks Kokona to visit her office after school ends...",
		"The guidance counselor asks Kokona to visit her office after school ends...",
		"The guidance counselor asks Kokona to visit her office after school ends...",
		"The guidance counselor asks Kokona to visit her office after school ends..."
	};

	public readonly string[] RivalText = new string[7]
	{
		string.Empty,
		"It...it's not what you think...I was just...um...",
		"No! I'm not the one who did this! I would never steal from anyone!",
		"Huh? I don't smoke! I don't know why something like this was in my bag!",
		"What?! I've never taken any pictures like that! How did this get on my phone?!",
		"I'm telling the truth! I didn't steal the answer sheet! I don't know why it was in my desk!",
		"No! Please! Don't do this!"
	};

	public UILabel[] Labels;

	public Transform CounselorWindow;

	public Transform Highlight;

	public Transform Chibi;

	public SkinnedMeshRenderer Face;

	public UILabel CounselorSubtitle;

	public UISprite EndOfDayDarkness;

	public UILabel LectureSubtitle;

	public UISprite ExpelProgress;

	public UILabel LectureLabel;

	public bool ShowWindow;

	public bool Lecturing;

	public bool Angry;

	public bool Busy;

	public int Selected = 1;

	public int LecturePhase = 1;

	public int LectureID = 5;

	public float Anger;

	public float ExpelTimer;

	public float ChinTimer;

	public float Timer;

	public Vector3 LookAtTarget;

	public bool LookAtPlayer;

	public Transform Default;

	public Transform Head;

	private void Start()
	{
		CounselorWindow.localScale = Vector3.zero;
		CounselorWindow.gameObject.SetActive(false);
		ExpelProgress.color = new Color(ExpelProgress.color.r, ExpelProgress.color.g, ExpelProgress.color.b, 0f);
	}

	private void Update()
	{
		if (Yandere.transform.position.x < base.transform.position.x)
		{
			Prompt.Hide();
			Prompt.enabled = false;
		}
		else
		{
			Prompt.enabled = true;
		}
		Animation component = GetComponent<Animation>();
		AudioSource component2 = GetComponent<AudioSource>();
		if (Prompt.Circle[0].fillAmount == 0f)
		{
			Prompt.Circle[0].fillAmount = 1f;
			if (!Yandere.Chased)
			{
				if (!Busy)
				{
					component.CrossFade("CounselorComputerAttention", 1f);
					ChinTimer = 0f;
					Yandere.TargetStudent = Student;
					int num = Random.Range(1, 3);
					CounselorSubtitle.text = CounselorGreetingText[num];
					component2.clip = CounselorGreetingClips[num];
					component2.Play();
					StudentManager.DisablePrompts();
					CounselorWindow.gameObject.SetActive(true);
					LookAtPlayer = true;
					ShowWindow = true;
					Yandere.ShoulderCamera.OverShoulder = true;
					Yandere.WeaponMenu.KeyboardShow = false;
					Yandere.Obscurance.enabled = false;
					Yandere.WeaponMenu.Show = false;
					Yandere.YandereVision = false;
					Yandere.CanMove = false;
					Yandere.Talking = true;
					PromptBar.ClearButtons();
					PromptBar.Label[0].text = "Accept";
					PromptBar.Label[4].text = "Choose";
					PromptBar.UpdateButtons();
					PromptBar.Show = true;
					UpdateList();
				}
				else
				{
					CounselorSubtitle.text = CounselorBusyText;
					component2.clip = CounselorBusyClip;
					component2.Play();
				}
			}
		}
		if (LookAtPlayer)
		{
			if (InputManager.TappedUp)
			{
				Selected--;
				if (Selected == 6)
				{
					Selected = 5;
				}
				UpdateHighlight();
			}
			if (InputManager.TappedDown)
			{
				Selected++;
				if (Selected == 6)
				{
					Selected = 7;
				}
				UpdateHighlight();
			}
			if (ShowWindow)
			{
				if (Yandere.Chased || Yandere.Chasers > 0)
				{
					Quit();
				}
				else if (Input.GetButtonDown("A"))
				{
					if (Selected == 7)
					{
						Quit();
					}
					else if (Labels[Selected].color.a == 1f)
					{
						if (Selected == 1)
						{
							SchemeGlobals.SetSchemeStage(1, 100);
							Schemes.UpdateInstructions();
						}
						else if (Selected == 2)
						{
							SchemeGlobals.SetSchemeStage(2, 100);
							Schemes.UpdateInstructions();
						}
						else if (Selected == 3)
						{
							SchemeGlobals.SetSchemeStage(3, 100);
							Schemes.UpdateInstructions();
						}
						else if (Selected == 4)
						{
							SchemeGlobals.SetSchemeStage(4, 100);
							Schemes.UpdateInstructions();
						}
						else if (Selected == 5)
						{
							SchemeGlobals.SetSchemeStage(5, 7);
							Schemes.UpdateInstructions();
						}
						CounselorSubtitle.text = CounselorReportText[Selected];
						component2.clip = CounselorReportClips[Selected];
						component2.Play();
						ShowWindow = false;
						Angry = true;
						LectureID = Selected;
						PromptBar.ClearButtons();
						PromptBar.Show = false;
						Busy = true;
					}
				}
			}
			else
			{
				if (Input.GetButtonDown("A"))
				{
					component2.Stop();
				}
				if (!component2.isPlaying)
				{
					Timer += Time.deltaTime;
					if (Timer > 0.5f)
					{
						component.CrossFade("CounselorComputerLoop", 1f);
						Yandere.ShoulderCamera.OverShoulder = false;
						StudentManager.EnablePrompts();
						Yandere.TargetStudent = null;
						LookAtPlayer = false;
						Angry = false;
						UpdateList();
					}
				}
			}
		}
		else
		{
			ChinTimer += Time.deltaTime;
			if (ChinTimer > 10f)
			{
				component.CrossFade("CounselorComputerChin");
				if (component["CounselorComputerChin"].time > component["CounselorComputerChin"].length)
				{
					component.CrossFade("CounselorComputerLoop");
					ChinTimer = 0f;
				}
			}
		}
		if (ShowWindow)
		{
			CounselorWindow.localScale = Vector3.Lerp(CounselorWindow.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 10f);
		}
		else if (CounselorWindow.localScale.x > 0.1f)
		{
			CounselorWindow.localScale = Vector3.Lerp(CounselorWindow.localScale, Vector3.zero, Time.deltaTime * 10f);
		}
		else
		{
			CounselorWindow.localScale = Vector3.zero;
			CounselorWindow.gameObject.SetActive(false);
		}
		if (Lecturing)
		{
			Chibi.localPosition = new Vector3(Chibi.localPosition.x, Mathf.Lerp(Chibi.localPosition.y, 250f + (float)StudentGlobals.ExpelProgress * -100f, Time.deltaTime * 2f), Chibi.localPosition.z);
			if (LecturePhase == 1)
			{
				LectureLabel.text = LectureIntro[LectureID];
				EndOfDayDarkness.color = new Color(EndOfDayDarkness.color.r, EndOfDayDarkness.color.g, EndOfDayDarkness.color.b, Mathf.MoveTowards(EndOfDayDarkness.color.a, 0f, Time.deltaTime));
				if (EndOfDayDarkness.color.a == 0f)
				{
					PromptBar.ClearButtons();
					PromptBar.Label[0].text = "Continue";
					PromptBar.UpdateButtons();
					PromptBar.Show = true;
					if (Input.GetButtonDown("A"))
					{
						LecturePhase++;
						PromptBar.ClearButtons();
						PromptBar.Show = false;
					}
				}
			}
			else if (LecturePhase == 2)
			{
				LectureLabel.color = new Color(LectureLabel.color.r, LectureLabel.color.g, LectureLabel.color.b, Mathf.MoveTowards(LectureLabel.color.a, 0f, Time.deltaTime));
				if (LectureLabel.color.a == 0f)
				{
					LectureSubtitle.text = CounselorLectureText[LectureID];
					component2.clip = CounselorLectureClips[LectureID];
					component2.Play();
					LecturePhase++;
				}
			}
			else if (LecturePhase == 3)
			{
				if (!component2.isPlaying || Input.GetButtonDown("A"))
				{
					LectureSubtitle.text = RivalText[LectureID];
					component2.clip = RivalClips[LectureID];
					component2.Play();
					LecturePhase++;
				}
			}
			else if (LecturePhase == 4)
			{
				if (!component2.isPlaying || Input.GetButtonDown("A"))
				{
					LectureSubtitle.text = string.Empty;
					if (StudentGlobals.ExpelProgress < 5)
					{
						LecturePhase++;
					}
					else
					{
						LecturePhase = 7;
						ExpelTimer = 11f;
					}
				}
			}
			else if (LecturePhase == 5)
			{
				ExpelProgress.color = new Color(ExpelProgress.color.r, ExpelProgress.color.g, ExpelProgress.color.b, Mathf.MoveTowards(ExpelProgress.color.a, 1f, Time.deltaTime));
				ExpelTimer += Time.deltaTime;
				if (ExpelTimer > 2f)
				{
					StudentGlobals.ExpelProgress++;
					LecturePhase++;
				}
			}
			else if (LecturePhase == 6)
			{
				ExpelTimer += Time.deltaTime;
				if (ExpelTimer > 4f)
				{
					LecturePhase++;
				}
			}
			else if (LecturePhase == 7)
			{
				ExpelProgress.color = new Color(ExpelProgress.color.r, ExpelProgress.color.g, ExpelProgress.color.b, Mathf.MoveTowards(ExpelProgress.color.a, 0f, Time.deltaTime));
				ExpelTimer += Time.deltaTime;
				if (ExpelTimer > 6f)
				{
					if (StudentGlobals.ExpelProgress == 5 && !StudentGlobals.GetStudentExpelled(7) && StudentManager.Police.TranqCase.VictimID != 7)
					{
						StudentGlobals.SetStudentExpelled(7, true);
						EndOfDayDarkness.color = new Color(EndOfDayDarkness.color.r, EndOfDayDarkness.color.g, EndOfDayDarkness.color.b, 0f);
						LectureLabel.color = new Color(LectureLabel.color.r, LectureLabel.color.g, LectureLabel.color.b, 0f);
						LecturePhase = 2;
						ExpelTimer = 0f;
						LectureID = 6;
					}
					else if (LectureID < 6)
					{
						EndOfDay.enabled = true;
						EndOfDay.Phase++;
						EndOfDay.UpdateScene();
						base.enabled = false;
					}
					else
					{
						EndOfDay.gameObject.SetActive(false);
						EndOfDay.Phase = 1;
						CutsceneManager.Phase++;
						Lecturing = false;
						LectureID = 0;
					}
				}
			}
		}
		if (!component2.isPlaying)
		{
			CounselorSubtitle.text = string.Empty;
		}
	}

	private void UpdateList()
	{
		for (int i = 1; i < Labels.Length; i++)
		{
			UILabel uILabel = Labels[i];
			uILabel.color = new Color(uILabel.color.r, uILabel.color.g, uILabel.color.b, 0.5f);
		}
		if (StudentManager.Students[7] != null)
		{
			if (SchemeGlobals.GetSchemeStage(1) == 2)
			{
				UILabel uILabel2 = Labels[1];
				uILabel2.color = new Color(uILabel2.color.r, uILabel2.color.g, uILabel2.color.b, 1f);
			}
			if (SchemeGlobals.GetSchemeStage(2) == 3)
			{
				UILabel uILabel3 = Labels[2];
				uILabel3.color = new Color(uILabel3.color.r, uILabel3.color.g, uILabel3.color.b, 1f);
			}
			if (SchemeGlobals.GetSchemeStage(3) == 4)
			{
				UILabel uILabel4 = Labels[3];
				uILabel4.color = new Color(uILabel4.color.r, uILabel4.color.g, uILabel4.color.b, 1f);
			}
			if (SchemeGlobals.GetSchemeStage(4) == 5)
			{
				UILabel uILabel5 = Labels[4];
				uILabel5.color = new Color(uILabel5.color.r, uILabel5.color.g, uILabel5.color.b, 1f);
			}
			if (SchemeGlobals.GetSchemeStage(5) == 6)
			{
				UILabel uILabel6 = Labels[5];
				uILabel6.color = new Color(uILabel6.color.r, uILabel6.color.g, uILabel6.color.b, 1f);
			}
		}
	}

	private void UpdateHighlight()
	{
		if (Selected < 1)
		{
			Selected = 7;
		}
		else if (Selected > 7)
		{
			Selected = 1;
		}
		Highlight.transform.localPosition = new Vector3(Highlight.transform.localPosition.x, 200f - 50f * (float)Selected, Highlight.transform.localPosition.z);
	}

	private void LateUpdate()
	{
		if (Angry)
		{
			Anger = Mathf.Lerp(Anger, 100f, Time.deltaTime);
			Face.SetBlendShapeWeight(1, Anger);
			Face.SetBlendShapeWeight(5, Anger);
			Face.SetBlendShapeWeight(9, Anger);
		}
		else
		{
			Anger = Mathf.Lerp(Anger, 0f, Time.deltaTime);
			Face.SetBlendShapeWeight(1, Anger);
			Face.SetBlendShapeWeight(5, Anger);
			Face.SetBlendShapeWeight(9, Anger);
		}
		LookAtTarget = Vector3.Lerp(LookAtTarget, (!LookAtPlayer) ? Default.position : Yandere.Head.position, Time.deltaTime * 2f);
		Head.LookAt(LookAtTarget);
	}

	private void Quit()
	{
		Animation component = GetComponent<Animation>();
		AudioSource component2 = GetComponent<AudioSource>();
		component.CrossFade("CounselorComputerLoop", 1f);
		Yandere.ShoulderCamera.OverShoulder = false;
		StudentManager.EnablePrompts();
		Yandere.TargetStudent = null;
		LookAtPlayer = false;
		ShowWindow = false;
		CounselorSubtitle.text = CounselorFarewellText;
		component2.clip = CounselorFarewellClip;
		component2.Play();
		PromptBar.ClearButtons();
		PromptBar.Show = false;
	}
}
