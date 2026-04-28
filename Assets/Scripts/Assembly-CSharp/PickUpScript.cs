using UnityEngine;

public class PickUpScript : MonoBehaviour
{
	public RigidbodyConstraints OriginalConstraints;

	public BloodCleanerScript BloodCleaner;

	public IncineratorScript Incinerator;

	public BodyPartScript BodyPart;

	public TrashCanScript TrashCan;

	public OutlineScript[] Outline;

	public YandereScript Yandere;

	public BucketScript Bucket;

	public PromptScript Prompt;

	public ClockScript Clock;

	public Rigidbody MyRigidbody;

	public Collider MyCollider;

	public Vector3 TrashPosition;

	public Vector3 TrashRotation;

	public Vector3 OriginalScale;

	public Vector3 HoldPosition;

	public Vector3 HoldRotation;

	public Color EvidenceColor;

	public Color OriginalColor;

	public bool CleaningProduct;

	public bool LockRotation;

	public bool BeingLifted;

	public bool CanCollide;

	public bool Suspicious;

	public bool Blowtorch;

	public bool Clothing;

	public bool Evidence;

	public bool JerryCan;

	public bool LeftHand;

	public bool Garbage;

	public bool Bleach;

	public bool Dumped;

	public bool Usable;

	public bool Weight;

	public int CarryAnimID;

	public int Food;

	public float KinematicTimer;

	public float DumpTimer;

	public bool Empty = true;

	public GameObject[] FoodPieces;

	private void Start()
	{
		Yandere = GameObject.Find("YandereChan").GetComponent<YandereScript>();
		Clock = GameObject.Find("Clock").GetComponent<ClockScript>();
		if (!CanCollide)
		{
			Physics.IgnoreCollision(Yandere.GetComponent<Collider>(), MyCollider);
		}
		OriginalColor = Outline[0].color;
		OriginalScale = base.transform.localScale;
		MyRigidbody = GetComponent<Rigidbody>();
	}

	private void LateUpdate()
	{
		if (CleaningProduct)
		{
			if (Clock.Period == 5)
			{
				Suspicious = false;
			}
			else
			{
				Suspicious = true;
			}
		}
		if (Prompt.Circle[3].fillAmount == 0f)
		{
			Prompt.Circle[3].fillAmount = 1f;
			if (Weight)
			{
				if (!Yandere.Chased && Yandere.Chasers == 0)
				{
					if (Yandere.PickUp != null)
					{
						Yandere.CharacterAnimation[Yandere.CarryAnims[Yandere.PickUp.CarryAnimID]].weight = 0f;
					}
					if (Yandere.Armed)
					{
						Yandere.CharacterAnimation[Yandere.ArmedAnims[Yandere.EquippedWeapon.AnimID]].weight = 0f;
					}
					Yandere.targetRotation = Quaternion.LookRotation(new Vector3(base.transform.position.x, Yandere.transform.position.y, base.transform.position.z) - Yandere.transform.position);
					Yandere.transform.rotation = Yandere.targetRotation;
					Yandere.EmptyHands();
					base.transform.parent = Yandere.transform;
					base.transform.localPosition = new Vector3(0f, 0f, 0.75f);
					base.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
					base.transform.parent = null;
					Yandere.Character.GetComponent<Animation>().Play("f02_heavyWeightLift_00");
					Yandere.HeavyWeight = true;
					Yandere.CanMove = false;
					Yandere.Lifting = true;
					MyRigidbody.isKinematic = true;
					BeingLifted = true;
				}
			}
			else
			{
				BePickedUp();
			}
		}
		if (Yandere.PickUp == this)
		{
			base.transform.localPosition = HoldPosition;
			base.transform.localEulerAngles = HoldRotation;
		}
		if (Dumped)
		{
			DumpTimer += Time.deltaTime;
			if (DumpTimer > 1f)
			{
				if (Clothing)
				{
					Yandere.Incinerator.BloodyClothing++;
				}
				else if ((bool)BodyPart)
				{
					Yandere.Incinerator.BodyParts++;
				}
				Object.Destroy(base.gameObject);
			}
		}
		if (MyRigidbody != null && !MyRigidbody.isKinematic)
		{
			KinematicTimer = Mathf.MoveTowards(KinematicTimer, 5f, Time.deltaTime);
			if (KinematicTimer == 5f)
			{
				MyRigidbody.isKinematic = true;
				KinematicTimer = 0f;
			}
		}
		if (!Weight || !BeingLifted)
		{
			return;
		}
		if (Yandere.Lifting)
		{
			if (Yandere.CharacterAnimation["f02_heavyWeightLift_00"].time >= 2f)
			{
				base.transform.parent = Yandere.LeftItemParent;
				base.transform.localPosition = HoldPosition;
				base.transform.localEulerAngles = HoldRotation;
				if (Yandere.StudentManager.Stop)
				{
					Drop();
				}
			}
		}
		else
		{
			BePickedUp();
			BeingLifted = false;
		}
	}

	private void BePickedUp()
	{
		Prompt.Circle[3].fillAmount = 1f;
		if (Yandere.PickUp != null)
		{
			Yandere.PickUp.Drop();
		}
		if (Yandere.Equipped == 3)
		{
			Yandere.Weapon[3].Drop();
		}
		else if (Yandere.Equipped > 0)
		{
			Yandere.Unequip();
		}
		if (Yandere.Dragging)
		{
			Yandere.Ragdoll.GetComponent<RagdollScript>().StopDragging();
		}
		if (Yandere.Carrying)
		{
			Yandere.StopCarrying();
		}
		if (!LeftHand)
		{
			base.transform.parent = Yandere.ItemParent;
		}
		else
		{
			base.transform.parent = Yandere.LeftItemParent;
		}
		if (GetComponent<RadioScript>() != null && GetComponent<RadioScript>().On)
		{
			GetComponent<RadioScript>().TurnOff();
		}
		base.transform.localPosition = new Vector3(0f, 0f, 0f);
		base.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		MyCollider.enabled = false;
		if (MyRigidbody != null)
		{
			MyRigidbody.constraints = RigidbodyConstraints.FreezeAll;
		}
		if (!Usable)
		{
			Prompt.Hide();
			Prompt.enabled = false;
			Yandere.NearestPrompt = null;
		}
		else
		{
			Prompt.Carried = true;
		}
		Yandere.PickUp = this;
		Yandere.CarryAnimID = CarryAnimID;
		OutlineScript[] outline = Outline;
		foreach (OutlineScript outlineScript in outline)
		{
			outlineScript.color = new Color(0f, 0f, 0f, 1f);
		}
		if ((bool)BodyPart)
		{
			Yandere.NearBodies++;
		}
		Yandere.StudentManager.UpdateStudents();
		KinematicTimer = 0f;
	}

	public void Drop()
	{
		if (Weight)
		{
			Yandere.IdleAnim = Yandere.OriginalIdleAnim;
			Yandere.WalkAnim = Yandere.OriginalWalkAnim;
			Yandere.RunAnim = Yandere.OriginalRunAnim;
		}
		if (BloodCleaner != null)
		{
			BloodCleaner.enabled = true;
			BloodCleaner.Pathfinding.enabled = true;
		}
		Yandere.PickUp = null;
		base.transform.parent = null;
		if (LockRotation)
		{
			base.transform.localEulerAngles = new Vector3(0f, base.transform.localEulerAngles.y, 0f);
		}
		if (MyRigidbody != null)
		{
			MyRigidbody.constraints = OriginalConstraints;
			MyRigidbody.isKinematic = false;
			MyRigidbody.useGravity = true;
		}
		if (Dumped)
		{
			base.transform.position = Incinerator.DumpPoint.position;
		}
		else
		{
			Prompt.enabled = true;
			MyCollider.enabled = true;
			MyCollider.isTrigger = false;
			if (!CanCollide)
			{
				Physics.IgnoreCollision(Yandere.GetComponent<Collider>(), MyCollider);
			}
		}
		Prompt.Carried = false;
		OutlineScript[] outline = Outline;
		foreach (OutlineScript outlineScript in outline)
		{
			outlineScript.color = ((!Evidence) ? OriginalColor : EvidenceColor);
		}
		base.transform.localScale = OriginalScale;
		if ((bool)BodyPart)
		{
			Yandere.NearBodies--;
		}
		Yandere.StudentManager.UpdateStudents();
	}
}
