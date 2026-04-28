#pragma warning disable 618 // Unity-deprecated APIs (AIBase.target, AIPath.speed, WWW, GetInstanceID, CF2Input.GetKeyDown(string), Physics2D.OverlapPointNonAlloc) still functional; full migration would change behavior or require coroutine refactors.
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugMenuScript : MonoBehaviour
{
	public FakeStudentSpawnerScript FakeStudentSpawner;

	public DelinquentManagerScript DelinquentManager;

	public StudentManagerScript StudentManager;

	public CameraEffectsScript CameraEffects;

	public WeaponManagerScript WeaponManager;

	public ReputationScript Reputation;

	public YandereScript Yandere;

	public BentoScript Bento;

	public ClockScript Clock;

	public PrayScript Turtle;

	public ZoomScript Zoom;

	public AstarPath Astar;

	public OsanaFridayBeforeClassEvent1Script OsanaEvent1;

	public OsanaFridayBeforeClassEvent2Script OsanaEvent2;

	public OsanaFridayLunchEventScript OsanaEvent3;

	public GameObject EasterEggWindow;

	public GameObject SacrificialArm;

	public GameObject CircularSaw;

	public GameObject Knife;

	public Transform[] TeleportSpot;

	public Transform RooftopSpot;

	public Transform Lockers;

	public GameObject Window;

	public bool MissionMode;

	public bool NoDebug;

	public int RooftopStudent = 33;

	public float Timer;

	public int ID;

	public Texture PantyCensorTexture;

	private void Start()
	{
		RooftopStudent = 33;
		base.transform.localPosition = new Vector3(base.transform.localPosition.x, 0f, base.transform.localPosition.z);
		Window.SetActive(false);
		if (MissionModeGlobals.MissionMode)
		{
			MissionMode = true;
		}
		if (GameGlobals.LoveSick)
		{
			NoDebug = true;
		}
	}

	private void Update()
	{
		if (!MissionMode && !NoDebug)
		{
			if (!Yandere.InClass && !Yandere.Chased && Yandere.Chasers == 0 && Yandere.CanMove)
			{
				if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Backslash) && Yandere.transform.position.y < 100f)
				{
					EasterEggWindow.SetActive(false);
					Window.SetActive(!Window.activeInHierarchy);
				}
			}
			else if (Window.activeInHierarchy)
			{
				Window.SetActive(false);
			}
			if (Window.activeInHierarchy)
			{
				if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F1))
				{
					StudentGlobals.FemaleUniform = 1;
					StudentGlobals.MaleUniform = 1;
					SceneManager.LoadScene("LoadingScene");
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F2))
				{
					StudentGlobals.FemaleUniform = 2;
					StudentGlobals.MaleUniform = 2;
					SceneManager.LoadScene("LoadingScene");
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F3))
				{
					StudentGlobals.FemaleUniform = 3;
					StudentGlobals.MaleUniform = 3;
					SceneManager.LoadScene("LoadingScene");
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F4))
				{
					StudentGlobals.FemaleUniform = 4;
					StudentGlobals.MaleUniform = 4;
					SceneManager.LoadScene("LoadingScene");
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F5))
				{
					StudentGlobals.FemaleUniform = 5;
					StudentGlobals.MaleUniform = 5;
					SceneManager.LoadScene("LoadingScene");
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F6))
				{
					StudentGlobals.FemaleUniform = 6;
					StudentGlobals.MaleUniform = 6;
					SceneManager.LoadScene("LoadingScene");
				}
				else
				{
					if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F12))
					{
						return;
					}
					if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha1))
					{
						DateGlobals.Weekday = DayOfWeek.Monday;
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha2))
					{
						DateGlobals.Weekday = DayOfWeek.Tuesday;
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha3))
					{
						DateGlobals.Weekday = DayOfWeek.Wednesday;
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha4))
					{
						DateGlobals.Weekday = DayOfWeek.Thursday;
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha5))
					{
						DateGlobals.Weekday = DayOfWeek.Friday;
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha6))
					{
						Yandere.transform.position = TeleportSpot[1].position;
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha7))
					{
						Yandere.transform.position = TeleportSpot[2].position + new Vector3(0.75f, 0f, 0f);
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha8))
					{
						Yandere.transform.position = TeleportSpot[3].position;
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha9))
					{
						Yandere.transform.position = TeleportSpot[4].position;
						Window.SetActive(false);
						if (Clock.HourTime < 7.1f)
						{
							Clock.PresentTime = 426f;
							StudentScript studentScript = StudentManager.Students[7];
							if (studentScript != null)
							{
								if (studentScript.Phase < 2)
								{
									studentScript.ShoeRemoval.Start();
									studentScript.ShoeRemoval.PutOnShoes();
									studentScript.CanTalk = true;
									studentScript.Phase = 2;
									studentScript.CurrentDestination = studentScript.Destinations[2];
									studentScript.Pathfinding.target = studentScript.Destinations[2];
								}
								studentScript.transform.position = studentScript.Destinations[2].position;
							}
							StudentScript studentScript2 = StudentManager.Students[13];
							if (studentScript2 != null)
							{
								if (studentScript2.Phase < 2)
								{
									studentScript2.ShoeRemoval.Start();
									studentScript2.ShoeRemoval.PutOnShoes();
									studentScript2.Phase = 2;
									studentScript2.CurrentDestination = studentScript2.Destinations[2];
									studentScript2.Pathfinding.target = studentScript2.Destinations[2];
								}
								studentScript2.transform.position = studentScript2.Destinations[2].position;
							}
							StudentScript studentScript3 = StudentManager.Students[16];
							if (studentScript3 != null)
							{
								if (studentScript3.Phase < 2)
								{
									studentScript3.ShoeRemoval.Start();
									studentScript3.ShoeRemoval.PutOnShoes();
									studentScript3.Phase = 2;
									studentScript3.CurrentDestination = studentScript3.Destinations[2];
									studentScript3.Pathfinding.target = studentScript3.Destinations[2];
								}
								studentScript3.transform.position = studentScript3.Destinations[2].position;
							}
						}
						Physics.SyncTransforms();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha0))
					{
						CameraEffects.DisableCamera();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.A))
					{
						if (SchoolAtmosphere.Type == SchoolAtmosphereType.High)
						{
							SchoolGlobals.SchoolAtmosphere = 0.5f;
						}
						else if (SchoolAtmosphere.Type == SchoolAtmosphereType.Medium)
						{
							SchoolGlobals.SchoolAtmosphere = 0f;
						}
						else
						{
							SchoolGlobals.SchoolAtmosphere = 1f;
						}
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.C))
					{
						for (ID = 1; ID < 11; ID++)
						{
							CollectibleGlobals.SetTapeCollected(ID, true);
						}
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.D))
					{
						for (ID = 0; ID < 5; ID++)
						{
							StudentScript studentScript4 = StudentManager.Students[76 + ID];
							if (studentScript4 != null)
							{
								if (studentScript4.Phase < 2)
								{
									studentScript4.ShoeRemoval.Start();
									studentScript4.ShoeRemoval.PutOnShoes();
									studentScript4.Phase = 2;
									studentScript4.CurrentDestination = studentScript4.Destinations[2];
									studentScript4.Pathfinding.target = studentScript4.Destinations[2];
								}
								studentScript4.transform.position = studentScript4.Destinations[2].position;
							}
						}
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F))
					{
						FakeStudentSpawner.Spawn();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.G))
					{
						StudentScript studentScript5 = StudentManager.Students[RooftopStudent];
						if (Clock.HourTime < 15f)
						{
							PlayerGlobals.SetStudentFriend(RooftopStudent, true);
							Yandere.transform.position = RooftopSpot.position + new Vector3(1f, 0f, 0f);
							WeaponManager.Weapons[6].transform.position = Yandere.transform.position + new Vector3(0f, 0f, 1.915f);
							if (studentScript5 != null)
							{
								StudentManager.OfferHelp.UpdateLocation();
								StudentManager.OfferHelp.enabled = true;
								if (!studentScript5.Indoors)
								{
									if (studentScript5.ShoeRemoval.Locker == null)
									{
										studentScript5.ShoeRemoval.Start();
									}
									studentScript5.ShoeRemoval.PutOnShoes();
								}
								studentScript5.CharacterAnimation.Play(studentScript5.IdleAnim);
								studentScript5.transform.position = RooftopSpot.position;
								studentScript5.transform.rotation = RooftopSpot.rotation;
								studentScript5.Prompt.Label[0].text = "     Push";
								studentScript5.CurrentDestination = RooftopSpot;
								studentScript5.Pathfinding.target = RooftopSpot;
								studentScript5.Pathfinding.canSearch = false;
								studentScript5.Pathfinding.canMove = false;
								studentScript5.SpeechLines.Stop();
								studentScript5.Pushable = true;
								studentScript5.Routine = false;
								studentScript5.Meeting = true;
								studentScript5.MeetTime = 0f;
							}
							if (Clock.HourTime < 7.1f)
							{
								Clock.PresentTime = 426f;
							}
						}
						else
						{
							Clock.PresentTime = 960f;
							studentScript5.transform.position = Lockers.position;
						}
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.K))
					{
						SchoolGlobals.KidnapVictim = 6;
						StudentGlobals.SetStudentSlave(6);
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.L))
					{
						SchemeGlobals.SetSchemeStage(1, 2);
						EventGlobals.Event1 = true;
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.M))
					{
						StudentGlobals.SetStudentBroken(81, true);
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.O))
					{
						Yandere.Inventory.RivalPhone = true;
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.P))
					{
						PlayerGlobals.PantyShots += 20;
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Q))
					{
						Censor();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.R))
					{
						if (PlayerGlobals.Reputation != 66.66666f)
						{
							PlayerGlobals.Reputation = 66.66666f;
							Reputation.Reputation = PlayerGlobals.Reputation;
						}
						else
						{
							PlayerGlobals.Reputation = -66.66666f;
							Reputation.Reputation = PlayerGlobals.Reputation;
						}
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.S))
					{
						ClassGlobals.PhysicalGrade = 5;
						PlayerGlobals.Seduction = 5;
						for (ID = 1; ID < 101; ID++)
						{
							StudentGlobals.SetStudentPhotographed(ID, true);
						}
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.T))
					{
						Zoom.OverShoulder = !Zoom.OverShoulder;
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.U))
					{
						PlayerGlobals.SetStudentFriend(7, true);
						PlayerGlobals.SetStudentFriend(13, true);
						for (ID = 1; ID < 26; ID++)
						{
							ConversationGlobals.SetTopicLearnedByStudent(ID, 7, true);
							ConversationGlobals.SetTopicDiscovered(ID, true);
						}
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Z))
					{
						if (ControlFreak2.CF2Input.GetKey(KeyCode.LeftShift))
						{
							for (ID = 2; ID < 93; ID++)
							{
								StudentScript studentScript6 = StudentManager.Students[ID];
								if (studentScript6 != null)
								{
									StudentGlobals.SetStudentMissing(ID, true);
								}
							}
						}
						else
						{
							for (ID = 2; ID < 101; ID++)
							{
								StudentScript studentScript7 = StudentManager.Students[ID];
								if (studentScript7 != null && studentScript7.Club != ClubType.Council)
								{
									studentScript7.SpawnAlarmDisc();
									studentScript7.BecomeRagdoll();
									studentScript7.DeathType = DeathType.EasterEgg;
									StudentGlobals.SetStudentDead(ID, true);
								}
							}
						}
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.X))
					{
						OptionGlobals.HighPopulation = !OptionGlobals.HighPopulation;
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Backspace))
					{
						Time.timeScale = 1f;
						Clock.PresentTime = 1079f;
						Clock.HourTime = Clock.PresentTime / 60f;
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.BackQuote))
					{
						Globals.DeleteAll();
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Space))
					{
						Yandere.transform.position = TeleportSpot[5].position;
						if (StudentManager.Students[21] != null)
						{
							StudentManager.Students[21].transform.position = TeleportSpot[5].position;
							if (!StudentManager.Students[21].Indoors)
							{
								if (StudentManager.Students[21].ShoeRemoval.Locker == null)
								{
									StudentManager.Students[21].ShoeRemoval.Start();
								}
								StudentManager.Students[21].ShoeRemoval.PutOnShoes();
							}
						}
						Clock.PresentTime = 1015f;
						Clock.HourTime = Clock.PresentTime / 60f;
						Window.SetActive(false);
						OsanaEvent1.enabled = false;
						OsanaEvent2.enabled = false;
						OsanaEvent3.enabled = false;
						Physics.SyncTransforms();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.LeftAlt))
					{
						Turtle.SpawnWeapons();
						Yandere.transform.position = TeleportSpot[6].position;
						Clock.PresentTime = 425f;
						Clock.HourTime = Clock.PresentTime / 60f;
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.LeftControl))
					{
						Yandere.transform.position = TeleportSpot[7].position;
						if (StudentManager.Students[26] != null)
						{
							StudentManager.Students[26].transform.position = TeleportSpot[7].position;
						}
						Clock.PresentTime = 1015f;
						Clock.HourTime = Clock.PresentTime / 60f;
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.RightControl))
					{
						Yandere.transform.position = TeleportSpot[8].position;
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Equals))
					{
						DelinquentManager.Timer -= 30f;
						Clock.PresentTime += 30f;
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Return))
					{
						Yandere.transform.eulerAngles = TeleportSpot[10].eulerAngles;
						Yandere.transform.position = TeleportSpot[10].position;
						StudentManager.Students[1].ShoeRemoval.Start();
						StudentManager.Students[1].ShoeRemoval.PutOnShoes();
						StudentManager.Students[1].transform.position = new Vector3(0f, 12.1f, -25f);
						StudentManager.Students[1].Alarmed = true;
						StudentManager.Students[33].Lethal = true;
						StudentManager.Students[33].ShoeRemoval.Start();
						StudentManager.Students[33].ShoeRemoval.PutOnShoes();
						StudentManager.Students[33].transform.position = new Vector3(0f, 12.1f, -25f);
						Clock.PresentTime = 780f;
						Clock.HourTime = Clock.PresentTime / 60f;
						Physics.SyncTransforms();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.B))
					{
						DatingGlobals.SuitorProgress = 2;
						SceneManager.LoadScene("LoadingScene");
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Pause))
					{
						Clock.StopTime = !Clock.StopTime;
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.W))
					{
						StudentManager.ToggleBookBags();
						Window.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.H))
					{
						StudentGlobals.SetFragileTarget(26);
						StudentGlobals.SetStudentFragileSlave(32);
						SceneManager.LoadScene("LoadingScene");
					}
				}
				return;
			}
			if (ControlFreak2.CF2Input.GetKey(KeyCode.BackQuote))
			{
				Timer += Time.deltaTime;
				if (Timer > 1f)
				{
					for (ID = 0; ID < StudentManager.NPCsTotal; ID++)
					{
						if (StudentGlobals.GetStudentDying(ID))
						{
							StudentGlobals.SetStudentDying(ID, false);
						}
					}
					SceneManager.LoadScene("LoadingScene");
				}
			}
			if (ControlFreak2.CF2Input.GetKeyUp(KeyCode.BackQuote))
			{
				Timer = 0f;
			}
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Backslash))
		{
			Censor();
		}
	}

	public void Censor()
	{
		Debug.Log("We're updating the censor.");
		if (!StudentManager.Censor)
		{
			if (Yandere.Schoolwear == 1)
			{
				if (!Yandere.Sans && !Yandere.SithLord && !Yandere.BanchoActive)
				{
					if (!Yandere.FlameDemonic && !Yandere.TornadoHair.activeInHierarchy)
					{
						Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount1", 1f);
						Yandere.MyRenderer.materials[1].SetFloat("_BlendAmount1", 1f);
						Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount", 1f);
						Yandere.MyRenderer.materials[1].SetFloat("_BlendAmount", 1f);
						Yandere.PantyAttacher.newRenderer.enabled = false;
					}
					else
					{
						Yandere.MyRenderer.materials[2].SetTexture("_OverlayTex", PantyCensorTexture);
						Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
						Yandere.MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
						Yandere.MyRenderer.materials[2].SetFloat("_BlendAmount", 1f);
					}
				}
				else
				{
					Yandere.PantyAttacher.newRenderer.enabled = false;
				}
			}
			StudentManager.Censor = true;
			StudentManager.CensorStudents();
		}
		else
		{
			Yandere.MyRenderer.materials[1].SetFloat("_BlendAmount1", 0f);
			Yandere.MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
			Yandere.MyRenderer.materials[2].SetFloat("_BlendAmount", 0f);
			if (Yandere.MyRenderer.sharedMesh != Yandere.NudeMesh)
			{
				Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount1", 1f);
				Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount", 1f);
				Yandere.PantyAttacher.newRenderer.enabled = true;
				EasterEggCheck();
			}
			else
			{
				Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount1", 0f);
				Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
				Yandere.PantyAttacher.newRenderer.enabled = false;
			}
			StudentManager.Censor = false;
			StudentManager.CensorStudents();
		}
	}

	public void EasterEggCheck()
	{
		if (Yandere.BanchoActive)
		{
			Debug.Log("The Bancho easter egg is active, so we're going to disable all shadows and panties.");
			Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
			Yandere.MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
			Yandere.MyRenderer.materials[2].SetFloat("_BlendAmount", 0f);
			Yandere.MyRenderer.materials[0].SetFloat("_BlendAmount1", 0f);
			Yandere.MyRenderer.materials[1].SetFloat("_BlendAmount1", 0f);
			Yandere.MyRenderer.materials[2].SetFloat("_BlendAmount1", 0f);
			Yandere.PantyAttacher.newRenderer.enabled = false;
		}
	}

	public void UpdateCensor()
	{
		Censor();
		Censor();
	}
}
