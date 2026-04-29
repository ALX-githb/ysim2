#pragma warning disable 618 // Unity-deprecated APIs (AIBase.target, AIPath.speed, WWW, GetInstanceID, CF2Input.GetKeyDown(string), Physics2D.OverlapPointNonAlloc) still functional; full migration would change behavior or require coroutine refactors.
using System.Collections;
using UnityEngine;

public class StudentManagerScript : MonoBehaviour
{
	private PortraitChanScript NewPortraitChan;

	private GameObject NewStudent;

	public StudentScript[] Students;

	public SelectiveGrayscale SmartphoneSelectiveGreyscale;

	public PickpocketMinigameScript PickpocketMinigame;

	public SelectiveGrayscale HandSelectiveGreyscale;

	public CleaningManagerScript CleaningManager;

	public StolenPhoneSpotScript StolenPhoneSpot;

	public SelectiveGrayscale SelectiveGreyscale;

	public CombatMinigameScript CombatMinigame;

	public DatingMinigameScript DatingMinigame;

	public TextureManagerScript TextureManager;

	public QualityManagerScript QualityManager;

	public ComputerGamesScript ComputerGames;

	public EmergencyExitScript EmergencyExit;

	public TranqDetectorScript TranqDetector;

	public WitnessCameraScript WitnessCamera;

	public ConvoManagerScript ConvoManager;

	public TallLockerScript CommunalLocker;

	public CabinetDoorScript CabinetDoor;

	public LightSwitchScript LightSwitch;

	public LoveManagerScript LoveManager;

	public TaskManagerScript TaskManager;

	public ReputationScript Reputation;

	public WeaponScript FragileWeapon;

	public ContainerScript Container;

	public RingEventScript RingEvent;

	public HologramScript Holograms;

	public RobotArmScript RobotArms;

	public FountainScript Fountain;

	public PoseModeScript PoseMode;

	public TrashCanScript TrashCan;

	public StudentScript Reporter;

	public GhostScript GhostChan;

	public YandereScript Yandere;

	public ListScript MeetSpots;

	public PoliceScript Police;

	public DoorScript ShedDoor;

	public UILabel ErrorLabel;

	public RestScript Rest;

	public TagScript Tag;

	public DoorScript AltFemaleVomitDoor;

	public DoorScript FemaleVomitDoor;

	public ParticleSystem AltFemaleDrownSplashes;

	public ParticleSystem FemaleDrownSplashes;

	public OfferHelpScript FragileOfferHelp;

	public OfferHelpScript OfferHelp;

	public Transform AltFemaleVomitSpot;

	public Transform FemaleVomitSpot;

	public ListScript SearchPatrols;

	public ListScript CleaningSpots;

	public ListScript Patrols;

	public ClockScript Clock;

	public JsonScript JSON;

	public GateScript Gate;

	public ListScript EntranceVectors;

	public ListScript GoAwaySpots;

	public ListScript HidingSpots;

	public ListScript LunchSpots;

	public ListScript Hangouts;

	public ListScript Lockers;

	public ListScript Podiums;

	public ListScript Clubs;

	public ChangingBoothScript[] ChangingBooths;

	public GradingPaperScript[] FacultyDesks;

	public StudentScript[] WitnessList;

	public StudentScript[] Teachers;

	public GameObject[] Graffiti;

	public ListScript[] Seats;

	public Transform[] TeacherGuardLocation;

	public Transform[] CorpseGuardLocation;

	public Transform[] SleuthDestinations;

	public Transform[] GardeningPatrols;

	public Transform[] LockerPositions;

	public Transform[] SpawnPositions;

	public Transform[] GraffitiSpots;

	public Transform[] PinDownSpots;

	public Transform[] SupplySpots;

	public Transform[] BullySpots;

	public Transform[] ClubZones;

	public Transform[] SulkSpots;

	public Transform[] FleeSpots;

	public bool[] SeatsTaken11;

	public bool[] SeatsTaken12;

	public bool[] SeatsTaken21;

	public bool[] SeatsTaken22;

	public bool[] SeatsTaken31;

	public bool[] SeatsTaken32;

	public bool[] NoBully;

	public Collider RivalDeskCollider;

	public Transform FollowerLookAtTarget;

	public Transform SuitorConfessionSpot;

	public Transform RivalConfessionSpot;

	public Transform ConfessionWaypoint;

	public Transform FragileSlaveSpot;

	public Transform FemaleCoupleSpot;

	public Transform YandereStripSpot;

	public Transform FemaleStalkSpot;

	public Transform ConfessionSpot;

	public Transform CorpseLocation;

	public Transform FemaleWashSpot;

	public Transform MaleCoupleSpot;

	public Transform FastBatheSpot;

	public Transform MaleStalkSpot;

	public Transform MaleVomitSpot;

	public Transform SacrificeSpot;

	public Transform FountainSpot;

	public Transform MaleWashSpot;

	public Transform SenpaiLocker;

	public Transform SuitorLocker;

	public Transform RomanceSpot;

	public Transform BrokenSpot;

	public Transform BullyGroup;

	public Transform EdgeOfGrid;

	public Transform GoAwaySpot;

	public Transform SuitorSpot;

	public Transform ToolTarget;

	public Transform BatheSpot;

	public Transform MournSpot;

	public Transform ShameSpot;

	public Transform SlaveSpot;

	public Transform StripSpot;

	public Transform Papers;

	public Transform Exit;

	public GameObject LovestruckCamera;

	public GameObject GardenBlockade;

	public GameObject PortraitChan;

	public GameObject RandomPatrol;

	public GameObject ChaseCamera;

	public GameObject EmptyObject;

	public GameObject PortraitKun;

	public GameObject StudentChan;

	public GameObject StudentKun;

	public GameObject Flowers;

	public GameObject Portal;

	public float[] SpawnTimes;

	public int LowDetailThreshold;

	public int StudentsSpawned;

	public int StudentsTotal = 13;

	public int TeachersTotal = 6;

	public int NPCsSpawned;

	public int NPCsTotal;

	public int Witnesses;

	public int PinPhase;

	public int Bullies;

	public int Frame;

	public int GymTeacherID = 100;

	public int SleuthPhase = 1;

	public int SuitorID = 13;

	public int VictimID;

	public int NurseID = 93;

	public int RivalID = 7;

	public int SpawnID;

	public int ID;

	public bool MurderTakingPlace;

	public bool TakingPortraits;

	public bool TeachersSpawned;

	public bool DisableFarAnims;

	public bool YandereDying;

	public bool YandereLate;

	public bool FirstUpdate;

	public bool MissionMode;

	public bool PinningDown;

	public bool ForceSpawn;

	public bool NoGravity;

	public bool Randomize;

	public bool NoSpeech;

	public bool Censor;

	public bool Spooky;

	public bool Bully;

	public bool Gaze;

	public bool Pose;

	public bool Sans;

	public bool Stop;

	public bool Egg;

	public bool Six;

	public bool AoT;

	public bool DK;

	public float ChangeTimer;

	public float SleuthTimer;

	public float LowestRep;

	public float PinTimer;

	public float Timer;

	public string[] ColorNames;

	public string[] MaleNames;

	public string[] FirstNames;

	public string[] LastNames;

	public AudioClip YanderePinDown;

	public AudioClip PinDownSFX;

	[SerializeField]
	private int ProblemID = -1;

	public GameObject Cardigan;

	public SkinnedMeshRenderer CardiganRenderer;

	public bool SeatOccupied;

	public int Class = 1;

	private void Start()
	{
		// On mobile platforms, aggressively reduce memory footprint to prevent OOM crashes.
		if (Application.isMobilePlatform)
		{
			QualitySettings.masterTextureLimit = 1;    // Half-res textures (saves ~50% VRAM)
			QualitySettings.antiAliasing = 0;
			QualitySettings.shadows = ShadowQuality.Disable;
			QualitySettings.skinWeights = SkinWeights.TwoBones;
			QualitySettings.lodBias = 0.5f;
			OptionGlobals.ParticleCount = 1;
			OptionGlobals.DisableOutlines = true;
			OptionGlobals.DisableBloom = true;
			OptionGlobals.DisableShadows = true;
			OptionGlobals.DisableFarAnimations = true;
			OptionGlobals.DisablePostAliasing = true;
			OptionGlobals.LowDetailStudents = 5;
			OptionGlobals.DrawDistance = 50;
			OptionGlobals.DrawDistanceLimit = 50;
		}
		for (ID = 76; ID < 81; ID++)
		{
			if (StudentGlobals.GetStudentReputation(ID) > -67)
			{
				StudentGlobals.SetStudentReputation(ID, -67);
			}
		}
		if (ClubGlobals.GetClubClosed(ClubType.Gardening))
		{
			GardenBlockade.SetActive(true);
			Flowers.SetActive(false);
		}
		ID = 0;
		SeatsTaken31[13] = true;
		SeatsTaken21[12] = true;
		SeatsTaken21[14] = true;
		SeatsTaken22[12] = true;
		SeatsTaken22[14] = true;
		SeatsTaken32[1] = true;
		SeatsTaken31[1] = true;
		SeatsTaken22[1] = true;
		SeatsTaken21[1] = true;
		SeatsTaken12[1] = true;
		SeatsTaken32[3] = true;
		SeatsTaken31[3] = true;
		SeatsTaken22[3] = true;
		SeatsTaken21[3] = true;
		SeatsTaken32[2] = true;
		SeatsTaken31[2] = true;
		SeatsTaken22[2] = true;
		SeatsTaken21[2] = true;
		SeatsTaken12[2] = true;
		SeatsTaken32[4] = true;
		SeatsTaken31[4] = true;
		SeatsTaken22[4] = true;
		SeatsTaken21[4] = true;
		SeatsTaken12[4] = true;
		SeatsTaken32[6] = true;
		SeatsTaken31[6] = true;
		SeatsTaken22[6] = true;
		SeatsTaken21[6] = true;
		SeatsTaken12[6] = true;
		SeatsTaken32[11] = true;
		SeatsTaken31[11] = true;
		SeatsTaken22[11] = true;
		SeatsTaken12[11] = true;
		SeatsTaken11[11] = true;
		SeatsTaken31[15] = true;
		SeatsTaken22[15] = true;
		SeatsTaken21[15] = true;
		SeatsTaken12[15] = true;
		SeatsTaken11[15] = true;
		for (ID = 1; ID < JSON.Students.Length; ID++)
		{
			if (!JSON.Students[ID].Success)
			{
				ProblemID = ID;
				break;
			}
		}
		if (ProblemID != -1)
		{
			if (ErrorLabel != null)
			{
				ErrorLabel.text = string.Empty;
				ErrorLabel.enabled = false;
			}
			SetAtmosphere();
			GameGlobals.Paranormal = false;
			if (MissionModeGlobals.MissionMode)
			{
				StudentGlobals.FemaleUniform = 5;
				StudentGlobals.MaleUniform = 5;
			}
			if (StudentGlobals.GetStudentSlave() > 0 && !StudentGlobals.GetStudentDead(StudentGlobals.GetStudentSlave()))
			{
				int studentSlave = StudentGlobals.GetStudentSlave();
				ForceSpawn = true;
				SpawnPositions[studentSlave] = SlaveSpot;
				SpawnID = studentSlave;
				StudentGlobals.SetStudentDead(studentSlave, false);
				SpawnStudent(SpawnID);
				Students[studentSlave].Slave = true;
				SpawnID = 0;
			}
			if (StudentGlobals.GetStudentFragileSlave() > 0 && !StudentGlobals.GetStudentDead(StudentGlobals.GetStudentFragileSlave()))
			{
				int studentFragileSlave = StudentGlobals.GetStudentFragileSlave();
				ForceSpawn = true;
				SpawnPositions[studentFragileSlave] = FragileSlaveSpot;
				SpawnID = studentFragileSlave;
				StudentGlobals.SetStudentDead(studentFragileSlave, false);
				SpawnStudent(SpawnID);
				Students[studentFragileSlave].FragileSlave = true;
				Students[studentFragileSlave].Slave = true;
				SpawnID = 0;
			}
			NPCsTotal = StudentsTotal + TeachersTotal;
			SpawnID = 1;
			if (StudentGlobals.MaleUniform == 0)
			{
				StudentGlobals.MaleUniform = 1;
			}
			for (ID = 1; ID < NPCsTotal + 1; ID++)
			{
				if (!StudentGlobals.GetStudentDead(ID))
				{
					StudentGlobals.SetStudentDying(ID, false);
				}
			}
			if (!TakingPortraits)
			{
				for (ID = 1; ID < Lockers.List.Length; ID++)
				{
					Transform transform = Object.Instantiate(EmptyObject, Lockers.List[ID].position + Lockers.List[ID].forward * 0.5f, Lockers.List[ID].rotation).transform;
					transform.parent = Lockers.transform;
					transform.transform.eulerAngles = new Vector3(transform.transform.eulerAngles.x, transform.transform.eulerAngles.y + 180f, transform.transform.eulerAngles.z);
					LockerPositions[ID] = transform;
				}
				for (ID = 1; ID < HidingSpots.List.Length; ID++)
				{
					if (HidingSpots.List[ID] == null)
					{
						GameObject gameObject = Object.Instantiate(EmptyObject, new Vector3(Random.Range(-17f, 17f), 0f, Random.Range(-17f, 17f)), Quaternion.identity);
						while (gameObject.transform.position.x < 2.5f && gameObject.transform.position.x > -2.5f && gameObject.transform.position.z > -2.5f && gameObject.transform.position.z < 2.5f)
						{
							gameObject.transform.position = new Vector3(Random.Range(-17f, 17f), 0f, Random.Range(-17f, 17f));
						}
						gameObject.transform.parent = HidingSpots.transform;
						HidingSpots.List[ID] = gameObject.transform;
					}
				}
			}
			if (HomeGlobals.LateForSchool)
			{
				HomeGlobals.LateForSchool = false;
				YandereLate = true;
				Clock.PresentTime = 480f;
				Clock.HourTime = 8f;
				SkipTo8();
			}
			if (!TakingPortraits)
			{
				StartCoroutine(SpawnAllStudentsCoroutine());
			}
		}
		else
		{
			string text = string.Empty;
			if (ProblemID > 1)
			{
				text = "The problem may be caused by Student " + ProblemID + ".";
			}
			if (ErrorLabel != null)
			{
				ErrorLabel.text = "The game cannot compile Students.JSON! There is a typo somewhere in the JSON file. The problem might be a missing quotation mark, a missing colon, a missing comma, or something else like that. Please find your typo and fix it, or revert to a backup of the JSON file. " + text;
				ErrorLabel.enabled = true;
			}
		}
	}

	private IEnumerator SpawnAllStudentsCoroutine()
	{
		bool isMobile = Application.isMobilePlatform;
		int batchCount = 0;
		while (SpawnID < NPCsTotal + 1)
		{
			SpawnStudent(SpawnID);
			SpawnID++;
			batchCount++;
			// Yield every 3 students to spread memory/CPU load across frames.
			// This prevents iOS watchdog kills and allows GC to run.
			if (batchCount % 3 == 0)
			{
				yield return null;
				// Every 15 students on mobile, force memory cleanup
				if (isMobile && batchCount % 15 == 0)
				{
					System.GC.Collect();
					yield return Resources.UnloadUnusedAssets();
				}
			}
		}
		if (Graffiti != null && Graffiti.Length > 5)
		{
			Graffiti[1].SetActive(false);
			Graffiti[2].SetActive(false);
			Graffiti[3].SetActive(false);
			Graffiti[4].SetActive(false);
			Graffiti[5].SetActive(false);
		}
		// Final cleanup after all students spawned
		if (isMobile)
		{
			System.GC.Collect();
			yield return Resources.UnloadUnusedAssets();
		}
	}

	public void SetAtmosphere()
	{
		if (GameGlobals.LoveSick)
		{
			SchoolGlobals.SchoolAtmosphereSet = true;
			SchoolGlobals.SchoolAtmosphere = 0f;
		}
		if (!SchoolGlobals.SchoolAtmosphereSet)
		{
			SchoolGlobals.SchoolAtmosphereSet = true;
			SchoolGlobals.SchoolAtmosphere = 1f;
		}
		Camera mainCam = Camera.main;
		if (mainCam == null) return;
		Vignetting[] components = mainCam.GetComponents<Vignetting>();
		float num = 1f - SchoolGlobals.SchoolAtmosphere;
		if (!TakingPortraits)
		{
			if (SmartphoneSelectiveGreyscale != null)
				SmartphoneSelectiveGreyscale.desaturation = num;
			if (SelectiveGreyscale != null)
				SelectiveGreyscale.desaturation = num;
			if (components != null && components.Length > 2)
			{
				components[2].intensity = num * 5f;
				components[2].blur = num;
				components[2].chromaticAberration = num * 5f;
			}
			float num2 = 1f - num;
			RenderSettings.fogColor = new Color(num2, num2, num2, 1f);
			mainCam.backgroundColor = new Color(num2, num2, num2, 1f);
			RenderSettings.fogDensity = num * 0.1f;
		}
	}

	private void Update()
	{
		ControlFreak2.CFCursor.lockState = CursorLockMode.Locked;
		ControlFreak2.CFCursor.visible = false;
		if (!TakingPortraits)
		{
			Frame++;
			if (!FirstUpdate)
			{
				QualityManager.UpdateOutlines();
				FirstUpdate = true;
				AssignTeachers();
			}
			if (Frame == 3)
			{
				LoveManager.CoupleCheck();
				if (Bullies > 0)
				{
					DetermineVictim();
				}
				UpdateStudents();
				if (!OptionGlobals.RimLight)
				{
					QualityManager.RimLight();
				}
			}
		}
		else if (NPCsSpawned < StudentsTotal + TeachersTotal)
		{
			Frame++;
			if (Frame == 1)
			{
				if (NewStudent != null)
				{
					Object.Destroy(NewStudent);
				}
				if (Randomize)
				{
					NewStudent = Object.Instantiate((Random.Range(0, 2) != 0) ? PortraitKun : PortraitChan, Vector3.zero, Quaternion.identity);
				}
				else
				{
					NewStudent = Object.Instantiate((JSON.Students[NPCsSpawned + 1].Gender != 0) ? PortraitKun : PortraitChan, Vector3.zero, Quaternion.identity);
				}
				NewStudent.GetComponent<CosmeticScript>().StudentID = NPCsSpawned + 1;
				NewStudent.GetComponent<CosmeticScript>().StudentManager = this;
				NewStudent.GetComponent<CosmeticScript>().TakingPortrait = true;
				NewStudent.GetComponent<CosmeticScript>().Randomize = Randomize;
				NewStudent.GetComponent<CosmeticScript>().JSON = JSON;
				NewPortraitChan = NewStudent.GetComponent<PortraitChanScript>();
				NewPortraitChan.StudentID = NPCsSpawned + 1;
				NewPortraitChan.StudentManager = this;
				NewPortraitChan.JSON = JSON;
				if (!Randomize)
				{
					NPCsSpawned++;
				}
			}
			if (Frame == 2)
			{
				ScreenCapture.CaptureScreenshot(Application.streamingAssetsPath + "/Portraits/Student_" + NPCsSpawned + ".png");
				Frame = 0;
			}
		}
		else
		{
			ScreenCapture.CaptureScreenshot(Application.streamingAssetsPath + "/Portraits/Student_" + NPCsSpawned + ".png");
			base.gameObject.SetActive(false);
		}
		if (Witnesses > 0)
		{
			for (ID = 1; ID < WitnessList.Length; ID++)
			{
				StudentScript studentScript = WitnessList[ID];
				if (studentScript != null && (!studentScript.Alive || studentScript.Attacked || (studentScript.Fleeing && !studentScript.PinningDown)))
				{
					studentScript.PinDownWitness = false;
					if (ID != WitnessList.Length - 1)
					{
						Shuffle(ID);
					}
					Witnesses--;
				}
			}
			if (PinningDown && Witnesses < 4)
			{
				Debug.Log("Students were going to pin Yandere-chan down, but now there are less than 4 witnesses, so it's not going to happen.");
				Yandere.CanMove = true;
				PinningDown = false;
				PinPhase = 0;
			}
		}
		if (PinningDown)
		{
			if (!Yandere.Attacking && Yandere.CanMove)
			{
				Yandere.CharacterAnimation.CrossFade("f02_pinDownPanic_00");
				Yandere.EmptyHands();
				Yandere.CanMove = false;
			}
			if (PinPhase == 1)
			{
				if (!Yandere.Attacking && !Yandere.Struggling)
				{
					PinTimer += Time.deltaTime;
				}
				if (PinTimer > 1f)
				{
					for (ID = 1; ID < 5; ID++)
					{
						StudentScript studentScript2 = WitnessList[ID];
						if (studentScript2 != null)
						{
							studentScript2.transform.position = new Vector3(studentScript2.transform.position.x, studentScript2.transform.position.y + 0.1f, studentScript2.transform.position.z);
							studentScript2.CurrentDestination = PinDownSpots[ID];
							studentScript2.Pathfinding.target = PinDownSpots[ID];
							studentScript2.SprintAnim = studentScript2.OriginalSprintAnim;
							studentScript2.DistanceToDestination = 100f;
							studentScript2.Pathfinding.speed = 5f;
							studentScript2.MyController.radius = 0f;
							studentScript2.PinningDown = true;
							studentScript2.Alarmed = false;
							studentScript2.Routine = false;
							studentScript2.Fleeing = true;
							studentScript2.AlarmTimer = 0f;
							studentScript2.Safe = true;
							studentScript2.Prompt.Hide();
							studentScript2.Prompt.enabled = false;
							Debug.Log(string.Concat(studentScript2, "'s current destination is ", studentScript2.CurrentDestination));
						}
					}
					PinPhase++;
				}
			}
			else if (WitnessList[1].PinPhase == 0)
			{
				if (WitnessList[1].DistanceToDestination < 1f && WitnessList[2].DistanceToDestination < 1f && WitnessList[3].DistanceToDestination < 1f && WitnessList[4].DistanceToDestination < 1f)
				{
					Clock.StopTime = true;
					if (Yandere.Aiming)
					{
						Yandere.StopAiming();
						Yandere.enabled = false;
					}
					Yandere.Mopping = false;
					Yandere.EmptyHands();
					AudioSource component = GetComponent<AudioSource>();
					component.PlayOneShot(PinDownSFX);
					component.PlayOneShot(YanderePinDown);
					Yandere.CharacterAnimation.CrossFade("f02_pinDown_00");
					Yandere.CanMove = false;
					Yandere.ShoulderCamera.LookDown = true;
					Yandere.RPGCamera.enabled = false;
					StopMoving();
					Yandere.ShoulderCamera.HeartbrokenCamera.GetComponent<Camera>().cullingMask |= 512;
					for (ID = 1; ID < 5; ID++)
					{
						StudentScript studentScript3 = WitnessList[ID];
						if (studentScript3.MyWeapon != null)
						{
							GameObjectUtils.SetLayerRecursively(studentScript3.MyWeapon.gameObject, 13);
						}
						studentScript3.CharacterAnimation.CrossFade((((!studentScript3.Male) ? "f02_pinDown_0" : "pinDown_0") + ID).ToString());
						studentScript3.PinPhase++;
					}
				}
			}
			else
			{
				bool flag = false;
				if (!WitnessList[1].Male)
				{
					if (WitnessList[1].CharacterAnimation["f02_pinDown_01"].time >= WitnessList[1].CharacterAnimation["f02_pinDown_01"].length)
					{
						flag = true;
					}
				}
				else if (WitnessList[1].CharacterAnimation["pinDown_01"].time >= WitnessList[1].CharacterAnimation["pinDown_01"].length)
				{
					flag = true;
				}
				if (flag)
				{
					Yandere.CharacterAnimation.CrossFade("f02_pinDownLoop_00");
					for (ID = 1; ID < 5; ID++)
					{
						StudentScript studentScript4 = WitnessList[ID];
						studentScript4.CharacterAnimation.CrossFade((((!studentScript4.Male) ? "f02_pinDownLoop_0" : "pinDownLoop_0") + ID).ToString());
					}
					PinningDown = false;
				}
			}
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Space))
		{
			DetermineVictim();
		}
	}

	public void SpawnStudent(int spawnID)
	{
		if (Students[spawnID] == null && !StudentGlobals.GetStudentDead(spawnID) && !StudentGlobals.GetStudentKidnapped(spawnID) && !StudentGlobals.GetStudentArrested(spawnID) && !StudentGlobals.GetStudentExpelled(spawnID) && JSON.Students[spawnID].Name != "Unknown" && StudentGlobals.GetStudentReputation(spawnID) > -100)
		{
			int num;
			if (JSON.Students[spawnID].Name == "Random")
			{
				GameObject gameObject = Object.Instantiate(EmptyObject, new Vector3(Random.Range(-17f, 17f), 0f, Random.Range(-17f, 17f)), Quaternion.identity);
				while (gameObject.transform.position.x < 2.5f && gameObject.transform.position.x > -2.5f && gameObject.transform.position.z > -2.5f && gameObject.transform.position.z < 2.5f)
				{
					gameObject.transform.position = new Vector3(Random.Range(-17f, 17f), 0f, Random.Range(-17f, 17f));
				}
				gameObject.transform.parent = HidingSpots.transform;
				HidingSpots.List[spawnID] = gameObject.transform;
				GameObject gameObject2 = Object.Instantiate(RandomPatrol, Vector3.zero, Quaternion.identity);
				gameObject2.transform.parent = Patrols.transform;
				Patrols.List[spawnID] = gameObject2.transform;
				GameObject gameObject3 = Object.Instantiate(RandomPatrol, Vector3.zero, Quaternion.identity);
				gameObject3.transform.parent = CleaningSpots.transform;
				CleaningSpots.List[spawnID] = gameObject3.transform;
				num = ((!MissionModeGlobals.MissionMode || MissionModeGlobals.MissionTarget != spawnID) ? Random.Range(0, 2) : 0);
				FindUnoccupiedSeat();
			}
			else
			{
				num = JSON.Students[spawnID].Gender;
			}
			NewStudent = Object.Instantiate((num != 0) ? StudentKun : StudentChan, SpawnPositions[spawnID].position, Quaternion.identity);
			NewStudent.GetComponent<CosmeticScript>().LoveManager = LoveManager;
			NewStudent.GetComponent<CosmeticScript>().StudentManager = this;
			NewStudent.GetComponent<CosmeticScript>().Randomize = Randomize;
			NewStudent.GetComponent<CosmeticScript>().StudentID = spawnID;
			NewStudent.GetComponent<CosmeticScript>().JSON = JSON;
			if (JSON.Students[spawnID].Name == "Random")
			{
				NewStudent.GetComponent<StudentScript>().CleaningSpot = CleaningSpots.List[spawnID];
				NewStudent.GetComponent<StudentScript>().CleaningRole = 3;
			}
			if (JSON.Students[spawnID].Club == ClubType.Bully)
			{
				Bullies++;
			}
			Students[spawnID] = NewStudent.GetComponent<StudentScript>();
			StudentScript studentScript = Students[spawnID];
			studentScript.Cosmetic.TextureManager = TextureManager;
			studentScript.WitnessCamera = WitnessCamera;
			studentScript.StudentManager = this;
			studentScript.StudentID = spawnID;
			studentScript.JSON = JSON;
			if (AoT)
			{
				studentScript.AoT = true;
			}
			if (DK)
			{
				studentScript.DK = true;
			}
			if (Spooky)
			{
				studentScript.Spooky = true;
			}
			if (Sans)
			{
				studentScript.BadTime = true;
			}
			if (spawnID == RivalID)
			{
				studentScript.Rival = true;
			}
			OccupySeat();
		}
		NPCsSpawned++;
		TaskManager.UpdateTaskStatus();
		ForceSpawn = false;
	}

	public void UpdateStudents()
	{
		for (ID = 2; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				if (studentScript.gameObject.activeInHierarchy)
				{
					if (!studentScript.Safe)
					{
						if (!studentScript.Slave)
						{
							if (studentScript.Pushable)
							{
								studentScript.Prompt.Label[0].text = "     Push";
							}
							else if (!studentScript.Following)
							{
								studentScript.Prompt.Label[0].text = "     Talk";
							}
							else
							{
								studentScript.Prompt.Label[0].text = "     Stop";
							}
							studentScript.Prompt.HideButton[0] = false;
							studentScript.Prompt.HideButton[2] = false;
							studentScript.Prompt.Attack = false;
							if (Yandere.Mask != null)
							{
								studentScript.Prompt.HideButton[0] = true;
							}
							if (Yandere.Dragging || Yandere.PickUp != null || Yandere.Chased)
							{
								studentScript.Prompt.HideButton[0] = true;
								studentScript.Prompt.HideButton[2] = true;
								if (Yandere.PickUp != null && Yandere.PickUp.Food > 0)
								{
									studentScript.Prompt.Label[0].text = "     Feed";
									studentScript.Prompt.HideButton[0] = false;
									studentScript.Prompt.HideButton[2] = true;
								}
							}
							if (Yandere.Armed)
							{
								studentScript.Prompt.HideButton[0] = true;
								studentScript.Prompt.MinimumDistance = 1f;
								studentScript.Prompt.Attack = true;
							}
							else
							{
								studentScript.Prompt.HideButton[2] = true;
								studentScript.Prompt.MinimumDistance = 2f;
								if (studentScript.WitnessedMurder || studentScript.WitnessedCorpse || studentScript.Private)
								{
									studentScript.Prompt.HideButton[0] = true;
								}
							}
							if (Yandere.NearBodies > 0 || Yandere.Sanity < 33.33333f)
							{
								studentScript.Prompt.HideButton[0] = true;
							}
							if (studentScript.Teacher)
							{
								studentScript.Prompt.HideButton[0] = true;
							}
						}
						else if (studentScript.Persona != PersonaType.Fragile)
						{
							if (Yandere.Armed)
							{
								if (Yandere.EquippedWeapon.Concealable)
								{
									studentScript.Prompt.HideButton[0] = false;
									studentScript.Prompt.Label[0].text = "     Give Weapon";
								}
								else
								{
									studentScript.Prompt.HideButton[0] = true;
									studentScript.Prompt.Label[0].text = string.Empty;
								}
							}
							else
							{
								studentScript.Prompt.HideButton[0] = true;
								studentScript.Prompt.Label[0].text = string.Empty;
							}
						}
					}
					if (NoSpeech && !studentScript.Armband.activeInHierarchy)
					{
						studentScript.Prompt.HideButton[0] = true;
					}
				}
				if (studentScript.Prompt.Label[0] != null)
				{
					if (Sans)
					{
						studentScript.Prompt.HideButton[0] = false;
						studentScript.Prompt.Label[0].text = "     Psychokinesis";
					}
					if (Pose)
					{
						studentScript.Prompt.HideButton[0] = false;
						studentScript.Prompt.Label[0].text = "     Pose";
						studentScript.Prompt.BloodMask = 1;
						studentScript.Prompt.BloodMask |= 2;
						studentScript.Prompt.BloodMask |= 512;
						studentScript.Prompt.BloodMask |= 8192;
						studentScript.Prompt.BloodMask |= 16384;
						studentScript.Prompt.BloodMask |= 65536;
						studentScript.Prompt.BloodMask |= 2097152;
						studentScript.Prompt.BloodMask = ~studentScript.Prompt.BloodMask;
					}
					if (!studentScript.Teacher && Six)
					{
						studentScript.Prompt.MinimumDistance = 0.75f;
						studentScript.Prompt.HideButton[0] = false;
						studentScript.Prompt.Label[0].text = "     Eat";
					}
					if (Gaze)
					{
						studentScript.Prompt.MinimumDistance = 5f;
						studentScript.Prompt.HideButton[0] = false;
						studentScript.Prompt.Label[0].text = "     Gaze";
					}
				}
			}
		}
		Container.UpdatePrompts();
		TrashCan.UpdatePrompt();
	}

	public void UpdateMe(int ID)
	{
		if (ID <= 1)
		{
			return;
		}
		StudentScript studentScript = Students[ID];
		if (!studentScript.Safe)
		{
			studentScript.Prompt.Label[0].text = "     Talk";
			studentScript.Prompt.HideButton[0] = false;
			studentScript.Prompt.HideButton[2] = false;
			studentScript.Prompt.Attack = false;
			if (Yandere.Armed)
			{
				studentScript.Prompt.HideButton[0] = true;
				studentScript.Prompt.MinimumDistance = 1f;
				studentScript.Prompt.Attack = true;
			}
			else
			{
				studentScript.Prompt.HideButton[2] = true;
				studentScript.Prompt.MinimumDistance = 2f;
				if (studentScript.WitnessedMurder || studentScript.WitnessedCorpse || studentScript.Private)
				{
					studentScript.Prompt.HideButton[0] = true;
				}
			}
			if (Yandere.Dragging || Yandere.PickUp != null || Yandere.Chased || Yandere.Chasers > 0)
			{
				studentScript.Prompt.HideButton[0] = true;
				studentScript.Prompt.HideButton[2] = true;
			}
			if (Yandere.NearBodies > 0 || Yandere.Sanity < 33.33333f)
			{
				studentScript.Prompt.HideButton[0] = true;
			}
			if (studentScript.Teacher)
			{
				studentScript.Prompt.HideButton[0] = true;
			}
		}
		if (Sans)
		{
			studentScript.Prompt.HideButton[0] = false;
			studentScript.Prompt.Label[0].text = "     Psychokinesis";
		}
		if (Pose)
		{
			studentScript.Prompt.HideButton[0] = false;
			studentScript.Prompt.Label[0].text = "     Pose";
		}
		if (NoSpeech)
		{
			studentScript.Prompt.HideButton[0] = true;
		}
	}

	public void AttendClass()
	{
		Debug.Log("All students are now being told to attend class.");
		ConvoManager.Confirmed = false;
		SleuthPhase = 3;
		if (RingEvent.EventActive)
		{
			RingEvent.ReturnRing();
		}
		while (NPCsSpawned < NPCsTotal)
		{
			SpawnStudent(SpawnID);
			SpawnID++;
		}
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && studentScript.Alive && !studentScript.Slave && !studentScript.Tranquil && !studentScript.Fleeing && studentScript.enabled && studentScript.gameObject.activeInHierarchy)
			{
				if (!studentScript.Started)
				{
					studentScript.Start();
				}
				if (!studentScript.Teacher)
				{
					if (!studentScript.Indoors)
					{
						if (studentScript.ShoeRemoval.Locker == null)
						{
							studentScript.ShoeRemoval.Start();
						}
						studentScript.ShoeRemoval.PutOnShoes();
					}
					studentScript.transform.position = studentScript.Seat.position + Vector3.up * 0.01f;
					studentScript.transform.rotation = studentScript.Seat.rotation;
					studentScript.Character.GetComponent<Animation>().Play(studentScript.SitAnim);
					studentScript.Pathfinding.canSearch = false;
					studentScript.Pathfinding.canMove = false;
					studentScript.OccultBook.SetActive(false);
					studentScript.SmartPhone.SetActive(false);
					studentScript.Pathfinding.speed = 0f;
					studentScript.Distracted = false;
					studentScript.Pushable = false;
					studentScript.Routine = true;
					studentScript.Hurry = false;
					studentScript.Safe = false;
					if (studentScript.Wet)
					{
						studentScript.Schoolwear = 3;
						studentScript.ChangeSchoolwear();
						studentScript.LiquidProjector.enabled = false;
						studentScript.Splashed = false;
						studentScript.Bloody = false;
						studentScript.BathePhase = 1;
						studentScript.Wet = false;
						studentScript.UnWet();
						if (studentScript.Rival && CommunalLocker.RivalPhone.Stolen)
						{
							studentScript.RealizePhoneIsMissing();
						}
					}
					if (studentScript.ClubAttire)
					{
						studentScript.ChangeSchoolwear();
						studentScript.ClubAttire = false;
					}
					if (studentScript.Meeting && Clock.HourTime > studentScript.MeetTime)
					{
						studentScript.Meeting = false;
					}
					if (studentScript.Club == ClubType.Sports)
					{
						studentScript.SetSplashes(false);
						studentScript.WalkAnim = studentScript.OriginalWalkAnim;
						studentScript.Character.transform.localPosition = new Vector3(0f, 0f, 0f);
						SkinnedMeshRenderer gogglesSmr = studentScript.Cosmetic.Goggles[studentScript.StudentID] != null ? studentScript.Cosmetic.Goggles[studentScript.StudentID].GetComponent<SkinnedMeshRenderer>() : null;
						if (gogglesSmr != null && gogglesSmr.sharedMesh != null && gogglesSmr.sharedMesh.blendShapeCount > 0)
							gogglesSmr.SetBlendShapeWeight(0, 0f);
						SkinnedMeshRenderer hairSmr = studentScript.Cosmetic.MaleHair[studentScript.Cosmetic.Hairstyle] != null ? studentScript.Cosmetic.MaleHair[studentScript.Cosmetic.Hairstyle].GetComponent<SkinnedMeshRenderer>() : null;
						if (hairSmr != null && hairSmr.sharedMesh != null && hairSmr.sharedMesh.blendShapeCount > 0)
							hairSmr.SetBlendShapeWeight(0, 0f);
					}
				}
				else if (ID != GymTeacherID && ID != NurseID)
				{
					studentScript.transform.position = Podiums.List[studentScript.Class].position + Vector3.up * 0.01f;
					studentScript.transform.rotation = Podiums.List[studentScript.Class].rotation;
				}
				else
				{
					studentScript.transform.position = studentScript.Seat.position + Vector3.up * 0.01f;
					studentScript.transform.rotation = studentScript.Seat.rotation;
				}
			}
		}
		UpdateStudents();
		Physics.SyncTransforms();
	}

	public void SkipTo8()
	{
		while (NPCsSpawned < NPCsTotal)
		{
			SpawnStudent(SpawnID);
			SpawnID++;
		}
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && studentScript.Alive && !studentScript.Slave && !studentScript.Tranquil)
			{
				if (!studentScript.Started)
				{
					studentScript.Start();
				}
				if (!studentScript.Teacher)
				{
					if (!studentScript.Indoors)
					{
						if (studentScript.ShoeRemoval.Locker == null)
						{
							studentScript.ShoeRemoval.Start();
						}
						studentScript.ShoeRemoval.PutOnShoes();
					}
					studentScript.transform.position = studentScript.Seat.position + Vector3.up * 0.01f;
					studentScript.transform.rotation = studentScript.Seat.rotation;
					studentScript.Pathfinding.canSearch = true;
					studentScript.Pathfinding.canMove = true;
					studentScript.SmartPhone.SetActive(false);
					studentScript.OccultBook.SetActive(false);
					studentScript.Pathfinding.speed = 1f;
					studentScript.Distracted = false;
					studentScript.Spawned = true;
					studentScript.Routine = true;
					studentScript.Safe = false;
					if (studentScript.ClubAttire)
					{
						studentScript.ChangeSchoolwear();
						studentScript.ClubAttire = true;
					}
					studentScript.TeleportToDestination();
					studentScript.TeleportToDestination();
				}
				else
				{
					studentScript.TeleportToDestination();
					studentScript.TeleportToDestination();
				}
			}
		}
	}

	public void ResumeMovement()
	{
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && !studentScript.Fleeing)
			{
				studentScript.Pathfinding.canSearch = true;
				studentScript.Pathfinding.canMove = true;
				studentScript.Pathfinding.speed = 1f;
				studentScript.Routine = true;
			}
		}
	}

	public void StopMoving()
	{
		CombatMinigame.enabled = false;
		Stop = true;
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				if (!studentScript.Dying && !studentScript.PinningDown && !studentScript.Spraying)
				{
					if (YandereDying && studentScript.Club != ClubType.Council)
					{
						studentScript.IdleAnim = studentScript.ScaredAnim;
					}
					if (Yandere.Attacking)
					{
						if (studentScript.MurderReaction == 0)
						{
							studentScript.Character.GetComponent<Animation>().CrossFade(studentScript.ScaredAnim);
						}
					}
					else if (ID > 1)
					{
						studentScript.Character.GetComponent<Animation>().CrossFade(studentScript.IdleAnim);
					}
					studentScript.Pathfinding.canSearch = false;
					studentScript.Pathfinding.canMove = false;
					studentScript.Pathfinding.speed = 0f;
					studentScript.Stop = true;
					if (studentScript.EventManager != null)
					{
						studentScript.EventManager.EndEvent();
					}
				}
				if (studentScript.Alive && studentScript.SawMask)
				{
					Police.MaskReported = true;
				}
				if (studentScript.Slave)
				{
					studentScript.Broken.Subtitle.text = string.Empty;
					studentScript.Broken.Done = true;
					Object.Destroy(studentScript.Broken);
					studentScript.Slave = false;
					studentScript.Suicide = true;
					studentScript.BecomeRagdoll();
					studentScript.DeathType = DeathType.Mystery;
					StudentGlobals.SetStudentSlave(studentScript.StudentID);
				}
			}
		}
	}

	public void StopFleeing()
	{
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && !studentScript.Teacher)
			{
				studentScript.Pathfinding.target = studentScript.Destinations[studentScript.Phase];
				studentScript.Pathfinding.speed = 1f;
				studentScript.WitnessedCorpse = false;
				studentScript.WitnessedMurder = false;
				studentScript.Alarmed = false;
				studentScript.Fleeing = false;
				studentScript.Reacted = false;
				studentScript.Witness = false;
				studentScript.Routine = true;
			}
		}
	}

	public void EnablePrompts()
	{
		for (ID = 2; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.Prompt.enabled = true;
			}
		}
	}

	public void DisablePrompts()
	{
		for (ID = 2; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.Prompt.Hide();
				studentScript.Prompt.enabled = false;
			}
		}
	}

	public void WipePendingRep()
	{
		for (ID = 2; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.PendingRep = 0f;
			}
		}
	}

	public void AttackOnTitan()
	{
		AoT = true;
		for (ID = 2; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && !studentScript.Teacher)
			{
				studentScript.AttackOnTitan();
			}
		}
	}

	public void Kong()
	{
		DK = true;
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.DK = true;
			}
		}
	}

	public void Spook()
	{
		Spooky = true;
		for (ID = 2; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && !studentScript.Male)
			{
				studentScript.Spook();
			}
		}
	}

	public void BadTime()
	{
		Sans = true;
		for (ID = 2; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.Prompt.HideButton[0] = false;
				studentScript.BadTime = true;
			}
		}
	}

	public void UpdateBooths()
	{
		for (ID = 0; ID < ChangingBooths.Length; ID++)
		{
			ChangingBoothScript changingBoothScript = ChangingBooths[ID];
			if (changingBoothScript != null)
			{
				changingBoothScript.CheckYandereClub();
			}
		}
	}

	public void UpdatePerception()
	{
		for (ID = 0; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.UpdatePerception();
			}
		}
	}

	public void StopHesitating()
	{
		for (ID = 0; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				if (studentScript.AlarmTimer > 0f)
				{
					studentScript.AlarmTimer = 1f;
				}
				studentScript.Hesitation = 0f;
			}
		}
	}

	private void Unstop()
	{
		for (ID = 0; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.Stop = false;
			}
		}
	}

	public void LowerCorpsePosition()
	{
		if (CorpseLocation.position.y < 4f)
		{
			CorpseLocation.position = new Vector3(CorpseLocation.position.x, 0f, CorpseLocation.position.z);
		}
		else if (CorpseLocation.position.y < 8f)
		{
			CorpseLocation.position = new Vector3(CorpseLocation.position.x, 4f, CorpseLocation.position.z);
		}
		else if (CorpseLocation.position.y < 12f)
		{
			CorpseLocation.position = new Vector3(CorpseLocation.position.x, 8f, CorpseLocation.position.z);
		}
		else
		{
			CorpseLocation.position = new Vector3(CorpseLocation.position.x, 12f, CorpseLocation.position.z);
		}
	}

	public void CensorStudents()
	{
		for (ID = 0; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && !studentScript.Male && studentScript.Club != ClubType.Teacher && studentScript.Club != ClubType.GymTeacher && studentScript.Club != ClubType.Nurse)
			{
				if (Censor)
				{
					studentScript.Cosmetic.CensorPanties();
				}
				else
				{
					studentScript.Cosmetic.RemoveCensor();
				}
			}
		}
	}

	private void OccupySeat()
	{
		int @class = JSON.Students[SpawnID].Class;
		int seat = JSON.Students[SpawnID].Seat;
		switch (@class)
		{
		case 11:
			SeatsTaken11[seat] = true;
			break;
		case 12:
			SeatsTaken12[seat] = true;
			break;
		case 21:
			SeatsTaken21[seat] = true;
			break;
		case 22:
			SeatsTaken22[seat] = true;
			break;
		case 31:
			SeatsTaken31[seat] = true;
			break;
		case 32:
			SeatsTaken32[seat] = true;
			break;
		}
	}

	private void FindUnoccupiedSeat()
	{
		SeatOccupied = false;
		if (Class == 1)
		{
			JSON.Students[SpawnID].Class = 11;
			ID = 1;
			while (ID < SeatsTaken11.Length && !SeatOccupied)
			{
				if (!SeatsTaken11[ID])
				{
					JSON.Students[SpawnID].Seat = ID;
					SeatsTaken11[ID] = true;
					SeatOccupied = true;
				}
				ID++;
				if (ID > 15)
				{
					Class++;
				}
			}
		}
		else if (Class == 2)
		{
			JSON.Students[SpawnID].Class = 12;
			ID = 1;
			while (ID < SeatsTaken12.Length && !SeatOccupied)
			{
				if (!SeatsTaken12[ID])
				{
					JSON.Students[SpawnID].Seat = ID;
					SeatsTaken12[ID] = true;
					SeatOccupied = true;
				}
				ID++;
				if (ID > 15)
				{
					Class++;
				}
			}
		}
		else if (Class == 3)
		{
			JSON.Students[SpawnID].Class = 21;
			ID = 1;
			while (ID < SeatsTaken21.Length && !SeatOccupied)
			{
				if (!SeatsTaken21[ID])
				{
					JSON.Students[SpawnID].Seat = ID;
					SeatsTaken21[ID] = true;
					SeatOccupied = true;
				}
				ID++;
				if (ID > 15)
				{
					Class++;
				}
			}
		}
		else if (Class == 4)
		{
			JSON.Students[SpawnID].Class = 22;
			ID = 1;
			while (ID < SeatsTaken22.Length && !SeatOccupied)
			{
				if (!SeatsTaken22[ID])
				{
					JSON.Students[SpawnID].Seat = ID;
					SeatsTaken22[ID] = true;
					SeatOccupied = true;
				}
				ID++;
				if (ID > 15)
				{
					Class++;
				}
			}
		}
		else if (Class == 5)
		{
			JSON.Students[SpawnID].Class = 31;
			ID = 1;
			while (ID < SeatsTaken31.Length && !SeatOccupied)
			{
				if (!SeatsTaken31[ID])
				{
					JSON.Students[SpawnID].Seat = ID;
					SeatsTaken31[ID] = true;
					SeatOccupied = true;
				}
				ID++;
				if (ID > 15)
				{
					Class++;
				}
			}
		}
		else if (Class == 6)
		{
			JSON.Students[SpawnID].Class = 32;
			ID = 1;
			while (ID < SeatsTaken32.Length && !SeatOccupied)
			{
				if (!SeatsTaken32[ID])
				{
					JSON.Students[SpawnID].Seat = ID;
					SeatsTaken32[ID] = true;
					SeatOccupied = true;
				}
				ID++;
				if (ID > 15)
				{
					Class++;
				}
			}
		}
		if (!SeatOccupied)
		{
			FindUnoccupiedSeat();
		}
	}

	public void PinDownCheck()
	{
		if (PinningDown || Witnesses <= 3)
		{
			return;
		}
		for (ID = 1; ID < WitnessList.Length; ID++)
		{
			StudentScript studentScript = WitnessList[ID];
			if (studentScript != null && (!studentScript.Alive || studentScript.Attacked || studentScript.Fleeing))
			{
				if (ID != WitnessList.Length - 1)
				{
					Shuffle(ID);
				}
				Witnesses--;
			}
		}
		if (Witnesses > 3)
		{
			PinningDown = true;
			PinPhase = 1;
		}
	}

	private void Shuffle(int Start)
	{
		for (int i = Start; i < WitnessList.Length - 1; i++)
		{
			WitnessList[i] = WitnessList[i + 1];
		}
	}

	public void ChangeOka()
	{
		StudentScript studentScript = Students[26];
		if (studentScript != null)
		{
			studentScript.AttachRiggedAccessory();
		}
	}

	public void RemovePapersFromDesks()
	{
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && studentScript.MyPaper != null)
			{
				studentScript.MyPaper.SetActive(false);
			}
		}
	}

	public void SetStudentsActive(bool active)
	{
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.gameObject.SetActive(active);
			}
		}
	}

	public void AssignTeachers()
	{
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.MyTeacher = Teachers[JSON.Students[studentScript.StudentID].Class];
			}
		}
	}

	public void ToggleBookBags()
	{
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null)
			{
				studentScript.BookBag.SetActive(!studentScript.BookBag.activeInHierarchy);
			}
		}
	}

	public void DetermineVictim()
	{
		Bully = false;
		for (ID = 2; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && !studentScript.Teacher && !studentScript.Slave && studentScript.Club != ClubType.Bully && studentScript.Club != ClubType.Council && studentScript.Club != ClubType.Delinquent && (float)StudentGlobals.GetStudentReputation(ID) < LowestRep)
			{
				LowestRep = StudentGlobals.GetStudentReputation(ID);
				VictimID = ID;
				Bully = true;
			}
		}
		if (Bully)
		{
			Debug.Log("A student has been chosen to be bullied. It's Student #" + VictimID + ".");
			if (Students[VictimID].Seat.position.x > 0f)
			{
				BullyGroup.position = Students[VictimID].Seat.position + new Vector3(0.33333f, 0f, 0f);
			}
			else
			{
				BullyGroup.position = Students[VictimID].Seat.position - new Vector3(0.33333f, 0f, 0f);
				BullyGroup.eulerAngles = new Vector3(0f, 90f, 0f);
			}
			StudentScript obj = Students[VictimID];
			ScheduleBlock obj2 = obj.ScheduleBlocks[2];
			obj2.destination = "ShameSpot";
			obj2.action = "Shamed";
			ScheduleBlock obj3 = obj.ScheduleBlocks[4];
			obj3.destination = "Seat";
			obj3.action = "Sit";
			obj.IdleAnim = obj.BulliedIdleAnim;
			obj.WalkAnim = obj.BulliedWalkAnim;
			obj.Bullied = true;
			obj.GetDestinations();
			obj.CameraAnims = obj.CowardAnims;
			obj.BusyAtLunch = true;
			obj.Shy = false;
		}
	}

	public void SecurityCameras()
	{
		Egg = true;
		for (ID = 1; ID < Students.Length; ID++)
		{
			StudentScript studentScript = Students[ID];
			if (studentScript != null && studentScript.SecurityCamera != null && (bool)studentScript.Ragdoll != base.enabled)
			{
				studentScript.SecurityCamera.SetActive(true);
			}
		}
	}

	public void DisableStudent(int DisableID)
	{
		StudentScript studentScript = Students[DisableID];
		if (!(studentScript != null))
		{
			return;
		}
		if (studentScript.gameObject.activeInHierarchy)
		{
			studentScript.gameObject.SetActive(false);
			return;
		}
		studentScript.gameObject.SetActive(true);
		if (studentScript.Club == ClubType.Council)
		{
			string text = string.Empty;
			if (studentScript.StudentID == 86)
			{
				text = "Strict";
			}
			else if (studentScript.StudentID == 87)
			{
				text = "Casual";
			}
			else if (studentScript.StudentID == 88)
			{
				text = "Grace";
			}
			else if (studentScript.StudentID == 89)
			{
				text = "Edgy";
			}
			studentScript.CharacterAnimation["f02_faceCouncil" + text + "_00"].layer = 10;
			studentScript.CharacterAnimation.Play("f02_faceCouncil" + text + "_00");
		}
	}

	public void UpdateGrafitti()
	{
		for (ID = 1; ID < 6; ID++)
		{
			if (!NoBully[ID])
			{
				Graffiti[ID].SetActive(true);
			}
		}
	}

	public void UpdateSleuths()
	{
		SleuthPhase++;
		for (ID = 56; ID < 61; ID++)
		{
			if (Students[ID] != null)
			{
				if (SleuthPhase < 3)
				{
					Students[ID].SleuthTarget = SleuthDestinations[ID - 55];
					Students[ID].Pathfinding.target = Students[ID].SleuthTarget;
					Students[ID].CurrentDestination = Students[ID].SleuthTarget;
				}
				else if (SleuthPhase == 3)
				{
					Students[ID].GetSleuthTarget();
				}
				else if (SleuthPhase == 4)
				{
					Students[ID].SleuthTarget = Clubs.List[ID];
					Students[ID].Pathfinding.target = Students[ID].SleuthTarget;
					Students[ID].CurrentDestination = Students[ID].SleuthTarget;
				}
				Students[ID].SmartPhone.SetActive(true);
				Students[ID].SpeechLines.Stop();
			}
		}
	}
}
