#pragma warning disable CS0618
using System.Collections;
using HighlightingSystem;
using Pathfinding;
using UnityEngine;

public class YandereScript : MonoBehaviour
{
	public Quaternion targetRotation;

	private Vector3 targetDirection;

	private GameObject NewTrail;

	private int AccessoryID;

	private int ID;

	public FootprintSpawnerScript RightFootprintSpawner;

	public FootprintSpawnerScript LeftFootprintSpawner;

	public ColorCorrectionCurves YandereColorCorrection;

	public ColorCorrectionCurves ColorCorrection;

	public SelectiveGrayscale SelectGrayscale;

	public HighlightingRenderer HighlightingR;

	public HighlightingBlitter HighlightingB;

	public AmbientObscurance Obscurance;

	public DepthOfField34 DepthOfField;

	public Vignetting Vignette;

	public Blur Blur;

	public NotificationManagerScript NotificationManager;

	public ObstacleDetectorScript ObstacleDetector;

	public RiggedAccessoryAttacher PantyAttacher;

	public AccessoryGroupScript AccessoryGroup;

	public DumpsterHandleScript DumpsterHandle;

	public PhonePromptBarScript PhonePromptBar;

	public ShoulderCameraScript ShoulderCamera;

	public StudentManagerScript StudentManager;

	public AttackManagerScript AttackManager;

	public CameraEffectsScript CameraEffects;

	public WeaponManagerScript WeaponManager;

	public SplashCameraScript SplashCamera;

	public SWP_HeartRateMonitor HeartRate;

	public LoveManagerScript LoveManager;

	public StruggleBarScript StruggleBar;

	public RummageSpotScript RummageSpot;

	public IncineratorScript Incinerator;

	public InputDeviceScript InputDevice;

	public MusicCreditScript MusicCredit;

	public PauseScreenScript PauseScreen;

	public WoodChipperScript WoodChipper;

	public RagdollScript CurrentRagdoll;

	public StudentScript TargetStudent;

	public WeaponMenuScript WeaponMenu;

	public PromptScript NearestPrompt;

	public ContainerScript Container;

	public InventoryScript Inventory;

	public TallLockerScript MyLocker;

	public PromptBarScript PromptBar;

	public TranqCaseScript TranqCase;

	public LocationScript Location;

	public SubtitleScript Subtitle;

	public UIPanel DetectionPanel;

	public StudentScript Follower;

	public JukeboxScript Jukebox;

	public OutlineScript Outline;

	public StudentScript Pursuer;

	public ShutterScript Shutter;

	public UISprite ProgressBar;

	public RPG_Camera RPGCamera;

	public BucketScript Bucket;

	public PickUpScript PickUp;

	public PoliceScript Police;

	public GloveScript Gloves;

	public UILabel PowerUp;

	public MaskScript Mask;

	public MopScript Mop;

	public UIPanel HUD;

	public CharacterController MyController;

	public Transform LeftItemParent;

	public Transform DismemberSpot;

	public Transform CameraTarget;

	public Transform RightArmRoll;

	public Transform LeftArmRoll;

	public Transform CameraFocus;

	public Transform RightBreast;

	public Transform HidingSpot;

	public Transform LeftBreast;

	public Transform ItemParent;

	public Transform PelvisRoot;

	public Transform PoisonSpot;

	public Transform CameraPOV;

	public Transform RightHand;

	public Transform RightKnee;

	public Transform RightFoot;

	public Transform ExitSpot;

	public Transform LeftHand;

	public Transform Backpack;

	public Transform DropSpot;

	public Transform Homeroom;

	public Transform DigSpot;

	public Transform Senpai;

	public Transform Stool;

	public Transform Eyes;

	public Transform Head;

	public Transform Hips;

	public AudioSource HeartBeat;

	public GameObject[] Accessories;

	public GameObject[] Hairstyles;

	public GameObject[] Poisons;

	public GameObject[] Shoes;

	public float[] DropTimer;

	public GameObject CinematicCamera;

	public GameObject FloatingShovel;

	public GameObject EasterEggMenu;

	public GameObject MemeGlasses;

	public GameObject GiggleDisc;

	public GameObject HandCamera;

	public GameObject KONGlasses;

	public GameObject Microphone;

	public GameObject AlarmDisc;

	public GameObject Character;

	public GameObject DebugMenu;

	public GameObject EyepatchL;

	public GameObject EyepatchR;

	public GameObject ShoePair;

	public GameObject Barcode;

	public GameObject Headset;

	public GameObject Ragdoll;

	public GameObject Hearts;

	public GameObject Phone;

	public GameObject Trail;

	public GameObject Match;

	public GameObject Arc;

	public SkinnedMeshRenderer MyRenderer;

	public Animation CharacterAnimation;

	public SpringJoint RagdollDragger;

	public SpringJoint RagdollPK;

	public Projector MyProjector;

	public Camera HeartCamera;

	public Camera MainCamera;

	public Camera Smartphone;

	public Renderer SmartphoneRenderer;

	public Renderer LongHairRenderer;

	public Renderer PonytailRenderer;

	public Renderer PigtailR;

	public Renderer PigtailL;

	public Renderer Drills;

	public float CinematicTimer;

	public float CanMoveTimer;

	public float RummageTimer;

	public float YandereTimer;

	public float AttackTimer;

	public float CaughtTimer;

	public float SenpaiTimer;

	public float CrawlTimer;

	public float GloveTimer;

	public float LaughTimer;

	public float SprayTimer;

	public float TheftTimer;

	public float BoneTimer;

	public float DumpTimer;

	public float ExitTimer;

	public float TalkTimer;

	[SerializeField]
	private float bloodiness;

	public float PreviousSanity = 100f;

	[SerializeField]
	private float sanity;

	public float TwitchTimer;

	public float NextTwitch;

	public float LaughIntensity;

	public float TimeSkipHeight;

	public float PourDistance;

	public float TargetHeight;

	public float BreastSize;

	public float Numbness;

	public float PourTime;

	public float RunSpeed;

	public float Height;

	public float Slouch;

	public float Bend;

	public float CrouchWalkSpeed;

	public float CrouchRunSpeed;

	public float ShoveSpeed = 2f;

	public float CrawlSpeed;

	public float FlapSpeed;

	public float WalkSpeed;

	public float YandereFade;

	public float YandereTint;

	public float SenpaiFade;

	public float SenpaiTint;

	public float GreyTarget;

	public int PreviousSchoolwear;

	public int NearestCorpseID;

	public int StrugglePhase;

	public int CarryAnimID;

	public int AttackPhase;

	public int Creepiness = 1;

	public int NearBodies;

	public int PoisonType;

	public int Schoolwear;

	public int SprayPhase;

	public int DragState;

	public int EyewearID;

	public int Followers;

	public int Hairstyle;

	public int DigPhase;

	public int Equipped;

	public int Chasers;

	public int Costume;

	public int Alerts;

	public int Health = 5;

	public YandereInteractionType Interaction;

	public YanderePersonaType Persona;

	public bool EavesdropWarning;

	public bool BloodyWarning;

	public bool CorpseWarning;

	public bool SanityWarning;

	public bool WeaponWarning;

	public bool DelinquentFighting;

	public bool DumpsterGrabbing;

	public bool BucketDropping;

	public bool TranquilHiding;

	public bool Eavesdropping;

	public bool Pickpocketing;

	public bool Dismembering;

	public bool TimeSkipping;

	public bool Cauterizing;

	public bool HeavyWeight;

	public bool Trespassing;

	public bool Struggling;

	public bool Attacking;

	public bool Degloving;

	public bool Poisoning;

	public bool Rummaging;

	public bool Stripping;

	public bool Blasting;

	public bool Carrying;

	public bool Chipping;

	public bool Dragging;

	public bool Dropping;

	public bool Flicking;

	public bool Laughing;

	public bool Punching;

	public bool Throwing;

	public bool Tripping;

	public bool Bathing;

	public bool Burying;

	public bool Cooking;

	public bool Digging;

	public bool Dipping;

	public bool Dumping;

	public bool Exiting;

	public bool Lifting;

	public bool Mopping;

	public bool Pouring;

	public bool Resting;

	public bool Talking;

	public bool Testing;

	public bool Aiming;

	public bool Caught;

	public bool Eating;

	public bool Hiding;

	public Stance Stance = new Stance(StanceType.Standing);

	public bool CrouchButtonDown;

	public bool UsingController;

	public bool CameFromCrouch;

	public bool CannotRecover;

	public bool PossessPoison;

	public bool YandereVision;

	public bool ClubActivity;

	public bool FlameDemonic;

	public bool PossessTranq;

	public bool SanityBased;

	public bool SummonBones;

	public bool ClubAttire;

	public bool FollowHips;

	public bool NearSenpai;

	public bool RivalPhone;

	public bool Possessed;

	public bool Attacked;

	public bool CanTranq;

	public bool Collapse;

	public bool RoofPush;

	public bool Demonic;

	public bool FlapOut;

	public bool NoDebug;

	public bool Noticed;

	public bool InClass;

	public bool Slender;

	public bool Sprayed;

	public bool CanMove = true;

	public bool Chased;

	public bool Gloved;

	public bool Shoved;

	public bool Drown;

	public bool Xtan;

	public bool Lewd;

	public bool Lost;

	public bool Sans;

	public bool Egg;

	public bool Won;

	public bool DK;

	public bool PK;

	public Texture[] UniformTextures;

	public Texture[] CasualTextures;

	public Texture[] BloodTextures;

	public WeaponScript[] Weapon;

	public GameObject[] ZipTie;

	public string[] ArmedAnims;

	public string[] CarryAnims;

	public Transform[] Spine;

	public AudioClip[] Stabs;

	public Transform[] Foot;

	public Transform[] Hand;

	public Transform[] Arm;

	public Transform[] Leg;

	public Mesh[] Uniforms;

	public Renderer RightYandereEye;

	public Renderer LeftYandereEye;

	public Vector3 RightEyeOrigin;

	public Vector3 LeftEyeOrigin;

	public Renderer RightRedEye;

	public Renderer LeftRedEye;

	public Transform RightEye;

	public Transform LeftEye;

	public float EyeShrink;

	public Vector3 Twitch;

	private AudioClip LaughClip;

	public string PourHeight = string.Empty;

	public string DrownAnim = string.Empty;

	public string LaughAnim = string.Empty;

	public string HideAnim = string.Empty;

	public string IdleAnim = string.Empty;

	public string WalkAnim = string.Empty;

	public string RunAnim = string.Empty;

	public string CrouchIdleAnim = string.Empty;

	public string CrouchWalkAnim = string.Empty;

	public string CrouchRunAnim = string.Empty;

	public string CrawlIdleAnim = string.Empty;

	public string CrawlWalkAnim = string.Empty;

	public string HeavyIdleAnim = string.Empty;

	public string HeavyWalkAnim = string.Empty;

	public string CarryIdleAnim = string.Empty;

	public string CarryWalkAnim = string.Empty;

	public string CarryRunAnim = string.Empty;

	public string[] CreepyIdles;

	public string[] CreepyWalks;

	public AudioClip ChargeUp;

	public AudioClip Laugh1;

	public AudioClip Laugh2;

	public AudioClip Laugh3;

	public AudioClip Laugh4;

	public AudioClip Thud;

	public AudioClip Dig;

	public Vector3 PreviousPosition;

	public string OriginalIdleAnim = string.Empty;

	public string OriginalWalkAnim = string.Empty;

	public string OriginalRunAnim = string.Empty;

	public Texture YanderePhoneTexture;

	public Texture RivalPhoneTexture;

	public float v;

	public float h;

	public GameObject CreepyArms;

	public Texture[] GloveTextures;

	public Texture TitanTexture;

	public Texture KONTexture;

	public GameObject PunishedAccessories;

	public GameObject PunishedScarf;

	public GameObject[] PunishedArm;

	public Texture[] PunishedTextures;

	public Shader PunishedShader;

	public Mesh PunishedMesh;

	public Material HatefulSkybox;

	public Texture HatefulUniform;

	public GameObject SukebanAccessories;

	public Texture SukebanBandages;

	public Texture SukebanUniform;

	public FalconPunchScript BanchoFinisher;

	public StandPunchScript BanchoFlurry;

	public GameObject BanchoPants;

	public Mesh BanchoMesh;

	public Texture BanchoBody;

	public Texture BanchoFace;

	public GameObject[] BanchoAccessories;

	public bool BanchoActive;

	public bool Finisher;

	public AudioClip BanchoYanYan;

	public AudioClip BanchoFinalYan;

	public AmplifyMotionObject MotionObject;

	public AmplifyMotionEffect MotionBlur;

	public GameObject BanchoCamera;

	public GameObject[] SlenderHair;

	public Texture SlenderUniform;

	public Material SlenderSkybox;

	public Texture SlenderSkin;

	public Transform[] LongHair;

	public GameObject BlackEyePatch;

	public GameObject XSclera;

	public GameObject XEye;

	public Texture XBody;

	public Texture XFace;

	public GameObject[] GaloAccessories;

	public Texture GaloArms;

	public Texture GaloFace;

	public AudioClip SummonStand;

	public StandScript Stand;

	public AudioClip YanYan;

	public Texture AgentFace;

	public Texture AgentSuit;

	public GameObject CirnoIceAttack;

	public AudioClip CirnoIceClip;

	public GameObject CirnoWings;

	public GameObject CirnoHair;

	public Texture CirnoUniform;

	public Texture CirnoFace;

	public Transform[] CirnoWing;

	public float CirnoRotation;

	public float CirnoTimer;

	public AudioClip FalconPunchVoice;

	public Texture FalconBody;

	public Texture FalconFace;

	public float FalconSpeed;

	public GameObject NewFalconPunch;

	public GameObject FalconWindUp;

	public GameObject FalconPunch;

	public GameObject FalconShoulderpad;

	public GameObject FalconNipple1;

	public GameObject FalconNipple2;

	public GameObject FalconBuckle;

	public GameObject FalconHelmet;

	public GameObject FalconGun;

	public AudioClip[] OnePunchVoices;

	public GameObject NewOnePunch;

	public GameObject OnePunch;

	public Texture SaitamaSuit;

	public GameObject Cape;

	public ParticleSystem GlowEffect;

	public GameObject[] BlasterSet;

	public GameObject[] SansEyes;

	public AudioClip BlasterClip;

	public Texture SansTexture;

	public Texture SansFace;

	public GameObject Bone;

	public AudioClip Slam;

	public Mesh Jersey;

	public int BlasterStage;

	public PKDirType PKDir;

	public Texture CyborgBody;

	public Texture CyborgFace;

	public GameObject[] CyborgParts;

	public GameObject EnergySword;

	public GameObject EbolaEffect;

	public GameObject EbolaWings;

	public GameObject EbolaHair;

	public Texture EbolaFace;

	public Texture EbolaUniform;

	public Mesh LongUniform;

	public Texture NewFace;

	public Mesh NewMesh;

	public GameObject[] CensorSteam;

	public Texture NudePanties;

	public Texture NudeTexture;

	public Mesh NudeMesh;

	public Texture SamusBody;

	public Texture SamusFace;

	public Texture WitchBody;

	public Texture WitchFace;

	public Collider BladeHairCollider1;

	public Collider BladeHairCollider2;

	public GameObject BladeHair;

	public DebugMenuScript TheDebugMenuScript;

	public GameObject RiggedAccessory;

	public GameObject TornadoAttack;

	public GameObject TornadoDress;

	public GameObject TornadoHair;

	public Renderer TornadoRenderer;

	public Mesh NoTorsoMesh;

	public GameObject KunHair;

	public GameObject Kun;

	public GameObject Kizuna;

	public AudioClip HaiDomo;

	public GameObject BlackRobe;

	public Mesh NoUpperBodyMesh;

	public ParticleSystem[] Beam;

	public SithBeamScript[] SithBeam;

	public bool SithRecovering;

	public bool SithAttacking;

	public bool SithLord;

	public string SithPrefix;

	public int SithComboLength;

	public int SithAttacks;

	public int SithSounds;

	public int SithCombo;

	public GameObject SithHardHitbox;

	public GameObject SithHitbox;

	public GameObject SithTrail1;

	public GameObject SithTrail2;

	public Transform SithTrailEnd1;

	public Transform SithTrailEnd2;

	public ZoomScript Zoom;

	public AudioClip SithOn;

	public AudioClip SithOff;

	public AudioClip SithSwing;

	public AudioClip SithStrike;

	public AudioSource SithAudio;

	public float[] SithHardSpawnTime1;

	public float[] SithHardSpawnTime2;

	public float[] SithSpawnTime;

	public Texture SnakeFace;

	public Texture SnakeBody;

	public Texture Stone;

	public AudioClip Petrify;

	public GameObject Pebbles;

	public bool Medusa;

	public Texture GazerFace;

	public Texture GazerBody;

	public GazerEyesScript GazerEyes;

	public AudioClip FingerSnap;

	public AudioClip Zap;

	public bool GazeAttacking;

	public bool Snapping;

	public bool Gazing;

	public int SnapPhase;

	public GameObject SixRaincoat;

	public GameObject RisingSmoke;

	public GameObject DarkHelix;

	public Texture SixFaceTexture;

	public AudioClip SixTakedown;

	public Transform SixTarget;

	public Mesh SixBodyMesh;

	public Transform Mouth;

	public int EatPhase;

	public bool Hungry;

	public int Hunger;

	public float[] BloodTimes;

	public AudioClip[] Snarls;

	public Texture KLKBody;

	public Texture KLKFace;

	public GameObject[] KLKParts;

	public GameObject KLKSword;

	public Mesh SchoolSwimsuit;

	public Mesh GymUniform;

	public Texture FaceTexture;

	public Texture SwimsuitTexture;

	public Texture GymTexture;

	public Texture TextureToUse;

	public bool Casual = true;

	public Mesh JudoGiMesh;

	public Texture JudoGiTexture;

	public Mesh ApronMesh;

	public Texture ApronTexture;

	public Mesh LabCoatMesh;

	public Mesh HeadAndHands;

	public Texture LabCoatTexture;

	public RiggedAccessoryAttacher LabcoatAttacher;

	public bool Paint;

	public GameObject[] ClubAccessories;

	public GameObject Fireball;

	public bool LiftOff;

	public GameObject LiftOffParticles;

	public float LiftOffSpeed;

	public SkinnedMeshUpdater SkinUpdater;

	public Mesh RivalChanMesh;

	public Mesh TestMesh;

	public bool BullyPhoto;

	public float Sanity
	{
		get
		{
			return sanity;
		}
		set
		{
			sanity = Mathf.Clamp(value, 0f, 100f);
			if (sanity > 66.66666f)
			{
				HeartRate.SetHeartRateColour(HeartRate.NormalColour);
				SanityWarning = false;
			}
			else if (sanity > 33.33333f)
			{
				HeartRate.SetHeartRateColour(HeartRate.MediumColour);
				SanityWarning = false;
				if (PreviousSanity < 33.33333f)
				{
					StudentManager.UpdateStudents();
				}
			}
			else
			{
				HeartRate.SetHeartRateColour(HeartRate.BadColour);
				if (!SanityWarning)
				{
					NotificationManager.DisplayNotification(NotificationType.Insane);
					SanityWarning = true;
				}
			}
			HeartRate.BeatsPerMinute = (int)(240f - sanity * 1.8f);
			if (MyRenderer.sharedMesh != NudeMesh)
			{
				if (!Slender)
				{
					MyRenderer.materials[2].SetFloat("_BlendAmount", 1f - sanity / 100f);
				}
				else
				{
					MyRenderer.materials[2].SetFloat("_BlendAmount", 0f);
				}
			}
			else
			{
				MyRenderer.materials[2].SetFloat("_BlendAmount", 0f);
			}
			PreviousSanity = sanity;
			SkinnedMeshRenderer hairSmr = Hairstyles[2] != null ? Hairstyles[2].GetComponent<SkinnedMeshRenderer>() : null;
		if (hairSmr != null && hairSmr.sharedMesh != null && hairSmr.sharedMesh.blendShapeCount > 0)
			hairSmr.SetBlendShapeWeight(0, Sanity);
		}
	}

	public float Bloodiness
	{
		get
		{
			return bloodiness;
		}
		set
		{
			bloodiness = Mathf.Clamp(value, 0f, 100f);
			if (!BloodyWarning && Bloodiness > 0f)
			{
				NotificationManager.DisplayNotification(NotificationType.Bloody);
				BloodyWarning = true;
				if (Schoolwear > 0)
				{
					Police.BloodyClothing++;
				}
			}
			MyProjector.enabled = true;
			if (Bloodiness == 100f)
			{
				MyProjector.material.mainTexture = BloodTextures[5];
			}
			else if (Bloodiness >= 80f)
			{
				MyProjector.material.mainTexture = BloodTextures[4];
			}
			else if (Bloodiness >= 60f)
			{
				MyProjector.material.mainTexture = BloodTextures[3];
			}
			else if (Bloodiness >= 40f)
			{
				MyProjector.material.mainTexture = BloodTextures[2];
			}
			else if (Bloodiness >= 20f)
			{
				MyProjector.material.mainTexture = BloodTextures[1];
			}
			else
			{
				MyProjector.enabled = false;
				BloodyWarning = false;
			}
			StudentManager.UpdateBooths();
			MyLocker.UpdateButtons();
			Outline.h.ReinitMaterials();
		}
	}

	public WeaponScript EquippedWeapon
	{
		get
		{
			return Weapon[Equipped];
		}
		set
		{
			Weapon[Equipped] = value;
		}
	}

	public bool Armed
	{
		get
		{
			return EquippedWeapon != null;
		}
	}

	public SanityType SanityType
	{
		get
		{
			if (Sanity / 100f > 2f / 3f)
			{
				return SanityType.High;
			}
			if (Sanity / 100f > 1f / 3f)
			{
				return SanityType.Medium;
			}
			return SanityType.Low;
		}
	}

	public Vector3 HeadPosition
	{
		get
		{
			return new Vector3(base.transform.position.x, Hips.position.y + 0.2f, base.transform.position.z);
		}
	}

	private void Start()
	{
		MyRenderer.materials[2].SetFloat("_BlendAmount1", 0f);
		CharacterAnimation = Character.GetComponent<Animation>();
		GreyTarget = 1f - SchoolGlobals.SchoolAtmosphere;
		SetAnimationLayers();
		UpdateNumbness();
		RightEyeOrigin = RightEye.localPosition;
		LeftEyeOrigin = LeftEye.localPosition;
		CharacterAnimation["f02_yanderePose_00"].weight = 0f;
		CharacterAnimation["f02_cameraPose_00"].weight = 0f;
		CharacterAnimation["f02_gazerSnap_00"].speed = 2f;
		Camera mainCam = Camera.main;
		if (mainCam != null)
		{
			ColorCorrectionCurves[] components = mainCam.GetComponents<ColorCorrectionCurves>();
			if (components != null && components.Length > 1)
				YandereColorCorrection = components[1];
			Vignetting[] components2 = mainCam.GetComponents<Vignetting>();
			if (components2 != null && components2.Length > 1)
				Vignette = components2[1];
		}
		ResetYandereEffects();
		ResetSenpaiEffects();
		Sanity = 100f;
		Bloodiness = 0f;
		SetUniform();
		EasterEggMenu.transform.localPosition = new Vector3(EasterEggMenu.transform.localPosition.x, 0f, EasterEggMenu.transform.localPosition.z);
		ProgressBar.transform.parent.gameObject.SetActive(false);
		Smartphone.transform.parent.gameObject.SetActive(false);
		ObstacleDetector.gameObject.SetActive(false);
		SithBeam[1].gameObject.SetActive(false);
		SithBeam[2].gameObject.SetActive(false);
		PunishedAccessories.SetActive(false);
		SukebanAccessories.SetActive(false);
		FalconShoulderpad.SetActive(false);
		CensorSteam[0].SetActive(false);
		CensorSteam[1].SetActive(false);
		CensorSteam[2].SetActive(false);
		CensorSteam[3].SetActive(false);
		FloatingShovel.SetActive(false);
		BlackEyePatch.SetActive(false);
		EasterEggMenu.SetActive(false);
		FalconNipple1.SetActive(false);
		FalconNipple2.SetActive(false);
		PunishedScarf.SetActive(false);
		FalconBuckle.SetActive(false);
		FalconHelmet.SetActive(false);
		TornadoDress.SetActive(false);
		Stand.Stand.SetActive(false);
		TornadoHair.SetActive(false);
		MemeGlasses.SetActive(false);
		CirnoWings.SetActive(false);
		KONGlasses.SetActive(false);
		EbolaWings.SetActive(false);
		Microphone.SetActive(false);
		Poisons[1].SetActive(false);
		Poisons[2].SetActive(false);
		Poisons[3].SetActive(false);
		BladeHair.SetActive(false);
		CirnoHair.SetActive(false);
		EbolaHair.SetActive(false);
		FalconGun.SetActive(false);
		EyepatchL.SetActive(false);
		EyepatchR.SetActive(false);
		ZipTie[0].SetActive(false);
		ZipTie[1].SetActive(false);
		Shoes[0].SetActive(false);
		Shoes[1].SetActive(false);
		Phone.SetActive(false);
		Cape.SetActive(false);
		OriginalIdleAnim = IdleAnim;
		OriginalWalkAnim = WalkAnim;
		OriginalRunAnim = RunAnim;
		for (ID = 1; ID < Accessories.Length; ID++)
		{
			Accessories[ID].SetActive(false);
		}
		GameObject[] punishedArm = PunishedArm;
		foreach (GameObject gameObject in punishedArm)
		{
			gameObject.SetActive(false);
		}
		GameObject[] galoAccessories = GaloAccessories;
		foreach (GameObject gameObject2 in galoAccessories)
		{
			gameObject2.SetActive(false);
		}
		for (ID = 1; ID < CyborgParts.Length; ID++)
		{
			CyborgParts[ID].SetActive(false);
		}
		for (ID = 0; ID < KLKParts.Length; ID++)
		{
			KLKParts[ID].SetActive(false);
		}
		for (ID = 0; ID < BanchoAccessories.Length; ID++)
		{
			BanchoAccessories[ID].SetActive(false);
		}
		if (PlayerGlobals.PantiesEquipped == 5)
		{
			RunSpeed += 1f;
		}
		if (PlayerGlobals.Headset)
		{
			Inventory.Headset = true;
		}
		UpdateHair();
		ClubAccessory();
		if (MissionModeGlobals.MissionMode || GameGlobals.LoveSick)
		{
			NoDebug = true;
		}
	}

	public string GetSanityString(SanityType sanityType)
	{
		switch (sanityType)
		{
		case SanityType.High:
			return "High";
		case SanityType.Medium:
			return "Med";
		default:
			return "Low";
		}
	}

	public void SetAnimationLayers()
	{
		CharacterAnimation["f02_yanderePose_00"].layer = 1;
		CharacterAnimation.Play("f02_yanderePose_00");
		CharacterAnimation["f02_yanderePose_00"].weight = 0f;
		CharacterAnimation["f02_shy_00"].layer = 2;
		CharacterAnimation.Play("f02_shy_00");
		CharacterAnimation["f02_shy_00"].weight = 0f;
		CharacterAnimation["f02_singleSaw_00"].layer = 3;
		CharacterAnimation.Play("f02_singleSaw_00");
		CharacterAnimation["f02_singleSaw_00"].weight = 0f;
		CharacterAnimation["f02_fist_00"].layer = 4;
		CharacterAnimation.Play("f02_fist_00");
		CharacterAnimation["f02_fist_00"].weight = 0f;
		CharacterAnimation["f02_mopping_00"].layer = 5;
		CharacterAnimation["f02_mopping_00"].speed = 2f;
		CharacterAnimation.Play("f02_mopping_00");
		CharacterAnimation["f02_mopping_00"].weight = 0f;
		CharacterAnimation["f02_carry_00"].layer = 6;
		CharacterAnimation.Play("f02_carry_00");
		CharacterAnimation["f02_carry_00"].weight = 0f;
		CharacterAnimation["f02_mopCarry_00"].layer = 7;
		CharacterAnimation.Play("f02_mopCarry_00");
		CharacterAnimation["f02_mopCarry_00"].weight = 0f;
		CharacterAnimation["f02_bucketCarry_00"].layer = 8;
		CharacterAnimation.Play("f02_bucketCarry_00");
		CharacterAnimation["f02_bucketCarry_00"].weight = 0f;
		CharacterAnimation["f02_cameraPose_00"].layer = 9;
		CharacterAnimation.Play("f02_cameraPose_00");
		CharacterAnimation["f02_cameraPose_00"].weight = 0f;
		CharacterAnimation["f02_grip_00"].layer = 10;
		CharacterAnimation.Play("f02_grip_00");
		CharacterAnimation["f02_grip_00"].weight = 0f;
		CharacterAnimation["f02_holdHead_00"].layer = 11;
		CharacterAnimation.Play("f02_holdHead_00");
		CharacterAnimation["f02_holdHead_00"].weight = 0f;
		CharacterAnimation["f02_holdTorso_00"].layer = 12;
		CharacterAnimation.Play("f02_holdTorso_00");
		CharacterAnimation["f02_holdTorso_00"].weight = 0f;
		CharacterAnimation["f02_carryCan_00"].layer = 13;
		CharacterAnimation.Play("f02_carryCan_00");
		CharacterAnimation["f02_carryCan_00"].weight = 0f;
		CharacterAnimation["f02_leftGrip_00"].layer = 14;
		CharacterAnimation.Play("f02_leftGrip_00");
		CharacterAnimation["f02_leftGrip_00"].weight = 0f;
		CharacterAnimation["f02_carryShoulder_00"].layer = 15;
		CharacterAnimation.Play("f02_carryShoulder_00");
		CharacterAnimation["f02_carryShoulder_00"].weight = 0f;
		CharacterAnimation[CreepyIdles[1]].layer = 16;
		CharacterAnimation.Play(CreepyIdles[1]);
		CharacterAnimation[CreepyIdles[1]].weight = 0f;
		CharacterAnimation[CreepyIdles[2]].layer = 17;
		CharacterAnimation.Play(CreepyIdles[2]);
		CharacterAnimation[CreepyIdles[2]].weight = 0f;
		CharacterAnimation[CreepyIdles[3]].layer = 18;
		CharacterAnimation.Play(CreepyIdles[3]);
		CharacterAnimation[CreepyIdles[3]].weight = 0f;
		CharacterAnimation[CreepyIdles[4]].layer = 19;
		CharacterAnimation.Play(CreepyIdles[4]);
		CharacterAnimation[CreepyIdles[4]].weight = 0f;
		CharacterAnimation[CreepyIdles[5]].layer = 20;
		CharacterAnimation.Play(CreepyIdles[5]);
		CharacterAnimation[CreepyIdles[5]].weight = 0f;
		CharacterAnimation[CreepyWalks[1]].layer = 21;
		CharacterAnimation.Play(CreepyWalks[1]);
		CharacterAnimation[CreepyWalks[1]].weight = 0f;
		CharacterAnimation[CreepyWalks[2]].layer = 22;
		CharacterAnimation.Play(CreepyWalks[2]);
		CharacterAnimation[CreepyWalks[2]].weight = 0f;
		CharacterAnimation[CreepyWalks[3]].layer = 23;
		CharacterAnimation.Play(CreepyWalks[3]);
		CharacterAnimation[CreepyWalks[3]].weight = 0f;
		CharacterAnimation[CreepyWalks[4]].layer = 24;
		CharacterAnimation.Play(CreepyWalks[4]);
		CharacterAnimation[CreepyWalks[4]].weight = 0f;
		CharacterAnimation[CreepyWalks[5]].layer = 25;
		CharacterAnimation.Play(CreepyWalks[5]);
		CharacterAnimation[CreepyWalks[5]].weight = 0f;
		CharacterAnimation["f02_carryDramatic_00"].layer = 26;
		CharacterAnimation.Play("f02_carryDramatic_00");
		CharacterAnimation["f02_carryDramatic_00"].weight = 0f;
		CharacterAnimation["f02_dipping_00"].speed = 2f;
		CharacterAnimation["f02_stripping_00"].speed = 1.5f;
		CharacterAnimation["f02_falconIdle_00"].speed = 2f;
		CharacterAnimation["f02_carryIdleA_00"].speed = 1.75f;
		CharacterAnimation["CyborgNinja_Run_Armed"].speed = 2f;
		CharacterAnimation["CyborgNinja_Run_Unarmed"].speed = 2f;
	}

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.LeftAlt))
		{
			CinematicCamera.SetActive(false);
		}
		AudioSource component = GetComponent<AudioSource>();
		if (!PauseScreen.Show)
		{
			UpdateMovement();
			UpdatePoisoning();
			if (!Laughing)
			{
				component.volume -= Time.deltaTime * 2f;
			}
			if (!Mopping)
			{
				CharacterAnimation["f02_mopping_00"].weight = Mathf.Lerp(CharacterAnimation["f02_mopping_00"].weight, 0f, Time.deltaTime * 10f);
			}
			else
			{
				CharacterAnimation["f02_mopping_00"].weight = Mathf.Lerp(CharacterAnimation["f02_mopping_00"].weight, 1f, Time.deltaTime * 10f);
				if (ControlFreak2.CF2Input.GetButtonUp("A") || ControlFreak2.CF2Input.GetKeyDown(KeyCode.Escape))
				{
					Mopping = false;
				}
			}
			if (LaughIntensity < 10f)
			{
				for (ID = 0; ID < CarryAnims.Length; ID++)
				{
					string text = CarryAnims[ID];
					if (PickUp != null && CarryAnimID == ID && !Mopping && !Dipping && !Pouring && !BucketDropping && !Digging && !Burying)
					{
						CharacterAnimation[text].weight = Mathf.Lerp(CharacterAnimation[text].weight, 1f, Time.deltaTime * 10f);
					}
					else
					{
						CharacterAnimation[text].weight = Mathf.Lerp(CharacterAnimation[text].weight, 0f, Time.deltaTime * 10f);
					}
				}
			}
			else if (Armed)
			{
				CharacterAnimation["f02_mopCarry_00"].weight = Mathf.Lerp(CharacterAnimation["f02_mopCarry_00"].weight, 1f, Time.deltaTime * 10f);
			}
			if (Noticed && !Attacking)
			{
				if (!Collapse)
				{
					CharacterAnimation.CrossFade("f02_scaredIdle_00");
					targetRotation = Quaternion.LookRotation(Senpai.position - base.transform.position);
					base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
					base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, base.transform.localEulerAngles.z);
				}
				else if (CharacterAnimation["f02_down_22"].time >= CharacterAnimation["f02_down_22"].length)
				{
					CharacterAnimation.CrossFade("f02_down_23");
				}
			}
			UpdateEffects();
			UpdateTalking();
			UpdateAttacking();
			UpdateSlouch();
			if (!Noticed)
			{
				RightYandereEye.material.color = new Color(RightYandereEye.material.color.r, RightYandereEye.material.color.g, RightYandereEye.material.color.b, 1f - Sanity / 100f);
				LeftYandereEye.material.color = new Color(LeftYandereEye.material.color.r, LeftYandereEye.material.color.g, LeftYandereEye.material.color.b, 1f - Sanity / 100f);
				EyeShrink = Mathf.Lerp(EyeShrink, 0.5f * (1f - Sanity / 100f), Time.deltaTime * 10f);
			}
			UpdateTwitch();
			UpdateWarnings();
			UpdateDebugFunctionality();
			if (base.transform.position.y < 0f)
			{
				base.transform.position = new Vector3(base.transform.position.x, 0f, base.transform.position.z);
			}
			if (base.transform.position.z < -99.5f)
			{
				base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, -99.5f);
			}
			base.transform.eulerAngles = new Vector3(0f, base.transform.eulerAngles.y, 0f);
		}
		else
		{
			component.volume -= 1f / 3f;
		}
	}

	private void GoToPKDir(PKDirType pkDir, string sansAnim, Vector3 ragdollLocalPos)
	{
		CharacterAnimation.CrossFade(sansAnim);
		RagdollPK.transform.localPosition = ragdollLocalPos;
		if (PKDir != pkDir)
		{
			AudioSource.PlayClipAtPoint(Slam, base.transform.position + Vector3.up);
		}
		PKDir = pkDir;
	}

	private void UpdateMovement()
	{
		AudioSource component = GetComponent<AudioSource>();
		if (CanMove)
		{
			MyController.Move(Physics.gravity * Time.deltaTime);
			v = ControlFreak2.CF2Input.GetAxis("Vertical");
			h = ControlFreak2.CF2Input.GetAxis("Horizontal");
			FlapSpeed = Mathf.Abs(v) + Mathf.Abs(h);
			if (!Aiming)
			{
				Vector3 vector = MainCamera.transform.TransformDirection(Vector3.forward);
				vector.y = 0f;
				vector = vector.normalized;
				Vector3 vector2 = new Vector3(vector.z, 0f, 0f - vector.x);
				targetDirection = h * vector2 + v * vector;
				if (targetDirection != Vector3.zero)
				{
					targetRotation = Quaternion.LookRotation(targetDirection);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
				}
				else
				{
					targetRotation = new Quaternion(0f, 0f, 0f, 0f);
				}
				if (v != 0f || h != 0f)
				{
					if (ControlFreak2.CF2Input.GetButton("LB") && Vector3.Distance(base.transform.position, Senpai.position) > 1f)
					{
						if (Stance.Current == StanceType.Crouching)
						{
							CharacterAnimation.CrossFade(CrouchRunAnim);
							MyController.Move(base.transform.forward * (CrouchRunSpeed + (float)(ClassGlobals.PhysicalGrade + PlayerGlobals.SpeedBonus) * 0.25f) * Time.deltaTime);
						}
						else if (!Dragging && !Mopping)
						{
							CharacterAnimation.CrossFade(RunAnim);
							MyController.Move(base.transform.forward * (RunSpeed + (float)(ClassGlobals.PhysicalGrade + PlayerGlobals.SpeedBonus) * 0.25f) * Time.deltaTime);
						}
						else if (Mopping)
						{
							CharacterAnimation.CrossFade(WalkAnim);
							MyController.Move(base.transform.forward * (WalkSpeed * Time.deltaTime));
						}
						if (Stance.Current == StanceType.Crouching)
						{
						}
						if (Stance.Current == StanceType.Crawling)
						{
							Stance.Current = StanceType.Crouching;
							Crouch();
						}
					}
					else if (!Dragging)
					{
						if (Stance.Current == StanceType.Crawling)
						{
							CharacterAnimation.CrossFade(CrawlWalkAnim);
							MyController.Move(base.transform.forward * (CrawlSpeed * Time.deltaTime));
						}
						else if (Stance.Current == StanceType.Crouching)
						{
							CharacterAnimation[CrouchWalkAnim].speed = 1f;
							CharacterAnimation.CrossFade(CrouchWalkAnim);
							MyController.Move(base.transform.forward * (CrouchWalkSpeed * Time.deltaTime));
						}
						else
						{
							CharacterAnimation.CrossFade(WalkAnim);
							if (NearSenpai)
							{
								for (int i = 1; i < 6; i++)
								{
									if (i != Creepiness)
									{
										CharacterAnimation[CreepyIdles[i]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyIdles[i]].weight, 0f, Time.deltaTime);
										CharacterAnimation[CreepyWalks[i]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyWalks[i]].weight, 0f, Time.deltaTime);
									}
								}
								CharacterAnimation[CreepyIdles[Creepiness]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyIdles[Creepiness]].weight, 0f, Time.deltaTime);
								CharacterAnimation[CreepyWalks[Creepiness]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyWalks[Creepiness]].weight, 1f, Time.deltaTime);
							}
							MyController.Move(base.transform.forward * (WalkSpeed * Time.deltaTime));
						}
					}
					else
					{
						CharacterAnimation.CrossFade("f02_dragWalk_01");
						MyController.Move(base.transform.forward * (WalkSpeed * Time.deltaTime));
					}
				}
				else if (!Dragging)
				{
					if (Stance.Current == StanceType.Crawling)
					{
						CharacterAnimation.CrossFade(CrawlIdleAnim);
					}
					else if (Stance.Current == StanceType.Crouching)
					{
						CharacterAnimation.CrossFade(CrouchIdleAnim);
					}
					else
					{
						CharacterAnimation.CrossFade(IdleAnim);
						if (NearSenpai)
						{
							for (int j = 1; j < 6; j++)
							{
								if (j != Creepiness)
								{
									CharacterAnimation[CreepyIdles[j]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyIdles[j]].weight, 0f, Time.deltaTime);
									CharacterAnimation[CreepyWalks[j]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyWalks[j]].weight, 0f, Time.deltaTime);
								}
							}
							CharacterAnimation[CreepyIdles[Creepiness]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyIdles[Creepiness]].weight, 1f, Time.deltaTime);
							CharacterAnimation[CreepyWalks[Creepiness]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyWalks[Creepiness]].weight, 0f, Time.deltaTime);
						}
					}
				}
				else
				{
					CharacterAnimation.CrossFade("f02_dragIdle_02");
				}
			}
			else
			{
				if (v != 0f || h != 0f)
				{
					if (Stance.Current == StanceType.Crawling)
					{
						CharacterAnimation.CrossFade(CrawlWalkAnim);
						MyController.Move(base.transform.forward * (CrawlSpeed * Time.deltaTime * v));
						MyController.Move(base.transform.right * (CrawlSpeed * Time.deltaTime * h));
					}
					else if (Stance.Current == StanceType.Crouching)
					{
						CharacterAnimation.CrossFade(CrouchWalkAnim);
						MyController.Move(base.transform.forward * (CrouchWalkSpeed * Time.deltaTime * v));
						MyController.Move(base.transform.right * (CrouchWalkSpeed * Time.deltaTime * h));
					}
					else
					{
						CharacterAnimation.CrossFade(WalkAnim);
						MyController.Move(base.transform.forward * (WalkSpeed * Time.deltaTime * v));
						MyController.Move(base.transform.right * (WalkSpeed * Time.deltaTime * h));
					}
				}
				else if (Stance.Current == StanceType.Crawling)
				{
					CharacterAnimation.CrossFade(CrawlIdleAnim);
				}
				else if (Stance.Current == StanceType.Crouching)
				{
					CharacterAnimation.CrossFade(CrouchIdleAnim);
				}
				else
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				Bend += ControlFreak2.CF2Input.GetAxis("Mouse Y") * 8f;
				if (Stance.Current == StanceType.Crawling)
				{
					if (Bend < 0f)
					{
						Bend = 0f;
					}
				}
				else if (Stance.Current == StanceType.Crouching)
				{
					if (Bend < -45f)
					{
						Bend = -45f;
					}
				}
				else if (Bend < -85f)
				{
					Bend = -85f;
				}
				if (Bend > 85f)
				{
					Bend = 85f;
				}
				base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y + ControlFreak2.CF2Input.GetAxis("Mouse X") * 8f, base.transform.localEulerAngles.z);
			}
			if (!NearSenpai)
			{
				if (!ControlFreak2.CF2Input.GetButton("A") && !ControlFreak2.CF2Input.GetButton("B") && !ControlFreak2.CF2Input.GetButton("X") && !ControlFreak2.CF2Input.GetButton("Y") && StudentManager.Clock.Timer > 1f && (ControlFreak2.CF2Input.GetAxis("LT") > 0.5f || ControlFreak2.CF2Input.GetMouseButton(1)))
				{
					if (Inventory.RivalPhone && ControlFreak2.CF2Input.GetButtonDown("LB"))
					{
						CharacterAnimation["f02_cameraPose_00"].weight = 0f;
						if (!RivalPhone)
						{
							SmartphoneRenderer.material.mainTexture = RivalPhoneTexture;
							RivalPhone = true;
						}
						else
						{
							SmartphoneRenderer.material.mainTexture = YanderePhoneTexture;
							RivalPhone = false;
						}
					}
					if (ControlFreak2.CF2Input.GetAxis("LT") > 0.5f)
					{
						UsingController = true;
					}
					if (!Aiming)
					{
						if (CameraEffects.OneCamera)
						{
							MainCamera.clearFlags = CameraClearFlags.Color;
							MainCamera.farClipPlane = 0.02f;
							HandCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.Color;
						}
						else
						{
							MainCamera.clearFlags = CameraClearFlags.Skybox;
							MainCamera.farClipPlane = OptionGlobals.DrawDistance;
							HandCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.Depth;
						}
						base.transform.eulerAngles = new Vector3(base.transform.eulerAngles.x, MainCamera.transform.eulerAngles.y, base.transform.eulerAngles.z);
						CharacterAnimation.Play(IdleAnim);
						Smartphone.transform.parent.gameObject.SetActive(true);
						DisableHairAndAccessories();
						ShoulderCamera.AimingCamera = true;
						Obscurance.enabled = false;
						HandCamera.SetActive(true);
						YandereVision = false;
						Blur.enabled = true;
						Mopping = false;
						Aiming = true;
						EmptyHands();
						if (Inventory.RivalPhone)
						{
							PhonePromptBar.Panel.enabled = true;
							PhonePromptBar.Show = true;
						}
						Time.timeScale = 1f;
					}
				}
				if (!Aiming && !Accessories[9].activeInHierarchy && !Accessories[16].activeInHierarchy)
				{
					if (ControlFreak2.CF2Input.GetButton("RB"))
					{
						if (BlackRobe.activeInHierarchy)
						{
							if (ControlFreak2.CF2Input.GetButtonDown("RB"))
							{
								AudioSource.PlayClipAtPoint(SithOn, base.transform.position);
							}
							SithTrailEnd1.localPosition = new Vector3(-1f, 0f, 0f);
							SithTrailEnd2.localPosition = new Vector3(1f, 0f, 0f);
							Beam[0].Play();
							Beam[1].Play();
							Beam[2].Play();
							Beam[3].Play();
							if (ControlFreak2.CF2Input.GetButtonDown("X"))
							{
								CharacterAnimation.Play("f02_sithAttack_00");
								SithBeam[1].Damage = 10f;
								SithBeam[2].Damage = 10f;
								SithAttacking = true;
								CanMove = false;
								SithPrefix = string.Empty;
							}
							if (ControlFreak2.CF2Input.GetButtonDown("Y"))
							{
								CharacterAnimation.Play("f02_sithAttackHard_00");
								SithBeam[1].Damage = 20f;
								SithBeam[2].Damage = 20f;
								SithAttacking = true;
								CanMove = false;
								SithPrefix = "Hard";
							}
						}
						YandereTimer += Time.deltaTime;
						if (YandereTimer > 0.5f)
						{
							if (!Sans && !BlackRobe.activeInHierarchy)
							{
								YandereVision = true;
							}
							else if (Sans)
							{
								SansEyes[0].SetActive(true);
								SansEyes[1].SetActive(true);
								GlowEffect.Play();
								SummonBones = true;
								YandereTimer = 0f;
								CanMove = false;
							}
						}
					}
					else
					{
						if (BlackRobe.activeInHierarchy)
						{
							SithTrailEnd1.localPosition = new Vector3(0f, 0f, 0f);
							SithTrailEnd2.localPosition = new Vector3(0f, 0f, 0f);
							if (ControlFreak2.CF2Input.GetButtonUp("RB"))
							{
								AudioSource.PlayClipAtPoint(SithOff, base.transform.position);
							}
							Beam[0].Stop();
							Beam[1].Stop();
							Beam[2].Stop();
							Beam[3].Stop();
						}
						if (YandereVision)
						{
							Obscurance.enabled = false;
							YandereVision = false;
						}
					}
					if (ControlFreak2.CF2Input.GetButtonUp("RB"))
					{
						if (Stance.Current != StanceType.Crouching && Stance.Current != StanceType.Crawling && YandereTimer < 0.5f && !Dragging && !Carrying && !Laughing)
						{
							if (Sans)
							{
								BlasterStage++;
								if (BlasterStage > 5)
								{
									BlasterStage = 1;
								}
								GameObject gameObject = Object.Instantiate(BlasterSet[BlasterStage], base.transform.position, Quaternion.identity);
								gameObject.transform.position = base.transform.position;
								gameObject.transform.rotation = base.transform.rotation;
								AudioSource.PlayClipAtPoint(BlasterClip, base.transform.position + Vector3.up);
								CharacterAnimation["f02_sansBlaster_00"].time = 0f;
								CharacterAnimation.Play("f02_sansBlaster_00");
								SansEyes[0].SetActive(true);
								SansEyes[1].SetActive(true);
								GlowEffect.Play();
								Blasting = true;
								CanMove = false;
							}
							else if (!BlackRobe.activeInHierarchy)
							{
								if (Gazing)
								{
									CharacterAnimation["f02_gazerSnap_00"].time = 0f;
									CharacterAnimation.CrossFade("f02_gazerSnap_00");
									Snapping = true;
									CanMove = false;
								}
								else if (!FalconHelmet.activeInHierarchy && Barcode.activeInHierarchy)
								{
									if (!Xtan)
									{
										if (!CirnoHair.activeInHierarchy && !TornadoHair.activeInHierarchy && !BladeHair.activeInHierarchy)
										{
											LaughAnim = "f02_laugh_01";
											LaughClip = Laugh1;
											LaughIntensity += 1f;
											component.clip = LaughClip;
											component.time = 0f;
											component.Play();
										}
										Object.Instantiate(GiggleDisc, base.transform.position + Vector3.up, Quaternion.identity);
										component.volume = 1f;
										LaughTimer = 0.5f;
										Laughing = true;
										CanMove = false;
									}
									else if (LongHair[0].gameObject.activeInHierarchy)
									{
										LongHair[0].gameObject.SetActive(false);
										BlackEyePatch.SetActive(false);
										SlenderHair[0].transform.parent.gameObject.SetActive(true);
										SlenderHair[0].SetActive(true);
										SlenderHair[1].SetActive(true);
									}
									else
									{
										LongHair[0].gameObject.SetActive(true);
										BlackEyePatch.SetActive(true);
										SlenderHair[0].transform.parent.gameObject.SetActive(true);
										SlenderHair[0].SetActive(false);
										SlenderHair[1].SetActive(false);
									}
								}
								else if (!Punching)
								{
									if (FalconHelmet.activeInHierarchy)
									{
										GameObject gameObject2 = Object.Instantiate(FalconWindUp);
										gameObject2.transform.parent = ItemParent;
										gameObject2.transform.localPosition = Vector3.zero;
										AudioClipPlayer.PlayAttached(FalconPunchVoice, MainCamera.transform, 5f, 10f);
										CharacterAnimation["f02_falconPunch_00"].time = 0f;
										CharacterAnimation.Play("f02_falconPunch_00");
										FalconSpeed = 0f;
									}
									else
									{
										GameObject gameObject3 = Object.Instantiate(FalconWindUp);
										gameObject3.transform.parent = ItemParent;
										gameObject3.transform.localPosition = Vector3.zero;
										AudioSource.PlayClipAtPoint(OnePunchVoices[Random.Range(0, OnePunchVoices.Length)], base.transform.position + Vector3.up);
										CharacterAnimation["f02_onePunch_00"].time = 0f;
										CharacterAnimation.CrossFade("f02_onePunch_00", 0.15f);
									}
									Punching = true;
									CanMove = false;
								}
							}
						}
						YandereTimer = 0f;
					}
				}
				if (!ControlFreak2.CF2Input.GetButton("LB"))
				{
					if (Stance.Current != StanceType.Crouching && Stance.Current != StanceType.Crawling)
					{
						if (ControlFreak2.CF2Input.GetButtonDown("RS"))
						{
							Obscurance.enabled = false;
							CrouchButtonDown = true;
							YandereVision = false;
							Stance.Current = StanceType.Crouching;
							Crouch();
							EmptyHands();
						}
					}
					else
					{
						if (Stance.Current == StanceType.Crouching)
						{
							if (ControlFreak2.CF2Input.GetButton("RS") && !CameFromCrouch)
							{
								CrawlTimer += Time.deltaTime;
							}
							if (CrawlTimer > 0.5f)
							{
								EmptyHands();
								Obscurance.enabled = false;
								YandereVision = false;
								Stance.Current = StanceType.Crawling;
								CrawlTimer = 0f;
								Crawl();
							}
							else if (ControlFreak2.CF2Input.GetButtonUp("RS") && !CrouchButtonDown && !CameFromCrouch)
							{
								Stance.Current = StanceType.Standing;
								CrawlTimer = 0f;
								Uncrouch();
							}
						}
						else if (ControlFreak2.CF2Input.GetButtonDown("RS"))
						{
							CameFromCrouch = true;
							Stance.Current = StanceType.Crouching;
							Crouch();
						}
						if (ControlFreak2.CF2Input.GetButtonUp("RS"))
						{
							CrouchButtonDown = false;
							CameFromCrouch = false;
							CrawlTimer = 0f;
						}
					}
				}
			}
			if (Aiming)
			{
				CharacterAnimation["f02_cameraPose_00"].weight = Mathf.Lerp(CharacterAnimation["f02_cameraPose_00"].weight, 1f, Time.deltaTime * 10f);
				if (ClubAccessories[7].activeInHierarchy && (ControlFreak2.CF2Input.GetAxis("DpadY") != 0f || ControlFreak2.CF2Input.GetAxis("Mouse ScrollWheel") != 0f || ControlFreak2.CF2Input.GetKey(KeyCode.Tab) || ControlFreak2.CF2Input.GetKey(KeyCode.LeftShift)))
				{
					if (ControlFreak2.CF2Input.GetKey(KeyCode.Tab))
					{
						Smartphone.fieldOfView -= Time.deltaTime * 100f;
					}
					if (ControlFreak2.CF2Input.GetKey(KeyCode.LeftShift))
					{
						Smartphone.fieldOfView += Time.deltaTime * 100f;
					}
					Smartphone.fieldOfView -= ControlFreak2.CF2Input.GetAxis("DpadY");
					Smartphone.fieldOfView -= ControlFreak2.CF2Input.GetAxis("Mouse ScrollWheel") * 10f;
					if (Smartphone.fieldOfView > 60f)
					{
						Smartphone.fieldOfView = 60f;
					}
					if (Smartphone.fieldOfView < 30f)
					{
						Smartphone.fieldOfView = 30f;
					}
				}
				if (ControlFreak2.CF2Input.GetAxis("RT") != 0f || ControlFreak2.CF2Input.GetMouseButtonDown(0) || ControlFreak2.CF2Input.GetButtonDown("RB"))
				{
					FixCamera();
					PauseScreen.CorrectingTime = false;
					Time.timeScale = 0.0001f;
					CanMove = false;
					Shutter.Snap();
				}
				if (Time.timeScale > 0.0001f && ((UsingController && ControlFreak2.CF2Input.GetAxis("LT") < 0.5f) || (!UsingController && !ControlFreak2.CF2Input.GetMouseButton(1))))
				{
					StopAiming();
				}
				if (ControlFreak2.CF2Input.GetKey(KeyCode.LeftAlt))
				{
					if (!CinematicCamera.activeInHierarchy)
					{
						if (CinematicTimer > 0f)
						{
							CinematicCamera.transform.eulerAngles = Smartphone.transform.eulerAngles;
							CinematicCamera.transform.position = Smartphone.transform.position;
							CinematicCamera.SetActive(true);
							CinematicTimer = 0f;
							StopAiming();
						}
						CinematicTimer += 1f;
					}
				}
				else
				{
					CinematicTimer = 0f;
				}
			}
			if (Gloved)
			{
				if (!Chased && Chasers == 0)
				{
					if (InputDevice.Type == InputDeviceType.Gamepad)
					{
						if (ControlFreak2.CF2Input.GetAxis("DpadY") < -0.5f)
						{
							GloveTimer += Time.deltaTime;
							if (GloveTimer > 0.5f)
							{
								CharacterAnimation.CrossFade("f02_removeGloves_00");
								Degloving = true;
								CanMove = false;
							}
						}
						else
						{
							GloveTimer = 0f;
						}
					}
					else if (ControlFreak2.CF2Input.GetKey(KeyCode.Alpha1))
					{
						GloveTimer += Time.deltaTime;
						if (GloveTimer > 0.1f)
						{
							CharacterAnimation.CrossFade("f02_removeGloves_00");
							Degloving = true;
							CanMove = false;
						}
					}
					else
					{
						GloveTimer = 0f;
					}
				}
				else
				{
					GloveTimer = 0f;
				}
			}
			if (Weapon[1] != null && DropTimer[2] == 0f)
			{
				if (InputDevice.Type == InputDeviceType.Gamepad)
				{
					if (ControlFreak2.CF2Input.GetAxis("DpadX") < -0.5f)
					{
						DropWeapon(1);
					}
					else
					{
						DropTimer[1] = 0f;
					}
				}
				else if (ControlFreak2.CF2Input.GetKey(KeyCode.Alpha2))
				{
					DropWeapon(1);
				}
				else
				{
					DropTimer[1] = 0f;
				}
			}
			if (Weapon[2] != null && DropTimer[1] == 0f)
			{
				if (InputDevice.Type == InputDeviceType.Gamepad)
				{
					if (ControlFreak2.CF2Input.GetAxis("DpadX") > 0.5f)
					{
						DropWeapon(2);
					}
					else
					{
						DropTimer[2] = 0f;
					}
				}
				else if (ControlFreak2.CF2Input.GetKey(KeyCode.Alpha3))
				{
					DropWeapon(2);
				}
				else
				{
					DropTimer[2] = 0f;
				}
			}
			if (ControlFreak2.CF2Input.GetButtonDown("LS") || ControlFreak2.CF2Input.GetKeyDown(KeyCode.T))
			{
				if (NewTrail != null)
				{
					Object.Destroy(NewTrail);
				}
				NewTrail = Object.Instantiate(Trail, base.transform.position + base.transform.forward * 0.5f + Vector3.up * 0.1f, Quaternion.identity);
				NewTrail.GetComponent<AIPath>().target = Homeroom;
			}
			if (Armed)
			{
				for (ID = 0; ID < ArmedAnims.Length; ID++)
				{
					string text = ArmedAnims[ID];
					CharacterAnimation[text].weight = Mathf.Lerp(CharacterAnimation[text].weight, (EquippedWeapon.AnimID != ID) ? 0f : 1f, Time.deltaTime * 10f);
				}
			}
			else
			{
				StopArmedAnim();
			}
			if (TheftTimer > 0f)
			{
				TheftTimer = Mathf.MoveTowards(TheftTimer, 0f, Time.deltaTime);
			}
			if (Eating)
			{
				FollowHips = false;
				Attacking = false;
				CanMove = true;
				Eating = false;
				EatPhase = 0;
			}
			return;
		}
		StopArmedAnim();
		if (Dumping)
		{
			targetRotation = Quaternion.LookRotation(Incinerator.transform.position - base.transform.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
			MoveTowardsTarget(Incinerator.transform.position + Vector3.right * -2f);
			if (DumpTimer == 0f && Carrying)
			{
				CharacterAnimation["f02_carryDisposeA_00"].time = 2.5f;
			}
			DumpTimer += Time.deltaTime;
			if (DumpTimer > 1f)
			{
				if (!Ragdoll.GetComponent<RagdollScript>().Dumped)
				{
					DumpRagdoll(RagdollDumpType.Incinerator);
				}
				CharacterAnimation.CrossFade("f02_carryDisposeA_00");
				if (CharacterAnimation["f02_carryDisposeA_00"].time >= CharacterAnimation["f02_carryDisposeA_00"].length)
				{
					Incinerator.Prompt.enabled = true;
					Incinerator.Ready = true;
					Incinerator.Open = false;
					Dragging = false;
					Dumping = false;
					CanMove = true;
					Ragdoll = null;
					StopCarrying();
					DumpTimer = 0f;
				}
			}
		}
		if (Chipping)
		{
			targetRotation = Quaternion.LookRotation(WoodChipper.gameObject.transform.position - base.transform.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
			MoveTowardsTarget(WoodChipper.DumpPoint.position);
			if (DumpTimer == 0f && Carrying)
			{
				CharacterAnimation["f02_carryDisposeA_00"].time = 2.5f;
			}
			DumpTimer += Time.deltaTime;
			if (DumpTimer > 1f)
			{
				if (!Ragdoll.GetComponent<RagdollScript>().Dumped)
				{
					DumpRagdoll(RagdollDumpType.WoodChipper);
				}
				CharacterAnimation.CrossFade("f02_carryDisposeA_00");
				if (CharacterAnimation["f02_carryDisposeA_00"].time >= CharacterAnimation["f02_carryDisposeA_00"].length)
				{
					WoodChipper.Prompt.HideButton[0] = false;
					WoodChipper.Prompt.HideButton[3] = true;
					WoodChipper.Occupied = true;
					WoodChipper.Open = false;
					Dragging = false;
					Chipping = false;
					CanMove = true;
					Ragdoll = null;
					StopCarrying();
					DumpTimer = 0f;
				}
			}
		}
		if (TranquilHiding)
		{
			targetRotation = Quaternion.LookRotation(TranqCase.transform.position - base.transform.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
			MoveTowardsTarget(TranqCase.transform.position + Vector3.right * 1.4f);
			if (DumpTimer == 0f && Carrying)
			{
				CharacterAnimation["f02_carryDisposeA_00"].time = 2.5f;
			}
			DumpTimer += Time.deltaTime;
			if (DumpTimer > 1f)
			{
				if (!Ragdoll.GetComponent<RagdollScript>().Dumped)
				{
					DumpRagdoll(RagdollDumpType.TranqCase);
				}
				CharacterAnimation.CrossFade("f02_carryDisposeA_00");
				if (CharacterAnimation["f02_carryDisposeA_00"].time >= CharacterAnimation["f02_carryDisposeA_00"].length)
				{
					TranquilHiding = false;
					Dragging = false;
					Dumping = false;
					CanMove = true;
					Ragdoll = null;
					StopCarrying();
					DumpTimer = 0f;
				}
			}
		}
		if (Dipping)
		{
			if (Bucket != null)
			{
				targetRotation = Quaternion.LookRotation(new Vector3(Bucket.transform.position.x, base.transform.position.y, Bucket.transform.position.z) - base.transform.position);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
			}
			CharacterAnimation.CrossFade("f02_dipping_00");
			if (CharacterAnimation["f02_dipping_00"].time >= CharacterAnimation["f02_dipping_00"].length * 0.5f)
			{
				Mop.Bleached = true;
				Mop.Sparkles.Play();
				if (Mop.Bloodiness > 0f)
				{
					if (Bucket != null)
					{
						Bucket.Bloodiness += Mop.Bloodiness / 2f;
						Bucket.UpdateAppearance = true;
					}
					Mop.Bloodiness = 0f;
					Mop.UpdateBlood();
				}
			}
			if (CharacterAnimation["f02_dipping_00"].time >= CharacterAnimation["f02_dipping_00"].length)
			{
				CharacterAnimation["f02_dipping_00"].time = 0f;
				Mop.Prompt.enabled = true;
				Dipping = false;
				CanMove = true;
			}
		}
		if (Pouring)
		{
			MoveTowardsTarget(Stool.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, Stool.rotation, 10f * Time.deltaTime);
			string animation = "f02_bucketDump" + PourHeight + "_00";
			AnimationState animationState = CharacterAnimation[animation];
			CharacterAnimation.CrossFade(animation, 0f);
			if (animationState.time >= PourTime && !PickUp.Bucket.Poured)
			{
				if (PickUp.Bucket.Gasoline)
				{
					ParticleSystem.MainModule main = PickUp.Bucket.PourEffect.main;
					main.startColor = new Color(1f, 1f, 0f, 0.5f);
					Object.Instantiate(PickUp.Bucket.GasCollider, PickUp.Bucket.PourEffect.transform.position + PourDistance * base.transform.forward, Quaternion.identity);
				}
				else if (PickUp.Bucket.Bloodiness < 50f)
				{
					ParticleSystem.MainModule main2 = PickUp.Bucket.PourEffect.main;
					main2.startColor = new Color(0f, 1f, 1f, 0.5f);
					Object.Instantiate(PickUp.Bucket.WaterCollider, PickUp.Bucket.PourEffect.transform.position + PourDistance * base.transform.forward, Quaternion.identity);
				}
				else
				{
					ParticleSystem.MainModule main3 = PickUp.Bucket.PourEffect.main;
					main3.startColor = new Color(0.5f, 0f, 0f, 0.5f);
					Object.Instantiate(PickUp.Bucket.BloodCollider, PickUp.Bucket.PourEffect.transform.position + PourDistance * base.transform.forward, Quaternion.identity);
				}
				PickUp.Bucket.PourEffect.Play();
				PickUp.Bucket.Poured = true;
				PickUp.Bucket.Empty();
			}
			if (animationState.time >= animationState.length)
			{
				animationState.time = 0f;
				PickUp.Bucket.Poured = false;
				Pouring = false;
				CanMove = true;
			}
		}
		if (Laughing)
		{
			if (Hairstyles[14].activeInHierarchy)
			{
				LaughAnim = "storepower_20";
				LaughClip = ChargeUp;
			}
			if (Stand.Stand.activeInHierarchy)
			{
				LaughAnim = "f02_jojoAttack_00";
				LaughClip = YanYan;
			}
			else if (FlameDemonic)
			{
				float axis = ControlFreak2.CF2Input.GetAxis("Vertical");
				float axis2 = ControlFreak2.CF2Input.GetAxis("Horizontal");
				Vector3 vector3 = MainCamera.transform.TransformDirection(Vector3.forward);
				vector3.y = 0f;
				vector3 = vector3.normalized;
				Vector3 vector4 = new Vector3(vector3.z, 0f, 0f - vector3.x);
				Vector3 vector5 = axis2 * vector4 + axis * vector3;
				if (vector5 != Vector3.zero)
				{
					targetRotation = Quaternion.LookRotation(vector5);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
				}
				LaughAnim = "f02_demonAttack_00";
				CirnoTimer -= Time.deltaTime;
				if (CirnoTimer < 0f)
				{
					GameObject gameObject4 = Object.Instantiate(Fireball, RightHand.position, base.transform.rotation);
					gameObject4.transform.localEulerAngles += new Vector3(Random.Range(0f, 22.5f), Random.Range(-22.5f, 22.5f), Random.Range(-22.5f, 22.5f));
					GameObject gameObject5 = Object.Instantiate(Fireball, LeftHand.position, base.transform.rotation);
					gameObject5.transform.localEulerAngles += new Vector3(Random.Range(0f, 22.5f), Random.Range(-22.5f, 22.5f), Random.Range(-22.5f, 22.5f));
					CirnoTimer = 0.1f;
				}
			}
			else if (CirnoHair.activeInHierarchy)
			{
				float axis3 = ControlFreak2.CF2Input.GetAxis("Vertical");
				float axis4 = ControlFreak2.CF2Input.GetAxis("Horizontal");
				Vector3 vector6 = MainCamera.transform.TransformDirection(Vector3.forward);
				vector6.y = 0f;
				vector6 = vector6.normalized;
				Vector3 vector7 = new Vector3(vector6.z, 0f, 0f - vector6.x);
				Vector3 vector8 = axis4 * vector7 + axis3 * vector6;
				if (vector8 != Vector3.zero)
				{
					targetRotation = Quaternion.LookRotation(vector8);
					base.transform.rotation = Quaternion.Lerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
				}
				LaughAnim = "f02_cirnoAttack_00";
				CirnoTimer -= Time.deltaTime;
				if (CirnoTimer < 0f)
				{
					GameObject gameObject6 = Object.Instantiate(CirnoIceAttack, base.transform.position + base.transform.up * 1.4f, base.transform.rotation);
					gameObject6.transform.localEulerAngles += new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
					component.PlayOneShot(CirnoIceClip);
					CirnoTimer = 0.1f;
				}
			}
			else if (TornadoHair.activeInHierarchy)
			{
				LaughAnim = "f02_tornadoAttack_00";
				CirnoTimer -= Time.deltaTime;
				if (CirnoTimer < 0f)
				{
					GameObject gameObject7 = Object.Instantiate(TornadoAttack, base.transform.forward * 5f + new Vector3(base.transform.position.x + Random.Range(-5f, 5f), base.transform.position.y, base.transform.position.z + Random.Range(-5f, 5f)), base.transform.rotation);
					while (Vector3.Distance(base.transform.position, gameObject7.transform.position) < 1f)
					{
						gameObject7.transform.position = base.transform.forward * 5f + new Vector3(base.transform.position.x + Random.Range(-5f, 5f), base.transform.position.y, base.transform.position.z + Random.Range(-5f, 5f));
					}
					CirnoTimer = 0.1f;
				}
			}
			else if (BladeHair.activeInHierarchy)
			{
				LaughAnim = "f02_spin_00";
				base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y + Time.deltaTime * 360f * 2f, base.transform.localEulerAngles.z);
				BladeHairCollider1.enabled = true;
				BladeHairCollider2.enabled = true;
			}
			else if (BanchoActive)
			{
				BanchoFlurry.MyCollider.enabled = true;
				LaughAnim = "f02_banchoFlurry_00";
			}
			else if (component.clip != LaughClip)
			{
				component.clip = LaughClip;
				component.time = 0f;
				component.Play();
			}
			CharacterAnimation.CrossFade(LaughAnim);
			if (ControlFreak2.CF2Input.GetButtonDown("RB"))
			{
				LaughIntensity += 1f;
				if (LaughIntensity <= 5f)
				{
					LaughAnim = "f02_laugh_01";
					LaughClip = Laugh1;
					LaughTimer = 0.5f;
				}
				else if (LaughIntensity <= 10f)
				{
					LaughAnim = "f02_laugh_02";
					LaughClip = Laugh2;
					LaughTimer = 1f;
				}
				else if (LaughIntensity <= 15f)
				{
					LaughAnim = "f02_laugh_03";
					LaughClip = Laugh3;
					LaughTimer = 1.5f;
				}
				else if (LaughIntensity <= 20f)
				{
					GameObject gameObject8 = Object.Instantiate(AlarmDisc, base.transform.position + Vector3.up, Quaternion.identity);
					gameObject8.GetComponent<AlarmDiscScript>().NoScream = true;
					LaughAnim = "f02_laugh_04";
					LaughClip = Laugh4;
					LaughTimer = 2f;
				}
				else
				{
					GameObject gameObject9 = Object.Instantiate(AlarmDisc, base.transform.position + Vector3.up, Quaternion.identity);
					gameObject9.GetComponent<AlarmDiscScript>().NoScream = true;
					LaughAnim = "f02_laugh_04";
					LaughIntensity = 20f;
					LaughTimer = 2f;
				}
			}
			if (LaughIntensity > 15f)
			{
				Sanity += Time.deltaTime * 10f;
			}
			LaughTimer -= Time.deltaTime;
			if (LaughTimer <= 0f)
			{
				StopLaughing();
			}
		}
		if (TimeSkipping)
		{
			base.transform.position = new Vector3(base.transform.position.x, TimeSkipHeight, base.transform.position.z);
			CharacterAnimation.CrossFade("f02_timeSkip_00");
			MyController.Move(base.transform.up * 0.0001f);
			Sanity += Time.deltaTime * 0.17f;
		}
		if (DumpsterGrabbing)
		{
			if (ControlFreak2.CF2Input.GetAxis("Horizontal") > 0.5f || ControlFreak2.CF2Input.GetAxis("DpadX") > 0.5f)
			{
				CharacterAnimation.CrossFade((DumpsterHandle.Direction != -1f) ? "f02_dumpsterPush_00" : "f02_dumpsterPull_00");
			}
			else if (ControlFreak2.CF2Input.GetAxis("Horizontal") < -0.5f || ControlFreak2.CF2Input.GetAxis("DpadX") < -0.5f)
			{
				CharacterAnimation.CrossFade((DumpsterHandle.Direction != -1f) ? "f02_dumpsterPull_00" : "f02_dumpsterPush_00");
			}
			else
			{
				CharacterAnimation.CrossFade("f02_dumpsterGrab_00");
			}
		}
		if (Stripping)
		{
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, StudentManager.YandereStripSpot.rotation, 10f * Time.deltaTime);
			if (CharacterAnimation["f02_stripping_00"].time >= CharacterAnimation["f02_stripping_00"].length)
			{
				Stripping = false;
				CanMove = true;
				MyLocker.UpdateSchoolwear();
			}
		}
		if (Bathing)
		{
			MoveTowardsTarget(Stool.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, Stool.rotation, 10f * Time.deltaTime);
			CharacterAnimation.CrossFade("f02_stoolBathing_00");
			if (CharacterAnimation["f02_stoolBathing_00"].time >= CharacterAnimation["f02_stoolBathing_00"].length)
			{
				Bloodiness = 0f;
				Bathing = false;
				CanMove = true;
			}
		}
		if (Degloving)
		{
			CharacterAnimation.CrossFade("f02_removeGloves_00");
			if (CharacterAnimation["f02_removeGloves_00"].time >= CharacterAnimation["f02_removeGloves_00"].length)
			{
				Gloves.GetComponent<Rigidbody>().isKinematic = false;
				Gloves.transform.parent = null;
				Gloves.gameObject.SetActive(true);
				Degloving = false;
				CanMove = true;
				Gloved = false;
				Gloves = null;
				SetUniform();
				Debug.Log("Gloves removed.");
			}
			else if (Chased || Chasers > 0 || Noticed)
			{
				Degloving = false;
				GloveTimer = 0f;
				if (!Noticed)
				{
					CanMove = true;
				}
			}
			else if (InputDevice.Type == InputDeviceType.Gamepad)
			{
				if (ControlFreak2.CF2Input.GetAxis("DpadY") > -0.5f)
				{
					Degloving = false;
					CanMove = true;
					GloveTimer = 0f;
				}
			}
			else if (ControlFreak2.CF2Input.GetKeyUp(KeyCode.Alpha1))
			{
				Degloving = false;
				CanMove = true;
				GloveTimer = 0f;
			}
		}
		if (Struggling)
		{
			if (!Won && !Lost)
			{
				CharacterAnimation.CrossFade((!TargetStudent.Teacher) ? "f02_struggleA_00" : "f02_teacherStruggleA_00");
				targetRotation = Quaternion.LookRotation(TargetStudent.transform.position - base.transform.position);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, 10f * Time.deltaTime);
			}
			else if (Won)
			{
				if (!TargetStudent.Teacher)
				{
					CharacterAnimation.CrossFade("f02_struggleWinA_00");
					if (CharacterAnimation["f02_struggleWinA_00"].time > CharacterAnimation["f02_struggleWinA_00"].length - 1f)
					{
						EquippedWeapon.transform.localEulerAngles = Vector3.Lerp(EquippedWeapon.transform.localEulerAngles, Vector3.zero, Time.deltaTime * 3.33333f);
					}
				}
				else
				{
					CharacterAnimation.CrossFade("f02_teacherStruggleWinA_00");
					EquippedWeapon.transform.localEulerAngles = Vector3.Lerp(EquippedWeapon.transform.localEulerAngles, Vector3.zero, Time.deltaTime);
				}
				if (StrugglePhase == 0)
				{
					if ((!TargetStudent.Teacher && CharacterAnimation["f02_struggleWinA_00"].time > 1.3f) || (TargetStudent.Teacher && CharacterAnimation["f02_teacherStruggleWinA_00"].time > 0.8f))
					{
						Object.Instantiate(TargetStudent.StabBloodEffect, (!TargetStudent.Teacher) ? TargetStudent.Head.position : EquippedWeapon.transform.position, Quaternion.identity);
						Bloodiness += 20f;
						Sanity -= 20f * Numbness;
						StainWeapon();
						StrugglePhase++;
					}
				}
				else if (StrugglePhase == 1)
				{
					if (TargetStudent.Teacher && CharacterAnimation["f02_teacherStruggleWinA_00"].time > 1.3f)
					{
						Object.Instantiate(TargetStudent.StabBloodEffect, EquippedWeapon.transform.position, Quaternion.identity);
						StrugglePhase++;
					}
				}
				else if (StrugglePhase == 2 && TargetStudent.Teacher && CharacterAnimation["f02_teacherStruggleWinA_00"].time > 2.1f)
				{
					Object.Instantiate(TargetStudent.StabBloodEffect, EquippedWeapon.transform.position, Quaternion.identity);
					StrugglePhase++;
				}
				if ((!TargetStudent.Teacher && CharacterAnimation["f02_struggleWinA_00"].time > CharacterAnimation["f02_struggleWinA_00"].length) || (TargetStudent.Teacher && CharacterAnimation["f02_teacherStruggleWinA_00"].time > CharacterAnimation["f02_teacherStruggleWinA_00"].length))
				{
					MyController.radius = 0.2f;
					CharacterAnimation.CrossFade(IdleAnim);
					ShoulderCamera.Struggle = false;
					Struggling = false;
					StrugglePhase = 0;
					if (TargetStudent == Pursuer)
					{
						Pursuer = null;
						Chased = false;
					}
					TargetStudent.BecomeRagdoll();
					TargetStudent.DeathType = DeathType.Weapon;
				}
			}
			else if (Lost)
			{
				CharacterAnimation.CrossFade((!TargetStudent.Teacher) ? "f02_struggleLoseA_00" : "f02_teacherStruggleLoseA_00");
			}
		}
		if (ClubActivity)
		{
			if (ClubGlobals.Club == ClubType.Art)
			{
				CharacterAnimation.Play("f02_painting_00");
			}
			else if (ClubGlobals.Club == ClubType.MartialArts)
			{
				CharacterAnimation.Play("f02_kick_23");
				if (CharacterAnimation["f02_kick_23"].time >= CharacterAnimation["f02_kick_23"].length)
				{
					CharacterAnimation["f02_kick_23"].time = 0f;
				}
			}
			else if (ClubGlobals.Club == ClubType.Photography)
			{
				CharacterAnimation.Play("f02_sit_00");
			}
		}
		if (Possessed)
		{
			CharacterAnimation.CrossFade("f02_possessionPose_00");
		}
		if (Punching)
		{
			if (FalconHelmet.activeInHierarchy)
			{
				if (CharacterAnimation["f02_falconPunch_00"].time >= 1f && CharacterAnimation["f02_falconPunch_00"].time <= 1.25f)
				{
					FalconSpeed = Mathf.MoveTowards(FalconSpeed, 2.5f, Time.deltaTime * 2.5f);
				}
				else if (CharacterAnimation["f02_falconPunch_00"].time >= 1.25f && CharacterAnimation["f02_falconPunch_00"].time <= 1.5f)
				{
					FalconSpeed = Mathf.MoveTowards(FalconSpeed, 0f, Time.deltaTime * 2.5f);
				}
				if (CharacterAnimation["f02_falconPunch_00"].time >= 1f && CharacterAnimation["f02_falconPunch_00"].time <= 1.5f)
				{
					if (NewFalconPunch == null)
					{
						NewFalconPunch = Object.Instantiate(FalconPunch);
						NewFalconPunch.transform.parent = ItemParent;
						NewFalconPunch.transform.localPosition = Vector3.zero;
					}
					MyController.Move(base.transform.forward * FalconSpeed);
				}
				if (CharacterAnimation["f02_falconPunch_00"].time >= CharacterAnimation["f02_falconPunch_00"].length)
				{
					NewFalconPunch = null;
					Punching = false;
					CanMove = true;
				}
			}
			else
			{
				if (CharacterAnimation["f02_onePunch_00"].time >= 0.833333f && CharacterAnimation["f02_onePunch_00"].time <= 1f && NewOnePunch == null)
				{
					NewOnePunch = Object.Instantiate(OnePunch);
					NewOnePunch.transform.parent = ItemParent;
					NewOnePunch.transform.localPosition = Vector3.zero;
				}
				if (CharacterAnimation["f02_onePunch_00"].time >= 2f)
				{
					NewOnePunch = null;
					Punching = false;
					CanMove = true;
				}
			}
		}
		if (PK)
		{
			if (ControlFreak2.CF2Input.GetAxis("Vertical") > 0.5f)
			{
				GoToPKDir(PKDirType.Up, "f02_sansUp_00", new Vector3(0f, 3f, 2f));
			}
			else if (ControlFreak2.CF2Input.GetAxis("Vertical") < -0.5f)
			{
				GoToPKDir(PKDirType.Down, "f02_sansDown_00", new Vector3(0f, 0f, 2f));
			}
			else if (ControlFreak2.CF2Input.GetAxis("Horizontal") > 0.5f)
			{
				GoToPKDir(PKDirType.Right, "f02_sansRight_00", new Vector3(1.5f, 1.5f, 2f));
			}
			else if (ControlFreak2.CF2Input.GetAxis("Horizontal") < -0.5f)
			{
				GoToPKDir(PKDirType.Left, "f02_sansLeft_00", new Vector3(-1.5f, 1.5f, 2f));
			}
			else
			{
				CharacterAnimation.CrossFade("f02_sansHold_00");
				RagdollPK.transform.localPosition = new Vector3(0f, 1.5f, 2f);
				PKDir = PKDirType.None;
			}
			if (ControlFreak2.CF2Input.GetButtonDown("B"))
			{
				PromptBar.ClearButtons();
				PromptBar.UpdateButtons();
				PromptBar.Show = false;
				Ragdoll.GetComponent<RagdollScript>().StopDragging();
				SansEyes[0].SetActive(false);
				SansEyes[1].SetActive(false);
				GlowEffect.Stop();
				CanMove = true;
				PK = false;
			}
		}
		if (SummonBones)
		{
			CharacterAnimation.CrossFade("f02_sansBones_00");
			if (BoneTimer == 0f)
			{
				Object.Instantiate(Bone, base.transform.position + base.transform.right * Random.Range(-2.5f, 2.5f) + base.transform.up * -2f + base.transform.forward * Random.Range(1f, 6f), Quaternion.identity);
			}
			BoneTimer += Time.deltaTime;
			if (BoneTimer > 0.1f)
			{
				BoneTimer = 0f;
			}
			if (ControlFreak2.CF2Input.GetButtonUp("RB"))
			{
				SansEyes[0].SetActive(false);
				SansEyes[1].SetActive(false);
				GlowEffect.Stop();
				SummonBones = false;
				CanMove = true;
			}
			if (PK)
			{
				PromptBar.ClearButtons();
				PromptBar.UpdateButtons();
				PromptBar.Show = false;
				Ragdoll.GetComponent<RagdollScript>().StopDragging();
				SansEyes[0].SetActive(false);
				SansEyes[1].SetActive(false);
				GlowEffect.Stop();
				CanMove = true;
				PK = false;
			}
		}
		if (Blasting)
		{
			if (CharacterAnimation["f02_sansBlaster_00"].time >= CharacterAnimation["f02_sansBlaster_00"].length - 0.25f)
			{
				SansEyes[0].SetActive(false);
				SansEyes[1].SetActive(false);
				GlowEffect.Stop();
				Blasting = false;
				CanMove = true;
			}
			if (PK)
			{
				PromptBar.ClearButtons();
				PromptBar.UpdateButtons();
				PromptBar.Show = false;
				Ragdoll.GetComponent<RagdollScript>().StopDragging();
				SansEyes[0].SetActive(false);
				SansEyes[1].SetActive(false);
				GlowEffect.Stop();
				CanMove = true;
				PK = false;
			}
		}
		if (Lifting)
		{
			if (!HeavyWeight)
			{
				if (CharacterAnimation["f02_carryLiftA_00"].time >= CharacterAnimation["f02_carryLiftA_00"].length)
				{
					IdleAnim = CarryIdleAnim;
					WalkAnim = CarryWalkAnim;
					RunAnim = CarryRunAnim;
					CanMove = true;
					Carrying = true;
					Lifting = false;
				}
			}
			else if (CharacterAnimation["f02_heavyWeightLift_00"].time >= CharacterAnimation["f02_heavyWeightLift_00"].length)
			{
				CharacterAnimation[CarryAnims[0]].weight = 1f;
				IdleAnim = HeavyIdleAnim;
				WalkAnim = HeavyWalkAnim;
				RunAnim = CarryRunAnim;
				CanMove = true;
				Lifting = false;
			}
		}
		if (Dropping)
		{
			targetRotation = Quaternion.LookRotation(DropSpot.position + DropSpot.forward - base.transform.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
			MoveTowardsTarget(DropSpot.position);
			if (Ragdoll != null)
			{
				CurrentRagdoll = Ragdoll.GetComponent<RagdollScript>();
			}
			if (DumpTimer == 0f && Carrying)
			{
				CurrentRagdoll.CharacterAnimation[CurrentRagdoll.DumpedAnim].time = 2.5f;
				CharacterAnimation["f02_carryDisposeA_00"].time = 2.5f;
			}
			DumpTimer += Time.deltaTime;
			if (DumpTimer > 1f)
			{
				if (Ragdoll != null)
				{
					CurrentRagdoll.PelvisRoot.localEulerAngles = new Vector3(CurrentRagdoll.PelvisRoot.localEulerAngles.x, 0f, CurrentRagdoll.PelvisRoot.localEulerAngles.z);
					CurrentRagdoll.PelvisRoot.localPosition = new Vector3(CurrentRagdoll.PelvisRoot.localPosition.x, CurrentRagdoll.PelvisRoot.localPosition.y, 0f);
				}
				CameraTarget.position = Vector3.MoveTowards(CameraTarget.position, new Vector3(Hips.position.x, base.transform.position.y + 1f, Hips.position.z), Time.deltaTime * 10f);
				if (CharacterAnimation["f02_carryDisposeA_00"].time >= 4.5f)
				{
					StopCarrying();
				}
				else
				{
					if (CurrentRagdoll.StopAnimation)
					{
						CurrentRagdoll.StopAnimation = false;
						for (ID = 0; ID < CurrentRagdoll.AllRigidbodies.Length; ID++)
						{
							CurrentRagdoll.AllRigidbodies[ID].isKinematic = true;
						}
					}
					CharacterAnimation.CrossFade("f02_carryDisposeA_00");
					CurrentRagdoll.CharacterAnimation.CrossFade(CurrentRagdoll.DumpedAnim);
					Ragdoll.transform.position = base.transform.position;
					Ragdoll.transform.eulerAngles = base.transform.eulerAngles;
				}
				if (CharacterAnimation["f02_carryDisposeA_00"].time >= CharacterAnimation["f02_carryDisposeA_00"].length)
				{
					CameraTarget.localPosition = new Vector3(0f, 1f, 0f);
					Dropping = false;
					CanMove = true;
					DumpTimer = 0f;
				}
			}
		}
		if (Dismembering && CharacterAnimation["f02_dismember_00"].time >= CharacterAnimation["f02_dismember_00"].length)
		{
			Ragdoll.GetComponent<RagdollScript>().Dismember();
			RPGCamera.enabled = true;
			TargetStudent = null;
			Dismembering = false;
			CanMove = true;
		}
		if (Shoved)
		{
			if (CharacterAnimation["f02_shoveA_01"].time >= CharacterAnimation["f02_shoveA_01"].length)
			{
				CharacterAnimation.CrossFade(IdleAnim);
				Shoved = false;
				if (!CannotRecover)
				{
					CanMove = true;
				}
			}
			else if (CharacterAnimation["f02_shoveA_01"].time < 0.66666f)
			{
				MyController.Move(base.transform.forward * -1f * ShoveSpeed * Time.deltaTime);
				MyController.Move(Physics.gravity * 0.1f);
				if (ShoveSpeed > 0f)
				{
					ShoveSpeed = Mathf.MoveTowards(ShoveSpeed, 0f, Time.deltaTime * 3f);
				}
			}
		}
		if (Attacked && CharacterAnimation["f02_swingB_00"].time >= CharacterAnimation["f02_swingB_00"].length)
		{
			ShoulderCamera.HeartbrokenCamera.SetActive(true);
			base.enabled = false;
		}
		if (Hiding)
		{
			if (!Exiting)
			{
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, HidingSpot.rotation, Time.deltaTime * 10f);
				MoveTowardsTarget(HidingSpot.position);
				CharacterAnimation.CrossFade(HideAnim);
				if (ControlFreak2.CF2Input.GetButtonDown("B"))
				{
					PromptBar.ClearButtons();
					PromptBar.Show = false;
					Exiting = true;
				}
			}
			else
			{
				MoveTowardsTarget(ExitSpot.position);
				CharacterAnimation.CrossFade(IdleAnim);
				ExitTimer += Time.deltaTime;
				if (ExitTimer > 1f || Vector3.Distance(base.transform.position, ExitSpot.position) < 0.1f)
				{
					MyController.center = new Vector3(MyController.center.x, 0.875f, MyController.center.z);
					MyController.radius = 0.2f;
					MyController.height = 1.55f;
					ExitTimer = 0f;
					Exiting = false;
					CanMove = true;
					Hiding = false;
				}
			}
		}
		if (Tripping)
		{
			if (CharacterAnimation["f02_bucketTrip_00"].time >= CharacterAnimation["f02_bucketTrip_00"].length)
			{
				CharacterAnimation["f02_bucketTrip_00"].speed = 1f;
				Tripping = false;
				CanMove = true;
			}
			else if (CharacterAnimation["f02_bucketTrip_00"].time < 0.5f)
			{
				MyController.Move(base.transform.forward * (Time.deltaTime * 2f));
				if (CharacterAnimation["f02_bucketTrip_00"].time > 1f / 3f && CharacterAnimation["f02_bucketTrip_00"].speed == 1f)
				{
					CharacterAnimation["f02_bucketTrip_00"].speed += 1E-06f;
					AudioSource.PlayClipAtPoint(Thud, base.transform.position);
				}
			}
			else if (ControlFreak2.CF2Input.GetButtonDown("A"))
			{
				CharacterAnimation["f02_bucketTrip_00"].speed += 0.1f;
			}
		}
		if (BucketDropping)
		{
			targetRotation = Quaternion.LookRotation(DropSpot.position + DropSpot.forward - base.transform.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
			MoveTowardsTarget(DropSpot.position);
			if (CharacterAnimation["f02_bucketDrop_00"].time >= CharacterAnimation["f02_bucketDrop_00"].length)
			{
				MyController.radius = 0.2f;
				BucketDropping = false;
				CanMove = true;
			}
			else if (CharacterAnimation["f02_bucketDrop_00"].time >= 1f && PickUp != null)
			{
				PickUp.Bucket.UpdateAppearance = true;
				PickUp.Bucket.Dropped = true;
				EmptyHands();
			}
		}
		if (Flicking)
		{
			if (CharacterAnimation["f02_flickingMatch_00"].time >= CharacterAnimation["f02_flickingMatch_00"].length)
			{
				PickUp.GetComponent<MatchboxScript>().Prompt.enabled = true;
				Arc.SetActive(true);
				Flicking = false;
				CanMove = true;
			}
			else if (CharacterAnimation["f02_flickingMatch_00"].time > 1f && Match != null)
			{
				Rigidbody component2 = Match.GetComponent<Rigidbody>();
				component2.isKinematic = false;
				component2.useGravity = true;
				component2.AddRelativeForce(Vector3.right * 250f);
				Match.transform.parent = null;
				Match = null;
			}
		}
		if (Rummaging)
		{
			MoveTowardsTarget(RummageSpot.Target.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, RummageSpot.Target.rotation, Time.deltaTime * 10f);
			RummageTimer += Time.deltaTime;
			ProgressBar.transform.localScale = new Vector3(RummageTimer / 10f, ProgressBar.transform.localScale.y, ProgressBar.transform.localScale.z);
			if (RummageTimer > 10f)
			{
				RummageSpot.GetReward();
				ProgressBar.transform.parent.gameObject.SetActive(false);
				RummageSpot = null;
				Rummaging = false;
				RummageTimer = 0f;
				CanMove = true;
			}
		}
		if (Digging)
		{
			if (DigPhase == 1)
			{
				if (CharacterAnimation["f02_shovelDig_00"].time >= 1.6666666f)
				{
					component.volume = 1f;
					component.clip = Dig;
					component.Play();
					DigPhase++;
				}
			}
			else if (DigPhase == 2)
			{
				if (CharacterAnimation["f02_shovelDig_00"].time >= 3.5f)
				{
					component.volume = 1f;
					component.Play();
					DigPhase++;
				}
			}
			else if (DigPhase == 3)
			{
				if (CharacterAnimation["f02_shovelDig_00"].time >= 5.6666665f)
				{
					component.volume = 1f;
					component.Play();
					DigPhase++;
				}
			}
			else if (DigPhase == 4 && CharacterAnimation["f02_shovelDig_00"].time >= CharacterAnimation["f02_shovelDig_00"].length)
			{
				EquippedWeapon.gameObject.SetActive(true);
				FloatingShovel.SetActive(false);
				RPGCamera.enabled = true;
				Digging = false;
				CanMove = true;
			}
		}
		if (Burying)
		{
			if (DigPhase == 1)
			{
				if (CharacterAnimation["f02_shovelBury_00"].time >= 2.1666667f)
				{
					component.volume = 1f;
					component.clip = Dig;
					component.Play();
					DigPhase++;
				}
			}
			else if (DigPhase == 2)
			{
				if (CharacterAnimation["f02_shovelBury_00"].time >= 4.6666665f)
				{
					component.volume = 1f;
					component.Play();
					DigPhase++;
				}
			}
			else if (CharacterAnimation["f02_shovelBury_00"].time >= CharacterAnimation["f02_shovelBury_00"].length)
			{
				EquippedWeapon.gameObject.SetActive(true);
				FloatingShovel.SetActive(false);
				RPGCamera.enabled = true;
				Burying = false;
				CanMove = true;
			}
		}
		if (Pickpocketing && !Noticed && Caught)
		{
			CaughtTimer += Time.deltaTime;
			if (CaughtTimer > 1f)
			{
				Pickpocketing = false;
				CaughtTimer = 0f;
				CanMove = true;
				Caught = false;
			}
		}
		if (Sprayed)
		{
			if (SprayPhase == 0)
			{
				if ((double)CharacterAnimation["f02_sprayed_00"].time > 0.66666)
				{
					Blur.enabled = true;
					Blur.blurSize += Time.deltaTime;
					if (Blur.blurSize > (float)Blur.blurIterations)
					{
						Blur.blurIterations++;
					}
				}
				if (CharacterAnimation["f02_sprayed_00"].time > 5f)
				{
					Police.Darkness.enabled = true;
					Police.Darkness.color = new Color(0f, 0f, 0f, Mathf.MoveTowards(Police.Darkness.color.a, 1f, Time.deltaTime));
					if (Police.Darkness.color.a == 1f)
					{
						SprayTimer += Time.deltaTime;
						if (SprayTimer > 1f)
						{
							CharacterAnimation.Play("f02_tied_00");
							RPGCamera.enabled = false;
							ZipTie[0].SetActive(true);
							ZipTie[1].SetActive(true);
							Blur.enabled = false;
							SprayTimer = 0f;
							SprayPhase++;
						}
					}
				}
			}
			else if (SprayPhase == 1)
			{
				Police.Darkness.color = new Color(0f, 0f, 0f, Mathf.MoveTowards(Police.Darkness.color.a, 0f, Time.deltaTime));
				if (Police.Darkness.color.a == 0f)
				{
					SprayTimer += Time.deltaTime;
					if (SprayTimer > 1f)
					{
						ShoulderCamera.HeartbrokenCamera.SetActive(true);
						SprayPhase++;
					}
				}
			}
		}
		if (SithAttacking)
		{
			if (!SithRecovering)
			{
				if (SithBeam[1].Damage == 10f)
				{
					if (SithAttacks == 0 && CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= SithSpawnTime[SithCombo])
					{
						Object.Instantiate(SithHitbox, base.transform.position + base.transform.forward * 1f + base.transform.up, base.transform.rotation);
						SithAttacks++;
					}
				}
				else if (SithAttacks == 0)
				{
					if (CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= SithHardSpawnTime1[SithCombo])
					{
						Object.Instantiate(SithHardHitbox, base.transform.position + base.transform.forward * 1f + base.transform.up, base.transform.rotation);
						SithAttacks++;
					}
				}
				else if (SithAttacks == 1)
				{
					if (CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= SithHardSpawnTime2[SithCombo])
					{
						Object.Instantiate(SithHardHitbox, base.transform.position + base.transform.forward * 1f + base.transform.up, base.transform.rotation);
						SithAttacks++;
					}
				}
				else if (SithAttacks == 2 && SithCombo == 1 && CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= 14f / 15f)
				{
					Object.Instantiate(SithHardHitbox, base.transform.position + base.transform.forward * 1f + base.transform.up, base.transform.rotation);
					SithAttacks++;
				}
				SithSoundCheck();
				if (CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].length)
				{
					if (SithCombo < SithComboLength)
					{
						SithCombo++;
						SithSounds = 0;
						SithAttacks = 0;
						CharacterAnimation.CrossFade("f02_sithAttack" + SithPrefix + "_0" + SithCombo);
					}
					else
					{
						CharacterAnimation.CrossFade("f02_sithRecover" + SithPrefix + "_0" + SithCombo);
						CharacterAnimation["f02_sithRecover" + SithPrefix + "_0" + SithCombo].speed = 2f;
						SithRecovering = true;
					}
				}
				else
				{
					if (ControlFreak2.CF2Input.GetButtonDown("X") && SithComboLength < SithCombo + 1 && SithComboLength < 2)
					{
						SithComboLength++;
					}
					if (ControlFreak2.CF2Input.GetButtonDown("Y") && SithComboLength < SithCombo + 1 && SithComboLength < 2)
					{
						SithComboLength++;
					}
				}
			}
			else if (CharacterAnimation["f02_sithRecover" + SithPrefix + "_0" + SithCombo].time >= CharacterAnimation["f02_sithRecover" + SithPrefix + "_0" + SithCombo].length)
			{
				CharacterAnimation["f02_sithRecover" + SithPrefix + "_0" + SithCombo].speed = 1f;
				SithRecovering = false;
				SithAttacking = false;
				SithComboLength = 0;
				SithAttacks = 0;
				SithSounds = 0;
				SithCombo = 0;
				CanMove = true;
			}
		}
		if (Eating)
		{
			targetRotation = Quaternion.LookRotation(new Vector3(TargetStudent.transform.position.x, base.transform.position.y, TargetStudent.transform.position.z) - base.transform.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, 10f * Time.deltaTime);
			if (CharacterAnimation["f02_sixEat_00"].time > BloodTimes[EatPhase])
			{
				GameObject gameObject10 = Object.Instantiate(TargetStudent.StabBloodEffect, Mouth.position, Quaternion.identity);
				gameObject10.GetComponent<RandomStabScript>().Biting = true;
				Bloodiness += 20f;
				EatPhase++;
			}
			if (CharacterAnimation["f02_sixEat_00"].time >= CharacterAnimation["f02_sixEat_00"].length)
			{
				if (Hunger < 5)
				{
					CharacterAnimation["f02_sixRun_00"].speed += 0.1f;
					RunSpeed += 1f;
					Hunger++;
					if (Hunger == 5)
					{
						RisingSmoke.SetActive(true);
						RunAnim = "f02_sixFastRun_00";
					}
				}
				Debug.Log("Finished eating.");
				FollowHips = false;
				Attacking = false;
				CanMove = true;
				Eating = false;
				EatPhase = 0;
			}
		}
		if (Snapping)
		{
			if (SnapPhase == 0)
			{
				if (CharacterAnimation["f02_gazerSnap_00"].time >= 0.8f)
				{
					AudioSource.PlayClipAtPoint(FingerSnap, base.transform.position + Vector3.up);
					GazerEyes.ChangeEffect();
					SnapPhase++;
				}
			}
			else if (CharacterAnimation["f02_gazerSnap_00"].time >= CharacterAnimation["f02_gazerSnap_00"].length)
			{
				Snapping = false;
				CanMove = true;
				SnapPhase = 0;
			}
		}
		if (GazeAttacking)
		{
			if (TargetStudent != null)
			{
				targetRotation = Quaternion.LookRotation(new Vector3(TargetStudent.transform.position.x, base.transform.position.y, TargetStudent.transform.position.z) - base.transform.position);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, 10f * Time.deltaTime);
			}
			if (SnapPhase == 0)
			{
				if (CharacterAnimation["f02_gazerPoint_00"].time >= 1f)
				{
					AudioSource.PlayClipAtPoint(Zap, base.transform.position + Vector3.up);
					GazerEyes.Attack();
					SnapPhase++;
				}
			}
			else if (CharacterAnimation["f02_gazerPoint_00"].time >= CharacterAnimation["f02_gazerPoint_00"].length)
			{
				GazerEyes.Attacking = false;
				GazeAttacking = false;
				CanMove = true;
				SnapPhase = 0;
			}
		}
		if (Finisher)
		{
			if (CharacterAnimation["f02_banchoFinisher_00"].time >= CharacterAnimation["f02_banchoFinisher_00"].length)
			{
				CharacterAnimation.CrossFade(IdleAnim);
				Finisher = false;
				CanMove = true;
			}
			else if (CharacterAnimation["f02_banchoFinisher_00"].time >= 1.6666666f)
			{
				BanchoFinisher.MyCollider.enabled = false;
			}
			else if (CharacterAnimation["f02_banchoFinisher_00"].time >= 5f / 6f)
			{
				BanchoFinisher.MyCollider.enabled = true;
			}
		}
		if (CanMoveTimer > 0f)
		{
			CanMoveTimer = Mathf.MoveTowards(CanMoveTimer, 0f, Time.deltaTime);
			if (CanMoveTimer == 0f)
			{
				CanMove = true;
			}
		}
	}

	private void UpdatePoisoning()
	{
		if (Poisoning)
		{
			MoveTowardsTarget(PoisonSpot.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, PoisonSpot.rotation, Time.deltaTime * 10f);
			if (CharacterAnimation["f02_poisoning_00"].time >= CharacterAnimation["f02_poisoning_00"].length)
			{
				Poisoning = false;
				CanMove = true;
			}
			else if (CharacterAnimation["f02_poisoning_00"].time >= 5.25f)
			{
				Poisons[PoisonType].SetActive(false);
			}
			else if ((double)CharacterAnimation["f02_poisoning_00"].time >= 0.75)
			{
				Poisons[PoisonType].SetActive(true);
			}
		}
	}

	private void UpdateEffects()
	{
		if (!Attacking && !DelinquentFighting && !Lost && CanMove)
		{
			if (Vector3.Distance(base.transform.position, Senpai.position) < 1f)
			{
				if (!Talking)
				{
					if (!NearSenpai)
					{
						DepthOfField.focalSize = 150f;
						NearSenpai = true;
					}
					if (Laughing)
					{
						StopLaughing();
					}
					Obscurance.enabled = false;
					YandereVision = false;
					Stance.Current = StanceType.Standing;
					Mopping = false;
					Uncrouch();
					YandereTimer = 0f;
					EmptyHands();
					if (Aiming)
					{
						StopAiming();
					}
				}
			}
			else
			{
				NearSenpai = false;
			}
		}
		if (NearSenpai && !Noticed)
		{
			DepthOfField.enabled = true;
			DepthOfField.focalSize = Mathf.Lerp(DepthOfField.focalSize, 0f, Time.deltaTime * 10f);
			DepthOfField.focalZStartCurve = Mathf.Lerp(DepthOfField.focalZStartCurve, 20f, Time.deltaTime * 10f);
			DepthOfField.focalZEndCurve = Mathf.Lerp(DepthOfField.focalZEndCurve, 20f, Time.deltaTime * 10f);
			DepthOfField.objectFocus = Senpai.transform;
			ColorCorrection.enabled = true;
			SenpaiFade = Mathf.Lerp(SenpaiFade, 0f, Time.deltaTime * 10f);
			SenpaiTint = 1f - SenpaiFade / 100f;
			ColorCorrection.redChannel.MoveKey(1, new Keyframe(0.5f, 0.5f + SenpaiTint * 0.5f));
			ColorCorrection.greenChannel.MoveKey(1, new Keyframe(0.5f, 1f - SenpaiTint * 0.5f));
			ColorCorrection.blueChannel.MoveKey(1, new Keyframe(0.5f, 0.5f + SenpaiTint * 0.5f));
			ColorCorrection.redChannel.SmoothTangents(1, 0f);
			ColorCorrection.greenChannel.SmoothTangents(1, 0f);
			ColorCorrection.blueChannel.SmoothTangents(1, 0f);
			ColorCorrection.UpdateTextures();
			if (!Attacking)
			{
			}
			SelectGrayscale.desaturation = Mathf.Lerp(SelectGrayscale.desaturation, 0f, Time.deltaTime * 10f);
			HeartBeat.volume = SenpaiTint;
			Sanity += Time.deltaTime * 10f;
			SenpaiTimer += Time.deltaTime;
			if (SenpaiTimer > 10f && Creepiness < 5)
			{
				SenpaiTimer = 0f;
				Creepiness++;
			}
		}
		else if (SenpaiFade < 99f)
		{
			DepthOfField.focalSize = Mathf.Lerp(DepthOfField.focalSize, 150f, Time.deltaTime * 10f);
			DepthOfField.focalZStartCurve = Mathf.Lerp(DepthOfField.focalZStartCurve, 0f, Time.deltaTime * 10f);
			DepthOfField.focalZEndCurve = Mathf.Lerp(DepthOfField.focalZEndCurve, 0f, Time.deltaTime * 10f);
			SenpaiFade = Mathf.Lerp(SenpaiFade, 100f, Time.deltaTime * 10f);
			SenpaiTint = SenpaiFade / 100f;
			ColorCorrection.redChannel.MoveKey(1, new Keyframe(0.5f, 1f - SenpaiTint * 0.5f));
			ColorCorrection.greenChannel.MoveKey(1, new Keyframe(0.5f, SenpaiTint * 0.5f));
			ColorCorrection.blueChannel.MoveKey(1, new Keyframe(0.5f, 1f - SenpaiTint * 0.5f));
			ColorCorrection.redChannel.SmoothTangents(1, 0f);
			ColorCorrection.greenChannel.SmoothTangents(1, 0f);
			ColorCorrection.blueChannel.SmoothTangents(1, 0f);
			ColorCorrection.UpdateTextures();
			SelectGrayscale.desaturation = Mathf.Lerp(SelectGrayscale.desaturation, GreyTarget, Time.deltaTime * 10f);
			CharacterAnimation["f02_shy_00"].weight = 1f - SenpaiTint;
			for (int i = 1; i < 6; i++)
			{
				CharacterAnimation[CreepyIdles[i]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyIdles[i]].weight, 0f, Time.deltaTime * 10f);
				CharacterAnimation[CreepyWalks[i]].weight = Mathf.MoveTowards(CharacterAnimation[CreepyWalks[i]].weight, 0f, Time.deltaTime * 10f);
			}
			HeartBeat.volume = 1f - SenpaiTint;
		}
		else if (SenpaiFade < 100f)
		{
			ResetSenpaiEffects();
		}
		if (YandereVision)
		{
			if (!HighlightingR.enabled)
			{
				YandereColorCorrection.enabled = true;
				HighlightingR.enabled = true;
				HighlightingB.enabled = true;
				Obscurance.enabled = true;
				Vignette.enabled = true;
			}
			Time.timeScale = Mathf.Lerp(Time.timeScale, 0.5f, Time.unscaledDeltaTime * 10f);
			YandereFade = Mathf.Lerp(YandereFade, 0f, Time.deltaTime * 10f);
			YandereTint = 1f - YandereFade / 100f;
			YandereColorCorrection.redChannel.MoveKey(1, new Keyframe(0.5f, 0.5f - YandereTint * 0.25f));
			YandereColorCorrection.greenChannel.MoveKey(1, new Keyframe(0.5f, 0.5f - YandereTint * 0.25f));
			YandereColorCorrection.blueChannel.MoveKey(1, new Keyframe(0.5f, 0.5f + YandereTint * 0.25f));
			YandereColorCorrection.redChannel.SmoothTangents(1, 0f);
			YandereColorCorrection.greenChannel.SmoothTangents(1, 0f);
			YandereColorCorrection.blueChannel.SmoothTangents(1, 0f);
			YandereColorCorrection.UpdateTextures();
			Vignette.intensity = Mathf.Lerp(Vignette.intensity, YandereTint * 5f, Time.deltaTime * 10f);
			Vignette.blur = Mathf.Lerp(Vignette.blur, YandereTint, Time.deltaTime * 10f);
			Vignette.chromaticAberration = Mathf.Lerp(Vignette.chromaticAberration, YandereTint * 5f, Time.deltaTime * 10f);
			if (StudentManager.Tag.Target != null)
			{
				StudentManager.Tag.Sprite.color = new Color(1f, 0f, 0f, Mathf.Lerp(StudentManager.Tag.Sprite.color.a, 1f, Time.unscaledDeltaTime * 10f));
			}
		}
		else
		{
			if (HighlightingR.enabled)
			{
				HighlightingR.enabled = false;
				HighlightingB.enabled = false;
			}
			if (YandereFade < 99f)
			{
				if (!Aiming)
				{
					Time.timeScale = Mathf.Lerp(Time.timeScale, 1f, Time.unscaledDeltaTime * 10f);
				}
				YandereFade = Mathf.Lerp(YandereFade, 100f, Time.deltaTime * 10f);
				YandereTint = YandereFade / 100f;
				YandereColorCorrection.redChannel.MoveKey(1, new Keyframe(0.5f, YandereTint * 0.5f));
				YandereColorCorrection.greenChannel.MoveKey(1, new Keyframe(0.5f, YandereTint * 0.5f));
				YandereColorCorrection.blueChannel.MoveKey(1, new Keyframe(0.5f, 1f - YandereTint * 0.5f));
				YandereColorCorrection.redChannel.SmoothTangents(1, 0f);
				YandereColorCorrection.greenChannel.SmoothTangents(1, 0f);
				YandereColorCorrection.blueChannel.SmoothTangents(1, 0f);
				YandereColorCorrection.UpdateTextures();
				Vignette.intensity = Mathf.Lerp(Vignette.intensity, 0f, Time.deltaTime * 10f);
				Vignette.blur = Mathf.Lerp(Vignette.blur, 0f, Time.deltaTime * 10f);
				Vignette.chromaticAberration = Mathf.Lerp(Vignette.chromaticAberration, 0f, Time.deltaTime * 10f);
				StudentManager.Tag.Sprite.color = new Color(1f, 0f, 0f, Mathf.Lerp(StudentManager.Tag.Sprite.color.a, 0f, Time.unscaledDeltaTime * 10f));
			}
			else if (YandereFade < 100f)
			{
				ResetYandereEffects();
			}
		}
		RightRedEye.material.color = new Color(RightRedEye.material.color.r, RightRedEye.material.color.g, RightRedEye.material.color.b, 1f - YandereFade / 100f);
		LeftRedEye.material.color = new Color(LeftRedEye.material.color.r, LeftRedEye.material.color.g, LeftRedEye.material.color.b, 1f - YandereFade / 100f);
		RightYandereEye.material.color = new Color(RightYandereEye.material.color.r, YandereFade / 100f, YandereFade / 100f, RightYandereEye.material.color.a);
		LeftYandereEye.material.color = new Color(LeftYandereEye.material.color.r, YandereFade / 100f, YandereFade / 100f, LeftYandereEye.material.color.a);
	}

	private void UpdateTalking()
	{
		if (!Talking)
		{
			return;
		}
		if (TargetStudent != null)
		{
			targetRotation = Quaternion.LookRotation(new Vector3(TargetStudent.transform.position.x, base.transform.position.y, TargetStudent.transform.position.z) - base.transform.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
		}
		if (Interaction == YandereInteractionType.Idle)
		{
			CharacterAnimation.CrossFade(IdleAnim);
		}
		else if (Interaction == YandereInteractionType.Apologizing)
		{
			if (TalkTimer == 3f)
			{
				CharacterAnimation.CrossFade("f02_greet_00");
				if (TargetStudent.Witnessed == StudentWitnessType.Insanity || TargetStudent.Witnessed == StudentWitnessType.WeaponAndBloodAndInsanity || TargetStudent.Witnessed == StudentWitnessType.WeaponAndInsanity || TargetStudent.Witnessed == StudentWitnessType.BloodAndInsanity)
				{
					Subtitle.UpdateLabel(SubtitleType.InsanityApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.WeaponAndBlood)
				{
					Subtitle.UpdateLabel(SubtitleType.WeaponAndBloodApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.Weapon)
				{
					Subtitle.UpdateLabel(SubtitleType.WeaponApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.Blood)
				{
					Subtitle.UpdateLabel(SubtitleType.BloodApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.Lewd)
				{
					Subtitle.UpdateLabel(SubtitleType.LewdApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.Accident)
				{
					Subtitle.UpdateLabel(SubtitleType.AccidentApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.Suspicious)
				{
					Subtitle.UpdateLabel(SubtitleType.SuspiciousApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.Eavesdropping)
				{
					Subtitle.UpdateLabel(SubtitleType.EavesdropApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.Violence)
				{
					Subtitle.UpdateLabel(SubtitleType.ViolenceApology, 0, 3f);
				}
				else if (TargetStudent.Witnessed == StudentWitnessType.Pickpocketing)
				{
					Subtitle.UpdateLabel(SubtitleType.PickpocketApology, 0, 3f);
				}
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_greet_00"].time >= CharacterAnimation["f02_greet_00"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.Forgiving;
					TargetStudent.TalkTimer = 3f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.Compliment)
		{
			if (TalkTimer == 3f)
			{
				CharacterAnimation.CrossFade("f02_greet_01");
				Subtitle.UpdateLabel(SubtitleType.PlayerCompliment, 0, 3f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_greet_01"].time >= CharacterAnimation["f02_greet_01"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.ReceivingCompliment;
					TargetStudent.TalkTimer = 3f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.Gossip)
		{
			if (TalkTimer == 3f)
			{
				CharacterAnimation.CrossFade("f02_lookdown_00");
				Subtitle.UpdateLabel(SubtitleType.PlayerGossip, 0, 3f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_lookdown_00"].time >= CharacterAnimation["f02_lookdown_00"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.Gossiping;
					TargetStudent.TalkTimer = 3f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.Bye)
		{
			if (TalkTimer == 2f)
			{
				CharacterAnimation.CrossFade("f02_greet_00");
				Subtitle.UpdateLabel(SubtitleType.PlayerFarewell, 0, 2f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_greet_00"].time >= CharacterAnimation["f02_greet_00"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.Bye;
					TargetStudent.TalkTimer = 2f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.FollowMe)
		{
			if (TalkTimer == 3f)
			{
				CharacterAnimation.CrossFade("f02_greet_01");
				Subtitle.UpdateLabel(SubtitleType.PlayerFollow, 0, 3f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_greet_01"].time >= CharacterAnimation["f02_greet_01"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.FollowingPlayer;
					TargetStudent.TalkTimer = 2f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.GoAway)
		{
			if (TalkTimer == 3f)
			{
				CharacterAnimation.CrossFade("f02_lookdown_00");
				Subtitle.UpdateLabel(SubtitleType.PlayerLeave, 0, 3f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_lookdown_00"].time >= CharacterAnimation["f02_lookdown_00"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.GoingAway;
					TargetStudent.TalkTimer = 3f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.DistractThem)
		{
			if (TalkTimer == 3f)
			{
				CharacterAnimation.CrossFade("f02_lookdown_00");
				Subtitle.UpdateLabel(SubtitleType.PlayerDistract, 0, 3f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_lookdown_00"].time >= CharacterAnimation["f02_lookdown_00"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.DistractingTarget;
					TargetStudent.TalkTimer = 3f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.NamingCrush)
		{
			if (TalkTimer == 3f)
			{
				CharacterAnimation.CrossFade("f02_greet_01");
				Subtitle.UpdateLabel(SubtitleType.PlayerLove, 0, 3f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_greet_01"].time >= CharacterAnimation["f02_greet_01"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.NamingCrush;
					TargetStudent.TalkTimer = 3f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.ChangingAppearance)
		{
			if (TalkTimer == 3f)
			{
				CharacterAnimation.CrossFade("f02_greet_01");
				Subtitle.UpdateLabel(SubtitleType.PlayerLove, 2, 3f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_greet_01"].time >= CharacterAnimation["f02_greet_01"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.ChangingAppearance;
					TargetStudent.TalkTimer = 3f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else if (Interaction == YandereInteractionType.Court)
		{
			if (TalkTimer == 5f)
			{
				CharacterAnimation.CrossFade("f02_greet_01");
				if (!TargetStudent.Male)
				{
					Subtitle.UpdateLabel(SubtitleType.PlayerLove, 3, 5f);
				}
				else
				{
					Subtitle.UpdateLabel(SubtitleType.PlayerLove, 4, 5f);
				}
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_greet_01"].time >= CharacterAnimation["f02_greet_01"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.Court;
					TargetStudent.TalkTimer = 3f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
		else
		{
			if (Interaction != YandereInteractionType.Confess)
			{
				return;
			}
			if (TalkTimer == 5f)
			{
				CharacterAnimation.CrossFade("f02_greet_01");
				Subtitle.UpdateLabel(SubtitleType.PlayerLove, 5, 5f);
			}
			else
			{
				if (ControlFreak2.CF2Input.GetButtonDown("A"))
				{
					TalkTimer = 0f;
				}
				if (CharacterAnimation["f02_greet_01"].time >= CharacterAnimation["f02_greet_01"].length)
				{
					CharacterAnimation.CrossFade(IdleAnim);
				}
				if (TalkTimer <= 0f)
				{
					TargetStudent.Interaction = StudentInteractionType.Gift;
					TargetStudent.TalkTimer = 5f;
					Interaction = YandereInteractionType.Idle;
				}
			}
			TalkTimer -= Time.deltaTime;
		}
	}

	private void UpdateAttacking()
	{
		if (!Attacking)
		{
			return;
		}
		if (TargetStudent != null)
		{
			targetRotation = Quaternion.LookRotation(new Vector3(TargetStudent.transform.position.x, base.transform.position.y, TargetStudent.transform.position.z) - base.transform.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, targetRotation, Time.deltaTime * 10f);
		}
		if (Drown)
		{
			MoveTowardsTarget(TargetStudent.transform.position + TargetStudent.transform.forward * -0.0001f);
			CharacterAnimation.CrossFade(DrownAnim);
			if (CharacterAnimation[DrownAnim].time > CharacterAnimation[DrownAnim].length)
			{
				TargetStudent.DeathType = DeathType.Drowning;
				Attacking = false;
				CanMove = true;
				Drown = false;
				Sanity -= ((PlayerGlobals.PantiesEquipped != 10) ? 20f : 10f) * Numbness;
			}
			if (TargetStudent.StudentID == 34)
			{
				if (CharacterAnimation[DrownAnim].time > 9f)
				{
					StudentManager.AltFemaleDrownSplashes.Stop();
				}
				else if (CharacterAnimation[DrownAnim].time > 3f)
				{
					StudentManager.AltFemaleDrownSplashes.Play();
				}
			}
			else if (CharacterAnimation[DrownAnim].time > 9f)
			{
				StudentManager.FemaleDrownSplashes.Stop();
			}
			else if (CharacterAnimation[DrownAnim].time > 3f)
			{
				StudentManager.FemaleDrownSplashes.Play();
			}
		}
		else if (RoofPush)
		{
			CameraTarget.position = Vector3.MoveTowards(CameraTarget.position, new Vector3(Hips.position.x, base.transform.position.y + 1f, Hips.position.z), Time.deltaTime * 10f);
			MoveTowardsTarget(TargetStudent.transform.position - TargetStudent.transform.forward);
			CharacterAnimation.CrossFade("f02_roofPushA_00");
			if (CharacterAnimation["f02_roofPushA_00"].time > 4.3333335f)
			{
				if (Shoes[0].activeInHierarchy)
				{
					GameObject gameObject = Object.Instantiate(ShoePair, base.transform.position + new Vector3(-1.6f, 0.045f, 0f), Quaternion.identity);
					gameObject.transform.eulerAngles = new Vector3(gameObject.transform.eulerAngles.x, -90f, gameObject.transform.eulerAngles.z);
					Shoes[0].SetActive(false);
					Shoes[1].SetActive(false);
				}
			}
			else if (CharacterAnimation["f02_roofPushA_00"].time > 2.1666667f && !Shoes[0].activeInHierarchy)
			{
				TargetStudent.RemoveShoes();
				Shoes[0].SetActive(true);
				Shoes[1].SetActive(true);
			}
			if (CharacterAnimation["f02_roofPushA_00"].time > CharacterAnimation["f02_roofPushA_00"].length)
			{
				CameraTarget.localPosition = new Vector3(0f, 1f, 0f);
				TargetStudent.DeathType = DeathType.Falling;
				Attacking = false;
				RoofPush = false;
				CanMove = true;
				Sanity -= 20f * Numbness;
			}
			if (ControlFreak2.CF2Input.GetButtonDown("B"))
			{
				SplashCamera.Show = true;
				SplashCamera.MyCamera.enabled = true;
				SplashCamera.transform.position = new Vector3(-33f, 1.35f, 30f);
				SplashCamera.transform.eulerAngles = new Vector3(0f, 135f, 0f);
			}
		}
		else if (TargetStudent.Teacher)
		{
			CharacterAnimation.CrossFade("f02_counterA_00");
			Character.transform.position = new Vector3(Character.transform.position.x, TargetStudent.transform.position.y, Character.transform.position.z);
		}
		else
		{
			if (SanityBased)
			{
				return;
			}
			if (EquippedWeapon.WeaponID == 11)
			{
				CharacterAnimation.CrossFade("CyborgNinja_Slash");
				if (CharacterAnimation["CyborgNinja_Slash"].time == 0f)
				{
					TargetStudent.CharacterAnimation[TargetStudent.PhoneAnim].weight = 0f;
					EquippedWeapon.gameObject.GetComponent<AudioSource>().Play();
				}
				if (CharacterAnimation["CyborgNinja_Slash"].time >= CharacterAnimation["CyborgNinja_Slash"].length)
				{
					Bloodiness += 20f;
					StainWeapon();
					CharacterAnimation["CyborgNinja_Slash"].time = 0f;
					CharacterAnimation.Stop("CyborgNinja_Slash");
					CharacterAnimation.CrossFade(IdleAnim);
					Attacking = false;
					if (!Noticed)
					{
						CanMove = true;
					}
					else
					{
						EquippedWeapon.Drop();
					}
				}
				return;
			}
			if (EquippedWeapon.WeaponID == 7)
			{
				CharacterAnimation.CrossFade("f02_buzzSawKill_A_00");
				if (CharacterAnimation["f02_buzzSawKill_A_00"].time == 0f)
				{
					TargetStudent.CharacterAnimation[TargetStudent.PhoneAnim].weight = 0f;
					EquippedWeapon.gameObject.GetComponent<AudioSource>().Play();
				}
				if (AttackPhase == 1)
				{
					if (CharacterAnimation["f02_buzzSawKill_A_00"].time > 1f / 3f)
					{
						TargetStudent.LiquidProjector.enabled = true;
						EquippedWeapon.Effect();
						StainWeapon();
						TargetStudent.LiquidProjector.material.mainTexture = BloodTextures[1];
						Bloodiness += 20f;
						AttackPhase++;
					}
				}
				else if (AttackPhase < 6 && CharacterAnimation["f02_buzzSawKill_A_00"].time > 1f / 3f * (float)AttackPhase)
				{
					TargetStudent.LiquidProjector.material.mainTexture = BloodTextures[AttackPhase];
					Bloodiness += 20f;
					AttackPhase++;
				}
				if (CharacterAnimation["f02_buzzSawKill_A_00"].time > CharacterAnimation["f02_buzzSawKill_A_00"].length)
				{
					if (TargetStudent == StudentManager.Reporter)
					{
						StudentManager.Reporter = null;
					}
					CharacterAnimation["f02_buzzSawKill_A_00"].time = 0f;
					CharacterAnimation.Stop("f02_buzzSawKill_A_00");
					CharacterAnimation.CrossFade(IdleAnim);
					MyController.radius = 0.2f;
					Attacking = false;
					AttackPhase = 1;
					Sanity -= 20f * Numbness;
					TargetStudent.DeathType = DeathType.Weapon;
					TargetStudent.BecomeRagdoll();
					if (!Noticed)
					{
						CanMove = true;
					}
					else
					{
						EquippedWeapon.Drop();
					}
				}
				return;
			}
			if (!EquippedWeapon.Concealable)
			{
				if (AttackPhase == 1)
				{
					CharacterAnimation.CrossFade("f02_swingA_00");
					if (CharacterAnimation["f02_swingA_00"].time > CharacterAnimation["f02_swingA_00"].length * 0.3f)
					{
						if (TargetStudent == StudentManager.Reporter)
						{
							StudentManager.Reporter = null;
						}
						Object.Destroy(TargetStudent.DeathScream);
						EquippedWeapon.Effect();
						AttackPhase = 2;
						Bloodiness += 20f;
						StainWeapon();
						Sanity -= 20f * Numbness;
					}
				}
				else if (CharacterAnimation["f02_swingA_00"].time >= CharacterAnimation["f02_swingA_00"].length * 0.9f)
				{
					CharacterAnimation.CrossFade(IdleAnim);
					TargetStudent.DeathType = DeathType.Weapon;
					TargetStudent.BecomeRagdoll();
					MyController.radius = 0.2f;
					Attacking = false;
					AttackPhase = 1;
					AttackTimer = 0f;
					if (!Noticed)
					{
						CanMove = true;
					}
					else
					{
						EquippedWeapon.Drop();
					}
				}
				return;
			}
			if (AttackPhase == 1)
			{
				CharacterAnimation.CrossFade("f02_stab_00");
				if (!(CharacterAnimation["f02_stab_00"].time > CharacterAnimation["f02_stab_00"].length * 0.35f))
				{
					return;
				}
				CharacterAnimation.CrossFade(IdleAnim);
				if (EquippedWeapon.Flaming)
				{
					TargetStudent.Combust();
				}
				else if (CanTranq && !TargetStudent.Male && TargetStudent.Club != ClubType.Council)
				{
					TargetStudent.Tranquil = true;
					CanTranq = false;
					Followers--;
				}
				else
				{
					TargetStudent.BloodSpray.SetActive(true);
					TargetStudent.DeathType = DeathType.Weapon;
					Bloodiness += 20f;
				}
				if (TargetStudent == StudentManager.Reporter)
				{
					StudentManager.Reporter = null;
				}
				AudioSource.PlayClipAtPoint(Stabs[Random.Range(0, Stabs.Length)], base.transform.position + Vector3.up);
				Object.Destroy(TargetStudent.DeathScream);
				AttackPhase = 2;
				Sanity -= 20f * Numbness;
				if (EquippedWeapon.WeaponID == 8)
				{
					TargetStudent.Ragdoll.Sacrifice = true;
					if (GameGlobals.Paranormal)
					{
						EquippedWeapon.Effect();
					}
				}
				return;
			}
			AttackTimer += Time.deltaTime;
			if (AttackTimer > 0.3f)
			{
				if (!CanTranq)
				{
					StainWeapon();
				}
				MyController.radius = 0.2f;
				SanityBased = true;
				Attacking = false;
				AttackPhase = 1;
				AttackTimer = 0f;
				if (!Noticed)
				{
					CanMove = true;
				}
				else
				{
					EquippedWeapon.Drop();
				}
			}
		}
	}

	private void UpdateSlouch()
	{
		if (CanMove && !Attacking && !Dragging && PickUp == null && !Aiming && Stance.Current != StanceType.Crawling && !Possessed && !Carrying && !CirnoWings.activeInHierarchy && LaughIntensity < 16f)
		{
			CharacterAnimation["f02_yanderePose_00"].weight = Mathf.Lerp(CharacterAnimation["f02_yanderePose_00"].weight, 1f - Sanity / 100f, Time.deltaTime * 10f);
			if (Hairstyle == 2 && Stance.Current == StanceType.Crouching)
			{
				Slouch = Mathf.Lerp(Slouch, 0f, Time.deltaTime * 20f);
			}
			else
			{
				Slouch = Mathf.Lerp(Slouch, 5f * (1f - Sanity / 100f), Time.deltaTime * 10f);
			}
		}
		else
		{
			CharacterAnimation["f02_yanderePose_00"].weight = Mathf.Lerp(CharacterAnimation["f02_yanderePose_00"].weight, 0f, Time.deltaTime * 10f);
			Slouch = Mathf.Lerp(Slouch, 0f, Time.deltaTime * 10f);
		}
	}

	private void UpdateTwitch()
	{
		if (Sanity < 100f)
		{
			TwitchTimer += Time.deltaTime;
			if (TwitchTimer > NextTwitch)
			{
				Twitch = new Vector3((1f - Sanity / 100f) * Random.Range(-10f, 10f), (1f - Sanity / 100f) * Random.Range(-10f, 10f), (1f - Sanity / 100f) * Random.Range(-10f, 10f));
				NextTwitch = Random.Range(0f, 1f);
				TwitchTimer = 0f;
			}
			Twitch = Vector3.Lerp(Twitch, Vector3.zero, Time.deltaTime * 10f);
		}
	}

	private void UpdateWarnings()
	{
		if (NearBodies > 0)
		{
			if (!CorpseWarning)
			{
				NotificationManager.DisplayNotification(NotificationType.Body);
				StudentManager.UpdateStudents();
				CorpseWarning = true;
			}
		}
		else if (CorpseWarning)
		{
			StudentManager.UpdateStudents();
			CorpseWarning = false;
		}
		if (Eavesdropping)
		{
			if (!EavesdropWarning)
			{
				NotificationManager.DisplayNotification(NotificationType.Eavesdropping);
				EavesdropWarning = true;
			}
		}
		else if (EavesdropWarning)
		{
			EavesdropWarning = false;
		}
	}

	private void UpdateDebugFunctionality()
	{
		if (!EasterEggMenu.activeInHierarchy)
		{
			if (!Aiming && CanMove && Time.timeScale > 0f && ControlFreak2.CF2Input.GetKeyDown(KeyCode.Escape))
			{
				PauseScreen.JumpToQuit();
			}
			if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.P))
			{
				CyborgParts[1].SetActive(false);
				MemeGlasses.SetActive(false);
				KONGlasses.SetActive(false);
				EyepatchR.SetActive(false);
				EyepatchL.SetActive(false);
				EyewearID++;
				if (EyewearID == 1)
				{
					EyepatchR.SetActive(true);
				}
				else if (EyewearID == 2)
				{
					EyepatchL.SetActive(true);
				}
				else if (EyewearID == 3)
				{
					EyepatchR.SetActive(true);
					EyepatchL.SetActive(true);
				}
				else if (EyewearID == 4)
				{
					KONGlasses.SetActive(true);
				}
				else if (EyewearID == 5)
				{
					MemeGlasses.SetActive(true);
				}
				else if (EyewearID == 6)
				{
					if (CyborgParts[2].activeInHierarchy)
					{
						CyborgParts[1].SetActive(true);
					}
					else
					{
						EyewearID = 0;
					}
				}
				else
				{
					EyewearID = 0;
				}
			}
			if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.H))
			{
				if (ControlFreak2.CF2Input.GetButton("LB"))
				{
					Hairstyle += 10;
				}
				else
				{
					Hairstyle++;
				}
				UpdateHair();
			}
			if (ControlFreak2.CF2Input.GetKey(KeyCode.H) && ControlFreak2.CF2Input.GetKeyDown(KeyCode.LeftArrow))
			{
				Hairstyle--;
				UpdateHair();
			}
			if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.O) && !EasterEggMenu.activeInHierarchy)
			{
				if (AccessoryID > 0)
				{
					Accessories[AccessoryID].SetActive(false);
				}
				if (ControlFreak2.CF2Input.GetButton("LB"))
				{
					AccessoryID += 10;
				}
				else
				{
					AccessoryID++;
				}
				UpdateAccessory();
			}
			if (ControlFreak2.CF2Input.GetKey(KeyCode.O) && ControlFreak2.CF2Input.GetKeyDown(KeyCode.LeftArrow))
			{
				if (AccessoryID > 0)
				{
					Accessories[AccessoryID].SetActive(false);
				}
				AccessoryID--;
				UpdateAccessory();
			}
			if (!NoDebug && !DebugMenu.activeInHierarchy && CanMove)
			{
				if (ControlFreak2.CF2Input.GetKeyDown("-"))
				{
					if (Time.timeScale < 6f)
					{
						Time.timeScale = 1f;
					}
					else
					{
						Time.timeScale -= 5f;
					}
				}
				if (ControlFreak2.CF2Input.GetKeyDown("="))
				{
					if (Time.timeScale < 5f)
					{
						Time.timeScale = 5f;
					}
					else
					{
						Time.timeScale += 5f;
						if (Time.timeScale > 25f)
						{
							Time.timeScale = 25f;
						}
					}
				}
			}
			if (ControlFreak2.CF2Input.GetKey(KeyCode.Period))
			{
				BreastSize += Time.deltaTime;
				if (BreastSize > 2f)
				{
					BreastSize = 2f;
				}
				RightBreast.localScale = new Vector3(BreastSize, BreastSize, BreastSize);
				LeftBreast.localScale = new Vector3(BreastSize, BreastSize, BreastSize);
			}
			if (ControlFreak2.CF2Input.GetKey(KeyCode.Comma))
			{
				BreastSize -= Time.deltaTime;
				if (BreastSize < 0.5f)
				{
					BreastSize = 0.5f;
				}
				RightBreast.localScale = new Vector3(BreastSize, BreastSize, BreastSize);
				LeftBreast.localScale = new Vector3(BreastSize, BreastSize, BreastSize);
			}
		}
		if (!NoDebug)
		{
			if (!CanMove || Egg || !(base.transform.position.y < 1000f))
			{
				return;
			}
			if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Slash))
			{
				DebugMenu.SetActive(false);
				EasterEggMenu.SetActive(!EasterEggMenu.activeInHierarchy);
			}
			if (!EasterEggMenu.activeInHierarchy || Egg)
			{
				return;
			}
			if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.P))
			{
				Punish();
			}
			else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Z))
			{
				Slend();
			}
			else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.B))
			{
				Bancho();
			}
			else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.C))
			{
				Cirno();
			}
			else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.H))
			{
				EmptyHands();
				Hate();
			}
			else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.T))
			{
				StudentManager.AttackOnTitan();
				AttackOnTitan();
			}
			else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.G))
			{
				GaloSengen();
			}
			else
			{
				if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.J))
				{
					return;
				}
				if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.K))
				{
					EasterEggMenu.SetActive(false);
					StudentManager.Kong();
					DK = true;
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.L))
				{
					Agent();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.N))
				{
					Nude();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.S))
				{
					EasterEggMenu.SetActive(false);
					Egg = true;
					StudentManager.Spook();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.F))
				{
					EasterEggMenu.SetActive(false);
					Falcon();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.X))
				{
					EasterEggMenu.SetActive(false);
					X();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.O))
				{
					EasterEggMenu.SetActive(false);
					Punch();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.U))
				{
					EasterEggMenu.SetActive(false);
					BadTime();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Y))
				{
					EasterEggMenu.SetActive(false);
					CyborgNinja();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.E))
				{
					EasterEggMenu.SetActive(false);
					Ebola();
				}
				else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Q))
				{
					EasterEggMenu.SetActive(false);
					Samus();
				}
				else if (!ControlFreak2.CF2Input.GetKeyDown(KeyCode.W))
				{
					if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.R))
					{
						EasterEggMenu.SetActive(false);
						Pose();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.V))
					{
						EasterEggMenu.SetActive(false);
						Long();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha2))
					{
						EasterEggMenu.SetActive(false);
						HairBlades();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha7))
					{
						EasterEggMenu.SetActive(false);
						Tornado();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha8))
					{
						EasterEggMenu.SetActive(false);
						GenderSwap();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown("[5]"))
					{
						EasterEggMenu.SetActive(false);
						SwapMesh();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.A))
					{
						StudentManager.ChangeOka();
						EasterEggMenu.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.I))
					{
						StudentManager.NoGravity = true;
						EasterEggMenu.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.D))
					{
						EasterEggMenu.SetActive(false);
						Sith();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.M))
					{
						EasterEggMenu.SetActive(false);
						Snake();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha1))
					{
						EasterEggMenu.SetActive(false);
						Gazer();
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha3))
					{
						StudentManager.SecurityCameras();
						EasterEggMenu.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha4))
					{
						KLK();
						EasterEggMenu.SetActive(false);
					}
					else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Alpha6))
					{
						EasterEggMenu.SetActive(false);
						Six();
					}
					else if (!ControlFreak2.CF2Input.GetKeyDown(KeyCode.Space))
					{
					}
				}
			}
		}
		else if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Z))
		{
			DebugMenu.transform.parent.GetComponent<DebugMenuScript>().Censor();
		}
	}

	private void LateUpdate()
	{
		LeftEye.localPosition = new Vector3(LeftEye.localPosition.x, LeftEye.localPosition.y, LeftEyeOrigin.z - EyeShrink * 0.01f);
		RightEye.localPosition = new Vector3(RightEye.localPosition.x, RightEye.localPosition.y, RightEyeOrigin.z + EyeShrink * 0.01f);
		LeftEye.localScale = new Vector3(1f - EyeShrink * 0.5f, 1f - EyeShrink * 0.5f, LeftEye.localScale.z);
		RightEye.localScale = new Vector3(1f - EyeShrink * 0.5f, 1f - EyeShrink * 0.5f, RightEye.localScale.z);
		for (ID = 0; ID < Spine.Length; ID++)
		{
			Transform transform = Spine[ID].transform;
			transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + Slouch, transform.localEulerAngles.y, transform.localEulerAngles.z);
		}
		if (Aiming)
		{
			Transform transform2 = Spine[3].transform;
			transform2.localEulerAngles = new Vector3(transform2.localEulerAngles.x - Bend, transform2.localEulerAngles.y, transform2.localEulerAngles.z);
		}
		float num = 1f;
		if (Stance.Current == StanceType.Crouching)
		{
			num = 3.66666f;
		}
		Transform transform3 = Arm[0].transform;
		transform3.localEulerAngles = new Vector3(transform3.localEulerAngles.x, transform3.localEulerAngles.y, transform3.localEulerAngles.z - Slouch * (3f + num));
		Transform transform4 = Arm[1].transform;
		transform4.localEulerAngles = new Vector3(transform4.localEulerAngles.x, transform4.localEulerAngles.y, transform4.localEulerAngles.z + Slouch * (3f + num));
		if (!Aiming)
		{
			Head.localEulerAngles += Twitch;
		}
		if (Aiming)
		{
			if (Stance.Current == StanceType.Crawling)
			{
				TargetHeight = -1.4f;
			}
			else if (Stance.Current == StanceType.Crouching)
			{
				TargetHeight = -0.6f;
			}
			else
			{
				TargetHeight = 0f;
			}
			Height = Mathf.Lerp(Height, TargetHeight, Time.deltaTime * 10f);
			PelvisRoot.transform.localPosition = new Vector3(PelvisRoot.transform.localPosition.x, Height, PelvisRoot.transform.localPosition.z);
		}
		if (Slender)
		{
			Transform transform5 = Leg[0];
			transform5.localScale = new Vector3(transform5.localScale.x, 2f, transform5.localScale.z);
			Transform transform6 = Foot[0];
			transform6.localScale = new Vector3(transform6.localScale.x, 0.5f, transform6.localScale.z);
			Transform transform7 = Leg[1];
			transform7.localScale = new Vector3(transform7.localScale.x, 2f, transform7.localScale.z);
			Transform transform8 = Foot[1];
			transform8.localScale = new Vector3(transform8.localScale.x, 0.5f, transform8.localScale.z);
			Transform transform9 = Arm[0];
			transform9.localScale = new Vector3(2f, transform9.localScale.y, transform9.localScale.z);
			Transform transform10 = Arm[1];
			transform10.localScale = new Vector3(2f, transform10.localScale.y, transform10.localScale.z);
		}
		if (DK)
		{
			Arm[0].localScale = new Vector3(2f, 2f, 2f);
			Arm[1].localScale = new Vector3(2f, 2f, 2f);
			Head.localScale = new Vector3(2f, 2f, 2f);
		}
		if (!CirnoWings.activeInHierarchy)
		{
			return;
		}
		if (ControlFreak2.CF2Input.GetButton("LB"))
		{
			FlapSpeed = 5f;
		}
		else if (FlapSpeed == 0f)
		{
			FlapSpeed = 1f;
		}
		else
		{
			FlapSpeed = 3f;
		}
		Transform transform11 = CirnoWing[0];
		Transform transform12 = CirnoWing[1];
		if (!FlapOut)
		{
			CirnoRotation += Time.deltaTime * 100f * FlapSpeed;
			transform11.localEulerAngles = new Vector3(transform11.localEulerAngles.x, CirnoRotation, transform11.localEulerAngles.z);
			transform12.localEulerAngles = new Vector3(transform12.localEulerAngles.x, 0f - CirnoRotation, transform12.localEulerAngles.z);
			if (CirnoRotation > 15f)
			{
				FlapOut = true;
			}
		}
		else
		{
			CirnoRotation -= Time.deltaTime * 100f * FlapSpeed;
			transform11.localEulerAngles = new Vector3(transform11.localEulerAngles.x, CirnoRotation, transform11.localEulerAngles.z);
			transform12.localEulerAngles = new Vector3(transform12.localEulerAngles.x, 0f - CirnoRotation, transform12.localEulerAngles.z);
			if (CirnoRotation < -15f)
			{
				FlapOut = false;
			}
		}
	}

	public void StainWeapon()
	{
		if (EquippedWeapon != null)
		{
			if (TargetStudent != null && TargetStudent.StudentID < EquippedWeapon.Victims.Length)
			{
				EquippedWeapon.Victims[TargetStudent.StudentID] = true;
			}
			EquippedWeapon.Blood.enabled = true;
			EquippedWeapon.MurderWeapon = true;
			if (Gloved && !Gloves.Blood.enabled)
			{
				Gloves.PickUp.Evidence = true;
				Gloves.Blood.enabled = true;
				Police.BloodyClothing++;
			}
			if (Mask != null && !Mask.Blood.enabled)
			{
				Mask.PickUp.Evidence = true;
				Mask.Blood.enabled = true;
				Police.BloodyClothing++;
			}
			if (!EquippedWeapon.Evidence)
			{
				EquippedWeapon.Evidence = true;
				Police.MurderWeapons++;
			}
		}
	}

	public void MoveTowardsTarget(Vector3 target)
	{
		Vector3 vector = target - base.transform.position;
		MyController.Move(vector * (Time.deltaTime * 10f));
	}

	public void StopAiming()
	{
		UpdateAccessory();
		UpdateHair();
		CharacterAnimation["f02_cameraPose_00"].weight = 0f;
		PelvisRoot.transform.localPosition = new Vector3(PelvisRoot.transform.localPosition.x, 0f, PelvisRoot.transform.localPosition.z);
		ShoulderCamera.AimingCamera = false;
		if (!ControlFreak2.CF2Input.GetButtonDown("Start") && !ControlFreak2.CF2Input.GetKeyDown(KeyCode.Escape))
		{
			FixCamera();
		}
		if (ShoulderCamera.Timer == 0f)
		{
			RPGCamera.enabled = true;
		}
		if (!OptionGlobals.Fog)
		{
			MainCamera.clearFlags = CameraClearFlags.Skybox;
		}
		MainCamera.farClipPlane = OptionGlobals.DrawDistance;
		Smartphone.transform.parent.gameObject.SetActive(false);
		PhonePromptBar.Show = false;
		Smartphone.fieldOfView = 60f;
		Shutter.TargetStudent = 0;
		HandCamera.SetActive(false);
		UsingController = false;
		Aiming = false;
		Lewd = false;
		Height = 0f;
		Bend = 0f;
	}

	public void FixCamera()
	{
		RPGCamera.enabled = true;
		RPGCamera.UpdateRotation();
		RPGCamera.mouseSmoothingFactor = 0f;
		RPGCamera.GetInput();
		RPGCamera.GetDesiredPosition();
		RPGCamera.PositionUpdate();
		RPGCamera.mouseSmoothingFactor = 0.08f;
		Blur.enabled = false;
	}

	private void ResetSenpaiEffects()
	{
		DepthOfField.focalSize = 150f;
		DepthOfField.focalZStartCurve = 0f;
		DepthOfField.focalZEndCurve = 0f;
		DepthOfField.enabled = false;
		ColorCorrection.redChannel.MoveKey(1, new Keyframe(0.5f, 0.5f));
		ColorCorrection.greenChannel.MoveKey(1, new Keyframe(0.5f, 0.5f));
		ColorCorrection.blueChannel.MoveKey(1, new Keyframe(0.5f, 0.5f));
		ColorCorrection.redChannel.SmoothTangents(1, 0f);
		ColorCorrection.greenChannel.SmoothTangents(1, 0f);
		ColorCorrection.blueChannel.SmoothTangents(1, 0f);
		ColorCorrection.UpdateTextures();
		ColorCorrection.enabled = false;
		for (int i = 1; i < 6; i++)
		{
			CharacterAnimation[CreepyIdles[i]].weight = 0f;
			CharacterAnimation[CreepyWalks[i]].weight = 0f;
		}
		CharacterAnimation["f02_shy_00"].weight = 0f;
		HeartBeat.volume = 0f;
		SelectGrayscale.desaturation = GreyTarget;
		SenpaiFade = 100f;
		SenpaiTint = 0f;
	}

	public void ResetYandereEffects()
	{
		Vignette.intensity = 0f;
		Vignette.blur = 0f;
		Vignette.chromaticAberration = 0f;
		Vignette.enabled = false;
		YandereColorCorrection.redChannel.MoveKey(1, new Keyframe(0.5f, 0.5f));
		YandereColorCorrection.greenChannel.MoveKey(1, new Keyframe(0.5f, 0.5f));
		YandereColorCorrection.blueChannel.MoveKey(1, new Keyframe(0.5f, 0.5f));
		YandereColorCorrection.redChannel.SmoothTangents(1, 0f);
		YandereColorCorrection.greenChannel.SmoothTangents(1, 0f);
		YandereColorCorrection.blueChannel.SmoothTangents(1, 0f);
		YandereColorCorrection.UpdateTextures();
		YandereColorCorrection.enabled = false;
		Time.timeScale = 1f;
		YandereFade = 100f;
		StudentManager.Tag.Sprite.color = new Color(1f, 0f, 0f, 0f);
	}

	private void DumpRagdoll(RagdollDumpType Type)
	{
		Ragdoll.transform.position = base.transform.position;
		switch (Type)
		{
		case RagdollDumpType.Incinerator:
			Ragdoll.transform.LookAt(Incinerator.transform.position);
			Ragdoll.transform.eulerAngles = new Vector3(Ragdoll.transform.eulerAngles.x, Ragdoll.transform.eulerAngles.y + 180f, Ragdoll.transform.eulerAngles.z);
			break;
		case RagdollDumpType.TranqCase:
			Ragdoll.transform.LookAt(TranqCase.transform.position);
			break;
		case RagdollDumpType.WoodChipper:
			Ragdoll.transform.LookAt(WoodChipper.transform.position);
			break;
		}
		RagdollScript component = Ragdoll.GetComponent<RagdollScript>();
		component.DumpType = Type;
		component.Dump();
	}

	public void Unequip()
	{
		if (!CanMove && !Noticed)
		{
			return;
		}
		if (Equipped < 3)
		{
			if (EquippedWeapon != null)
			{
				EquippedWeapon.gameObject.SetActive(false);
			}
		}
		else
		{
			Weapon[3].Drop();
		}
		Equipped = 0;
		Mopping = false;
		StudentManager.UpdateStudents();
		WeaponManager.UpdateLabels();
		WeaponMenu.UpdateSprites();
		WeaponWarning = false;
	}

	public void DropWeapon(int ID)
	{
		DropTimer[ID] += Time.deltaTime;
		if (DropTimer[ID] > 0.5f)
		{
			Weapon[ID].Drop();
			Weapon[ID] = null;
			Unequip();
			DropTimer[ID] = 0f;
		}
	}

	public void EmptyHands()
	{
		if (Carrying || HeavyWeight)
		{
			StopCarrying();
		}
		if (Armed)
		{
			Unequip();
		}
		if (PickUp != null)
		{
			PickUp.Drop();
		}
		if (Dragging)
		{
			Ragdoll.GetComponent<RagdollScript>().StopDragging();
		}
		Mopping = false;
	}

	public void UpdateNumbness()
	{
		Numbness = 1f - 0.1f * (float)(PlayerGlobals.Numbness + PlayerGlobals.NumbnessBonus);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "BloodPool(Clone)" && other.transform.localScale.x > 0.3f)
		{
			if (PlayerGlobals.PantiesEquipped == 8)
			{
				RightFootprintSpawner.Bloodiness = 5;
				LeftFootprintSpawner.Bloodiness = 5;
			}
			else
			{
				RightFootprintSpawner.Bloodiness = 10;
				LeftFootprintSpawner.Bloodiness = 10;
			}
		}
	}

	public void UpdateHair()
	{
		if (Hairstyle > Hairstyles.Length - 1)
		{
			Hairstyle = 0;
		}
		if (Hairstyle < 0)
		{
			Hairstyle = Hairstyles.Length - 1;
		}
		for (ID = 1; ID < Hairstyles.Length; ID++)
		{
			Hairstyles[ID].SetActive(false);
		}
		if (Hairstyle > 0)
		{
			Hairstyles[Hairstyle].SetActive(true);
		}
	}

	public void StopLaughing()
	{
		BladeHairCollider1.enabled = false;
		BladeHairCollider2.enabled = false;
		LaughIntensity = 0f;
		Laughing = false;
		LaughClip = null;
		if (!Stand.Stand.activeInHierarchy)
		{
			CanMove = true;
		}
		if (BanchoActive)
		{
			AudioSource.PlayClipAtPoint(BanchoFinalYan, base.transform.position);
			CharacterAnimation.CrossFade("f02_banchoFinisher_00");
			BanchoFlurry.MyCollider.enabled = false;
			Finisher = true;
			CanMove = false;
		}
	}

	private void SetUniform()
	{
		if (StudentGlobals.FemaleUniform == 0)
		{
			StudentGlobals.FemaleUniform = 1;
		}
		MyRenderer.sharedMesh = Uniforms[StudentGlobals.FemaleUniform];
		if (Casual)
		{
			TextureToUse = UniformTextures[StudentGlobals.FemaleUniform];
		}
		else
		{
			TextureToUse = CasualTextures[StudentGlobals.FemaleUniform];
		}
		MyRenderer.materials[0].mainTexture = TextureToUse;
		MyRenderer.materials[1].mainTexture = TextureToUse;
		MyRenderer.materials[2].mainTexture = FaceTexture;
		StartCoroutine(ApplyCustomCostume());
	}

	private IEnumerator ApplyCustomCostume()
	{
		if (StudentGlobals.FemaleUniform == 1)
		{
			WWW CustomUniform = new WWW("file:///" + Application.streamingAssetsPath + "/CustomUniform.png");
			yield return CustomUniform;
			if (CustomUniform.error == null)
			{
				MyRenderer.materials[0].mainTexture = CustomUniform.texture;
				MyRenderer.materials[1].mainTexture = CustomUniform.texture;
			}
		}
		else if (StudentGlobals.FemaleUniform == 2)
		{
			WWW CustomLong = new WWW("file:///" + Application.streamingAssetsPath + "/CustomLong.png");
			yield return CustomLong;
			if (CustomLong.error == null)
			{
				MyRenderer.materials[0].mainTexture = CustomLong.texture;
				MyRenderer.materials[1].mainTexture = CustomLong.texture;
			}
		}
		else if (StudentGlobals.FemaleUniform == 3)
		{
			WWW CustomSweater = new WWW("file:///" + Application.streamingAssetsPath + "/CustomSweater.png");
			yield return CustomSweater;
			if (CustomSweater.error == null)
			{
				MyRenderer.materials[0].mainTexture = CustomSweater.texture;
				MyRenderer.materials[1].mainTexture = CustomSweater.texture;
			}
		}
		else if (StudentGlobals.FemaleUniform == 4 || StudentGlobals.FemaleUniform == 5)
		{
			WWW CustomBlazer = new WWW("file:///" + Application.streamingAssetsPath + "/CustomBlazer.png");
			yield return CustomBlazer;
			if (CustomBlazer.error == null)
			{
				MyRenderer.materials[0].mainTexture = CustomBlazer.texture;
				MyRenderer.materials[1].mainTexture = CustomBlazer.texture;
			}
		}
		WWW CustomFace = new WWW("file:///" + Application.streamingAssetsPath + "/CustomFace.png");
		yield return CustomFace;
		if (CustomFace.error == null)
		{
			MyRenderer.materials[2].mainTexture = CustomFace.texture;
			FaceTexture = CustomFace.texture;
		}
		WWW CustomHair = new WWW("file:///" + Application.streamingAssetsPath + "/CustomHair.png");
		yield return CustomHair;
		if (CustomHair.error == null)
		{
			PonytailRenderer.material.mainTexture = CustomHair.texture;
			PigtailR.material.mainTexture = CustomHair.texture;
			PigtailL.material.mainTexture = CustomHair.texture;
		}
		WWW CustomDrills = new WWW("file:///" + Application.streamingAssetsPath + "/CustomDrills.png");
		yield return CustomDrills;
		if (CustomDrills.error == null)
		{
			Drills.materials[0].mainTexture = CustomDrills.texture;
			Drills.material.mainTexture = CustomDrills.texture;
		}
		WWW CustomSwimsuit = new WWW("file:///" + Application.streamingAssetsPath + "/CustomSwimsuit.png");
		yield return CustomSwimsuit;
		if (CustomSwimsuit.error == null)
		{
			SwimsuitTexture = CustomSwimsuit.texture;
		}
		WWW CustomGym = new WWW("file:///" + Application.streamingAssetsPath + "/CustomGym.png");
		yield return CustomGym;
		if (CustomGym.error == null)
		{
			GymTexture = CustomGym.texture;
		}
		WWW CustomNude = new WWW("file:///" + Application.streamingAssetsPath + "/CustomNude.png");
		yield return CustomNude;
		if (CustomNude.error == null)
		{
			NudeTexture = CustomNude.texture;
		}
		WWW CustomLongHairA = new WWW("file:///" + Application.streamingAssetsPath + "/CustomLongHairA.png");
		yield return CustomDrills;
		WWW CustomLongHairB = new WWW("file:///" + Application.streamingAssetsPath + "/CustomLongHairB.png");
		yield return CustomDrills;
		WWW CustomLongHairC = new WWW("file:///" + Application.streamingAssetsPath + "/CustomLongHairC.png");
		yield return CustomDrills;
		if (CustomLongHairA.error == null && CustomLongHairB.error == null && CustomLongHairC.error == null)
		{
			LongHairRenderer.materials[0].mainTexture = CustomLongHairA.texture;
			LongHairRenderer.materials[1].mainTexture = CustomLongHairB.texture;
			LongHairRenderer.materials[2].mainTexture = CustomLongHairC.texture;
		}
	}

	public void WearGloves()
	{
		if (Bloodiness > 0f && !Gloves.Blood.enabled)
		{
			Gloves.PickUp.Evidence = true;
			Gloves.Blood.enabled = true;
			Police.BloodyClothing++;
		}
		Gloved = true;
		if (StudentGlobals.FemaleUniform == 1)
		{
			MyRenderer.materials[1].mainTexture = GloveTextures[StudentGlobals.FemaleUniform];
		}
		else
		{
			MyRenderer.materials[0].mainTexture = GloveTextures[StudentGlobals.FemaleUniform];
		}
	}

	private void AttackOnTitan()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MusicCredit.SongLabel.text = "Now Playing: This Is My Choice";
		MusicCredit.BandLabel.text = "By: The Kira Justice";
		MusicCredit.Panel.enabled = true;
		MusicCredit.Slide = true;
		EasterEggMenu.SetActive(false);
		Egg = true;
		MyRenderer.sharedMesh = Uniforms[1];
		MyRenderer.materials[0].mainTexture = TitanTexture;
		MyRenderer.materials[1].mainTexture = TitanTexture;
		MyRenderer.materials[2].mainTexture = FaceTexture;
		Outline.h.ReinitMaterials();
	}

	private void KON()
	{
		MyRenderer.sharedMesh = Uniforms[4];
		MyRenderer.materials[0].mainTexture = KONTexture;
		MyRenderer.materials[1].mainTexture = KONTexture;
		MyRenderer.materials[2].mainTexture = FaceTexture;
		Outline.h.ReinitMaterials();
	}

	private void Punish()
	{
		PunishedShader = Shader.Find("Toon/Cutoff");
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		EasterEggMenu.SetActive(false);
		Egg = true;
		PunishedAccessories.SetActive(true);
		PunishedScarf.SetActive(true);
		EyepatchL.SetActive(false);
		EyepatchR.SetActive(false);
		for (ID = 0; ID < PunishedArm.Length; ID++)
		{
			PunishedArm[ID].SetActive(true);
		}
		MyRenderer.sharedMesh = PunishedMesh;
		MyRenderer.materials[0].mainTexture = PunishedTextures[1];
		MyRenderer.materials[1].mainTexture = PunishedTextures[1];
		MyRenderer.materials[2].mainTexture = PunishedTextures[0];
		MyRenderer.materials[1].shader = PunishedShader;
		MyRenderer.materials[1].SetFloat("_Shininess", 1f);
		MyRenderer.materials[1].SetFloat("_ShadowThreshold", 0f);
		MyRenderer.materials[1].SetFloat("_Cutoff", 0.9f);
		Outline.h.ReinitMaterials();
	}

	private void Hate()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.sharedMesh = Uniforms[1];
		MyRenderer.materials[0].mainTexture = HatefulUniform;
		MyRenderer.materials[1].mainTexture = HatefulUniform;
		MyRenderer.materials[2].mainTexture = FaceTexture;
		RenderSettings.skybox = HatefulSkybox;
		SelectGrayscale.desaturation = 1f;
		HeartRate.gameObject.SetActive(false);
		Sanity = 0f;
		Hairstyle = 15;
		UpdateHair();
		EasterEggMenu.SetActive(false);
		Egg = true;
	}

	private void Sukeban()
	{
		IdleAnim = "f02_idle_00";
		SukebanAccessories.SetActive(true);
		MyRenderer.sharedMesh = Uniforms[1];
		MyRenderer.materials[1].mainTexture = SukebanBandages;
		MyRenderer.materials[0].mainTexture = SukebanUniform;
		MyRenderer.materials[2].mainTexture = FaceTexture;
		EasterEggMenu.SetActive(false);
		Egg = true;
	}

	private void Bancho()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		BanchoCamera.SetActive(true);
		MotionObject.enabled = true;
		MotionBlur.enabled = true;
		BanchoAccessories[0].SetActive(true);
		BanchoAccessories[1].SetActive(true);
		BanchoAccessories[2].SetActive(true);
		BanchoAccessories[3].SetActive(true);
		BanchoAccessories[4].SetActive(true);
		BanchoAccessories[5].SetActive(true);
		BanchoAccessories[6].SetActive(true);
		BanchoAccessories[7].SetActive(true);
		BanchoAccessories[8].SetActive(true);
		Laugh1 = BanchoYanYan;
		Laugh2 = BanchoYanYan;
		Laugh3 = BanchoYanYan;
		Laugh4 = BanchoYanYan;
		IdleAnim = "f02_banchoIdle_00";
		WalkAnim = "f02_banchoWalk_00";
		RunAnim = "f02_banchoSprint_00";
		OriginalIdleAnim = IdleAnim;
		OriginalWalkAnim = WalkAnim;
		OriginalRunAnim = RunAnim;
		RunSpeed *= 2f;
		BanchoPants.SetActive(true);
		MyRenderer.sharedMesh = BanchoMesh;
		MyRenderer.materials[0].mainTexture = BanchoFace;
		MyRenderer.materials[1].mainTexture = BanchoBody;
		MyRenderer.materials[2].mainTexture = BanchoBody;
		BanchoActive = true;
		TheDebugMenuScript.UpdateCensor();
		Character.transform.localPosition = new Vector3(0f, 0.04f, 0f);
		Hairstyle = 0;
		UpdateHair();
		EasterEggMenu.SetActive(false);
		Egg = true;
	}

	private void Slend()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		RenderSettings.skybox = SlenderSkybox;
		SelectGrayscale.desaturation = 0.5f;
		SelectGrayscale.enabled = true;
		EasterEggMenu.SetActive(false);
		Slender = true;
		Egg = true;
		Hairstyle = 0;
		UpdateHair();
		SlenderHair[0].transform.parent.gameObject.SetActive(true);
		SlenderHair[0].SetActive(true);
		SlenderHair[1].SetActive(true);
		RightYandereEye.gameObject.SetActive(false);
		LeftYandereEye.gameObject.SetActive(false);
		Character.transform.localPosition = new Vector3(Character.transform.localPosition.x, 0.822f, Character.transform.localPosition.z);
		MyRenderer.sharedMesh = Uniforms[1];
		MyRenderer.materials[0].mainTexture = SlenderUniform;
		MyRenderer.materials[1].mainTexture = SlenderUniform;
		MyRenderer.materials[2].mainTexture = SlenderSkin;
		Sanity = 0f;
	}

	private void X()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		Xtan = true;
		Egg = true;
		Hairstyle = 9;
		UpdateHair();
		BlackEyePatch.SetActive(true);
		XSclera.SetActive(true);
		XEye.SetActive(true);
		Schoolwear = 2;
		ChangeSchoolwear();
		CanMove = true;
		MyRenderer.materials[0].mainTexture = XBody;
		MyRenderer.materials[1].mainTexture = XBody;
		MyRenderer.materials[2].mainTexture = XFace;
	}

	private void GaloSengen()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		IdleAnim = "f02_gruntIdle_00";
		EasterEggMenu.SetActive(false);
		Egg = true;
		for (ID = 0; ID < GaloAccessories.Length; ID++)
		{
			GaloAccessories[ID].SetActive(true);
		}
		MyRenderer.sharedMesh = Uniforms[1];
		MyRenderer.materials[0].mainTexture = UniformTextures[1];
		MyRenderer.materials[1].mainTexture = GaloArms;
		MyRenderer.materials[2].mainTexture = GaloFace;
		Hairstyle = 14;
		UpdateHair();
	}

	public void Jojo()
	{
		ShoulderCamera.LastPosition = ShoulderCamera.transform.position;
		ShoulderCamera.Summoning = true;
		RPGCamera.enabled = false;
		AudioSource.PlayClipAtPoint(SummonStand, base.transform.position);
		IdleAnim = "f02_jojoPose_00";
		WalkAnim = "f02_jojoWalk_00";
		EasterEggMenu.SetActive(false);
		CanMove = false;
		Egg = true;
		CharacterAnimation.CrossFade("f02_summonStand_00");
		Laugh1 = YanYan;
		Laugh2 = YanYan;
		Laugh3 = YanYan;
		Laugh4 = YanYan;
	}

	private void Agent()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.sharedMesh = Uniforms[4];
		MyRenderer.materials[0].mainTexture = AgentSuit;
		MyRenderer.materials[1].mainTexture = AgentSuit;
		MyRenderer.materials[2].mainTexture = AgentFace;
		EasterEggMenu.SetActive(false);
		Egg = true;
		Hairstyle = 0;
		UpdateHair();
	}

	private void Cirno()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.sharedMesh = Uniforms[3];
		MyRenderer.materials[0].mainTexture = CirnoUniform;
		MyRenderer.materials[1].mainTexture = CirnoUniform;
		MyRenderer.materials[2].mainTexture = CirnoFace;
		CirnoWings.SetActive(true);
		CirnoHair.SetActive(true);
		IdleAnim = "f02_cirnoIdle_00";
		WalkAnim = "f02_cirnoWalk_00";
		RunAnim = "f02_cirnoRun_00";
		EasterEggMenu.SetActive(false);
		Stance.Current = StanceType.Standing;
		Uncrouch();
		Egg = true;
		Hairstyle = 0;
		UpdateHair();
	}

	private void Falcon()
	{
		MyRenderer.sharedMesh = SchoolSwimsuit;
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[0].mainTexture = FalconBody;
		MyRenderer.materials[1].mainTexture = FalconBody;
		MyRenderer.materials[2].mainTexture = FalconFace;
		FalconShoulderpad.SetActive(true);
		FalconNipple1.SetActive(true);
		FalconNipple2.SetActive(true);
		FalconBuckle.SetActive(true);
		FalconHelmet.SetActive(true);
		FalconGun.SetActive(true);
		CharacterAnimation[RunAnim].speed = 5f;
		IdleAnim = "f02_falconIdle_00";
		RunSpeed *= 5f;
		Egg = true;
		Hairstyle = 0;
		UpdateHair();
	}

	private void Punch()
	{
		MusicCredit.SongLabel.text = "Now Playing: Unknown Hero";
		MusicCredit.BandLabel.text = "By: The Kira Justice";
		MusicCredit.Panel.enabled = true;
		MusicCredit.Slide = true;
		MyRenderer.sharedMesh = SchoolSwimsuit;
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[0].mainTexture = SaitamaSuit;
		MyRenderer.materials[1].mainTexture = SaitamaSuit;
		MyRenderer.materials[2].mainTexture = FaceTexture;
		EasterEggMenu.SetActive(false);
		Barcode.SetActive(false);
		Cape.SetActive(true);
		Egg = true;
		Hairstyle = 0;
		UpdateHair();
	}

	private void BadTime()
	{
		MyRenderer.sharedMesh = Jersey;
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[0].mainTexture = SansFace;
		MyRenderer.materials[1].mainTexture = SansTexture;
		MyRenderer.materials[2].mainTexture = SansTexture;
		EasterEggMenu.SetActive(false);
		IdleAnim = "f02_sansIdle_00";
		WalkAnim = "f02_sansWalk_00";
		RunAnim = "f02_sansRun_00";
		StudentManager.BadTime();
		Barcode.SetActive(false);
		Sans = true;
		Egg = true;
		Hairstyle = 0;
		UpdateHair();
	}

	private void CyborgNinja()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		EnergySword.SetActive(true);
		IdleAnim = "CyborgNinja_Idle_Unarmed";
		RunAnim = "CyborgNinja_Run_Unarmed";
		MyRenderer.sharedMesh = NudeMesh;
		MyRenderer.materials[0].mainTexture = CyborgFace;
		MyRenderer.materials[1].mainTexture = CyborgBody;
		MyRenderer.materials[2].mainTexture = CyborgBody;
		Schoolwear = 0;
		for (ID = 1; ID < CyborgParts.Length; ID++)
		{
			CyborgParts[ID].SetActive(true);
		}
		for (ID = 1; ID < StudentManager.Students.Length; ID++)
		{
			StudentScript studentScript = StudentManager.Students[ID];
			if (studentScript != null)
			{
				studentScript.Teacher = false;
			}
		}
		RunSpeed *= 2f;
		EyewearID = 6;
		Hairstyle = 45;
		UpdateHair();
		Egg = true;
		DebugMenu.transform.parent.GetComponent<DebugMenuScript>().UpdateCensor();
	}

	private void Ebola()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		IdleAnim = "f02_ebolaIdle_00";
		MyRenderer.sharedMesh = Uniforms[1];
		MyRenderer.materials[0].mainTexture = EbolaUniform;
		MyRenderer.materials[1].mainTexture = EbolaUniform;
		MyRenderer.materials[2].mainTexture = EbolaFace;
		Hairstyle = 0;
		UpdateHair();
		EbolaWings.SetActive(true);
		EbolaHair.SetActive(true);
		Egg = true;
	}

	private void Long()
	{
		MyRenderer.sharedMesh = LongUniform;
	}

	private void SwapMesh()
	{
		MyRenderer.sharedMesh = NewMesh;
		MyRenderer.materials[0].mainTexture = TextureToUse;
		MyRenderer.materials[1].mainTexture = NewFace;
		MyRenderer.materials[2].mainTexture = TextureToUse;
		RightYandereEye.gameObject.SetActive(false);
		LeftYandereEye.gameObject.SetActive(false);
	}

	private void Nude()
	{
		Debug.Log("Making Yandere-chan nude.");
		MyRenderer.sharedMesh = NudeMesh;
		MyRenderer.materials[0].mainTexture = FaceTexture;
		MyRenderer.materials[1].mainTexture = NudeTexture;
		for (ID = 0; ID < CensorSteam.Length; ID++)
		{
			CensorSteam[ID].SetActive(true);
		}
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[0].SetFloat("_BlendAmount1", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount1", 0f);
		EasterEggMenu.SetActive(false);
		ClubAttire = false;
		Schoolwear = 0;
		ClubAccessory();
	}

	private void Samus()
	{
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.sharedMesh = NudeMesh;
		MyRenderer.materials[0].mainTexture = SamusFace;
		MyRenderer.materials[1].mainTexture = SamusBody;
		PantyAttacher.newRenderer.enabled = false;
		Schoolwear = 0;
		PonytailRenderer.material.mainTexture = SamusFace;
		Egg = true;
		DebugMenu.transform.parent.GetComponent<DebugMenuScript>().UpdateCensor();
	}

	private void Witch()
	{
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.sharedMesh = NudeMesh;
		MyRenderer.materials[0].mainTexture = WitchFace;
		MyRenderer.materials[1].mainTexture = WitchBody;
		PantyAttacher.newRenderer.enabled = false;
		Schoolwear = 0;
		PonytailRenderer.material.mainTexture = WitchFace;
		Egg = true;
		DebugMenu.transform.parent.GetComponent<DebugMenuScript>().UpdateCensor();
	}

	private void Pose()
	{
		if (!StudentManager.Pose)
		{
			StudentManager.Pose = true;
		}
		else
		{
			StudentManager.Pose = false;
		}
		StudentManager.UpdateStudents();
	}

	private void HairBlades()
	{
		Hairstyle = 0;
		UpdateHair();
		BladeHair.SetActive(true);
		Egg = true;
	}

	private void Tornado()
	{
		Hairstyle = 0;
		UpdateHair();
		IdleAnim = "f02_tornadoIdle_00";
		WalkAnim = "f02_tornadoWalk_00";
		RunAnim = "f02_tornadoRun_00";
		TornadoHair.SetActive(true);
		TornadoDress.SetActive(true);
		RiggedAccessory.SetActive(true);
		MyRenderer.sharedMesh = NoTorsoMesh;
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		Sanity = 100f;
		MyRenderer.materials[0].mainTexture = FaceTexture;
		MyRenderer.materials[1].mainTexture = NudePanties;
		MyRenderer.materials[2].mainTexture = NudePanties;
		TheDebugMenuScript.UpdateCensor();
		Stance.Current = StanceType.Standing;
		Egg = true;
	}

	private void GenderSwap()
	{
		Kun.SetActive(true);
		KunHair.SetActive(true);
		MyRenderer.enabled = false;
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		IdleAnim = "idleShort_00";
		WalkAnim = "walk_00";
		RunAnim = "newSprint_00";
		OriginalIdleAnim = IdleAnim;
		OriginalWalkAnim = WalkAnim;
		OriginalRunAnim = RunAnim;
		Hairstyle = 0;
		UpdateHair();
	}

	private void KizunaAI()
	{
		AudioSource.PlayClipAtPoint(HaiDomo, base.transform.position);
		RightYandereEye.enabled = false;
		LeftYandereEye.enabled = false;
		Kizuna.SetActive(true);
		MyRenderer.enabled = false;
		IdleAnim = "f02_idleGirly_00";
		OriginalIdleAnim = IdleAnim;
		OriginalWalkAnim = WalkAnim;
		OriginalRunAnim = RunAnim;
		Hairstyle = 0;
		UpdateHair();
	}

	private void Sith()
	{
		Hairstyle = 67;
		UpdateHair();
		SithTrail1.SetActive(true);
		SithTrail2.SetActive(true);
		IdleAnim = "f02_sithIdle_00";
		WalkAnim = "f02_sithWalk_00";
		RunAnim = "f02_sithRun_00";
		BlackRobe.SetActive(true);
		MyRenderer.sharedMesh = NoUpperBodyMesh;
		MyRenderer.materials[0].mainTexture = NudePanties;
		MyRenderer.materials[1].mainTexture = FaceTexture;
		MyRenderer.materials[2].mainTexture = NudePanties;
		Stance.Current = StanceType.Standing;
		FollowHips = true;
		SithLord = true;
		Egg = true;
		TheDebugMenuScript.UpdateCensor();
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		RunSpeed *= 2f;
		Zoom.TargetZoom = 0.4f;
	}

	private void Snake()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.sharedMesh = Uniforms[1];
		MyRenderer.materials[0].mainTexture = SnakeBody;
		MyRenderer.materials[1].mainTexture = SnakeBody;
		MyRenderer.materials[2].mainTexture = SnakeFace;
		Hairstyle = 161;
		UpdateHair();
		Medusa = true;
		Egg = true;
	}

	private void Gazer()
	{
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		GazerEyes.gameObject.SetActive(true);
		MyRenderer.sharedMesh = NudeMesh;
		MyRenderer.materials[0].mainTexture = GazerFace;
		MyRenderer.materials[1].mainTexture = GazerBody;
		MyRenderer.materials[2].mainTexture = GazerBody;
		PantyAttacher.newRenderer.enabled = false;
		Schoolwear = 0;
		IdleAnim = "f02_gazerIdle_00";
		WalkAnim = "f02_gazerWalk_00";
		RunAnim = "f02_gazerRun_00";
		OriginalIdleAnim = IdleAnim;
		OriginalWalkAnim = WalkAnim;
		OriginalRunAnim = RunAnim;
		Hairstyle = 158;
		UpdateHair();
		StudentManager.Gaze = true;
		StudentManager.UpdateStudents();
		Gazing = true;
		Egg = true;
		DebugMenu.transform.parent.GetComponent<DebugMenuScript>().UpdateCensor();
	}

	private void Six()
	{
		RenderSettings.skybox = HatefulSkybox;
		Hairstyle = 0;
		UpdateHair();
		IdleAnim = "f02_sixIdle_00";
		WalkAnim = "f02_sixWalk_00";
		RunAnim = "f02_sixRun_00";
		OriginalIdleAnim = IdleAnim;
		OriginalWalkAnim = WalkAnim;
		OriginalRunAnim = RunAnim;
		SixRaincoat.SetActive(true);
		MyRenderer.sharedMesh = SixBodyMesh;
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[0].mainTexture = SixFaceTexture;
		MyRenderer.materials[1].mainTexture = NudeTexture;
		MyRenderer.materials[2].mainTexture = NudeTexture;
		TheDebugMenuScript.UpdateCensor();
		SchoolGlobals.SchoolAtmosphere = 0f;
		StudentManager.SetAtmosphere();
		StudentManager.Six = true;
		StudentManager.UpdateStudents();
		WalkSpeed = 0.75f;
		RunSpeed = 2f;
		Hungry = true;
		Egg = true;
	}

	private void KLK()
	{
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		KLKSword.SetActive(true);
		IdleAnim = "f02_heroicIdle_00";
		WalkAnim = "f02_walkConfident_00";
		MyRenderer.sharedMesh = NudeMesh;
		MyRenderer.materials[0].mainTexture = KLKFace;
		MyRenderer.materials[1].mainTexture = KLKBody;
		MyRenderer.materials[2].mainTexture = KLKBody;
		PantyAttacher.newRenderer.enabled = false;
		Schoolwear = 0;
		for (ID = 0; ID < KLKParts.Length; ID++)
		{
			KLKParts[ID].SetActive(true);
		}
		for (ID = 1; ID < StudentManager.Students.Length; ID++)
		{
			StudentScript studentScript = StudentManager.Students[ID];
			if (studentScript != null)
			{
				studentScript.Teacher = false;
			}
		}
		Egg = true;
		DebugMenu.transform.parent.GetComponent<DebugMenuScript>().UpdateCensor();
	}

	public void ChangeSchoolwear()
	{
		PantyAttacher.newRenderer.enabled = false;
		RightFootprintSpawner.Bloodiness = 0;
		LeftFootprintSpawner.Bloodiness = 0;
		if (ClubAttire && Bloodiness == 0f)
		{
			Schoolwear = PreviousSchoolwear;
		}
		LabcoatAttacher.RemoveAccessory();
		Paint = false;
		for (ID = 0; ID < CensorSteam.Length; ID++)
		{
			CensorSteam[ID].SetActive(false);
		}
		if (Casual)
		{
			TextureToUse = UniformTextures[StudentGlobals.FemaleUniform];
		}
		else
		{
			TextureToUse = CasualTextures[StudentGlobals.FemaleUniform];
		}
		if ((ClubAttire && Bloodiness > 0f) || Schoolwear == 0)
		{
			Nude();
		}
		else if (Schoolwear == 1)
		{
			PantyAttacher.newRenderer.enabled = true;
			MyRenderer.sharedMesh = Uniforms[StudentGlobals.FemaleUniform];
			MyRenderer.materials[1].SetFloat("_BlendAmount", 1f);
			if (StudentManager.Censor)
			{
				Debug.Log("Activating shadows on Yandere-chan.");
				MyRenderer.materials[0].SetFloat("_BlendAmount1", 1f);
				MyRenderer.materials[1].SetFloat("_BlendAmount1", 1f);
				PantyAttacher.newRenderer.enabled = false;
			}
			MyRenderer.materials[0].mainTexture = TextureToUse;
			MyRenderer.materials[1].mainTexture = TextureToUse;
			MyRenderer.materials[2].mainTexture = FaceTexture;
			StartCoroutine(ApplyCustomCostume());
		}
		else if (Schoolwear == 2)
		{
			MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
			MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
			MyRenderer.materials[0].SetFloat("_BlendAmount1", 0f);
			MyRenderer.materials[1].SetFloat("_BlendAmount1", 0f);
			MyRenderer.sharedMesh = SchoolSwimsuit;
			MyRenderer.materials[0].mainTexture = SwimsuitTexture;
			MyRenderer.materials[1].mainTexture = SwimsuitTexture;
			MyRenderer.materials[2].mainTexture = FaceTexture;
		}
		else if (Schoolwear == 3)
		{
			MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
			MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
			MyRenderer.materials[0].SetFloat("_BlendAmount1", 0f);
			MyRenderer.materials[1].SetFloat("_BlendAmount1", 0f);
			MyRenderer.sharedMesh = GymUniform;
			MyRenderer.materials[0].mainTexture = GymTexture;
			MyRenderer.materials[1].mainTexture = GymTexture;
			MyRenderer.materials[2].mainTexture = FaceTexture;
		}
		CanMove = false;
		Outline.h.ReinitMaterials();
		ClubAccessory();
	}

	public void ChangeClubwear()
	{
		PantyAttacher.newRenderer.enabled = false;
		MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		MyRenderer.materials[0].SetFloat("_BlendAmount1", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount1", 0f);
		Paint = false;
		if (!ClubAttire)
		{
			ClubAttire = true;
			if (ClubGlobals.Club == ClubType.Art)
			{
				MyRenderer.sharedMesh = ApronMesh;
				MyRenderer.materials[0].mainTexture = ApronTexture;
				MyRenderer.materials[1].mainTexture = ApronTexture;
				MyRenderer.materials[2].mainTexture = FaceTexture;
				Schoolwear = 4;
				Paint = true;
			}
			else if (ClubGlobals.Club == ClubType.MartialArts)
			{
				MyRenderer.sharedMesh = JudoGiMesh;
				MyRenderer.materials[0].mainTexture = JudoGiTexture;
				MyRenderer.materials[1].mainTexture = JudoGiTexture;
				MyRenderer.materials[2].mainTexture = FaceTexture;
				Schoolwear = 5;
			}
			else if (ClubGlobals.Club == ClubType.Science)
			{
				LabcoatAttacher.enabled = true;
				MyRenderer.sharedMesh = HeadAndHands;
				if (LabcoatAttacher.Initialized)
				{
					LabcoatAttacher.AttachAccessory();
				}
				MyRenderer.materials[0].mainTexture = FaceTexture;
				MyRenderer.materials[1].mainTexture = NudeTexture;
				MyRenderer.materials[2].mainTexture = NudeTexture;
				Schoolwear = 6;
			}
		}
		else
		{
			ChangeSchoolwear();
			ClubAttire = false;
		}
		MyLocker.UpdateButtons();
	}

	public void ClubAccessory()
	{
		for (ID = 0; ID < ClubAccessories.Length; ID++)
		{
			GameObject gameObject = ClubAccessories[ID];
			if (gameObject != null)
			{
				gameObject.SetActive(false);
			}
		}
		if (!CensorSteam[0].activeInHierarchy && ClubGlobals.Club > ClubType.None && ClubAccessories[(int)ClubGlobals.Club] != null)
		{
			ClubAccessories[(int)ClubGlobals.Club].SetActive(true);
		}
	}

	public void StopCarrying()
	{
		if (Ragdoll != null)
		{
			Ragdoll.GetComponent<RagdollScript>().Fall();
		}
		HeavyWeight = false;
		Carrying = false;
		IdleAnim = OriginalIdleAnim;
		WalkAnim = OriginalWalkAnim;
		RunAnim = OriginalRunAnim;
	}

	private void Crouch()
	{
		MyController.center = new Vector3(MyController.center.x, 0.55f, MyController.center.z);
		MyController.height = 0.9f;
	}

	private void Crawl()
	{
		MyController.center = new Vector3(MyController.center.x, 0.25f, MyController.center.z);
		MyController.height = 0.1f;
	}

	private void Uncrouch()
	{
		MyController.center = new Vector3(MyController.center.x, 0.875f, MyController.center.z);
		MyController.height = 1.55f;
	}

	private void StopArmedAnim()
	{
		for (ID = 0; ID < ArmedAnims.Length; ID++)
		{
			string text = ArmedAnims[ID];
			CharacterAnimation[text].weight = Mathf.Lerp(CharacterAnimation[text].weight, 0f, Time.deltaTime * 10f);
		}
	}

	private void UpdateAccessory()
	{
		if (AccessoryGroup != null)
		{
			AccessoryGroup.SetPartsActive(false);
		}
		if (AccessoryID > Accessories.Length - 1)
		{
			AccessoryID = 0;
		}
		if (AccessoryID < 0)
		{
			AccessoryID = Accessories.Length - 1;
		}
		if (AccessoryID > 0)
		{
			Accessories[AccessoryID].SetActive(true);
			AccessoryGroup = Accessories[AccessoryID].GetComponent<AccessoryGroupScript>();
			if (AccessoryGroup != null)
			{
				AccessoryGroup.SetPartsActive(true);
			}
		}
	}

	private void DisableHairAndAccessories()
	{
		for (ID = 1; ID < Accessories.Length; ID++)
		{
			Accessories[ID].SetActive(false);
		}
		for (ID = 1; ID < Hairstyles.Length; ID++)
		{
			Hairstyles[ID].SetActive(false);
		}
	}

	public void BullyPhotoCheck()
	{
		Debug.Log("We are now going to perform a bully photo check.");
		for (int i = 1; i < 26; i++)
		{
			if (PlayerGlobals.GetBullyPhoto(i) > 0)
			{
				Debug.Log("Yandere-chan has a bully photo in her photo gallery!");
				BullyPhoto = true;
			}
		}
	}

	public void UpdatePersona(int NewPersona)
	{
		switch (NewPersona)
		{
		case 0:
			Persona = YanderePersonaType.Default;
			break;
		case 1:
			Persona = YanderePersonaType.Chill;
			break;
		case 2:
			Persona = YanderePersonaType.Confident;
			break;
		case 3:
			Persona = YanderePersonaType.Elegant;
			break;
		case 4:
			Persona = YanderePersonaType.Girly;
			break;
		case 5:
			Persona = YanderePersonaType.Graceful;
			break;
		case 6:
			Persona = YanderePersonaType.Haughty;
			break;
		case 7:
			Persona = YanderePersonaType.Lively;
			break;
		case 8:
			Persona = YanderePersonaType.Scholarly;
			break;
		case 9:
			Persona = YanderePersonaType.Shy;
			break;
		case 10:
			Persona = YanderePersonaType.Tough;
			break;
		case 11:
			Persona = YanderePersonaType.Aggressive;
			break;
		case 12:
			Persona = YanderePersonaType.Grunt;
			break;
		}
	}

	private void SithSoundCheck()
	{
		if (SithBeam[1].Damage == 10f)
		{
			if (SithSounds == 0 && CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= SithSpawnTime[SithCombo] - 0.1f)
			{
				SithAudio.pitch = Random.Range(0.9f, 1.1f);
				SithAudio.Play();
				SithSounds++;
			}
		}
		else if (SithSounds == 0)
		{
			if (CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= SithHardSpawnTime1[SithCombo] - 0.1f)
			{
				SithAudio.pitch = Random.Range(0.9f, 1.1f);
				SithAudio.Play();
				SithSounds++;
			}
		}
		else if (SithSounds == 1)
		{
			if (CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= SithHardSpawnTime2[SithCombo] - 0.1f)
			{
				SithAudio.pitch = Random.Range(0.9f, 1.1f);
				SithAudio.Play();
				SithSounds++;
			}
		}
		else if (SithSounds == 2 && SithCombo == 1 && CharacterAnimation["f02_sithAttack" + SithPrefix + "_0" + SithCombo].time >= 5f / 6f)
		{
			SithAudio.pitch = Random.Range(0.9f, 1.1f);
			SithAudio.Play();
			SithSounds++;
		}
	}
}
