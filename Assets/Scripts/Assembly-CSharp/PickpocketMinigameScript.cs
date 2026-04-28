using UnityEngine;

public class PickpocketMinigameScript : MonoBehaviour
{
	public Transform PickpocketSpot;

	public UISprite[] ButtonPrompts;

	public UISprite Circle;

	public UISprite BG;

	public YandereScript Yandere;

	public string CurrentButton = string.Empty;

	public bool NotNurse;

	public bool Failure;

	public bool Success;

	public bool Show;

	public int ButtonID;

	public int Progress;

	public int ID;

	public float Timer;

	private void Start()
	{
		base.transform.localScale = Vector3.zero;
		ButtonPrompts[1].enabled = false;
		ButtonPrompts[2].enabled = false;
		ButtonPrompts[3].enabled = false;
		ButtonPrompts[4].enabled = false;
		Circle.enabled = false;
		BG.enabled = false;
	}

	private void Update()
	{
		if (Show)
		{
			if (PickpocketSpot != null)
			{
				Yandere.MoveTowardsTarget(PickpocketSpot.position);
				Yandere.transform.rotation = Quaternion.Slerp(Yandere.transform.rotation, PickpocketSpot.rotation, Time.deltaTime * 10f);
			}
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 10f);
			Timer += Time.deltaTime;
			if (Timer > 1f)
			{
				if (ButtonID == 0)
				{
					ChooseButton();
					Timer = 0f;
				}
				else
				{
					Yandere.Caught = true;
					Failure = true;
					End();
				}
			}
			else
			{
				if (ButtonID <= 0)
				{
					return;
				}
				Circle.fillAmount = 1f - Timer / 1f;
				if ((ControlFreak2.CF2Input.GetButtonDown("A") && CurrentButton != "A") || (ControlFreak2.CF2Input.GetButtonDown("B") && CurrentButton != "B") || (ControlFreak2.CF2Input.GetButtonDown("X") && CurrentButton != "X") || (ControlFreak2.CF2Input.GetButtonDown("Y") && CurrentButton != "Y"))
				{
					Yandere.Caught = true;
					Failure = true;
					End();
				}
				else if (ControlFreak2.CF2Input.GetButtonDown(CurrentButton))
				{
					ButtonPrompts[ButtonID].enabled = false;
					Circle.enabled = false;
					BG.enabled = false;
					ButtonID = 0;
					Timer = 0f;
					Progress++;
					if (Progress == 5)
					{
						Yandere.Pickpocketing = false;
						Yandere.CanMove = true;
						Success = true;
						End();
					}
				}
			}
		}
		else if (base.transform.localScale.x > 0.1f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 10f);
			if (base.transform.localScale.x < 0.1f)
			{
				base.transform.localScale = Vector3.zero;
			}
		}
	}

	private void ChooseButton()
	{
		ButtonPrompts[1].enabled = false;
		ButtonPrompts[2].enabled = false;
		ButtonPrompts[3].enabled = false;
		ButtonPrompts[4].enabled = false;
		int buttonID = ButtonID;
		while (ButtonID == buttonID)
		{
			ButtonID = Random.Range(1, 5);
		}
		if (ButtonID == 1)
		{
			CurrentButton = "A";
		}
		else if (ButtonID == 2)
		{
			CurrentButton = "B";
		}
		else if (ButtonID == 3)
		{
			CurrentButton = "X";
		}
		else if (ButtonID == 4)
		{
			CurrentButton = "Y";
		}
		ButtonPrompts[ButtonID].enabled = true;
		Circle.enabled = true;
		BG.enabled = true;
	}

	public void End()
	{
		Debug.Log("Ending minigame.");
		ButtonPrompts[1].enabled = false;
		ButtonPrompts[2].enabled = false;
		ButtonPrompts[3].enabled = false;
		ButtonPrompts[4].enabled = false;
		Circle.enabled = false;
		BG.enabled = false;
		Yandere.CharacterAnimation.CrossFade("f02_readyToFight_00");
		Progress = 0;
		ButtonID = 0;
		Show = false;
		Timer = 0f;
	}
}
