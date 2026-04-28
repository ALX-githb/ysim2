using UnityEngine;

public class NoteWindowScript : MonoBehaviour
{
	public InputManagerScript InputManager;

	public NoteLockerScript NoteLocker;

	public PromptBarScript PromptBar;

	public YandereScript Yandere;

	public ClockScript Clock;

	public Transform SubHighlight;

	public Transform SubMenu;

	public UISprite[] SlotHighlights;

	public UILabel[] SlotLabels;

	public UILabel[] SubLabels;

	public string[] OriginalText;

	public string[] Subjects;

	public string[] Locations;

	public string[] Times;

	public float[] Hours;

	public bool[] SlotsFilled;

	public int SubSlot;

	public int MeetID;

	public int Slot = 1;

	public float Rotation;

	public float TimeID;

	public int ID;

	public bool Selecting;

	public bool Fade;

	public bool Show;

	private void Start()
	{
		SubMenu.transform.localScale = Vector3.zero;
		base.transform.localPosition = new Vector3(455f, -965f, 0f);
		base.transform.localEulerAngles = new Vector3(0f, 0f, -90f);
		OriginalText[1] = SlotLabels[1].text;
		OriginalText[2] = SlotLabels[2].text;
		OriginalText[3] = SlotLabels[3].text;
		UpdateHighlights();
		UpdateSubLabels();
	}

	private void Update()
	{
		float t = Time.unscaledDeltaTime * 10f;
		if (!Show)
		{
			if (Rotation > -90f)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(455f, -965f, 0f), t);
				Rotation = Mathf.Lerp(Rotation, -91f, t);
				base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, Rotation);
			}
			else
			{
				base.gameObject.SetActive(false);
			}
			return;
		}
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, Vector3.zero, t);
		Rotation = Mathf.Lerp(Rotation, 0f, t);
		base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, Rotation);
		if (!Selecting)
		{
			if (SubMenu.transform.localScale.x > 0.1f)
			{
				SubMenu.transform.localScale = Vector3.Lerp(SubMenu.transform.localScale, Vector3.zero, t);
			}
			else
			{
				SubMenu.transform.localScale = Vector3.zero;
			}
			if (InputManager.TappedDown)
			{
				Slot++;
				if (Slot > 3)
				{
					Slot = 1;
				}
				UpdateHighlights();
			}
			if (InputManager.TappedUp)
			{
				Slot--;
				if (Slot < 1)
				{
					Slot = 3;
				}
				UpdateHighlights();
			}
			if (ControlFreak2.CF2Input.GetButtonDown("A"))
			{
				PromptBar.Label[2].text = string.Empty;
				PromptBar.UpdateButtons();
				Selecting = true;
				UpdateSubLabels();
			}
			if (ControlFreak2.CF2Input.GetButtonDown("B"))
			{
				Slot = 1;
				UpdateHighlights();
				SlotLabels[1].text = OriginalText[1];
				SlotLabels[2].text = OriginalText[2];
				SlotLabels[3].text = OriginalText[3];
				SlotsFilled[1] = false;
				SlotsFilled[2] = false;
				SlotsFilled[3] = false;
				Exit();
			}
			if (ControlFreak2.CF2Input.GetButtonDown("X") && SlotsFilled[1] && SlotsFilled[2] && SlotsFilled[3])
			{
				NoteLocker.MeetID = MeetID;
				NoteLocker.MeetTime = TimeID;
				NoteLocker.Prompt.enabled = false;
				NoteLocker.CanLeaveNote = false;
				NoteLocker.NoteLeft = true;
				if (NoteLocker.Student.StudentID == 7 && SlotLabels[1].text == Subjects[10])
				{
					NoteLocker.Success = true;
				}
				if (NoteLocker.Student.StudentID == 32 && NoteLocker.Student.Bullied && SlotLabels[1].text == Subjects[6])
				{
					NoteLocker.Success = true;
				}
				Exit();
			}
		}
		else
		{
			SubMenu.transform.localScale = Vector3.Lerp(SubMenu.transform.localScale, new Vector3(1f, 1f, 1f), t);
			if (InputManager.TappedDown)
			{
				SubSlot++;
				if (SubSlot > 10)
				{
					SubSlot = 1;
				}
				SubHighlight.localPosition = new Vector3(SubHighlight.localPosition.x, 550f - 100f * (float)SubSlot, SubHighlight.localPosition.z);
			}
			if (InputManager.TappedUp)
			{
				SubSlot--;
				if (SubSlot < 1)
				{
					SubSlot = 10;
				}
				SubHighlight.localPosition = new Vector3(SubHighlight.localPosition.x, 550f - 100f * (float)SubSlot, SubHighlight.localPosition.z);
			}
			if (ControlFreak2.CF2Input.GetButtonDown("A") && SubLabels[SubSlot].color.a > 0.5f && SubLabels[SubSlot].text != string.Empty && SubLabels[SubSlot].text != "??????????")
			{
				SlotLabels[Slot].text = SubLabels[SubSlot].text;
				SlotsFilled[Slot] = true;
				if (Slot == 2)
				{
					MeetID = SubSlot;
				}
				if (Slot == 3)
				{
					TimeID = Hours[SubSlot];
				}
				CheckForCompletion();
				Selecting = false;
				SubSlot = 1;
				SubHighlight.localPosition = new Vector3(SubHighlight.localPosition.x, 450f, SubHighlight.localPosition.z);
			}
			if (ControlFreak2.CF2Input.GetButtonDown("B"))
			{
				CheckForCompletion();
				Selecting = false;
				SubSlot = 1;
				SubHighlight.localPosition = new Vector3(SubHighlight.localPosition.x, 450f, SubHighlight.localPosition.z);
			}
		}
		UISprite uISprite = SlotHighlights[Slot];
		if (!Fade)
		{
			uISprite.color = new Color(uISprite.color.r, uISprite.color.g, uISprite.color.b, uISprite.color.a + 1f / 60f);
			if (uISprite.color.a >= 0.5f)
			{
				Fade = true;
			}
		}
		else
		{
			uISprite.color = new Color(uISprite.color.r, uISprite.color.g, uISprite.color.b, uISprite.color.a - 1f / 60f);
			if (uISprite.color.a <= 0f)
			{
				Fade = false;
			}
		}
	}

	private void UpdateHighlights()
	{
		for (int i = 1; i < SlotHighlights.Length; i++)
		{
			UISprite uISprite = SlotHighlights[i];
			uISprite.color = new Color(uISprite.color.r, uISprite.color.g, uISprite.color.b, 0f);
		}
	}

	private void UpdateSubLabels()
	{
		if (Slot == 1)
		{
			for (ID = 1; ID < SubLabels.Length; ID++)
			{
				UILabel uILabel = SubLabels[ID];
				uILabel.text = Subjects[ID];
				uILabel.color = new Color(uILabel.color.r, uILabel.color.g, uILabel.color.b, 1f);
			}
			if (!EventGlobals.Event1)
			{
				SubLabels[10].text = "??????????";
			}
		}
		else if (Slot == 2)
		{
			for (ID = 1; ID < SubLabels.Length; ID++)
			{
				UILabel uILabel2 = SubLabels[ID];
				uILabel2.text = Locations[ID];
				uILabel2.color = new Color(uILabel2.color.r, uILabel2.color.g, uILabel2.color.b, 1f);
			}
		}
		else if (Slot == 3)
		{
			for (ID = 1; ID < SubLabels.Length; ID++)
			{
				UILabel uILabel3 = SubLabels[ID];
				uILabel3.text = Times[ID];
				uILabel3.color = new Color(uILabel3.color.r, uILabel3.color.g, uILabel3.color.b, 1f);
			}
			DisableOptions();
		}
	}

	private void CheckForCompletion()
	{
		if (SlotsFilled[1] && SlotsFilled[2] && SlotsFilled[3])
		{
			PromptBar.Label[2].text = "Finish";
			PromptBar.UpdateButtons();
		}
	}

	private void Exit()
	{
		Yandere.Blur.enabled = false;
		Yandere.CanMove = true;
		Show = false;
		Yandere.HUD.alpha = 1f;
		Time.timeScale = 1f;
		PromptBar.Label[0].text = string.Empty;
		PromptBar.Label[1].text = string.Empty;
		PromptBar.Label[2].text = string.Empty;
		PromptBar.Label[4].text = string.Empty;
		PromptBar.Show = false;
		PromptBar.UpdateButtons();
	}

	private void DisableOptions()
	{
		if (Clock.HourTime >= 7.25f)
		{
			UILabel uILabel = SubLabels[1];
			uILabel.color = new Color(uILabel.color.r, uILabel.color.g, uILabel.color.b, 0.5f);
		}
		if (Clock.HourTime >= 7.5f)
		{
			UILabel uILabel2 = SubLabels[2];
			uILabel2.color = new Color(uILabel2.color.r, uILabel2.color.g, uILabel2.color.b, 0.5f);
		}
		if (Clock.HourTime >= 7.75f)
		{
			UILabel uILabel3 = SubLabels[3];
			uILabel3.color = new Color(uILabel3.color.r, uILabel3.color.g, uILabel3.color.b, 0.5f);
		}
		if (Clock.HourTime >= 8f)
		{
			UILabel uILabel4 = SubLabels[4];
			uILabel4.color = new Color(uILabel4.color.r, uILabel4.color.g, uILabel4.color.b, 0.5f);
		}
		if (Clock.HourTime >= 8.25f)
		{
			UILabel uILabel5 = SubLabels[5];
			uILabel5.color = new Color(uILabel5.color.r, uILabel5.color.g, uILabel5.color.b, 0.5f);
		}
		if (Clock.HourTime >= 15.5f)
		{
			UILabel uILabel6 = SubLabels[6];
			uILabel6.color = new Color(uILabel6.color.r, uILabel6.color.g, uILabel6.color.b, 0.5f);
		}
		if (Clock.HourTime >= 16f)
		{
			UILabel uILabel7 = SubLabels[7];
			uILabel7.color = new Color(uILabel7.color.r, uILabel7.color.g, uILabel7.color.b, 0.5f);
		}
		if (Clock.HourTime >= 16.5f)
		{
			UILabel uILabel8 = SubLabels[8];
			uILabel8.color = new Color(uILabel8.color.r, uILabel8.color.g, uILabel8.color.b, 0.5f);
		}
		if (Clock.HourTime >= 17f)
		{
			UILabel uILabel9 = SubLabels[9];
			uILabel9.color = new Color(uILabel9.color.r, uILabel9.color.g, uILabel9.color.b, 0.5f);
		}
		if (Clock.HourTime >= 17.5f)
		{
			UILabel uILabel10 = SubLabels[10];
			uILabel10.color = new Color(uILabel10.color.r, uILabel10.color.g, uILabel10.color.b, 0.5f);
		}
	}
}
