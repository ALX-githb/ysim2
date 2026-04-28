using UnityEngine;

public class WeaponScript : MonoBehaviour
{
	public ParticleSystem[] ShortBloodSpray;

	public ParticleSystem[] BloodSpray;

	public OutlineScript[] Outline;

	public float[] SoundTime;

	public IncineratorScript Incinerator;

	public YandereScript Yandere;

	public PromptScript Prompt;

	public AudioClip[] Clips;

	public AudioClip[] Clips2;

	public AudioClip[] Clips3;

	public AudioClip DismemberClip;

	public AudioClip EquipClip;

	public ParticleSystem FireEffect;

	public GameObject ExtraBlade;

	public AudioSource FireAudio;

	public Collider MyCollider;

	public Renderer MyRenderer;

	public Transform Blade;

	public Projector Blood;

	public bool DisableCollider;

	public bool Dismembering;

	public bool MurderWeapon;

	public bool WeaponEffect;

	public bool Concealable;

	public bool Suspicious;

	public bool Evidence;

	public bool StartLow;

	public bool Flaming;

	public bool Bloody;

	public bool Dumped;

	public bool Heated;

	public bool Metal;

	public bool Flip;

	public bool Spin;

	public Color EvidenceColor;

	public Color OriginalColor;

	public float OriginalOffset;

	public float KinematicTimer;

	public float DumpTimer;

	public float Rotation;

	public float Speed;

	public string SpriteName;

	public string Name;

	public int DismemberPhase;

	public int FingerprintID;

	public int WeaponID;

	public int AnimID;

	public WeaponType Type = WeaponType.Knife;

	public bool[] Victims;

	private AudioClip OriginalClip;

	private int ID;

	public GameObject HeartBurst;

	private void Start()
	{
		Yandere = GameObject.Find("YandereChan").GetComponent<YandereScript>();
		Physics.IgnoreCollision(Yandere.GetComponent<Collider>(), MyCollider);
		OriginalColor = Outline[0].color;
		if (StartLow)
		{
			OriginalOffset = Prompt.OffsetY[3];
			Prompt.OffsetY[3] = 0.2f;
		}
		if (DisableCollider)
		{
			MyCollider.enabled = false;
		}
		AudioSource component = GetComponent<AudioSource>();
		if (component != null)
		{
			OriginalClip = component.clip;
		}
		GetComponent<Rigidbody>().isKinematic = true;
	}

	public string GetTypePrefix()
	{
		if (Type == WeaponType.Knife)
		{
			return "knife";
		}
		if (Type == WeaponType.Katana)
		{
			return "katana";
		}
		if (Type == WeaponType.Bat)
		{
			return "bat";
		}
		if (Type == WeaponType.Saw)
		{
			return "saw";
		}
		if (Type == WeaponType.Syringe)
		{
			return "syringe";
		}
		Debug.LogError("Weapon type \"" + Type.ToString() + "\" not implemented.");
		return string.Empty;
	}

	public AudioClip GetClip(float sanity, bool stealth)
	{
		AudioClip[] array;
		if (Clips2.Length == 0)
		{
			array = Clips;
		}
		else
		{
			int num = Random.Range(2, 4);
			array = ((num != 2) ? Clips3 : Clips2);
		}
		if (stealth)
		{
			return array[0];
		}
		if (sanity > 2f / 3f)
		{
			return array[1];
		}
		if (sanity > 1f / 3f)
		{
			return array[2];
		}
		return array[3];
	}

	private void Update()
	{
		if (WeaponID == 16 && Yandere.EquippedWeapon == this && Input.GetButtonDown("RB"))
		{
			ExtraBlade.SetActive(!ExtraBlade.activeInHierarchy);
		}
		if (Dismembering)
		{
			AudioSource component = GetComponent<AudioSource>();
			if (DismemberPhase < 4)
			{
				if (component.time > 0.75f)
				{
					if (Speed < 36f)
					{
						Speed += Time.deltaTime + 10f;
					}
					Rotation += Speed;
					Blade.localEulerAngles = new Vector3(Rotation, Blade.localEulerAngles.y, Blade.localEulerAngles.z);
				}
				if (component.time > SoundTime[DismemberPhase])
				{
					Yandere.Sanity -= 5f * Yandere.Numbness;
					Yandere.Bloodiness += 25f;
					ShortBloodSpray[0].Play();
					ShortBloodSpray[1].Play();
					Blood.enabled = true;
					MurderWeapon = true;
					DismemberPhase++;
				}
			}
			else
			{
				Rotation = Mathf.Lerp(Rotation, 0f, Time.deltaTime * 2f);
				Blade.localEulerAngles = new Vector3(Rotation, Blade.localEulerAngles.y, Blade.localEulerAngles.z);
				if (!component.isPlaying)
				{
					component.clip = OriginalClip;
					Yandere.StainWeapon();
					Dismembering = false;
					DismemberPhase = 0;
					Rotation = 0f;
					Speed = 0f;
				}
			}
			return;
		}
		if (Yandere.EquippedWeapon == this)
		{
			if (Yandere.AttackManager.IsAttacking())
			{
				if (Type == WeaponType.Knife)
				{
					base.transform.localEulerAngles = new Vector3(base.transform.localEulerAngles.x, Mathf.Lerp(base.transform.localEulerAngles.y, (!Flip) ? 0f : 180f, Time.deltaTime * 10f), base.transform.localEulerAngles.z);
				}
				else if (Type == WeaponType.Saw && Spin)
				{
					Blade.transform.localEulerAngles = new Vector3(Blade.transform.localEulerAngles.x + Time.deltaTime * 360f, Blade.transform.localEulerAngles.y, Blade.transform.localEulerAngles.z);
				}
			}
			return;
		}
		Rigidbody component2 = GetComponent<Rigidbody>();
		if (!component2.isKinematic)
		{
			KinematicTimer = Mathf.MoveTowards(KinematicTimer, 5f, Time.deltaTime);
			if (KinematicTimer == 5f)
			{
				component2.isKinematic = true;
				KinematicTimer = 0f;
			}
		}
		if (base.transform.position.x > -89f && base.transform.position.x < -79f && base.transform.position.z > -13.5f && base.transform.position.z < -3.5f)
		{
			base.transform.position = new Vector3(-80.75f, 1f, -2.75f);
		}
		if (base.transform.position.x > -21f && base.transform.position.x < 21f && base.transform.position.z > 79f && base.transform.position.z < 121f)
		{
			base.transform.position = new Vector3(0f, 1f, 79f);
		}
	}

	private void LateUpdate()
	{
		if (Prompt.Circle[3].fillAmount == 0f)
		{
			Prompt.Circle[3].fillAmount = 1f;
			if (Prompt.Suspicious)
			{
				Yandere.TheftTimer = 0.1f;
			}
			if (!Yandere.Gloved)
			{
				FingerprintID = 100;
			}
			for (ID = 0; ID < Outline.Length; ID++)
			{
				Outline[ID].color = new Color(0f, 0f, 0f, 1f);
			}
			base.transform.parent = Yandere.ItemParent;
			base.transform.localPosition = Vector3.zero;
			if (Type == WeaponType.Bat)
			{
				base.transform.localEulerAngles = new Vector3(0f, 0f, -90f);
			}
			else
			{
				base.transform.localEulerAngles = Vector3.zero;
			}
			MyCollider.enabled = false;
			GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			if (Yandere.Equipped == 3)
			{
				Yandere.Weapon[3].Drop();
			}
			if (Yandere.PickUp != null)
			{
				Yandere.PickUp.Drop();
			}
			if (Yandere.Dragging)
			{
				Yandere.Ragdoll.GetComponent<RagdollScript>().StopDragging();
			}
			if (Yandere.Carrying)
			{
				Yandere.StopCarrying();
			}
			if (Concealable)
			{
				if (Yandere.Weapon[1] == null)
				{
					if (Yandere.Weapon[2] != null)
					{
						Yandere.Weapon[2].gameObject.SetActive(false);
					}
					Yandere.Equipped = 1;
					Yandere.EquippedWeapon = this;
				}
				else if (Yandere.Weapon[2] == null)
				{
					if (Yandere.Weapon[1] != null)
					{
						Yandere.Weapon[1].gameObject.SetActive(false);
					}
					Yandere.Equipped = 2;
					Yandere.EquippedWeapon = this;
				}
				else if (Yandere.Weapon[2].gameObject.activeInHierarchy)
				{
					Yandere.Weapon[2].Drop();
					Yandere.Equipped = 2;
					Yandere.EquippedWeapon = this;
				}
				else
				{
					Yandere.Weapon[1].Drop();
					Yandere.Equipped = 1;
					Yandere.EquippedWeapon = this;
				}
			}
			else
			{
				if (Yandere.Weapon[1] != null)
				{
					Yandere.Weapon[1].gameObject.SetActive(false);
				}
				if (Yandere.Weapon[2] != null)
				{
					Yandere.Weapon[2].gameObject.SetActive(false);
				}
				Yandere.Equipped = 3;
				Yandere.EquippedWeapon = this;
			}
			Yandere.StudentManager.UpdateStudents();
			Prompt.Hide();
			Prompt.enabled = false;
			Yandere.NearestPrompt = null;
			if (WeaponID == 9 || WeaponID == 10 || WeaponID == 12)
			{
				SuspicionCheck();
			}
			if (Yandere.EquippedWeapon.Suspicious)
			{
				if (!Yandere.WeaponWarning)
				{
					Yandere.NotificationManager.DisplayNotification(NotificationType.Armed);
					Yandere.WeaponWarning = true;
				}
			}
			else
			{
				Yandere.WeaponWarning = false;
			}
			Yandere.WeaponMenu.UpdateSprites();
			Yandere.WeaponManager.UpdateLabels();
			if (Evidence)
			{
				Yandere.Police.BloodyWeapons--;
			}
			if (WeaponID == 11)
			{
				Yandere.IdleAnim = "CyborgNinja_Idle_Armed";
				Yandere.WalkAnim = "CyborgNinja_Walk_Armed";
				Yandere.RunAnim = "CyborgNinja_Run_Armed";
			}
			KinematicTimer = 0f;
			AudioSource.PlayClipAtPoint(EquipClip, Camera.main.transform.position);
		}
		if (Yandere.EquippedWeapon == this && Yandere.Armed)
		{
			base.transform.localScale = new Vector3(1f, 1f, 1f);
			if (!Yandere.Struggling)
			{
				if (Yandere.CanMove)
				{
					base.transform.localPosition = Vector3.zero;
					if (Type == WeaponType.Bat)
					{
						base.transform.localEulerAngles = new Vector3(0f, 0f, -90f);
					}
					else
					{
						base.transform.localEulerAngles = Vector3.zero;
					}
				}
			}
			else
			{
				base.transform.localPosition = new Vector3(-0.01f, 0.005f, -0.01f);
			}
		}
		if (Dumped)
		{
			DumpTimer += Time.deltaTime;
			if (DumpTimer > 1f)
			{
				Yandere.Incinerator.MurderWeapons++;
				Object.Destroy(base.gameObject);
			}
		}
		if (base.transform.parent == Yandere.ItemParent && Concealable && Yandere.Weapon[1] != this && Yandere.Weapon[2] != this)
		{
			Drop();
		}
	}

	public void Drop()
	{
		Debug.Log("Yandere-chan dropped her weapon.");
		if (WeaponID == 11)
		{
			Yandere.IdleAnim = "CyborgNinja_Idle_Unarmed";
			Yandere.WalkAnim = Yandere.OriginalWalkAnim;
			Yandere.RunAnim = "CyborgNinja_Run_Unarmed";
		}
		if (StartLow)
		{
			Prompt.OffsetY[3] = OriginalOffset;
		}
		Yandere.EquippedWeapon = null;
		Yandere.Equipped = 0;
		Yandere.StudentManager.UpdateStudents();
		base.gameObject.SetActive(true);
		base.transform.parent = null;
		Rigidbody component = GetComponent<Rigidbody>();
		component.constraints = RigidbodyConstraints.None;
		component.isKinematic = false;
		component.useGravity = true;
		if (Dumped)
		{
			base.transform.position = Incinerator.DumpPoint.position;
		}
		else
		{
			Prompt.enabled = true;
			MyCollider.enabled = true;
			if (Yandere.GetComponent<Collider>().enabled)
			{
				Physics.IgnoreCollision(Yandere.GetComponent<Collider>(), MyCollider);
			}
		}
		if (Evidence)
		{
			Yandere.Police.BloodyWeapons++;
		}
		for (ID = 0; ID < Outline.Length; ID++)
		{
			Outline[ID].color = ((!Evidence) ? OriginalColor : EvidenceColor);
		}
		if (base.transform.position.y > 1000f)
		{
			base.transform.position = new Vector3(12f, 0f, 28f);
		}
	}

	public void UpdateLabel()
	{
		if (!(this != null) || !base.gameObject.activeInHierarchy)
		{
			return;
		}
		if (Yandere.Weapon[1] != null && Yandere.Weapon[2] != null && Concealable)
		{
			if (Prompt.Label[3] != null)
			{
				if (!Yandere.Armed || Yandere.Equipped == 3)
				{
					Prompt.Label[3].text = "     Swap " + Yandere.Weapon[1].Name + " for " + Name;
				}
				else
				{
					Prompt.Label[3].text = "     Swap " + Yandere.EquippedWeapon.Name + " for " + Name;
				}
			}
		}
		else if (Prompt.Label[3] != null)
		{
			Prompt.Label[3].text = "     " + Name;
		}
	}

	public void Effect()
	{
		if (WeaponID == 7)
		{
			BloodSpray[0].Play();
			BloodSpray[1].Play();
		}
		else if (WeaponID == 8)
		{
			base.gameObject.GetComponent<ParticleSystem>().Play();
			GetComponent<AudioSource>().clip = OriginalClip;
			GetComponent<AudioSource>().Play();
		}
		else if (WeaponID == 2 || WeaponID == 9 || WeaponID == 10 || WeaponID == 12 || WeaponID == 13)
		{
			GetComponent<AudioSource>().Play();
		}
		else if (WeaponID == 14)
		{
			Object.Instantiate(HeartBurst, Yandere.TargetStudent.Head.position, Quaternion.identity);
			GetComponent<AudioSource>().Play();
		}
	}

	public void Dismember()
	{
		AudioSource component = GetComponent<AudioSource>();
		component.clip = DismemberClip;
		component.Play();
		Dismembering = true;
	}

	public void SuspicionCheck()
	{
		if ((WeaponID == 9 && ClubGlobals.Club == ClubType.Sports) || (WeaponID == 10 && ClubGlobals.Club == ClubType.Gardening) || (WeaponID == 12 && ClubGlobals.Club == ClubType.Sports))
		{
			Suspicious = false;
		}
		else
		{
			Suspicious = true;
		}
	}
}
