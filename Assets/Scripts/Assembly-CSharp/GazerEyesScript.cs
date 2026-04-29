using UnityEngine;

public class GazerEyesScript : MonoBehaviour
{
	public StudentManagerScript StudentManager;

	public YandereScript Yandere;

	public GameObject FemaleBloodyScream;

	public GameObject MaleBloodyScream;

	public GameObject ParticleEffect;

	public GameObject Laser;

	public SkinnedMeshRenderer[] Eyes;

	public float[] BlinkStrength;

	public Texture[] EyeTextures;

	public bool[] Blink;

	public float RandomNumber;

	public float AnimTime;

	public bool Attacking;

	public int Effect;

	public int ID;

	private void Start()
	{
		Animation anim = GetComponent<Animation>();
		if (anim == null) return;
		if (anim["Eyeballs_Run"] != null) anim["Eyeballs_Run"].speed = 0f;
		if (anim["Eyeballs_Walk"] != null) anim["Eyeballs_Walk"].speed = 0f;
		if (anim["Eyeballs_Idle"] != null) anim["Eyeballs_Idle"].speed = 0f;
	}

	private Animation _cachedAnim;

	private void Update()
	{
		if (StudentManager != null) StudentManager.UpdateStudents();
		if (!Attacking)
		{
			AnimTime += Time.deltaTime;
			if (AnimTime > 144f)
			{
				AnimTime = 0f;
			}
		}
		else if (AnimTime < 72f)
		{
			AnimTime = Mathf.Lerp(AnimTime, 0f, Time.deltaTime * 1.44f * 5f);
		}
		else
		{
			AnimTime = Mathf.Lerp(AnimTime, 144f, Time.deltaTime * 1.44f * 5f);
		}
		if (_cachedAnim == null) _cachedAnim = GetComponent<Animation>();
		if (_cachedAnim != null)
		{
			if (_cachedAnim["Eyeballs_Run"] != null) _cachedAnim["Eyeballs_Run"].time = AnimTime;
			if (_cachedAnim["Eyeballs_Walk"] != null) _cachedAnim["Eyeballs_Walk"].time = AnimTime;
			if (_cachedAnim["Eyeballs_Idle"] != null) _cachedAnim["Eyeballs_Idle"].time = AnimTime;
		}
		for (ID = 0; ID < Eyes.Length; ID++)
		{
			if (BlinkStrength[ID] == 0f)
			{
				RandomNumber = Random.Range(1, 101);
			}
			if (RandomNumber == 1f)
			{
				Blink[ID] = true;
			}
			if (Blink[ID])
			{
				BlinkStrength[ID] = Mathf.MoveTowards(BlinkStrength[ID], 100f, Time.deltaTime * 1000f);
				if (Eyes[ID] != null && Eyes[ID].sharedMesh != null && Eyes[ID].sharedMesh.blendShapeCount > 0)
					Eyes[ID].SetBlendShapeWeight(0, BlinkStrength[ID]);
				if (BlinkStrength[ID] == 100f)
				{
					Blink[ID] = false;
				}
			}
			else if (BlinkStrength[ID] > 0f)
			{
				BlinkStrength[ID] = Mathf.MoveTowards(BlinkStrength[ID], 0f, Time.deltaTime * 1000f);
				if (Eyes[ID] != null && Eyes[ID].sharedMesh != null && Eyes[ID].sharedMesh.blendShapeCount > 0)
					Eyes[ID].SetBlendShapeWeight(0, BlinkStrength[ID]);
			}
		}
		float axis = ControlFreak2.CF2Input.GetAxis("Vertical");
		float axis2 = ControlFreak2.CF2Input.GetAxis("Horizontal");
		if (Yandere == null || !Yandere.CanMove)
		{
			return;
		}
		if (_cachedAnim == null) return;
		if (axis != 0f || axis2 != 0f)
		{
			if (ControlFreak2.CF2Input.GetButton("LB"))
			{
				_cachedAnim.CrossFade("Eyeballs_Run", 1f);
			}
			else
			{
				_cachedAnim.CrossFade("Eyeballs_Walk", 1f);
			}
		}
		else
		{
			_cachedAnim.CrossFade("Eyeballs_Idle", 1f);
		}
	}

	public void ChangeEffect()
	{
		Effect++;
		if (Effect == EyeTextures.Length)
		{
			Effect = 0;
		}
		for (ID = 0; ID < Eyes.Length; ID++)
		{
			Object.Instantiate(ParticleEffect, Eyes[ID].transform.position, Quaternion.identity);
			Eyes[ID].material.mainTexture = EyeTextures[Effect];
		}
	}

	public void Attack()
	{
		for (ID = 0; ID < Eyes.Length; ID++)
		{
			GameObject gameObject = Object.Instantiate(Laser, Eyes[ID].transform.position, Quaternion.identity);
			gameObject.transform.LookAt(Yandere.TargetStudent.Hips.position + new Vector3(0f, 0.33333f, 0f));
			gameObject.transform.localScale = new Vector3(1f, 1f, Vector3.Distance(Eyes[ID].transform.position, Yandere.TargetStudent.Hips.position + new Vector3(0f, 0.33333f, 0f)) * 0.5f);
		}
		if (Effect == 0)
		{
			Yandere.TargetStudent.Combust();
		}
		else if (Effect == 1)
		{
			StudentScript targetStudent = Yandere.TargetStudent;
			targetStudent.CharacterAnimation["f02_electrocution_00"].speed = 0.85f;
			targetStudent.CharacterAnimation["f02_electrocution_00"].time = 2f;
			targetStudent.CharacterAnimation.CrossFade("f02_electrocution_00");
			targetStudent.Pathfinding.canSearch = false;
			targetStudent.Pathfinding.canMove = false;
			targetStudent.Electrified = true;
			targetStudent.Fleeing = false;
			targetStudent.Routine = false;
			targetStudent.Dying = true;
			GameObject gameObject2 = Object.Instantiate(StudentManager.LightSwitch.Electricity, targetStudent.transform.position, Quaternion.identity);
			gameObject2.transform.parent = targetStudent.BoneSets.RightArm;
			gameObject2.transform.localPosition = Vector3.zero;
			GameObject gameObject3 = Object.Instantiate(StudentManager.LightSwitch.Electricity, targetStudent.transform.position, Quaternion.identity);
			gameObject3.transform.parent = targetStudent.BoneSets.LeftArm;
			gameObject3.transform.localPosition = Vector3.zero;
			GameObject gameObject4 = Object.Instantiate(StudentManager.LightSwitch.Electricity, targetStudent.transform.position, Quaternion.identity);
			gameObject4.transform.parent = targetStudent.BoneSets.RightLeg;
			gameObject4.transform.localPosition = Vector3.zero;
			GameObject gameObject5 = Object.Instantiate(StudentManager.LightSwitch.Electricity, targetStudent.transform.position, Quaternion.identity);
			gameObject5.transform.parent = targetStudent.BoneSets.LeftLeg;
			gameObject5.transform.localPosition = Vector3.zero;
			GameObject gameObject6 = Object.Instantiate(StudentManager.LightSwitch.Electricity, targetStudent.transform.position, Quaternion.identity);
			gameObject6.transform.parent = targetStudent.BoneSets.Head;
			gameObject6.transform.localPosition = Vector3.zero;
			GameObject gameObject7 = Object.Instantiate(StudentManager.LightSwitch.Electricity, targetStudent.transform.position, Quaternion.identity);
			gameObject7.transform.parent = targetStudent.Hips;
			gameObject7.transform.localPosition = Vector3.zero;
			AudioSource.PlayClipAtPoint(StudentManager.LightSwitch.Flick[2], targetStudent.transform.position + Vector3.up);
		}
		else if (Effect == 2)
		{
			Object.Instantiate(Yandere.FalconPunch, Yandere.TargetStudent.transform.position + new Vector3(0f, 0.5f, 0f) - Yandere.transform.forward * 0.5f, Quaternion.identity);
		}
		else if (Effect == 3)
		{
			Object.Instantiate(Yandere.EbolaEffect, Yandere.TargetStudent.transform.position + Vector3.up, Quaternion.identity);
			Yandere.TargetStudent.SpawnAlarmDisc();
			Yandere.TargetStudent.BecomeRagdoll();
		}
		else if (Effect == 4)
		{
			if (Yandere.TargetStudent.Male)
			{
				Object.Instantiate(MaleBloodyScream, Yandere.TargetStudent.transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
			}
			else
			{
				Object.Instantiate(FemaleBloodyScream, Yandere.TargetStudent.transform.position + new Vector3(0f, 1f, 0f), Quaternion.identity);
			}
			Yandere.TargetStudent.BecomeRagdoll();
			Yandere.TargetStudent.Ragdoll.Dismember();
		}
		else if (Effect == 5)
		{
			Yandere.TargetStudent.TurnToStone();
		}
		Yandere.TargetStudent.Prompt.Hide();
		Yandere.TargetStudent.Prompt.enabled = false;
	}
}
