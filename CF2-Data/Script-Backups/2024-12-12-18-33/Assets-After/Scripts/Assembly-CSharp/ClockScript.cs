using System;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
	private string MinuteNumber = string.Empty;

	private string HourNumber = string.Empty;

	public Collider[] TrespassZones;

	public StudentManagerScript StudentManager;

	public YandereScript Yandere;

	public PoliceScript Police;

	public ClockScript Clock;

	public Bloom BloomEffect;

	public MotionBlur Blur;

	public Transform PromptParent;

	public Transform MinuteHand;

	public Transform HourHand;

	public Transform Sun;

	public UILabel PeriodLabel;

	public UILabel TimeLabel;

	public UILabel DayLabel;

	public Light MainLight;

	public float HalfwayTime;

	public float PresentTime;

	public float TargetTime;

	public float StartTime;

	public float HourTime;

	public float AmbientLightDim;

	public float CameraTimer;

	public float DayProgress;

	public float StartHour;

	public float TimeSpeed;

	public float Minute;

	public float Timer;

	public float Hour;

	public int Period;

	public int ID;

	public string TimeText = string.Empty;

	public bool IgnorePhotographyClub;

	public bool StopTime;

	public bool TimeSkip;

	public bool FadeIn;

	public AudioSource SchoolBell;

	public Color SkyboxColor;

	private void Start()
	{
		PeriodLabel.text = "BEFORE CLASS";
		PresentTime = StartHour * 60f;
		if (DateGlobals.Weekday == DayOfWeek.Sunday)
		{
			DateGlobals.Weekday = DayOfWeek.Monday;
		}
		if (SchoolGlobals.SchoolAtmosphere < 0.5f)
		{
			BloomEffect.bloomIntensity = 0.25f;
			BloomEffect.bloomThreshhold = 0.5f;
			Police.Darkness.enabled = true;
			Police.Darkness.color = new Color(Police.Darkness.color.r, Police.Darkness.color.g, Police.Darkness.color.b, 1f);
			FadeIn = true;
			Timer = 5f;
		}
		else
		{
			BloomEffect.bloomIntensity = 10f;
			BloomEffect.bloomThreshhold = 0f;
		}
		BloomEffect.bloomThreshhold = 0f;
		DayLabel.text = GetWeekdayText(DateGlobals.Weekday);
		MainLight.color = new Color(1f, 1f, 1f, 1f);
		RenderSettings.ambientLight = new Color(0.75f, 0.75f, 0.75f, 1f);
		RenderSettings.skybox.SetColor("_Tint", new Color(0.5f, 0.5f, 0.5f));
		if (ClubGlobals.GetClubClosed(ClubType.Photography) || StudentGlobals.GetStudentGrudge(56) || StudentGlobals.GetStudentGrudge(57) || StudentGlobals.GetStudentGrudge(58) || StudentGlobals.GetStudentGrudge(59) || StudentGlobals.GetStudentGrudge(60))
		{
			IgnorePhotographyClub = true;
		}
	}

	private void Update()
	{
		if (FadeIn && Time.deltaTime < 1f)
		{
			Police.Darkness.color = new Color(Police.Darkness.color.r, Police.Darkness.color.g, Police.Darkness.color.b, Mathf.MoveTowards(Police.Darkness.color.a, 0f, Time.deltaTime));
			if (Police.Darkness.color.a == 0f)
			{
				Police.Darkness.enabled = false;
				FadeIn = false;
			}
		}
		if (CameraTimer < 1f)
		{
			CameraTimer += Time.deltaTime;
			if (CameraTimer > 1f)
			{
				Yandere.RPGCamera.enabled = true;
			}
		}
		if (PresentTime < 1080f)
		{
			if (Timer < 5f)
			{
				Timer += Time.deltaTime;
				BloomEffect.bloomIntensity -= Time.deltaTime * 9.75f;
				BloomEffect.bloomThreshhold += Time.deltaTime * 0.5f;
				if (BloomEffect.bloomThreshhold > 0.5f)
				{
					BloomEffect.bloomIntensity = 0.25f;
					BloomEffect.bloomThreshhold = 0.5f;
				}
			}
		}
		else if (!Police.FadeOut && !Yandere.Attacking && !Yandere.Struggling && !Yandere.DelinquentFighting && !Yandere.Pickpocketing && !Yandere.Noticed)
		{
			Yandere.StudentManager.StopMoving();
			Police.Darkness.enabled = true;
			Police.FadeOut = true;
			StopTime = true;
		}
		if (!StopTime)
		{
			if (Period == 3)
			{
				PresentTime += Time.deltaTime * (1f / 60f) * TimeSpeed * 0.5f;
			}
			else
			{
				PresentTime += Time.deltaTime * (1f / 60f) * TimeSpeed;
			}
		}
		if (PresentTime > 1440f)
		{
			PresentTime -= 1440f;
		}
		HourTime = PresentTime / 60f;
		Hour = Mathf.Floor(PresentTime / 60f);
		Minute = Mathf.Floor((PresentTime / 60f - Hour) * 60f);
		if (Hour == 0f || Hour == 12f)
		{
			HourNumber = "12";
		}
		else if (Hour < 12f)
		{
			HourNumber = Hour.ToString("f0");
		}
		else
		{
			HourNumber = (Hour - 12f).ToString("f0");
		}
		if (Minute < 10f)
		{
			MinuteNumber = "0" + Minute.ToString("f0");
		}
		else
		{
			MinuteNumber = Minute.ToString("f0");
		}
		TimeText = HourNumber + ":" + MinuteNumber + ((!(Hour < 12f)) ? " PM" : " AM");
		TimeLabel.text = TimeText;
		MinuteHand.localEulerAngles = new Vector3(MinuteHand.localEulerAngles.x, MinuteHand.localEulerAngles.y, Minute * 6f);
		HourHand.localEulerAngles = new Vector3(HourHand.localEulerAngles.x, HourHand.localEulerAngles.y, Hour * 30f);
		if (HourTime < 8.5f)
		{
			if (Period < 1)
			{
				PeriodLabel.text = "BEFORE CLASS";
				DeactivateTrespassZones();
				Period++;
			}
		}
		else if (HourTime < 13f)
		{
			if (Period < 2)
			{
				PeriodLabel.text = "CLASS TIME";
				ActivateTrespassZones();
				Period++;
			}
		}
		else if (HourTime < 13.5f)
		{
			if (Period < 3)
			{
				PeriodLabel.text = "LUNCH TIME";
				DeactivateTrespassZones();
				Period++;
			}
		}
		else if (HourTime < 15.5f)
		{
			if (Period < 4)
			{
				PeriodLabel.text = "CLASS TIME";
				ActivateTrespassZones();
				Period++;
			}
		}
		else if (HourTime < 16f)
		{
			if (Period < 5)
			{
				GameObject[] graffiti = StudentManager.Graffiti;
				foreach (GameObject gameObject in graffiti)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(false);
					}
				}
				PeriodLabel.text = "CLEANING TIME";
				DeactivateTrespassZones();
				Period++;
			}
		}
		else if (Period < 6)
		{
			PeriodLabel.text = "AFTER SCHOOL";
			Period++;
		}
		if (!IgnorePhotographyClub && HourTime > 16.75f && StudentManager.SleuthPhase < 4)
		{
			StudentManager.SleuthPhase = 3;
			StudentManager.UpdateSleuths();
		}
		Sun.eulerAngles = new Vector3(Sun.eulerAngles.x, Sun.eulerAngles.y, -45f + 90f * (PresentTime - 420f) / 660f);
		if ((Yandere.transform.position.y < 11f && Yandere.transform.position.x > -30f && Yandere.transform.position.z > -38f && Yandere.transform.position.x < -22f && Yandere.transform.position.z < -26f) || (Yandere.transform.position.y < 11f && Yandere.transform.position.x > 22f && Yandere.transform.position.z > -38f && Yandere.transform.position.x < 30f && Yandere.transform.position.z < -26f))
		{
			AmbientLightDim -= Time.deltaTime;
			if (AmbientLightDim < 0.1f)
			{
				AmbientLightDim = 0.1f;
			}
		}
		else
		{
			AmbientLightDim += Time.deltaTime;
			if (AmbientLightDim > 0.75f)
			{
				AmbientLightDim = 0.75f;
			}
		}
		if (PresentTime > 930f)
		{
			DayProgress = (PresentTime - 930f) / 150f;
			MainLight.color = new Color(1f - 0.14901961f * DayProgress, 1f - 0.40392157f * DayProgress, 1f - 0.70980394f * DayProgress);
			RenderSettings.ambientLight = new Color(1f - 0.14901961f * DayProgress - (1f - AmbientLightDim) * (1f - DayProgress), 1f - 0.40392157f * DayProgress - (1f - AmbientLightDim) * (1f - DayProgress), 1f - 0.70980394f * DayProgress - (1f - AmbientLightDim) * (1f - DayProgress));
			SkyboxColor = new Color(1f - 0.14901961f * DayProgress - 0.5f * (1f - DayProgress), 1f - 0.40392157f * DayProgress - 0.5f * (1f - DayProgress), 1f - 0.70980394f * DayProgress - 0.5f * (1f - DayProgress));
			RenderSettings.skybox.SetColor("_Tint", new Color(SkyboxColor.r, SkyboxColor.g, SkyboxColor.b));
		}
		else
		{
			RenderSettings.ambientLight = new Color(AmbientLightDim, AmbientLightDim, AmbientLightDim);
		}
		if (!TimeSkip)
		{
			return;
		}
		if (HalfwayTime == 0f)
		{
			HalfwayTime = PresentTime + (TargetTime - PresentTime) * 0.5f;
			Yandere.TimeSkipHeight = Yandere.transform.position.y;
			Yandere.Phone.SetActive(true);
			Yandere.TimeSkipping = true;
			Yandere.CanMove = false;
			Blur.enabled = true;
			if (Yandere.Armed)
			{
				Yandere.Unequip();
			}
		}
		if (Time.timeScale < 25f)
		{
			Time.timeScale += 1f;
		}
		Yandere.Character.GetComponent<Animation>()["f02_timeSkip_00"].speed = 1f / Time.timeScale;
		Blur.blurAmount = 0.92f * (Time.timeScale / 100f);
		if (PresentTime > TargetTime)
		{
			EndTimeSkip();
		}
		if (Yandere.CameraEffects.Streaks.color.a > 0f || Yandere.CameraEffects.MurderStreaks.color.a > 0f || Yandere.NearSenpai || ControlFreak2.CF2Input.GetButtonDown("Start"))
		{
			EndTimeSkip();
		}
	}

	public void EndTimeSkip()
	{
		PromptParent.localScale = new Vector3(1f, 1f, 1f);
		Yandere.Phone.SetActive(false);
		Yandere.TimeSkipping = false;
		Blur.enabled = false;
		Time.timeScale = 1f;
		TimeSkip = false;
		HalfwayTime = 0f;
		if (!Yandere.Noticed && !Police.FadeOut)
		{
			Yandere.CharacterAnimation.CrossFade(Yandere.IdleAnim);
			Yandere.CanMoveTimer = 0.5f;
		}
	}

	private string GetWeekdayText(DayOfWeek weekday)
	{
		switch (weekday)
		{
		case DayOfWeek.Sunday:
			return "SUNDAY";
		case DayOfWeek.Monday:
			return "MONDAY";
		case DayOfWeek.Tuesday:
			return "TUESDAY";
		case DayOfWeek.Wednesday:
			return "WEDNESDAY";
		case DayOfWeek.Thursday:
			return "THURSDAY";
		case DayOfWeek.Friday:
			return "FRIDAY";
		default:
			return "SATURDAY";
		}
	}

	private void ActivateTrespassZones()
	{
		SchoolBell.Play();
		Collider[] trespassZones = TrespassZones;
		foreach (Collider collider in trespassZones)
		{
			collider.enabled = true;
		}
	}

	public void DeactivateTrespassZones()
	{
		Yandere.Trespassing = false;
		SchoolBell.Play();
		Collider[] trespassZones = TrespassZones;
		foreach (Collider collider in trespassZones)
		{
			if (!collider.GetComponent<TrespassScript>().OffLimits)
			{
				collider.enabled = false;
			}
		}
	}
}
