using System.Collections.Generic;
using UnityEngine;

public class PortraitChanScript : MonoBehaviour
{
	public StudentManagerScript StudentManager;

	public HomeCameraScript HomeCamera;

	public JsonScript JSON;

	public SkinnedMeshRenderer MyRenderer;

	public Renderer TeacherHairRenderer;

	public Renderer MaleHairRenderer;

	public Renderer PonyRenderer;

	public Renderer NewLongHair;

	public Renderer ShortHair;

	public Renderer TwinPony;

	public Renderer PigtailR;

	public Renderer PigtailL;

	public Renderer LongHair;

	public Renderer Drills;

	public Renderer EyeR;

	public Renderer EyeL;

	public Transform LongHairBone;

	public Transform HomeYandere;

	public Transform RightBreast;

	public Transform LeftBreast;

	public Transform Ponytail;

	public Transform RightEye;

	public Transform LeftEye;

	public Transform HairF;

	public Transform HairL;

	public Transform HairR;

	public Texture UniformTexture;

	public Texture DrillTexture;

	public Texture HairTexture;

	public GameObject[] TeacherGlasses;

	public GameObject[] TeacherHair;

	public GameObject[] OccultHair;

	public GameObject[] IrisLight;

	public GameObject ShinyGlasses;

	public GameObject CirnoHair;

	public GameObject Character;

	public GameObject PippiHair;

	public GameObject Eyepatch;

	public GameObject Bandage;

	public GameObject Bandana;

	public bool VeryLongHair;

	public bool HidePony;

	public bool Bullied;

	public bool Teacher;

	public bool Male;

	public bool Emo;

	public float BreastSize;

	public string Accessory = string.Empty;

	public string Hairstyle = string.Empty;

	public int StudentID;

	public ClubType Club;

	public GameObject[] MaleHairstyles;

	private Dictionary<string, Color> HairColors;

	public Mesh TeacherMesh;

	public Texture TeacherTexture;

	public HomeYandereDetectorScript YandereDetector;

	public Quaternion LastRotation;

	public GameObject RightIris;

	public GameObject LeftIris;

	public Transform TwintailR;

	public Transform TwintailL;

	public Transform Neck;

	public Vector3 RightEyeRotOrigin;

	public Vector3 LeftEyeRotOrigin;

	public Vector3 RightEyeOrigin;

	public Vector3 LeftEyeOrigin;

	public Vector3 Twitch;

	public float HairRotation;

	public float TwitchTimer;

	public float NextTwitch;

	public float EyeShrink;

	public float Sanity;

	public bool Kidnapped;

	public bool Tortured;

	public Mesh[] FemaleUniforms;

	public Texture[] FemaleUniformTextures;

	private void Awake()
	{
		HairColors = new Dictionary<string, Color>
		{
			{
				"Black",
				new Color(0.5f, 0.5f, 0.5f)
			},
			{
				"Red",
				new Color(1f, 0f, 0f)
			},
			{
				"Yellow",
				new Color(1f, 1f, 0f)
			},
			{
				"Green",
				new Color(0f, 1f, 0f)
			},
			{
				"Cyan",
				new Color(0f, 1f, 1f)
			},
			{
				"Blue",
				new Color(0f, 0f, 1f)
			},
			{
				"Purple",
				new Color(1f, 0f, 1f)
			},
			{
				"Orange",
				new Color(1f, 0.5f, 0f)
			},
			{
				"Brown",
				new Color(0.5f, 0.25f, 0f)
			}
		};
	}

	private void Start()
	{
		if (RightEye != null)
		{
			RightEyeRotOrigin = RightEye.localEulerAngles;
			LeftEyeRotOrigin = LeftEye.localEulerAngles;
			RightEyeOrigin = RightEye.localPosition;
			LeftEyeOrigin = LeftEye.localPosition;
		}
		Animation component = Character.GetComponent<Animation>();
		if (Kidnapped)
		{
			StudentID = SchoolGlobals.KidnapVictim;
			component.Play("f02_kidnapIdle_01");
			TwintailR.transform.localEulerAngles = new Vector3(10f, -90f, 0f);
			TwintailL.transform.localEulerAngles = new Vector3(10f, 90f, 0f);
		}
		if (Bullied)
		{
			StudentID = 7;
			component.Play("f02_bulliedPose_00");
		}
		Club = JSON.Students[StudentID].Club;
		BreastSize = JSON.Students[StudentID].BreastSize;
		Hairstyle = JSON.Students[StudentID].Hairstyle;
		Accessory = JSON.Students[StudentID].Accessory;
		if (!Male)
		{
			RightBreast.localScale = new Vector3(BreastSize, BreastSize, BreastSize);
			LeftBreast.localScale = new Vector3(BreastSize, BreastSize, BreastSize);
			UpdateHair();
		}
		else if (Club == ClubType.Occult)
		{
			component["sadFace_00"].layer = 1;
			component.Play("sadFace_00");
			component["sadFace_00"].weight = 1f;
		}
		Bandana.SetActive(false);
		if (Club == ClubType.Teacher)
		{
			BecomeTeacher();
		}
		else if (Club == ClubType.MartialArts)
		{
			Bandana.SetActive(true);
		}
		SetColors();
		if (!Male && !Teacher)
		{
			SetFemaleUniform();
		}
		UpdateSanity();
	}

	private void SetColors()
	{
		string color = JSON.Students[StudentID].Color;
		if (!Male)
		{
			if (!Teacher)
			{
				MyRenderer.materials[0].mainTexture = UniformTexture;
				MyRenderer.materials[1].mainTexture = UniformTexture;
				MyRenderer.materials[2].mainTexture = HairTexture;
				PonyRenderer.material.mainTexture = HairTexture;
				NewLongHair.material.mainTexture = HairTexture;
				ShortHair.material.mainTexture = HairTexture;
				LongHair.material.mainTexture = HairTexture;
				PigtailR.material.mainTexture = HairTexture;
				PigtailL.material.mainTexture = HairTexture;
				Drills.materials[0].mainTexture = DrillTexture;
				Drills.materials[1].mainTexture = DrillTexture;
				Drills.materials[2].mainTexture = DrillTexture;
			}
			else if (color == "Brown")
			{
				TeacherHair[1].GetComponent<Renderer>().material.color = new Color(0.5f, 0.25f, 0f, 1f);
				TeacherHair[2].GetComponent<Renderer>().material.color = new Color(0.5f, 0.25f, 0f, 1f);
				TeacherHair[3].GetComponent<Renderer>().material.color = new Color(0.5f, 0.25f, 0f, 1f);
				TeacherHair[4].GetComponent<Renderer>().material.color = new Color(0.5f, 0.25f, 0f, 1f);
				TeacherHair[5].GetComponent<Renderer>().material.color = new Color(0.5f, 0.25f, 0f, 1f);
				TeacherHair[6].GetComponent<Renderer>().material.color = new Color(0.5f, 0.25f, 0f, 1f);
			}
			if (Accessory == "Bandage")
			{
				Bandage.SetActive(true);
			}
			else if (Accessory == "Eyepatch")
			{
				Eyepatch.SetActive(true);
			}
		}
		else
		{
			MaleHairstyles[int.Parse(Hairstyle)].SetActive(true);
			if (int.Parse(Hairstyle) < 8)
			{
				MaleHairRenderer = MaleHairstyles[int.Parse(Hairstyle)].GetComponent<Renderer>();
				Color value;
				bool flag = HairColors.TryGetValue(color, out value);
				MaleHairRenderer.material.color = value;
				EyeR.material.color = MaleHairRenderer.material.color;
				EyeL.material.color = MaleHairRenderer.material.color;
				if (Club == ClubType.MartialArts)
				{
					Transform transform = MaleHairstyles[int.Parse(Hairstyle)].transform;
					transform.localScale = new Vector3(-1f, transform.localScale.y, transform.localScale.z);
					Bandana.SetActive(true);
				}
			}
			else
			{
				switch (color)
				{
				case "Occult2":
				case "Occult4":
				case "Occult6":
					MaleHairRenderer = MaleHairstyles[int.Parse(Hairstyle)].GetComponent<Renderer>();
					MyRenderer.materials[2].mainTexture = MaleHairRenderer.material.mainTexture;
					EyeR.material.mainTexture = MaleHairRenderer.material.mainTexture;
					EyeL.material.mainTexture = MaleHairRenderer.material.mainTexture;
					break;
				}
			}
			if (Accessory == "ShinyGlasses")
			{
				ShinyGlasses.SetActive(true);
				IrisLight[0].SetActive(false);
				IrisLight[1].SetActive(false);
			}
		}
		if (!Male)
		{
			PigtailR.material.mainTexture = HairTexture;
			PigtailL.material.mainTexture = HairTexture;
			if (DrillTexture != null)
			{
				Drills.materials[0].mainTexture = DrillTexture;
				Drills.materials[1].mainTexture = DrillTexture;
				Drills.materials[2].mainTexture = DrillTexture;
			}
		}
	}

	private void UpdateHair()
	{
		PonyRenderer.gameObject.SetActive(false);
		NewLongHair.gameObject.SetActive(false);
		PigtailR.gameObject.SetActive(false);
		PigtailL.gameObject.SetActive(false);
		LongHair.gameObject.SetActive(false);
		TwinPony.gameObject.SetActive(false);
		Drills.gameObject.SetActive(false);
		OccultHair[1].SetActive(false);
		OccultHair[3].SetActive(false);
		OccultHair[5].SetActive(false);
		CirnoHair.SetActive(false);
		PippiHair.SetActive(false);
		ShortHair.gameObject.SetActive(false);
		if (Hairstyle == "PonyTail")
		{
			PonyRenderer.transform.parent.gameObject.SetActive(true);
			PonyRenderer.gameObject.SetActive(true);
		}
		else if (Hairstyle == "RightTail")
		{
			PonyRenderer.transform.parent.gameObject.SetActive(true);
			PonyRenderer.gameObject.SetActive(true);
			PigtailR.transform.parent.transform.parent.gameObject.SetActive(true);
			PigtailR.gameObject.SetActive(true);
			HidePony = true;
		}
		else if (Hairstyle == "LeftTail")
		{
			PonyRenderer.transform.parent.gameObject.SetActive(true);
			PonyRenderer.gameObject.SetActive(true);
			PigtailL.transform.parent.transform.parent.gameObject.SetActive(true);
			PigtailL.gameObject.SetActive(true);
			HidePony = true;
		}
		else if (Hairstyle == "PigTails")
		{
			PonyRenderer.transform.parent.gameObject.SetActive(true);
			PonyRenderer.gameObject.SetActive(true);
			PigtailR.transform.parent.transform.parent.gameObject.SetActive(true);
			PigtailL.transform.parent.transform.parent.gameObject.SetActive(true);
			PigtailR.gameObject.SetActive(true);
			PigtailL.gameObject.SetActive(true);
			HidePony = true;
		}
		else if (Hairstyle == "TriTails")
		{
			PonyRenderer.transform.parent.gameObject.SetActive(true);
			PonyRenderer.gameObject.SetActive(true);
			PigtailR.transform.parent.transform.parent.gameObject.SetActive(true);
			PigtailL.transform.parent.transform.parent.gameObject.SetActive(true);
			PigtailR.gameObject.SetActive(true);
			PigtailL.gameObject.SetActive(true);
			PigtailR.transform.localScale = new Vector3(1f, 1f, 1f);
			PigtailL.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		else if (Hairstyle == "TwinTails")
		{
			PonyRenderer.transform.parent.gameObject.SetActive(true);
			PonyRenderer.gameObject.SetActive(true);
			PigtailR.transform.parent.transform.parent.gameObject.SetActive(true);
			PigtailL.transform.parent.transform.parent.gameObject.SetActive(true);
			PigtailR.gameObject.SetActive(true);
			PigtailL.gameObject.SetActive(true);
			PigtailR.transform.parent.transform.parent.transform.localScale = new Vector3(2f, 2f, 2f);
			PigtailL.transform.parent.transform.parent.transform.localScale = new Vector3(2f, 2f, 2f);
			HidePony = true;
		}
		else if (Hairstyle == "Drills")
		{
			PonyRenderer.transform.parent.gameObject.SetActive(true);
			PonyRenderer.gameObject.SetActive(true);
			Drills.transform.parent.transform.parent.gameObject.SetActive(true);
			Drills.gameObject.SetActive(true);
			HidePony = true;
		}
		else if (Hairstyle == "Short")
		{
			ShortHair.gameObject.SetActive(true);
		}
		else if (Hairstyle == "Pippi")
		{
			PippiHair.SetActive(true);
		}
		else if (Hairstyle == "Cirno")
		{
			CirnoHair.SetActive(true);
		}
		else if (Hairstyle == "Long")
		{
			LongHair.transform.parent.gameObject.SetActive(true);
			LongHair.gameObject.SetActive(true);
		}
		else if (Hairstyle == "NewLong")
		{
			NewLongHair.transform.parent.gameObject.SetActive(true);
			NewLongHair.gameObject.SetActive(true);
			VeryLongHair = false;
		}
		else if (Hairstyle == "VeryLong")
		{
			NewLongHair.transform.parent.gameObject.SetActive(true);
			NewLongHair.gameObject.SetActive(true);
			VeryLongHair = true;
		}
		else if (Hairstyle == "TwinPony")
		{
			TwinPony.transform.parent.transform.parent.gameObject.SetActive(true);
			TwinPony.gameObject.SetActive(true);
		}
		else if (Hairstyle == "Occult1")
		{
			OccultHair[1].SetActive(true);
		}
		else if (Hairstyle == "Occult3")
		{
			OccultHair[3].SetActive(true);
		}
		else if (Hairstyle == "Occult5")
		{
			OccultHair[5].SetActive(true);
		}
		else if (Hairstyle == "Teacher1")
		{
			TeacherHair[1].SetActive(true);
			TeacherGlasses[1].SetActive(true);
		}
		else if (Hairstyle == "Teacher2")
		{
			TeacherHair[2].SetActive(true);
			TeacherGlasses[2].SetActive(true);
		}
		else if (Hairstyle == "Teacher3")
		{
			TeacherHair[3].SetActive(true);
			TeacherGlasses[3].SetActive(true);
		}
		else if (Hairstyle == "Teacher4")
		{
			TeacherHair[4].SetActive(true);
			TeacherGlasses[4].SetActive(true);
		}
		else if (Hairstyle == "Teacher5")
		{
			TeacherHair[5].SetActive(true);
			TeacherGlasses[5].SetActive(true);
		}
		else if (Hairstyle == "Teacher6")
		{
			TeacherHair[6].SetActive(true);
			TeacherGlasses[6].SetActive(true);
		}
		if (HidePony)
		{
			Ponytail.parent.transform.localScale = new Vector3(1f, 1f, 0.93f);
			Ponytail.localScale = Vector3.zero;
			HairR.localScale = Vector3.zero;
			HairL.localScale = Vector3.zero;
		}
	}

	private void BecomeTeacher()
	{
		MyRenderer.sharedMesh = TeacherMesh;
		Teacher = true;
		MyRenderer.materials[0].mainTexture = TeacherTexture;
		MyRenderer.materials[1].mainTexture = TeacherTexture;
		MyRenderer.materials[2].mainTexture = TeacherTexture;
	}

	private void LateUpdate()
	{
		if (Kidnapped)
		{
			if (!Tortured)
			{
				if (Sanity > 0f)
				{
					if (YandereDetector.YandereDetected && Vector3.Distance(base.transform.position, HomeYandere.position) < 2f)
					{
						Quaternion b;
						if (HomeCamera.Target == HomeCamera.Targets[10])
						{
							b = Quaternion.LookRotation(HomeCamera.transform.position + Vector3.down * (1.5f * ((100f - Sanity) / 100f)) - Neck.position);
							HairRotation = Mathf.Lerp(HairRotation, 0f, Time.deltaTime * 2f);
						}
						else
						{
							b = Quaternion.LookRotation(HomeYandere.position + Vector3.up * 1.5f - Neck.position);
							HairRotation = Mathf.Lerp(HairRotation, -45f, Time.deltaTime * 2f);
						}
						Neck.rotation = Quaternion.Slerp(LastRotation, b, Time.deltaTime * 2f);
						TwintailR.transform.localEulerAngles = new Vector3(15f, -75f, HairRotation);
						TwintailL.transform.localEulerAngles = new Vector3(15f, 75f, 0f - HairRotation);
					}
					else
					{
						if (HomeCamera.Target == HomeCamera.Targets[10])
						{
							Quaternion quaternion = Quaternion.LookRotation(HomeCamera.transform.position + Vector3.down * (1.5f * ((100f - Sanity) / 100f)) - Neck.position);
							HairRotation = Mathf.Lerp(HairRotation, 0f, Time.deltaTime * 2f);
						}
						else
						{
							Quaternion quaternion = Quaternion.LookRotation(base.transform.position + base.transform.forward - Neck.position);
							Neck.rotation = Quaternion.Slerp(LastRotation, quaternion, Time.deltaTime * 2f);
						}
						HairRotation = Mathf.Lerp(HairRotation, 45f, Time.deltaTime * 2f);
						TwintailR.transform.localEulerAngles = new Vector3(15f, -75f, HairRotation);
						TwintailL.transform.localEulerAngles = new Vector3(15f, 75f, 0f - HairRotation);
					}
				}
				else
				{
					Neck.localEulerAngles = new Vector3(Neck.localEulerAngles.x - 45f, Neck.localEulerAngles.y, Neck.localEulerAngles.z);
				}
			}
			else
			{
				EyeShrink += Time.deltaTime * 0.1f;
			}
			LastRotation = Neck.rotation;
			if (!Tortured && Sanity < 100f && Sanity > 0f)
			{
				TwitchTimer += Time.deltaTime;
				if (TwitchTimer > NextTwitch)
				{
					Twitch = new Vector3((1f - Sanity / 100f) * Random.Range(-10f, 10f), (1f - Sanity / 100f) * Random.Range(-10f, 10f), (1f - Sanity / 100f) * Random.Range(-10f, 10f));
					NextTwitch = Random.Range(0f, 1f);
					TwitchTimer = 0f;
				}
				Twitch = Vector3.Lerp(Twitch, Vector3.zero, Time.deltaTime * 10f);
				Neck.localEulerAngles += Twitch;
			}
		}
		if (VeryLongHair)
		{
			LongHairBone.localScale = new Vector3(2f, LongHairBone.localScale.y, LongHairBone.localScale.z);
		}
		if (Emo)
		{
			HairF.localPosition = new Vector3(-0.1f, -0.285f, HairF.localPosition.z);
		}
		if (Tortured && RightEye != null)
		{
			if (EyeShrink > 1f)
			{
				EyeShrink = 1f;
			}
			if (Sanity >= 50f)
			{
				LeftEye.localPosition = new Vector3(LeftEye.localPosition.x - EyeShrink * 0.002f, LeftEye.localPosition.y, LeftEye.localPosition.z - EyeShrink * 0.009f);
				RightEye.localPosition = new Vector3(RightEye.localPosition.x - EyeShrink * 0.002f, RightEye.localPosition.y, RightEye.localPosition.z + EyeShrink * 0.009f);
				LeftEye.localEulerAngles = new Vector3(LeftEye.localEulerAngles.x + 5f + Random.Range(0f - EyeShrink, EyeShrink), LeftEye.localEulerAngles.y + Random.Range(0f - EyeShrink, EyeShrink), LeftEye.localEulerAngles.z + Random.Range(0f - EyeShrink, EyeShrink));
				RightEye.localEulerAngles = new Vector3(RightEye.localEulerAngles.x - 5f + Random.Range(0f - EyeShrink, EyeShrink), RightEye.localEulerAngles.y + Random.Range(0f - EyeShrink, EyeShrink), RightEye.localEulerAngles.z + Random.Range(0f - EyeShrink, EyeShrink));
				LeftEye.localScale = new Vector3(1f - EyeShrink * 0.5f, 1f - EyeShrink * 0.5f, LeftEye.localScale.z);
				RightEye.localScale = new Vector3(1f - EyeShrink * 0.5f, 1f - EyeShrink * 0.5f, RightEye.localScale.z);
			}
		}
	}

	private void UpdateSanity()
	{
		if (Kidnapped)
		{
			Sanity = StudentGlobals.GetStudentSanity(StudentID);
			RightIris.SetActive(Sanity == 0f);
			LeftIris.SetActive(Sanity == 0f);
		}
	}

	private void SetFemaleUniform()
	{
		if (Tortured)
		{
			MyRenderer.sharedMesh = FemaleUniforms[StudentGlobals.FemaleUniform];
			MyRenderer.materials[0].mainTexture = FemaleUniformTextures[StudentGlobals.FemaleUniform];
			MyRenderer.materials[1].mainTexture = FemaleUniformTextures[StudentGlobals.FemaleUniform];
			PonyRenderer.material.mainTexture = HairTexture;
		}
	}
}
