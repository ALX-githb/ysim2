#pragma warning disable 618 // Unity-deprecated APIs (AIBase.target, AIPath.speed, WWW, GetInstanceID, CF2Input.GetKeyDown(string), Physics2D.OverlapPointNonAlloc) still functional; full migration would change behavior or require coroutine refactors.
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CosmeticScript : MonoBehaviour
{
	public SkinnedMeshRenderer BlendshapesRenderer;

	public StudentManagerScript StudentManager;

	public TextureManagerScript TextureManager;

	public SkinnedMeshUpdater SkinUpdater;

	public LoveManagerScript LoveManager;

	public Animation CharacterAnimation;

	public ModelSwapScript ModelSwap;

	public StudentScript Student;

	public JsonScript JSON;

	public GameObject[] TeacherAccessories;

	public GameObject[] FemaleAccessories;

	public GameObject[] MaleAccessories;

	public GameObject[] ClubAccessories;

	public GameObject[] RightStockings;

	public GameObject[] LeftStockings;

	public GameObject[] PhoneCharms;

	public GameObject[] TeacherHair;

	public GameObject[] FacialHair;

	public GameObject[] FemaleHair;

	public GameObject[] MaleHair;

	public GameObject[] Scanners;

	public GameObject[] Eyewear;

	public GameObject[] Goggles;

	public GameObject[] Flowers;

	public Renderer[] TeacherHairRenderers;

	public Renderer[] FacialHairRenderers;

	public Renderer[] FemaleHairRenderers;

	public Renderer[] MaleHairRenderers;

	public Renderer[] Fingernails;

	public Texture[] GanguroUniformTextures;

	public Texture[] GanguroCasualTextures;

	public Texture[] GanguroSocksTextures;

	public Texture[] OccultUniformTextures;

	public Texture[] OccultCasualTextures;

	public Texture[] OccultSocksTextures;

	public Texture[] FemaleUniformTextures;

	public Texture[] FemaleCasualTextures;

	public Texture[] FemaleSocksTextures;

	public Texture[] MaleUniformTextures;

	public Texture[] MaleCasualTextures;

	public Texture[] MaleSocksTextures;

	public Texture[] SmartphoneTextures;

	public Texture[] HoodieTextures;

	public Texture[] FaceTextures;

	public Texture[] SkinTextures;

	public Texture[] WristwearTextures;

	public Texture[] CardiganTextures;

	public Texture[] BookbagTextures;

	public Texture[] EyeTextures;

	public Texture[] CheekTextures;

	public Texture[] ForeheadTextures;

	public Texture[] MouthTextures;

	public Texture[] NoseTextures;

	public Texture[] Trunks;

	public Mesh[] FemaleUniforms;

	public Mesh[] MaleUniforms;

	public Mesh[] Berets;

	public Color[] BullyColor;

	public SkinnedMeshRenderer CardiganRenderer;

	public SkinnedMeshRenderer MyRenderer;

	public Renderer FacialHairRenderer;

	public Renderer RightEyeRenderer;

	public Renderer LeftEyeRenderer;

	public Renderer HoodieRenderer;

	public Renderer HairRenderer;

	public Mesh DelinquentMesh;

	public Mesh SchoolUniform;

	public Texture DefaultFaceTexture;

	public Texture TeacherBodyTexture;

	public Texture CoachPaleBodyTexture;

	public Texture CoachBodyTexture;

	public Texture CoachFaceTexture;

	public Texture UniformTexture;

	public Texture CasualTexture;

	public Texture SocksTexture;

	public Texture FaceTexture;

	public Texture SatomiFace;

	public Texture PurpleStockings;

	public Texture YellowStockings;

	public Texture BlackStockings;

	public Texture GreenStockings;

	public Texture BlueStockings;

	public Texture CyanStockings;

	public Texture RedStockings;

	public Texture BlackKneeSocks;

	public Texture GreenSocks;

	public Texture KizanaStockings;

	public Texture OsanaStockings;

	public Texture MarySueStockings;

	public Texture TurtleStockings;

	public Texture TigerStockings;

	public Texture BirdStockings;

	public Texture DragonStockings;

	public Texture SatomiSkin;

	public Texture[] CustomStockings;

	public Texture MyStockings;

	public Texture BlackBody;

	public Texture BlackFace;

	public Texture DelinquentUniformTexture;

	public Texture DelinquentCasualTexture;

	public Texture DelinquentSocksTexture;

	public GameObject RightIrisLight;

	public GameObject LeftIrisLight;

	public GameObject RightWristband;

	public GameObject LeftWristband;

	public GameObject Cardigan;

	public GameObject Bookbag;

	public GameObject ThickBrows;

	public GameObject Character;

	public GameObject RightShoe;

	public GameObject LeftShoe;

	public GameObject Armband;

	public GameObject Hoodie;

	public Transform RightBreast;

	public Transform LeftBreast;

	public Color CorrectColor;

	public Color ColorValue;

	public Mesh TeacherMesh;

	public Mesh CoachMesh;

	public Mesh NurseMesh;

	public bool TakingPortrait;

	public bool Initialized;

	public bool CustomEyes;

	public bool CustomHair;

	public bool HomeScene;

	public bool Kidnapped;

	public bool Randomize;

	public bool Cutscene;

	public bool TurnedOn;

	public bool Teacher;

	public bool Yandere;

	public bool Male;

	public float BreastSize;

	public string OriginalStockings = string.Empty;

	public string HairColor = string.Empty;

	public string Stockings = string.Empty;

	public string EyeColor = string.Empty;

	public string EyeType = string.Empty;

	public int FacialHairstyle;

	public int Accessory;

	public int Hairstyle;

	public int SkinColor;

	public int StudentID;

	public ClubType Club;

	public int ID;

	public GameObject[] GaloAccessories;

	public Material[] NurseMaterials;

	public GameObject CardiganPrefab;

	public int FaceID;

	public int SkinID;

	public int UniformID;

	public void Start()
	{
		CharacterAnimation = Character.GetComponent<Animation>();
		if (Kidnapped)
		{
		}
		if (RightShoe != null)
		{
			RightShoe.SetActive(false);
			LeftShoe.SetActive(false);
		}
		ColorValue = new Color(1f, 1f, 1f, 1f);
		if (JSON == null)
		{
			JSON = Student.JSON;
		}
		string empty = string.Empty;
		if (!Initialized)
		{
			Accessory = int.Parse(JSON.Students[StudentID].Accessory);
			Hairstyle = int.Parse(JSON.Students[StudentID].Hairstyle);
			Stockings = JSON.Students[StudentID].Stockings;
			BreastSize = JSON.Students[StudentID].BreastSize;
			EyeType = JSON.Students[StudentID].EyeType;
			HairColor = JSON.Students[StudentID].Color;
			EyeColor = JSON.Students[StudentID].Eyes;
			Club = JSON.Students[StudentID].Club;
			empty = JSON.Students[StudentID].Name;
			if (Yandere)
			{
				Accessory = 0;
				Hairstyle = 1;
				Stockings = "Black";
				BreastSize = 1f;
				HairColor = "White";
				EyeColor = "Black";
				Club = ClubType.None;
			}
			OriginalStockings = Stockings;
			Initialized = true;
		}
		if (empty == "Random")
		{
			Randomize = true;
			if (!Male)
			{
				empty = StudentManager.FirstNames[Random.Range(0, StudentManager.FirstNames.Length)] + " " + StudentManager.LastNames[Random.Range(0, StudentManager.LastNames.Length)];
				JSON.Students[StudentID].Name = empty;
				Student.Name = empty;
			}
			else
			{
				empty = StudentManager.MaleNames[Random.Range(0, StudentManager.MaleNames.Length)] + " " + StudentManager.LastNames[Random.Range(0, StudentManager.LastNames.Length)];
				JSON.Students[StudentID].Name = empty;
				Student.Name = empty;
			}
			if (MissionModeGlobals.MissionMode && MissionModeGlobals.MissionTarget == StudentID)
			{
				JSON.Students[StudentID].Name = MissionModeGlobals.MissionTargetName;
				Student.Name = MissionModeGlobals.MissionTargetName;
				empty = MissionModeGlobals.MissionTargetName;
			}
		}
		if (Randomize)
		{
			Teacher = false;
			BreastSize = Random.Range(0.5f, 2f);
			Accessory = 0;
			Club = ClubType.None;
			if (!Male)
			{
				Hairstyle = 1;
				while (Hairstyle == 1 || Hairstyle == 20 || Hairstyle == 21)
				{
					Hairstyle = Random.Range(1, FemaleHair.Length);
				}
			}
			else
			{
				SkinColor = Random.Range(0, SkinTextures.Length);
				Hairstyle = Random.Range(1, MaleHair.Length);
			}
		}
		if (!Male)
		{
			GameObject[] phoneCharms = PhoneCharms;
			foreach (GameObject gameObject in phoneCharms)
			{
				if (gameObject != null)
				{
					gameObject.SetActive(false);
				}
			}
			RightBreast.localScale = new Vector3(BreastSize, BreastSize, BreastSize);
			LeftBreast.localScale = new Vector3(BreastSize, BreastSize, BreastSize);
			RightWristband.SetActive(false);
			LeftWristband.SetActive(false);
			if (Club == ClubType.Bully)
			{
				if (!Kidnapped)
				{
					Student.SmartPhone.GetComponent<Renderer>().material.mainTexture = SmartphoneTextures[StudentID];
					Student.SmartPhone.transform.localPosition = new Vector3(0.01f, 0.005f, 0.01f);
					Student.SmartPhone.transform.localEulerAngles = new Vector3(0f, -160f, 165f);
				}
				RightWristband.GetComponent<Renderer>().material.mainTexture = WristwearTextures[StudentID];
				LeftWristband.GetComponent<Renderer>().material.mainTexture = WristwearTextures[StudentID];
				Bookbag.GetComponent<Renderer>().material.mainTexture = BookbagTextures[StudentID];
				HoodieRenderer.material.mainTexture = HoodieTextures[StudentID];
				if (PhoneCharms.Length > 0)
				{
					PhoneCharms[StudentID].SetActive(true);
				}
				if (StudentGlobals.FemaleUniform < 2 || StudentGlobals.FemaleUniform == 3)
				{
					RightWristband.SetActive(true);
					LeftWristband.SetActive(true);
				}
				Bookbag.SetActive(true);
				Hoodie.SetActive(true);
				for (int j = 0; j < 10; j++)
				{
					Fingernails[j].material.color = BullyColor[StudentID];
				}
			}
			else
			{
				for (int k = 0; k < 10; k++)
				{
					Fingernails[k].gameObject.SetActive(false);
				}
			}
			if (!Kidnapped && SceneManager.GetActiveScene().name == "PortraitScene")
			{
				if (StudentID == 32)
				{
					CharacterAnimation.Play("f02_shy_00");
					CharacterAnimation.Play("f02_shy_00");
					CharacterAnimation["f02_shy_00"].time = 1f;
				}
				else if (StudentID == 59)
				{
					CharacterAnimation.Play("f02_sleuthPortrait_00");
				}
				else if (StudentID == 60)
				{
					CharacterAnimation.Play("f02_sleuthPortrait_01");
				}
				else if (StudentID == 71)
				{
					CharacterAnimation.Play("f02_idleGirly_00");
					CharacterAnimation["f02_idleGirly_00"].time = 0f;
				}
				else if (StudentID == 72)
				{
					CharacterAnimation.Play("f02_idleGirly_00");
					CharacterAnimation["f02_idleGirly_00"].time = 0.66666f;
				}
				else if (StudentID == 73)
				{
					CharacterAnimation.Play("f02_idleGirly_00");
					CharacterAnimation["f02_idleGirly_00"].time = 1.33332f;
				}
				else if (StudentID == 74)
				{
					CharacterAnimation.Play("f02_idleGirly_00");
					CharacterAnimation["f02_idleGirly_00"].time = 1.99998f;
				}
				else if (StudentID == 75)
				{
					CharacterAnimation.Play("f02_idleGirly_00");
					CharacterAnimation["f02_idleGirly_00"].time = 2.66664f;
				}
				else if (StudentID == 81)
				{
					CharacterAnimation.Play("f02_socialCameraPose_00");
					base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y + 0.05f, base.transform.position.z);
				}
				else if (StudentID == 82)
				{
					CharacterAnimation.Play("f02_galPose_01");
				}
				else if (StudentID == 83)
				{
					CharacterAnimation.Play("f02_galPose_02");
				}
				else if (StudentID == 84)
				{
					CharacterAnimation.Play("f02_galPose_03");
				}
				else if (StudentID == 85)
				{
					CharacterAnimation.Play("f02_galPose_04");
				}
			}
		}
		else
		{
			ThickBrows.SetActive(false);
			GameObject[] galoAccessories = GaloAccessories;
			foreach (GameObject gameObject2 in galoAccessories)
			{
				gameObject2.SetActive(false);
			}
			if (Club == ClubType.Occult)
			{
				CharacterAnimation["sadFace_00"].layer = 1;
				CharacterAnimation.Play("sadFace_00");
				CharacterAnimation["sadFace_00"].weight = 1f;
			}
			if (StudentID == 66)
			{
				CharacterAnimation["toughFace_00"].layer = 1;
				CharacterAnimation.Play("toughFace_00");
				CharacterAnimation["toughFace_00"].weight = 1f;
				ThickBrows.SetActive(true);
			}
			if (StudentID == 13 && StudentGlobals.CustomSuitor)
			{
				if (StudentGlobals.CustomSuitorHair > 0)
				{
					Hairstyle = StudentGlobals.CustomSuitorHair;
				}
				if (StudentGlobals.CustomSuitorAccessory > 0)
				{
					Accessory = StudentGlobals.CustomSuitorAccessory;
					if (Accessory == 1)
					{
						Transform transform = MaleAccessories[1].transform;
						transform.localScale = new Vector3(1.02f, transform.localScale.y, 1.062f);
					}
				}
				if (StudentGlobals.CustomSuitorBlonde > 0)
				{
					HairColor = "Yellow";
				}
				if (StudentGlobals.CustomSuitorJewelry > 0)
				{
					GameObject[] galoAccessories2 = GaloAccessories;
					foreach (GameObject gameObject3 in galoAccessories2)
					{
						gameObject3.SetActive(true);
					}
				}
			}
			if (SceneManager.GetActiveScene().name == "PortraitScene")
			{
				if (StudentID == 56)
				{
					CharacterAnimation.Play("idleConfident_00");
				}
				else if (StudentID == 57)
				{
					CharacterAnimation.Play("sleuthPortrait_00");
				}
				else if (StudentID == 58)
				{
					CharacterAnimation.Play("sleuthPortrait_01");
				}
				else if (StudentID == 61)
				{
					CharacterAnimation.Play("scienceMad_00");
					base.transform.position = new Vector3(0f, 0.1f, 0f);
				}
				else if (StudentID == 76)
				{
					CharacterAnimation.Play("delinquentPoseB");
				}
				else if (StudentID == 77)
				{
					CharacterAnimation.Play("delinquentPoseA");
				}
				else if (StudentID == 78)
				{
					CharacterAnimation.Play("delinquentPoseC");
				}
				else if (StudentID == 79)
				{
					CharacterAnimation.Play("delinquentPoseD");
				}
				else if (StudentID == 80)
				{
					CharacterAnimation.Play("delinquentPoseE");
				}
			}
		}
		if (Club == ClubType.Teacher)
		{
			MyRenderer.sharedMesh = TeacherMesh;
			Teacher = true;
		}
		else if (Club == ClubType.GymTeacher)
		{
			if (!StudentGlobals.GetStudentReplaced(StudentID))
			{
				CharacterAnimation["f02_smile_00"].layer = 1;
				CharacterAnimation.Play("f02_smile_00");
				CharacterAnimation["f02_smile_00"].weight = 1f;
				RightEyeRenderer.gameObject.SetActive(false);
				LeftEyeRenderer.gameObject.SetActive(false);
			}
			MyRenderer.sharedMesh = CoachMesh;
			Teacher = true;
		}
		else if (Club == ClubType.Nurse)
		{
			MyRenderer.sharedMesh = NurseMesh;
			Teacher = true;
		}
		else if (Club == ClubType.Council)
		{
			Armband.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(-103f / 160f, 0f));
			Armband.SetActive(true);
			string text = string.Empty;
			if (StudentID == 86)
			{
				text = "Strict";
			}
			if (StudentID == 87)
			{
				text = "Casual";
			}
			if (StudentID == 88)
			{
				text = "Grace";
			}
			if (StudentID == 89)
			{
				text = "Edgy";
			}
			CharacterAnimation["f02_faceCouncil" + text + "_00"].layer = 1;
			CharacterAnimation.Play("f02_faceCouncil" + text + "_00");
			CharacterAnimation["f02_idleCouncil" + text + "_00"].time = 1f;
			CharacterAnimation.Play("f02_idleCouncil" + text + "_00");
		}
		if (TakingPortrait && (StudentID == 21 || StudentID == 26 || StudentID == 41 || StudentID == 56 || StudentID == 61 || StudentID == 66 || StudentID == 71))
		{
			Armband.SetActive(true);
		}
		GameObject[] femaleAccessories = FemaleAccessories;
		foreach (GameObject gameObject4 in femaleAccessories)
		{
			if (gameObject4 != null)
			{
				gameObject4.SetActive(false);
			}
		}
		GameObject[] maleAccessories = MaleAccessories;
		foreach (GameObject gameObject5 in maleAccessories)
		{
			if (gameObject5 != null)
			{
				gameObject5.SetActive(false);
			}
		}
		GameObject[] clubAccessories = ClubAccessories;
		foreach (GameObject gameObject6 in clubAccessories)
		{
			if (gameObject6 != null)
			{
				gameObject6.SetActive(false);
			}
		}
		GameObject[] teacherAccessories = TeacherAccessories;
		foreach (GameObject gameObject7 in teacherAccessories)
		{
			if (gameObject7 != null)
			{
				gameObject7.SetActive(false);
			}
		}
		GameObject[] teacherHair = TeacherHair;
		foreach (GameObject gameObject8 in teacherHair)
		{
			if (gameObject8 != null)
			{
				gameObject8.SetActive(false);
			}
		}
		GameObject[] femaleHair = FemaleHair;
		foreach (GameObject gameObject9 in femaleHair)
		{
			if (gameObject9 != null)
			{
				gameObject9.SetActive(false);
			}
		}
		GameObject[] maleHair = MaleHair;
		foreach (GameObject gameObject10 in maleHair)
		{
			if (gameObject10 != null)
			{
				gameObject10.SetActive(false);
			}
		}
		GameObject[] facialHair = FacialHair;
		foreach (GameObject gameObject11 in facialHair)
		{
			if (gameObject11 != null)
			{
				gameObject11.SetActive(false);
			}
		}
		GameObject[] eyewear = Eyewear;
		foreach (GameObject gameObject12 in eyewear)
		{
			if (gameObject12 != null)
			{
				gameObject12.SetActive(false);
			}
		}
		GameObject[] rightStockings = RightStockings;
		foreach (GameObject gameObject13 in rightStockings)
		{
			if (gameObject13 != null)
			{
				gameObject13.SetActive(false);
			}
		}
		GameObject[] leftStockings = LeftStockings;
		foreach (GameObject gameObject14 in leftStockings)
		{
			if (gameObject14 != null)
			{
				gameObject14.SetActive(false);
			}
		}
		GameObject[] scanners = Scanners;
		foreach (GameObject gameObject15 in scanners)
		{
			if (gameObject15 != null)
			{
				gameObject15.SetActive(false);
			}
		}
		GameObject[] flowers = Flowers;
		foreach (GameObject gameObject16 in flowers)
		{
			if (gameObject16 != null)
			{
				gameObject16.SetActive(false);
			}
		}
		GameObject[] goggles = Goggles;
		foreach (GameObject gameObject17 in goggles)
		{
			if (gameObject17 != null)
			{
				gameObject17.SetActive(false);
			}
		}
		if (StudentID == 13 && StudentGlobals.CustomSuitor && StudentGlobals.CustomSuitorEyewear > 0)
		{
			Eyewear[StudentGlobals.CustomSuitorEyewear].SetActive(true);
		}
		if (StudentID == 1 && SenpaiGlobals.CustomSenpai)
		{
			if (SenpaiGlobals.SenpaiEyeWear > 0)
			{
				Eyewear[SenpaiGlobals.SenpaiEyeWear].SetActive(true);
			}
			FacialHairstyle = SenpaiGlobals.SenpaiFacialHair;
			HairColor = SenpaiGlobals.SenpaiHairColor;
			EyeColor = SenpaiGlobals.SenpaiEyeColor;
			Hairstyle = SenpaiGlobals.SenpaiHairStyle;
		}
		if (!Male)
		{
			if (!Teacher)
			{
				FemaleHair[Hairstyle].SetActive(true);
				HairRenderer = FemaleHairRenderers[Hairstyle];
				SetFemaleUniform();
			}
			else
			{
				TeacherHair[Hairstyle].SetActive(true);
				HairRenderer = TeacherHairRenderers[Hairstyle];
				if (Club == ClubType.Teacher)
				{
					MyRenderer.materials[0].mainTexture = TeacherBodyTexture;
					MyRenderer.materials[1].mainTexture = DefaultFaceTexture;
					MyRenderer.materials[2].mainTexture = TeacherBodyTexture;
				}
				else if (Club == ClubType.GymTeacher)
				{
					if (StudentGlobals.GetStudentReplaced(StudentID))
					{
						MyRenderer.materials[0].mainTexture = DefaultFaceTexture;
						MyRenderer.materials[1].mainTexture = CoachPaleBodyTexture;
						MyRenderer.materials[2].mainTexture = CoachPaleBodyTexture;
					}
					else
					{
						MyRenderer.materials[0].mainTexture = CoachFaceTexture;
						MyRenderer.materials[1].mainTexture = CoachBodyTexture;
						MyRenderer.materials[2].mainTexture = CoachBodyTexture;
					}
				}
				else if (Club == ClubType.Nurse)
				{
					MyRenderer.materials = NurseMaterials;
				}
			}
		}
		else
		{
			if (Hairstyle > 0)
			{
				MaleHair[Hairstyle].SetActive(true);
				HairRenderer = MaleHairRenderers[Hairstyle];
			}
			if (FacialHairstyle > 0)
			{
				FacialHair[FacialHairstyle].SetActive(true);
				FacialHairRenderer = FacialHairRenderers[FacialHairstyle];
			}
			SetMaleUniform();
		}
		if (!Male)
		{
			if (!Teacher)
			{
				if (FemaleAccessories[Accessory] != null)
				{
					FemaleAccessories[Accessory].SetActive(true);
				}
			}
			else if (TeacherAccessories[Accessory] != null)
			{
				TeacherAccessories[Accessory].SetActive(true);
			}
		}
		else if (MaleAccessories[Accessory] != null)
		{
			MaleAccessories[Accessory].SetActive(true);
		}
		if (Club < ClubType.Gaming && ClubAccessories[(int)Club] != null && !ClubGlobals.GetClubClosed(Club) && StudentID != 26)
		{
			ClubAccessories[(int)Club].SetActive(true);
		}
		if (Club == ClubType.Art)
		{
			ClubAccessories[(int)Club].GetComponent<MeshFilter>().sharedMesh = Berets[StudentID];
		}
		else if (Club == ClubType.Science)
		{
			ClubAccessories[(int)Club].SetActive(false);
			ClubAccessories[(int)Club] = Scanners[StudentID];
			if (!ClubGlobals.GetClubClosed(Club))
			{
				ClubAccessories[(int)Club].SetActive(true);
			}
		}
		else if (Club == ClubType.Sports)
		{
			ClubAccessories[(int)Club].SetActive(false);
			ClubAccessories[(int)Club] = Goggles[StudentID];
			if (!ClubGlobals.GetClubClosed(Club))
			{
				ClubAccessories[(int)Club].SetActive(true);
			}
		}
		else if (Club == ClubType.Gardening)
		{
			ClubAccessories[(int)Club].SetActive(false);
			ClubAccessories[(int)Club] = Flowers[StudentID];
			if (!ClubGlobals.GetClubClosed(Club))
			{
				ClubAccessories[(int)Club].SetActive(true);
			}
		}
		if (!Male)
		{
			StartCoroutine(PutOnStockings());
		}
		if (!Randomize)
		{
			if (EyeColor != string.Empty)
			{
				if (EyeColor == "White")
				{
					CorrectColor = new Color(1f, 1f, 1f);
				}
				else if (EyeColor == "Black")
				{
					CorrectColor = new Color(0.5f, 0.5f, 0.5f);
				}
				else if (EyeColor == "Red")
				{
					CorrectColor = new Color(1f, 0f, 0f);
				}
				else if (EyeColor == "Yellow")
				{
					CorrectColor = new Color(1f, 1f, 0f);
				}
				else if (EyeColor == "Green")
				{
					CorrectColor = new Color(0f, 1f, 0f);
				}
				else if (EyeColor == "Cyan")
				{
					CorrectColor = new Color(0f, 1f, 1f);
				}
				else if (EyeColor == "Blue")
				{
					CorrectColor = new Color(0f, 0f, 1f);
				}
				else if (EyeColor == "Purple")
				{
					CorrectColor = new Color(1f, 0f, 1f);
				}
				else if (EyeColor == "Orange")
				{
					CorrectColor = new Color(1f, 0.5f, 0f);
				}
				else if (EyeColor == "Brown")
				{
					CorrectColor = new Color(0.5f, 0.25f, 0f);
				}
				else
				{
					CorrectColor = new Color(0f, 0f, 0f);
				}
				if (CorrectColor != new Color(0f, 0f, 0f))
				{
					RightEyeRenderer.material.color = CorrectColor;
					LeftEyeRenderer.material.color = CorrectColor;
				}
			}
		}
		else
		{
			float r = Random.Range(0f, 1f);
			float g = Random.Range(0f, 1f);
			float b = Random.Range(0f, 1f);
			RightEyeRenderer.material.color = new Color(r, g, b);
			LeftEyeRenderer.material.color = new Color(r, g, b);
		}
		if (!Randomize)
		{
			switch (HairColor)
{
    case "White":
        ColorValue = new Color(1f, 1f, 1f);
        break;

    case "Black":
        ColorValue = new Color(0.5f, 0.5f, 0.5f);
        break;

    case "Red":
        ColorValue = new Color(1f, 0f, 0f);
        break;

    case "Yellow":
        ColorValue = new Color(1f, 1f, 0f);
        break;

    case "Green":
        ColorValue = new Color(0f, 1f, 0f);
        break;

    case "Cyan":
        ColorValue = new Color(0f, 1f, 1f);
        break;

    case "Blue":
        ColorValue = new Color(0f, 0f, 1f);
        break;

    case "Purple":
        ColorValue = new Color(1f, 0f, 1f);
        break;

    case "Orange":
        ColorValue = new Color(1f, 0.5f, 0f);
        break;

    case "Brown":
        ColorValue = new Color(0.5f, 0.25f, 0f);
        break;

    default:
        ColorValue = new Color(0f, 0f, 0f);
        RightIrisLight.SetActive(false);
        LeftIrisLight.SetActive(false);
        break;
}
			if (ColorValue == new Color(0f, 0f, 0f))
			{
				RightEyeRenderer.material.mainTexture = HairRenderer.material.mainTexture;
				LeftEyeRenderer.material.mainTexture = HairRenderer.material.mainTexture;
				FaceTexture = HairRenderer.material.mainTexture;
				CustomHair = true;
			}
			if (!CustomHair)
			{
				if (Hairstyle > 0)
				{
					if (GameGlobals.LoveSick)
					{
						HairRenderer.material.color = new Color(0.1f, 0.1f, 0.1f);
					}
					else
					{
						HairRenderer.material.color = ColorValue;
					}
				}
			}
			else if (GameGlobals.LoveSick)
			{
				HairRenderer.material.color = new Color(0.1f, 0.1f, 0.1f);
			}
			if (!Male)
			{
				FemaleAccessories[6].GetComponent<Renderer>().material.color = ColorValue;
			}
		}
		else
		{
			HairRenderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		}
		if (!Teacher)
		{
			if (CustomHair)
			{
				if (!Male)
				{
					MyRenderer.materials[2].mainTexture = FaceTexture;
				}
				else if (StudentGlobals.MaleUniform == 1)
				{
					MyRenderer.materials[2].mainTexture = FaceTexture;
				}
				else if (StudentGlobals.MaleUniform < 4)
				{
					MyRenderer.materials[1].mainTexture = FaceTexture;
				}
				else
				{
					MyRenderer.materials[0].mainTexture = FaceTexture;
				}
			}
		}
		else if (Teacher && StudentGlobals.GetStudentReplaced(StudentID))
		{
			Color studentColor = StudentGlobals.GetStudentColor(StudentID);
			Color studentEyeColor = StudentGlobals.GetStudentEyeColor(StudentID);
			HairRenderer.material.color = studentColor;
			RightEyeRenderer.material.color = studentEyeColor;
			LeftEyeRenderer.material.color = studentEyeColor;
		}
		if (Male)
		{
			if (Accessory == 2)
			{
				RightIrisLight.SetActive(false);
				LeftIrisLight.SetActive(false);
			}
			if (SceneManager.GetActiveScene().name == "PortraitScene")
			{
				Character.transform.localScale = new Vector3(0.93f, 0.93f, 0.93f);
			}
			if (FacialHairRenderer != null)
			{
				FacialHairRenderer.material.color = ColorValue;
				if (FacialHairRenderer.materials.Length > 1)
				{
					FacialHairRenderer.materials[1].color = ColorValue;
				}
			}
		}
		if (StudentID > 1 && StudentID < 8)
		{
			FemaleAccessories[6].SetActive(true);
			if ((float)StudentGlobals.GetStudentReputation(StudentID) < -33.33333f)
			{
				FemaleAccessories[6].SetActive(false);
			}
		}
		if (StudentID == 17)
		{
			if (SchemeGlobals.GetSchemeStage(2) == 2)
			{
				FemaleAccessories[3].SetActive(false);
			}
		}
		else if (StudentID == 20)
		{
			if (base.transform.position != Vector3.zero)
			{
				RightEyeRenderer.material.mainTexture = DefaultFaceTexture;
				LeftEyeRenderer.material.mainTexture = DefaultFaceTexture;
				RightEyeRenderer.gameObject.GetComponent<RainbowScript>().enabled = true;
				LeftEyeRenderer.gameObject.GetComponent<RainbowScript>().enabled = true;
			}
		}
		else if (StudentID == 41)
		{
			CharacterAnimation["moodyEyes_00"].layer = 1;
			CharacterAnimation.Play("moodyEyes_00");
			CharacterAnimation["moodyEyes_00"].weight = 1f;
			CharacterAnimation.Play("moodyEyes_00");
		}
		else if (StudentID == 59)
		{
			ClubAccessories[7].transform.localPosition = new Vector3(0f, -1.04f, 0.5f);
			ClubAccessories[7].transform.localEulerAngles = new Vector3(-22.5f, 0f, 0f);
		}
		else if (StudentID == 60)
		{
			FemaleAccessories[13].SetActive(true);
		}
		if (Student != null && Student.AoT)
		{
			Student.AttackOnTitan();
		}
		if (HomeScene)
		{
			Student.CharacterAnimation["idle_00"].time = 9f;
			Student.CharacterAnimation["idle_00"].speed = 0f;
		}
		TaskCheck();
		TurnOnCheck();
		EyeTypeCheck();
		if (Kidnapped)
		{
			WearIndoorShoes();
		}
	}

	public void SetMaleUniform()
	{
		if (StudentID == 1)
		{
			SkinColor = SenpaiGlobals.SenpaiSkinColor;
			FaceTexture = FaceTextures[SkinColor];
		}
		else
		{
			FaceTexture = ((!CustomHair) ? FaceTextures[SkinColor] : HairRenderer.material.mainTexture);
			if (StudentID == 13 && StudentGlobals.CustomSuitor && StudentGlobals.CustomSuitorTan)
			{
				SkinColor = 6;
				FaceTexture = FaceTextures[6];
			}
		}
		MyRenderer.sharedMesh = MaleUniforms[StudentGlobals.MaleUniform];
		SchoolUniform = MaleUniforms[StudentGlobals.MaleUniform];
		UniformTexture = MaleUniformTextures[StudentGlobals.MaleUniform];
		CasualTexture = MaleCasualTextures[StudentGlobals.MaleUniform];
		SocksTexture = MaleSocksTextures[StudentGlobals.MaleUniform];
		if (StudentGlobals.MaleUniform == 1)
		{
			SkinID = 0;
			UniformID = 1;
			FaceID = 2;
		}
		else if (StudentGlobals.MaleUniform == 2)
		{
			UniformID = 0;
			FaceID = 1;
			SkinID = 2;
		}
		else if (StudentGlobals.MaleUniform == 3)
		{
			UniformID = 0;
			FaceID = 1;
			SkinID = 2;
		}
		else if (StudentGlobals.MaleUniform == 4)
		{
			FaceID = 0;
			SkinID = 1;
			UniformID = 2;
		}
		else if (StudentGlobals.MaleUniform == 5)
		{
			FaceID = 0;
			SkinID = 1;
			UniformID = 2;
		}
		else if (StudentGlobals.MaleUniform == 6)
		{
			FaceID = 0;
			SkinID = 1;
			UniformID = 2;
		}
		if (StudentGlobals.MaleUniform < 2 && Club == ClubType.Delinquent)
		{
			MyRenderer.sharedMesh = DelinquentMesh;
			if (StudentID == 76)
			{
				UniformTexture = EyeTextures[0];
				CasualTexture = EyeTextures[1];
				SocksTexture = EyeTextures[2];
			}
			else if (StudentID == 77)
			{
				UniformTexture = CheekTextures[0];
				CasualTexture = CheekTextures[1];
				SocksTexture = CheekTextures[2];
			}
			else if (StudentID == 78)
			{
				UniformTexture = ForeheadTextures[0];
				CasualTexture = ForeheadTextures[1];
				SocksTexture = ForeheadTextures[2];
			}
			else if (StudentID == 79)
			{
				UniformTexture = MouthTextures[0];
				CasualTexture = MouthTextures[1];
				SocksTexture = MouthTextures[2];
			}
			else if (StudentID == 80)
			{
				UniformTexture = NoseTextures[0];
				CasualTexture = NoseTextures[1];
				SocksTexture = NoseTextures[2];
			}
		}
		if (StudentID == 58)
		{
			SkinColor = 4;
		}
		if (!Student.Indoors)
		{
			MyRenderer.materials[FaceID].mainTexture = FaceTexture;
			MyRenderer.materials[SkinID].mainTexture = SkinTextures[SkinColor];
			MyRenderer.materials[UniformID].mainTexture = CasualTexture;
		}
		else
		{
			MyRenderer.materials[FaceID].mainTexture = FaceTexture;
			MyRenderer.materials[SkinID].mainTexture = SkinTextures[SkinColor];
			MyRenderer.materials[UniformID].mainTexture = UniformTexture;
		}
	}

	public void SetFemaleUniform()
	{
		if (Club != ClubType.Council)
		{
			MyRenderer.sharedMesh = FemaleUniforms[StudentGlobals.FemaleUniform];
			SchoolUniform = FemaleUniforms[StudentGlobals.FemaleUniform];
			if (StudentID == 26)
			{
				UniformTexture = OccultUniformTextures[StudentGlobals.FemaleUniform];
				CasualTexture = OccultCasualTextures[StudentGlobals.FemaleUniform];
				SocksTexture = OccultSocksTextures[StudentGlobals.FemaleUniform];
			}
			else if (Club == ClubType.Bully)
			{
				UniformTexture = GanguroUniformTextures[StudentGlobals.FemaleUniform];
				CasualTexture = GanguroCasualTextures[StudentGlobals.FemaleUniform];
				SocksTexture = GanguroSocksTextures[StudentGlobals.FemaleUniform];
			}
			else if (StudentID == 35)
			{
				UniformTexture = BlackBody;
				CasualTexture = BlackBody;
				SocksTexture = BlackBody;
				HairRenderer.material.mainTexture = BlackBody;
			}
			else
			{
				UniformTexture = FemaleUniformTextures[StudentGlobals.FemaleUniform];
				CasualTexture = FemaleCasualTextures[StudentGlobals.FemaleUniform];
				SocksTexture = FemaleSocksTextures[StudentGlobals.FemaleUniform];
			}
		}
		else
		{
			RightIrisLight.SetActive(false);
			LeftIrisLight.SetActive(false);
			MyRenderer.sharedMesh = FemaleUniforms[4];
			SchoolUniform = FemaleUniforms[4];
			UniformTexture = FemaleUniformTextures[7];
			CasualTexture = FemaleCasualTextures[7];
			SocksTexture = FemaleSocksTextures[7];
		}
		if (!Cutscene)
		{
			if (!Kidnapped)
			{
				if (!Student.Indoors)
				{
					MyRenderer.materials[0].mainTexture = CasualTexture;
					MyRenderer.materials[1].mainTexture = CasualTexture;
				}
				else
				{
					MyRenderer.materials[0].mainTexture = UniformTexture;
					MyRenderer.materials[1].mainTexture = UniformTexture;
				}
			}
			else
			{
				MyRenderer.materials[0].mainTexture = UniformTexture;
				MyRenderer.materials[1].mainTexture = UniformTexture;
			}
		}
		else
		{
			UniformTexture = FemaleUniformTextures[StudentGlobals.FemaleUniform];
			FaceTexture = DefaultFaceTexture;
			MyRenderer.materials[0].mainTexture = UniformTexture;
			MyRenderer.materials[1].mainTexture = UniformTexture;
		}
		if (Club == ClubType.Bully)
		{
		}
		if (StudentID == 35)
		{
			FaceTexture = BlackFace;
		}
		MyRenderer.materials[2].mainTexture = FaceTexture;
		if (!TakingPortrait && Student != null && Student.StudentManager != null && Student.StudentManager.Censor)
		{
			CensorPanties();
		}
		if (MyStockings != null)
		{
			StartCoroutine(PutOnStockings());
		}
	}

	public void CensorPanties()
	{
		if (!Student.ClubAttire && Student.Schoolwear == 1)
		{
			MyRenderer.materials[0].SetFloat("_BlendAmount1", 1f);
			MyRenderer.materials[1].SetFloat("_BlendAmount1", 1f);
		}
		else
		{
			RemoveCensor();
		}
	}

	public void RemoveCensor()
	{
		MyRenderer.materials[0].SetFloat("_BlendAmount1", 0f);
		MyRenderer.materials[1].SetFloat("_BlendAmount1", 0f);
	}

	private void TaskCheck()
	{
		if (StudentID == 15)
		{
			if (TaskGlobals.GetTaskStatus(15) < 3)
			{
				if (!TakingPortrait)
				{
					MaleAccessories[1].SetActive(false);
				}
				else
				{
					MaleAccessories[1].SetActive(true);
				}
			}
		}
		else if (StudentID == 33 && PhoneCharms.Length > 0)
		{
			if (TaskGlobals.GetTaskStatus(33) < 3)
			{
				PhoneCharms[33].SetActive(false);
			}
			else
			{
				PhoneCharms[33].SetActive(true);
			}
		}
	}

	private void TurnOnCheck()
	{
		if (!TurnedOn && !TakingPortrait && Male)
		{
			if (HairColor == "Purple")
			{
				LoveManager.Targets[LoveManager.TotalTargets] = Student.Head;
				LoveManager.TotalTargets++;
			}
			if (Hairstyle == 28)
			{
				LoveManager.Targets[LoveManager.TotalTargets] = Student.Head;
				LoveManager.TotalTargets++;
			}
			if (Accessory > 1)
			{
				LoveManager.Targets[LoveManager.TotalTargets] = Student.Head;
				LoveManager.TotalTargets++;
			}
			if (Student.Persona == PersonaType.TeachersPet)
			{
				LoveManager.Targets[LoveManager.TotalTargets] = Student.Head;
				LoveManager.TotalTargets++;
			}
		}
		TurnedOn = true;
	}

	private void DestroyUnneccessaryObjects()
	{
		GameObject[] femaleAccessories = FemaleAccessories;
		foreach (GameObject gameObject in femaleAccessories)
		{
			if (gameObject != null && !gameObject.activeInHierarchy)
			{
				Object.Destroy(gameObject);
			}
		}
		GameObject[] maleAccessories = MaleAccessories;
		foreach (GameObject gameObject2 in maleAccessories)
		{
			if (gameObject2 != null && !gameObject2.activeInHierarchy)
			{
				Object.Destroy(gameObject2);
			}
		}
		GameObject[] clubAccessories = ClubAccessories;
		foreach (GameObject gameObject3 in clubAccessories)
		{
			if (gameObject3 != null && !gameObject3.activeInHierarchy)
			{
				Object.Destroy(gameObject3);
			}
		}
		GameObject[] teacherAccessories = TeacherAccessories;
		foreach (GameObject gameObject4 in teacherAccessories)
		{
			if (gameObject4 != null && !gameObject4.activeInHierarchy)
			{
				Object.Destroy(gameObject4);
			}
		}
		GameObject[] teacherHair = TeacherHair;
		foreach (GameObject gameObject5 in teacherHair)
		{
			if (gameObject5 != null && !gameObject5.activeInHierarchy)
			{
				Object.Destroy(gameObject5);
			}
		}
		GameObject[] femaleHair = FemaleHair;
		foreach (GameObject gameObject6 in femaleHair)
		{
			if (gameObject6 != null && !gameObject6.activeInHierarchy)
			{
				Object.Destroy(gameObject6);
			}
		}
		GameObject[] maleHair = MaleHair;
		foreach (GameObject gameObject7 in maleHair)
		{
			if (gameObject7 != null && !gameObject7.activeInHierarchy)
			{
				Object.Destroy(gameObject7);
			}
		}
		GameObject[] facialHair = FacialHair;
		foreach (GameObject gameObject8 in facialHair)
		{
			if (gameObject8 != null && !gameObject8.activeInHierarchy)
			{
				Object.Destroy(gameObject8);
			}
		}
		GameObject[] eyewear = Eyewear;
		foreach (GameObject gameObject9 in eyewear)
		{
			if (gameObject9 != null && !gameObject9.activeInHierarchy)
			{
				Object.Destroy(gameObject9);
			}
		}
		GameObject[] rightStockings = RightStockings;
		foreach (GameObject gameObject10 in rightStockings)
		{
			if (gameObject10 != null && !gameObject10.activeInHierarchy)
			{
				Object.Destroy(gameObject10);
			}
		}
		GameObject[] leftStockings = LeftStockings;
		foreach (GameObject gameObject11 in leftStockings)
		{
			if (gameObject11 != null && !gameObject11.activeInHierarchy)
			{
				Object.Destroy(gameObject11);
			}
		}
	}

	public IEnumerator PutOnStockings()
	{
		RightStockings[0].SetActive(false);
		LeftStockings[0].SetActive(false);
		switch (Stockings)
		{
			case "Red":
			    MyStockings = RedStockings;
				break;
			case "Yellow":
			    MyStockings = YellowStockings;
				break;
			case "Green":
			    MyStockings = GreenStockings;
				break;
			case "Cyan":
			    MyStockings = CyanStockings;
				break;
			case "Blue":
			    MyStockings = BlueStockings;
				break;
			case "Purple":
			    MyStockings = PurpleStockings;
				break;
			case "ShortGreen":
			    MyStockings = GreenSocks;
				break;
			case "ShortBlack":
			    MyStockings = BlackKneeSocks;
				break;
			case "Black":
			    MyStockings = BlackStockings;
				break;
			case "Osana":
			    MyStockings = OsanaStockings;
				break;
			case "MarySue":
			    MyStockings = MarySueStockings;
				break;
			case "Kizana":
			    MyStockings = KizanaStockings;
				break;
			case "Council1":
			    MyStockings = TurtleStockings;
				break;
			case "Council2":
			    MyStockings = TigerStockings;
				break;
			case "Council3":
			    MyStockings = BirdStockings;
				break;
			case "Council4":
			    MyStockings = DragonStockings;
				break;
			case "Custom1":
			    WWW NewCustomStockings = new WWW("file:///" + Application.streamingAssetsPath + "/CustomStockings1.png");
			    yield return NewCustomStockings;
			    if (NewCustomStockings.error == null)
			    { 
				    CustomStockings[1] = NewCustomStockings.texture;
			    }
			    MyStockings = CustomStockings[1];
				break;
			case "Custom2":
			    WWW NewCustomStockings2 = new WWW("file:///" + Application.streamingAssetsPath + "/CustomStockings2.png");
			    yield return NewCustomStockings2;
			    if (NewCustomStockings2.error == null)
			    { 
				    CustomStockings[2] = NewCustomStockings2.texture;
			    }
			    MyStockings = CustomStockings[2];
				break;
			case "Custom3":
			    WWW NewCustomStockings3 = new WWW("file:///" + Application.streamingAssetsPath + "/CustomStockings3.png");
			    yield return NewCustomStockings3;
			    if (NewCustomStockings3.error == null)
			    { 
				    CustomStockings[3] = NewCustomStockings3.texture;
			    }
			    MyStockings = CustomStockings[3];
				break;
			case "Loose":
			    MyStockings = null;
			    RightStockings[0].SetActive(true);
			    LeftStockings[0].SetActive(true);
				break;
			case "Raibaru":
			    MyStockings = SatomiSkin;
			    RightStockings[0].SetActive(true);
			    LeftStockings[0].SetActive(true);
				break;
			default:
			    MyStockings = null;
				break;
		}
		if (MyStockings != null)
		{
			MyRenderer.materials[0].SetTexture("_OverlayTex", MyStockings);
			MyRenderer.materials[1].SetTexture("_OverlayTex", MyStockings);
			MyRenderer.materials[0].SetFloat("_BlendAmount", 1f);
			MyRenderer.materials[1].SetFloat("_BlendAmount", 1f);
		}
		else
		{
			MyRenderer.materials[0].SetTexture("_OverlayTex", null);
			MyRenderer.materials[1].SetTexture("_OverlayTex", null);
			MyRenderer.materials[0].SetFloat("_BlendAmount", 0f);
			MyRenderer.materials[1].SetFloat("_BlendAmount", 0f);
		}
	}

	public void WearIndoorShoes()
	{
		if (!Male)
		{
			MyRenderer.materials[0].mainTexture = CasualTexture;
			MyRenderer.materials[1].mainTexture = CasualTexture;
		}
		else
		{
			MyRenderer.materials[UniformID].mainTexture = CasualTexture;
		}
	}

	public void WearOutdoorShoes()
	{
		if (!Male)
		{
			MyRenderer.materials[0].mainTexture = UniformTexture;
			MyRenderer.materials[1].mainTexture = UniformTexture;
		}
		else
		{
			MyRenderer.materials[UniformID].mainTexture = UniformTexture;
		}
	}

	public void EyeTypeCheck()
	{
		if (StudentGlobals.FemaleUniform == 1 && !(EyeType == "Gentle"))
		{
			int GentleEye = 12;
			BlendshapesRenderer.SetBlendShapeWeight(GentleEye, 100f);
		}

		else if (StudentGlobals.FemaleUniform == 1 && !(EyeType == "MO"))
		{
			int MOEye = 9;
			BlendshapesRenderer.SetBlendShapeWeight(MOEye, 100f);
		}

		else if (StudentGlobals.FemaleUniform == 1 && !(EyeType == "Raibaru"))
		{
			int MO2 = 9;
			int Gentle2 = 12;
			BlendshapesRenderer.SetBlendShapeWeight(MO2, 100f);
			BlendshapesRenderer.SetBlendShapeWeight(Gentle2, 100f);
		}

		else if (StudentGlobals.FemaleUniform == 1 && !(EyeType == "Default"))
		{
			int MO3 = 9;
			int Gentle3 = 12;
			int ThinEye2 = 8;
			BlendshapesRenderer.SetBlendShapeWeight(MO3, 0f);
			BlendshapesRenderer.SetBlendShapeWeight(Gentle3, 0f);
			BlendshapesRenderer.SetBlendShapeWeight(ThinEye2, 0f);
		}

		else if (StudentGlobals.FemaleUniform == 1 && !(EyeType == "Rival1"))
		{
			int ThinEye = 8;
			BlendshapesRenderer.SetBlendShapeWeight(ThinEye, 50f);
		}
	}
}
