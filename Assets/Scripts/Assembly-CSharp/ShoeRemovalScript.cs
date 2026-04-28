#pragma warning disable 618 // Unity-deprecated APIs (AIBase.target, AIPath.speed, WWW, GetInstanceID, CF2Input.GetKeyDown(string), Physics2D.OverlapPointNonAlloc) still functional; full migration would change behavior or require coroutine refactors.
using UnityEngine;

public class ShoeRemovalScript : MonoBehaviour
{
	public StudentScript Student;

	public Vector3 RightShoePosition;

	public Vector3 LeftShoePosition;

	public Transform RightCurrentShoe;

	public Transform LeftCurrentShoe;

	public Transform RightCasualShoe;

	public Transform LeftCasualShoe;

	public Transform RightSchoolShoe;

	public Transform LeftSchoolShoe;

	public Transform RightNewShoe;

	public Transform LeftNewShoe;

	public Transform RightFoot;

	public Transform LeftFoot;

	public Transform RightHand;

	public Transform LeftHand;

	public Transform ShoeParent;

	public Transform Locker;

	public GameObject NewPairOfShoes;

	public GameObject Character;

	public string[] LockerAnims;

	public Texture OutdoorShoes;

	public Texture IndoorShoes;

	public Texture TargetShoes;

	public Texture Socks;

	public Renderer MyRenderer;

	public bool RemovingCasual = true;

	public bool Male;

	public int Height;

	public int Phase = 1;

	public float X;

	public float Y;

	public float Z;

	public string RemoveCasualAnim = string.Empty;

	public string RemoveSchoolAnim = string.Empty;

	public string RemovalAnim = string.Empty;

	public void Start()
	{
		if (!(Locker == null))
		{
			return;
		}
		GetHeight(Student.StudentID);
		Locker = Student.StudentManager.Lockers.List[Student.StudentID];
		GameObject gameObject = Object.Instantiate(NewPairOfShoes, base.transform.position, Quaternion.identity);
		gameObject.transform.parent = Locker;
		gameObject.transform.localEulerAngles = new Vector3(0f, -180f, 0f);
		gameObject.transform.localPosition = new Vector3(0f, -0.29f + 0.3f * (float)Height, (!Male) ? 0.05f : 0.04f);
		LeftSchoolShoe = gameObject.transform.GetChild(0);
		RightSchoolShoe = gameObject.transform.GetChild(1);
		RemovalAnim = RemoveCasualAnim;
		RightCurrentShoe = RightCasualShoe;
		LeftCurrentShoe = LeftCasualShoe;
		RightCasualShoe.gameObject.SetActive(true);
		LeftCasualShoe.gameObject.SetActive(true);
		RightNewShoe = RightSchoolShoe;
		LeftNewShoe = LeftSchoolShoe;
		ShoeParent = gameObject.transform;
		TargetShoes = IndoorShoes;
		RightShoePosition = RightCurrentShoe.localPosition;
		LeftShoePosition = LeftCurrentShoe.localPosition;
		RightCurrentShoe.localScale = new Vector3(1.111113f, 1f, 1.111113f);
		LeftCurrentShoe.localScale = new Vector3(1.111113f, 1f, 1.111113f);
		OutdoorShoes = Student.Cosmetic.CasualTexture;
		IndoorShoes = Student.Cosmetic.UniformTexture;
		Socks = Student.Cosmetic.SocksTexture;
		if (!Student.AoT)
		{
			if (!Male)
			{
				MyRenderer.materials[0].mainTexture = Socks;
				MyRenderer.materials[1].mainTexture = Socks;
			}
			else
			{
				MyRenderer.materials[Student.Cosmetic.UniformID].mainTexture = Socks;
			}
		}
		TargetShoes = IndoorShoes;
		Locker.gameObject.GetComponent<Animation>().Play(LockerAnims[Height]);
		Character.GetComponent<Animation>().cullingType = AnimationCullingType.AlwaysAnimate;
		Character.GetComponent<Animation>().Play(RemovalAnim);
	}

	private void Update()
	{
		if (!Student.DiscCheck && !Student.Dying && !Student.Alarmed && !Student.Splashed && !Student.TurnOffRadio)
		{
			if (Student.CurrentDestination == null)
			{
				Student.CurrentDestination = Student.Destinations[Student.Phase];
				Student.Pathfinding.target = Student.CurrentDestination;
			}
			Student.MoveTowardsTarget(Student.CurrentDestination.position);
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, Student.CurrentDestination.rotation, 10f * Time.deltaTime);
			if (Phase == 1)
			{
				if (Character.GetComponent<Animation>()[RemovalAnim].time >= 1.1f)
				{
					ShoeParent.parent = LeftHand;
					Phase++;
				}
			}
			else if (Phase == 2)
			{
				if (Character.GetComponent<Animation>()[RemovalAnim].time >= 2f)
				{
					ShoeParent.parent = Locker;
					X = ShoeParent.localEulerAngles.x;
					Y = ShoeParent.localEulerAngles.y;
					Z = ShoeParent.localEulerAngles.z;
					Phase++;
				}
			}
			else if (Phase == 3)
			{
				X = Mathf.MoveTowards(X, 0f, Time.deltaTime * 360f);
				Y = Mathf.MoveTowards(Y, 186.878f, Time.deltaTime * 360f);
				Z = Mathf.MoveTowards(Z, 0f, Time.deltaTime * 360f);
				ShoeParent.localEulerAngles = new Vector3(X, Y, Z);
				ShoeParent.localPosition = Vector3.MoveTowards(ShoeParent.localPosition, new Vector3(0.272f, 0f, 0.552f), Time.deltaTime);
				if (ShoeParent.localPosition.y == 0f)
				{
					ShoeParent.localPosition = new Vector3(0.272f, 0f, 0.552f);
					ShoeParent.localEulerAngles = new Vector3(0f, 186.878f, 0f);
					Phase++;
				}
			}
			else if (Phase == 4)
			{
				if (Character.GetComponent<Animation>()[RemovalAnim].time >= 3.4f)
				{
					RightCurrentShoe.parent = null;
					RightCurrentShoe.position = new Vector3(RightCurrentShoe.position.x, 0.05f, RightCurrentShoe.position.z);
					RightCurrentShoe.localEulerAngles = new Vector3(0f, RightCurrentShoe.localEulerAngles.y, 0f);
					Phase++;
				}
			}
			else if (Phase == 5)
			{
				if (Character.GetComponent<Animation>()[RemovalAnim].time >= 4.4f)
				{
					LeftCurrentShoe.parent = null;
					LeftCurrentShoe.position = new Vector3(LeftCurrentShoe.position.x, 0.05f, LeftCurrentShoe.position.z);
					LeftCurrentShoe.localEulerAngles = new Vector3(0f, LeftCurrentShoe.localEulerAngles.y, 0f);
					Phase++;
				}
			}
			else if (Phase == 6)
			{
				if (Character.GetComponent<Animation>()[RemovalAnim].time >= 5.6f)
				{
					LeftNewShoe.parent = LeftFoot;
					LeftNewShoe.localPosition = LeftShoePosition;
					LeftNewShoe.localEulerAngles = Vector3.zero;
					Phase++;
				}
			}
			else if (Phase == 7)
			{
				if (!(Character.GetComponent<Animation>()[RemovalAnim].time >= 6.8f))
				{
					return;
				}
				if (!Student.AoT)
				{
					if (!Male)
					{
						MyRenderer.materials[0].mainTexture = TargetShoes;
						MyRenderer.materials[1].mainTexture = TargetShoes;
					}
					else
					{
						MyRenderer.materials[Student.Cosmetic.UniformID].mainTexture = TargetShoes;
					}
				}
				RightNewShoe.parent = RightFoot;
				RightNewShoe.localPosition = RightShoePosition;
				RightNewShoe.localEulerAngles = Vector3.zero;
				RightNewShoe.gameObject.SetActive(false);
				LeftNewShoe.gameObject.SetActive(false);
				Phase++;
			}
			else if (Phase == 8)
			{
				if (Character.GetComponent<Animation>()[RemovalAnim].time >= 7.6f)
				{
					ShoeParent.transform.position = (RightCurrentShoe.position - LeftCurrentShoe.position) * 0.5f;
					RightCurrentShoe.parent = ShoeParent;
					LeftCurrentShoe.parent = ShoeParent;
					ShoeParent.parent = RightHand;
					Phase++;
				}
			}
			else if (Phase == 9)
			{
				if (Character.GetComponent<Animation>()[RemovalAnim].time >= 8.5f)
				{
					ShoeParent.parent = Locker;
					ShoeParent.localPosition = new Vector3(0f, ((!(TargetShoes == IndoorShoes)) ? (-0.29f) : (-0.14f)) + 0.3f * (float)Height, -0.01f);
					ShoeParent.localEulerAngles = new Vector3(0f, 180f, 0f);
					RightCurrentShoe.localPosition = new Vector3(0.041f, 0.04271515f, 0f);
					LeftCurrentShoe.localPosition = new Vector3(-0.041f, 0.04271515f, 0f);
					RightCurrentShoe.localEulerAngles = Vector3.zero;
					LeftCurrentShoe.localEulerAngles = Vector3.zero;
					Phase++;
				}
			}
			else
			{
				if (Phase != 10 || !(Character.GetComponent<Animation>()[RemovalAnim].time >= Character.GetComponent<Animation>()[RemovalAnim].length))
				{
					return;
				}
				Character.GetComponent<Animation>().cullingType = AnimationCullingType.BasedOnRenderers;
				Student.Routine = true;
				base.enabled = false;
				if (!Student.Indoors)
				{
					if (Student.Persona == PersonaType.PhoneAddict || Student.Sleuthing)
					{
						Student.SmartPhone.SetActive(true);
						if (!Student.Sleuthing)
						{
							Student.WalkAnim = Student.PhoneAnims[1];
						}
					}
					Student.Indoors = true;
					Student.CanTalk = true;
				}
				else
				{
					Student.CurrentDestination = Student.StudentManager.Hangouts.List[0];
					Student.Pathfinding.target = Student.StudentManager.Hangouts.List[0];
					Locker.gameObject.GetComponent<Animation>().Stop();
					Student.CanTalk = false;
					Student.Leaving = true;
					Student.Phase++;
					base.enabled = false;
					Phase++;
				}
			}
		}
		else
		{
			PutOnShoes();
			Student.Routine = false;
		}
	}

	private void LateUpdate()
	{
		if (Phase < 7)
		{
			RightFoot.localScale = new Vector3(0.9f, 1f, 0.9f);
			LeftFoot.localScale = new Vector3(0.9f, 1f, 0.9f);
		}
	}

	public void PutOnShoes()
	{
		CloseLocker();
		ShoeParent.parent = LeftHand;
		ShoeParent.parent = Locker;
		ShoeParent.localPosition = new Vector3(0.272f, 0f, 0.552f);
		ShoeParent.localEulerAngles = new Vector3(0f, 186.878f, 0f);
		RightCurrentShoe.parent = null;
		RightCurrentShoe.position = new Vector3(RightCurrentShoe.position.x, 0.05f, RightCurrentShoe.position.z);
		RightCurrentShoe.localEulerAngles = new Vector3(0f, RightCurrentShoe.localEulerAngles.y, 0f);
		LeftCurrentShoe.parent = null;
		LeftCurrentShoe.position = new Vector3(LeftCurrentShoe.position.x, 0.05f, LeftCurrentShoe.position.z);
		LeftCurrentShoe.localEulerAngles = new Vector3(0f, LeftCurrentShoe.localEulerAngles.y, 0f);
		LeftNewShoe.parent = LeftFoot;
		LeftNewShoe.localPosition = LeftShoePosition;
		LeftNewShoe.localEulerAngles = Vector3.zero;
		if (!Student.AoT)
		{
			if (!Male)
			{
				MyRenderer.materials[0].mainTexture = TargetShoes;
				MyRenderer.materials[1].mainTexture = TargetShoes;
			}
			else
			{
				MyRenderer.materials[Student.Cosmetic.UniformID].mainTexture = TargetShoes;
			}
		}
		RightNewShoe.parent = RightFoot;
		RightNewShoe.localPosition = RightShoePosition;
		RightNewShoe.localEulerAngles = Vector3.zero;
		RightNewShoe.gameObject.SetActive(false);
		LeftNewShoe.gameObject.SetActive(false);
		ShoeParent.transform.position = (RightCurrentShoe.position - LeftCurrentShoe.position) * 0.5f;
		RightCurrentShoe.parent = ShoeParent;
		LeftCurrentShoe.parent = ShoeParent;
		ShoeParent.parent = RightHand;
		ShoeParent.parent = Locker;
		ShoeParent.localPosition = new Vector3(0f, ((!(TargetShoes == IndoorShoes)) ? (-0.29f) : (-0.14f)) + 0.3f * (float)Height, -0.01f);
		ShoeParent.localEulerAngles = new Vector3(0f, 180f, 0f);
		RightCurrentShoe.localPosition = new Vector3(0.041f, 0.04271515f, 0f);
		LeftCurrentShoe.localPosition = new Vector3(-0.041f, 0.04271515f, 0f);
		RightCurrentShoe.localEulerAngles = Vector3.zero;
		LeftCurrentShoe.localEulerAngles = Vector3.zero;
		Student.Indoors = true;
		Student.CanTalk = true;
		base.enabled = false;
		Character.GetComponent<Animation>().cullingType = AnimationCullingType.BasedOnRenderers;
		Student.StopPairing();
	}

	public void CloseLocker()
	{
		Locker.gameObject.GetComponent<Animation>()[LockerAnims[Height]].time = Locker.gameObject.GetComponent<Animation>()[LockerAnims[Height]].length;
	}

	private void UpdateShoes()
	{
		Student.Indoors = true;
		if (!Student.AoT)
		{
			if (!Male)
			{
				MyRenderer.materials[0].mainTexture = IndoorShoes;
				MyRenderer.materials[1].mainTexture = IndoorShoes;
			}
			else
			{
				MyRenderer.materials[Student.Cosmetic.UniformID].mainTexture = IndoorShoes;
			}
		}
	}

	public void LeavingSchool()
	{
		Student.CharacterAnimation.cullingType = AnimationCullingType.AlwaysAnimate;
		OutdoorShoes = Student.Cosmetic.CasualTexture;
		IndoorShoes = Student.Cosmetic.UniformTexture;
		Socks = Student.Cosmetic.SocksTexture;
		RemovalAnim = RemoveSchoolAnim;
		Locker.gameObject.GetComponent<Animation>()[LockerAnims[Height]].time = 0f;
		Locker.gameObject.GetComponent<Animation>().Play(LockerAnims[Height]);
		if (!Student.AoT)
		{
			if (!Male)
			{
				MyRenderer.materials[0].mainTexture = Socks;
				MyRenderer.materials[1].mainTexture = Socks;
			}
			else
			{
				MyRenderer.materials[Student.Cosmetic.UniformID].mainTexture = Socks;
			}
		}
		Character.GetComponent<Animation>().Play(RemovalAnim);
		RightNewShoe.gameObject.SetActive(true);
		LeftNewShoe.gameObject.SetActive(true);
		RightCurrentShoe = RightSchoolShoe;
		LeftCurrentShoe = LeftSchoolShoe;
		RightNewShoe = RightCasualShoe;
		LeftNewShoe = LeftCasualShoe;
		TargetShoes = OutdoorShoes;
		Phase = 1;
		RightFoot.localScale = new Vector3(0.9f, 1f, 0.9f);
		LeftFoot.localScale = new Vector3(0.9f, 1f, 0.9f);
		RightCurrentShoe.localScale = new Vector3(1.111113f, 1f, 1.111113f);
		LeftCurrentShoe.localScale = new Vector3(1.111113f, 1f, 1.111113f);
	}

	private void GetHeight(int StudentID)
	{
		Height = 6;
		while (StudentID > 0)
		{
			Height--;
			StudentID--;
			if (Height == 0)
			{
				Height = 5;
			}
		}
		if (Student.StudentID == 7 || Student.StudentID == 32 || Student.StudentID == Student.StudentManager.RivalID || Student.StudentID == Student.StudentManager.SuitorID)
		{
			Height = 5;
		}
		RemoveCasualAnim = RemoveCasualAnim + Height + "_00";
		RemoveSchoolAnim = RemoveSchoolAnim + Height + "_01";
	}
}
