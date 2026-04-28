using UnityEngine;

public class VoidGoddessScript : MonoBehaviour
{
	public StudentManagerScript StudentManager;

	public InputManagerScript InputManager;

	public PromptScript Prompt;

	public GameObject NewPortrait;

	public GameObject Portrait;

	public GameObject Goddess;

	public Transform Highlight;

	public Transform Window;

	public Transform Head;

	public UITexture[] Portraits;

	public Animation[] Legs;

	public bool PassingJudgement;

	public bool Follow;

	public int Selected;

	public int Column;

	public int Row;

	public int ID;

	private void Start()
	{
		Legs[1]["SpiderLegWiggle"].speed = 1f;
		Legs[2]["SpiderLegWiggle"].speed = 0.95f;
		Legs[3]["SpiderLegWiggle"].speed = 0.9f;
		Legs[4]["SpiderLegWiggle"].speed = 0.85f;
		Legs[5]["SpiderLegWiggle"].speed = 0.8f;
		Legs[6]["SpiderLegWiggle"].speed = 0.75f;
		Legs[7]["SpiderLegWiggle"].speed = 0.7f;
		Legs[8]["SpiderLegWiggle"].speed = 0.65f;
		for (ID = 1; ID < 101; ID++)
		{
			NewPortrait = Object.Instantiate(Portrait, base.transform.position, Quaternion.identity);
			NewPortrait.transform.parent = Window;
			NewPortrait.transform.localScale = new Vector3(1f, 1f, 1f);
			NewPortrait.transform.localPosition = new Vector3(-450 + Column * 100, 450 - Row * 100, 0f);
			Portraits[ID] = NewPortrait.GetComponent<UITexture>();
			if ((ID <= 32 || ID >= 41) && (ID <= 45 || ID >= 56) && ID <= 97)
			{
				string url = "file:///" + Application.streamingAssetsPath + "/Portraits/Student_" + ID + ".png";
				WWW wWW = new WWW(url);
				NewPortrait.GetComponent<UITexture>().mainTexture = wWW.texture;
			}
			Column++;
			if (Column == 10)
			{
				Column = 0;
				Row++;
			}
		}
		Window.parent.gameObject.SetActive(false);
		Selected = 1;
		Column = 0;
		Row = 0;
		UpdatePortraits();
	}

	private void Update()
	{
		if (Prompt.Circle[0].fillAmount == 0f)
		{
			Prompt.Circle[0].fillAmount = 1f;
			if (!Goddess.activeInHierarchy)
			{
				Prompt.Label[0].text = "     Pass Judgement";
				Prompt.Label[1].text = "     Dismiss";
				Prompt.Label[2].text = "     Follow";
				Prompt.HideButton[1] = false;
				Prompt.HideButton[2] = false;
				Prompt.OffsetX[0] = -1f;
				Goddess.SetActive(true);
			}
			else
			{
				Window.parent.gameObject.SetActive(true);
				Prompt.Yandere.CanMove = false;
				PassingJudgement = true;
			}
		}
		if (Prompt.Circle[1].fillAmount == 0f)
		{
			Prompt.Circle[1].fillAmount = 1f;
			Prompt.Label[0].text = "     Summon An Ancient Evil";
			Prompt.Label[1].text = string.Empty;
			Prompt.Label[2].text = string.Empty;
			Prompt.HideButton[1] = true;
			Prompt.HideButton[2] = true;
			Prompt.OffsetX[0] = 0f;
			base.transform.position = new Vector3(-9.5f, 1f, -75f);
			Goddess.SetActive(false);
			Follow = false;
		}
		if (Prompt.Circle[2].fillAmount == 0f)
		{
			Prompt.Circle[2].fillAmount = 1f;
			Follow = !Follow;
		}
		if (Follow && Vector3.Distance(Prompt.Yandere.transform.position + new Vector3(0f, 1f, 0f), base.transform.position) > 1f)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, Prompt.Yandere.transform.position + new Vector3(0f, 1f, 0f), Time.deltaTime);
		}
		if (!PassingJudgement)
		{
			return;
		}
		if (InputManager.TappedUp)
		{
			Row--;
			UpdateHighlight();
		}
		else if (InputManager.TappedDown)
		{
			Row++;
			UpdateHighlight();
		}
		if (InputManager.TappedLeft)
		{
			Column--;
			UpdateHighlight();
		}
		else if (InputManager.TappedRight)
		{
			Column++;
			UpdateHighlight();
		}
		if (ControlFreak2.CF2Input.GetButtonDown("A"))
		{
			StudentManager.DisableStudent(Selected);
			UpdatePortraits();
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha1))
		{
			for (ID = 1; ID < 101; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha2))
		{
			for (ID = 1; ID < 21; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			StudentManager.DisableStudent(32);
			StudentManager.DisableStudent(33);
			StudentManager.DisableStudent(34);
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha3))
		{
			for (ID = 21; ID < 26; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha4))
		{
			for (ID = 26; ID < 32; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha5))
		{
			for (ID = 41; ID < 46; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha6))
		{
			for (ID = 56; ID < 61; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha7))
		{
			for (ID = 61; ID < 66; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha8))
		{
			for (ID = 66; ID < 71; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha9))
		{
			for (ID = 71; ID < 76; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha0))
		{
			for (ID = 76; ID < 81; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown("-"))
		{
			for (ID = 81; ID < 86; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown("="))
		{
			for (ID = 86; ID < 90; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Backspace))
		{
			for (ID = 90; ID < 98; ID++)
			{
				StudentManager.DisableStudent(ID);
			}
			UpdatePortraits();
		}
		if (ControlFreak2.CF2Input.GetButtonDown("B"))
		{
			Window.parent.gameObject.SetActive(false);
			Prompt.Yandere.CanMove = true;
			Prompt.Yandere.Shoved = false;
			PassingJudgement = false;
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Z))
		{
			StudentManager.Students[Selected].transform.position = Prompt.Yandere.transform.position + Prompt.Yandere.transform.forward;
		}
	}

	private void UpdateHighlight()
	{
		if (Row < 0)
		{
			Row = 9;
		}
		else if (Row > 9)
		{
			Row = 0;
		}
		if (Column < 0)
		{
			Column = 9;
		}
		else if (Column > 9)
		{
			Column = 0;
		}
		Highlight.localPosition = new Vector3(-450 + 100 * Column, 450 - 100 * Row, Highlight.localPosition.z);
		Selected = 1 + Row * 10 + Column;
	}

	private void UpdatePortraits()
	{
		for (ID = 1; ID < 101; ID++)
		{
			if (StudentManager.Students[ID] != null)
			{
				if (StudentManager.Students[ID].gameObject.activeInHierarchy)
				{
					Portraits[ID].color = new Color(1f, 1f, 1f, 1f);
				}
				else
				{
					Portraits[ID].color = new Color(1f, 1f, 1f, 0.5f);
				}
			}
			else
			{
				Portraits[ID].color = new Color(1f, 1f, 1f, 0.5f);
			}
		}
	}
}
