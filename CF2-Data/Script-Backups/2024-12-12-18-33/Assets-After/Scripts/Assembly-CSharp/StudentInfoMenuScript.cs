using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StudentInfoMenuScript : MonoBehaviour
{
	public StudentManagerScript StudentManager;

	public InputManagerScript InputManager;

	public PauseScreenScript PauseScreen;

	public StudentInfoScript StudentInfo;

	public PromptBarScript PromptBar;

	public JsonScript JSON;

	public GameObject StudentPortrait;

	public Texture UnknownPortrait;

	public Texture BlankPortrait;

	public Texture Headmaster;

	public Texture Counselor;

	public Texture InfoChan;

	public Transform PortraitGrid;

	public Transform Highlight;

	public Transform Scrollbar;

	public StudentPortraitScript[] StudentPortraits;

	public bool[] PortraitLoaded;

	public UISprite[] DeathShadows;

	public UISprite[] Friends;

	public UISprite[] Panties;

	public UITexture[] PrisonBars;

	public UITexture[] Portraits;

	public UILabel NameLabel;

	public bool CustomPortraits;

	public bool CyberBullying;

	public bool GettingInfo;

	public bool MatchMaking;

	public bool Distracting;

	public bool SendingHome;

	public bool Gossiping;

	public bool Targeting;

	public bool Dead;

	public int[] SetSizes;

	public int StudentID;

	public int Column;

	public int Row;

	public int Set;

	public int Columns;

	public int Rows;

	private void Start()
	{
		for (int i = 1; i < 101; i++)
		{
			GameObject gameObject = Object.Instantiate(StudentPortrait, base.transform.position, Quaternion.identity);
			gameObject.transform.parent = PortraitGrid;
			gameObject.transform.localPosition = new Vector3(-300f + (float)Column * 150f, 80f - (float)Row * 160f, 0f);
			gameObject.transform.localEulerAngles = Vector3.zero;
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			StudentPortraits[i] = gameObject.GetComponent<StudentPortraitScript>();
			Column++;
			if (Column > 4)
			{
				Column = 0;
				Row++;
			}
		}
		Column = 0;
		Row = 0;
		if (File.Exists(Application.streamingAssetsPath + "/CustomPortraits.txt"))
		{
			string text = File.ReadAllText(Application.streamingAssetsPath + "/CustomPortraits.txt");
			if (text == "1")
			{
				CustomPortraits = true;
			}
		}
	}

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetButtonDown("A") && PromptBar.Label[0].text != string.Empty)
		{
			if (StudentGlobals.GetStudentPhotographed(StudentID) || StudentID > 97)
			{
				StudentInfo.gameObject.SetActive(true);
				StudentInfo.UpdateInfo(StudentID);
				StudentInfo.Topics.SetActive(false);
				base.gameObject.SetActive(false);
				PromptBar.ClearButtons();
				if (Gossiping)
				{
					PromptBar.Label[0].text = "Gossip";
				}
				if (Distracting)
				{
					PromptBar.Label[0].text = "Distract";
				}
				if (CyberBullying)
				{
					PromptBar.Label[0].text = "Accept";
				}
				if (MatchMaking)
				{
					PromptBar.Label[0].text = "Match";
				}
				if (Targeting)
				{
					PromptBar.Label[0].text = "Kill";
				}
				if (SendingHome)
				{
					PromptBar.Label[0].text = "Send Home";
				}
				if (StudentManager.Students[StudentID].gameObject.activeInHierarchy)
				{
					if (StudentManager.Tag.Target == StudentManager.Students[StudentID].Head)
					{
						PromptBar.Label[2].text = "Untag";
					}
					else
					{
						PromptBar.Label[2].text = "Tag";
					}
				}
				else
				{
					PromptBar.Label[2].text = string.Empty;
				}
				PromptBar.Label[1].text = "Back";
				PromptBar.Label[3].text = "Interests";
				PromptBar.UpdateButtons();
			}
			else
			{
				StudentGlobals.SetStudentPhotographed(StudentID, true);
				PauseScreen.ServiceMenu.gameObject.SetActive(true);
				PauseScreen.ServiceMenu.UpdateList();
				PauseScreen.ServiceMenu.UpdateDesc();
				PauseScreen.ServiceMenu.Purchase();
				GettingInfo = false;
				base.gameObject.SetActive(false);
			}
		}
		if (ControlFreak2.CF2Input.GetButtonDown("B"))
		{
			if (Gossiping || Distracting || MatchMaking || Targeting)
			{
				if (Targeting)
				{
					PauseScreen.Yandere.RPGCamera.enabled = true;
				}
				PauseScreen.Yandere.Interaction = YandereInteractionType.Bye;
				PauseScreen.Yandere.TalkTimer = 2f;
				PauseScreen.MainMenu.SetActive(true);
				PauseScreen.Sideways = false;
				PauseScreen.Show = false;
				base.gameObject.SetActive(false);
				Time.timeScale = 1f;
				Distracting = false;
				MatchMaking = false;
				Gossiping = false;
				Targeting = false;
				PromptBar.ClearButtons();
				PromptBar.Show = false;
			}
			else if (CyberBullying)
			{
				PauseScreen.MainMenu.SetActive(true);
				PauseScreen.Sideways = false;
				PauseScreen.Show = false;
				base.gameObject.SetActive(false);
				PromptBar.ClearButtons();
				PromptBar.Show = false;
			}
			else if (SendingHome || GettingInfo)
			{
				PauseScreen.ServiceMenu.gameObject.SetActive(true);
				PauseScreen.ServiceMenu.UpdateList();
				PauseScreen.ServiceMenu.UpdateDesc();
				base.gameObject.SetActive(false);
				SendingHome = false;
				GettingInfo = false;
			}
			else
			{
				PauseScreen.MainMenu.SetActive(true);
				PauseScreen.Sideways = false;
				PauseScreen.PressedB = true;
				base.gameObject.SetActive(false);
				PromptBar.ClearButtons();
				PromptBar.Label[0].text = "Accept";
				PromptBar.Label[1].text = "Exit";
				PromptBar.Label[4].text = "Choose";
				PromptBar.UpdateButtons();
				PromptBar.Show = true;
			}
		}
		float t = Time.unscaledDeltaTime * 10f;
		float num = ((Row % 2 != 0) ? ((Row - 1) / 2) : (Row / 2));
		float b = 320f * num;
		PortraitGrid.localPosition = new Vector3(PortraitGrid.localPosition.x, Mathf.Lerp(PortraitGrid.localPosition.y, b, t), PortraitGrid.localPosition.z);
		Scrollbar.localPosition = new Vector3(Scrollbar.localPosition.x, Mathf.Lerp(Scrollbar.localPosition.y, 175f - 350f * (PortraitGrid.localPosition.y / 2880f), t), Scrollbar.localPosition.z);
		if (InputManager.TappedUp)
		{
			Row--;
			if (Row < 0)
			{
				Row = Rows - 1;
			}
			UpdateHighlight();
		}
		if (InputManager.TappedDown)
		{
			Row++;
			if (Row > Rows - 1)
			{
				Row = 0;
			}
			UpdateHighlight();
		}
		if (InputManager.TappedRight)
		{
			Column++;
			if (Column > Columns - 1)
			{
				Column = 0;
			}
			UpdateHighlight();
		}
		if (InputManager.TappedLeft)
		{
			Column--;
			if (Column < 0)
			{
				Column = Columns - 1;
			}
			UpdateHighlight();
		}
	}

	public void UpdateHighlight()
	{
		StudentID = 1 + (Column + Row * Columns);
		if (StudentGlobals.GetStudentPhotographed(StudentID) || StudentID > 97)
		{
			PromptBar.Label[0].text = "View Info";
			PromptBar.UpdateButtons();
		}
		else
		{
			PromptBar.Label[0].text = string.Empty;
			PromptBar.UpdateButtons();
		}
		if (Gossiping && (StudentID == 1 || StudentID == PauseScreen.Yandere.TargetStudent.StudentID || JSON.Students[StudentID].Club == ClubType.Sports || StudentGlobals.GetStudentDead(StudentID) || StudentID > 97))
		{
			PromptBar.Label[0].text = string.Empty;
			PromptBar.UpdateButtons();
		}
		if (CyberBullying && (JSON.Students[StudentID].Gender == 1 || StudentGlobals.GetStudentDead(StudentID) || StudentID > 97))
		{
			PromptBar.Label[0].text = string.Empty;
			PromptBar.UpdateButtons();
		}
		if (Distracting)
		{
			Dead = false;
			if (StudentManager.Students[StudentID] == null)
			{
				Dead = true;
			}
			if (Dead)
			{
				PromptBar.Label[0].text = string.Empty;
				PromptBar.UpdateButtons();
			}
			else if (StudentID == 0 || !StudentManager.Students[StudentID].Alive || StudentID == PauseScreen.Yandere.TargetStudent.StudentID || StudentGlobals.GetStudentKidnapped(StudentID) || StudentManager.Students[StudentID].Tranquil || StudentManager.Students[StudentID].Slave || StudentGlobals.GetStudentDead(StudentID) || StudentID > 97)
			{
				PromptBar.Label[0].text = string.Empty;
				PromptBar.UpdateButtons();
			}
		}
		if (MatchMaking && (StudentID == PauseScreen.Yandere.TargetStudent.StudentID || StudentGlobals.GetStudentDead(StudentID) || StudentID > 97))
		{
			PromptBar.Label[0].text = string.Empty;
			PromptBar.UpdateButtons();
		}
		if (Targeting && (StudentID == 1 || StudentGlobals.GetStudentDead(StudentID) || StudentID > 97))
		{
			PromptBar.Label[0].text = string.Empty;
			PromptBar.UpdateButtons();
		}
		if (SendingHome)
		{
			Debug.Log("Highlighting student number " + StudentID);
			if (StudentManager.Students[StudentID] != null && (StudentID == 1 || StudentGlobals.GetStudentDead(StudentID) || (StudentID < 98 && StudentManager.Students[StudentID].SentHome) || StudentID > 97 || StudentGlobals.GetStudentSlave() == StudentID))
			{
				PromptBar.Label[0].text = string.Empty;
				PromptBar.UpdateButtons();
			}
		}
		if (GettingInfo)
		{
			if (StudentGlobals.GetStudentPhotographed(StudentID) || StudentID > 97)
			{
				PromptBar.Label[0].text = string.Empty;
				PromptBar.UpdateButtons();
			}
			else
			{
				PromptBar.Label[0].text = "Get Info";
				PromptBar.UpdateButtons();
			}
		}
		Highlight.localPosition = new Vector3(-300f + (float)Column * 150f, 80f - (float)Row * 160f, Highlight.localPosition.z);
		UpdateNameLabel();
	}

	private void UpdateNameLabel()
	{
		if (StudentID > 97 || StudentGlobals.GetStudentPhotographed(StudentID))
		{
			NameLabel.text = JSON.Students[StudentID].Name;
		}
		else
		{
			NameLabel.text = "Unknown";
		}
	}

	public IEnumerator UpdatePortraits()
	{
		Debug.Log("The Student Info Menu was instructed to get photos.");
		for (int ID = 1; ID < 101; ID++)
		{
			Debug.Log("1 - We entered the loop.");
			if (ID == 0)
			{
				StudentPortraits[ID].Portrait.mainTexture = InfoChan;
			}
			else
			{
				Debug.Log("2 - ID is not zero.");
				if (!PortraitLoaded[ID])
				{
					Debug.Log("3 - PortraitLoaded is false.");
					if (ID < 98)
					{
						Debug.Log("4 - ID is less than 98.");
						if (StudentGlobals.GetStudentPhotographed(ID))
						{
							Debug.Log("5 - GetStudentPhotographed is true.");
							string path = "file:///" + Application.streamingAssetsPath + "/Portraits/Student_" + ID + ".png";
							WWW www = new WWW(path);
							Debug.Log("Waiting for www to return.");
							yield return www;
							Debug.Log("www has returned.");
							if (www.error == null)
							{
								Debug.Log("6 - Error is null.");
								if (!StudentGlobals.GetStudentReplaced(ID))
								{
									if (!CustomPortraits)
									{
										if (ID < 33 || (ID > 40 && ID < 46) || ID > 55)
										{
											StudentPortraits[ID].Portrait.mainTexture = www.texture;
										}
										else
										{
											StudentPortraits[ID].Portrait.mainTexture = BlankPortrait;
										}
									}
									else
									{
										StudentPortraits[ID].Portrait.mainTexture = www.texture;
									}
								}
								else
								{
									StudentPortraits[ID].Portrait.mainTexture = BlankPortrait;
								}
							}
							else
							{
								Debug.Log("We got an error when trying to retrieve a student's portrait!");
								StudentPortraits[ID].Portrait.mainTexture = UnknownPortrait;
							}
							PortraitLoaded[ID] = true;
						}
						else
						{
							StudentPortraits[ID].Portrait.mainTexture = UnknownPortrait;
						}
					}
					else
					{
						switch (ID)
						{
						case 98:
							StudentPortraits[ID].Portrait.mainTexture = Counselor;
							break;
						case 99:
							StudentPortraits[ID].Portrait.mainTexture = Headmaster;
							break;
						case 100:
							StudentPortraits[ID].Portrait.mainTexture = InfoChan;
							break;
						}
					}
				}
			}
			if (PlayerGlobals.GetStudentPantyShot(JSON.Students[ID].Name))
			{
				StudentPortraits[ID].Panties.SetActive(true);
			}
			StudentPortraits[ID].Friend.SetActive(PlayerGlobals.GetStudentFriend(ID));
			if (StudentGlobals.GetStudentDying(ID) || StudentGlobals.GetStudentDead(ID))
			{
				StudentPortraits[ID].DeathShadow.SetActive(true);
			}
			if (SceneManager.GetActiveScene().name == "SchoolScene" && StudentManager.Students[ID] != null && StudentManager.Students[ID].Tranquil)
			{
				StudentPortraits[ID].DeathShadow.SetActive(true);
			}
			if (StudentGlobals.GetStudentArrested(ID))
			{
				StudentPortraits[ID].PrisonBars.SetActive(true);
				StudentPortraits[ID].DeathShadow.SetActive(true);
			}
		}
	}
}
