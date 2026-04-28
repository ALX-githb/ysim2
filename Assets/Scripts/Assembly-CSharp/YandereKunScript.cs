using UnityEngine;

public class YandereKunScript : MonoBehaviour
{
	public Transform ChanItemParent;

	public Transform KunItemParent;

	public Transform ChanHips;

	public Transform ChanSpine;

	public Transform ChanSpine1;

	public Transform ChanSpine2;

	public Transform ChanSpine3;

	public Transform ChanNeck;

	public Transform ChanHead;

	public Transform ChanRightUpLeg;

	public Transform ChanRightLeg;

	public Transform ChanRightFoot;

	public Transform ChanRightToes;

	public Transform ChanLeftUpLeg;

	public Transform ChanLeftLeg;

	public Transform ChanLeftFoot;

	public Transform ChanLeftToes;

	public Transform ChanRightShoulder;

	public Transform ChanRightArm;

	public Transform ChanRightArmRoll;

	public Transform ChanRightForeArm;

	public Transform ChanRightForeArmRoll;

	public Transform ChanRightHand;

	public Transform ChanLeftShoulder;

	public Transform ChanLeftArm;

	public Transform ChanLeftArmRoll;

	public Transform ChanLeftForeArm;

	public Transform ChanLeftForeArmRoll;

	public Transform ChanLeftHand;

	public Transform ChanLeftHandPinky1;

	public Transform ChanLeftHandPinky2;

	public Transform ChanLeftHandPinky3;

	public Transform ChanLeftHandRing1;

	public Transform ChanLeftHandRing2;

	public Transform ChanLeftHandRing3;

	public Transform ChanLeftHandMiddle1;

	public Transform ChanLeftHandMiddle2;

	public Transform ChanLeftHandMiddle3;

	public Transform ChanLeftHandIndex1;

	public Transform ChanLeftHandIndex2;

	public Transform ChanLeftHandIndex3;

	public Transform ChanLeftHandThumb1;

	public Transform ChanLeftHandThumb2;

	public Transform ChanLeftHandThumb3;

	public Transform ChanRightHandPinky1;

	public Transform ChanRightHandPinky2;

	public Transform ChanRightHandPinky3;

	public Transform ChanRightHandRing1;

	public Transform ChanRightHandRing2;

	public Transform ChanRightHandRing3;

	public Transform ChanRightHandMiddle1;

	public Transform ChanRightHandMiddle2;

	public Transform ChanRightHandMiddle3;

	public Transform ChanRightHandIndex1;

	public Transform ChanRightHandIndex2;

	public Transform ChanRightHandIndex3;

	public Transform ChanRightHandThumb1;

	public Transform ChanRightHandThumb2;

	public Transform ChanRightHandThumb3;

	public Transform KunHips;

	public Transform KunSpine;

	public Transform KunSpine1;

	public Transform KunSpine2;

	public Transform KunSpine3;

	public Transform KunNeck;

	public Transform KunHead;

	public Transform KunRightUpLeg;

	public Transform KunRightLeg;

	public Transform KunRightFoot;

	public Transform KunRightToes;

	public Transform KunLeftUpLeg;

	public Transform KunLeftLeg;

	public Transform KunLeftFoot;

	public Transform KunLeftToes;

	public Transform KunRightShoulder;

	public Transform KunRightArm;

	public Transform KunRightArmRoll;

	public Transform KunRightForeArm;

	public Transform KunRightForeArmRoll;

	public Transform KunRightHand;

	public Transform KunLeftShoulder;

	public Transform KunLeftArm;

	public Transform KunLeftArmRoll;

	public Transform KunLeftForeArm;

	public Transform KunLeftForeArmRoll;

	public Transform KunLeftHand;

	public Transform KunLeftHandPinky1;

	public Transform KunLeftHandPinky2;

	public Transform KunLeftHandPinky3;

	public Transform KunLeftHandRing1;

	public Transform KunLeftHandRing2;

	public Transform KunLeftHandRing3;

	public Transform KunLeftHandMiddle1;

	public Transform KunLeftHandMiddle2;

	public Transform KunLeftHandMiddle3;

	public Transform KunLeftHandIndex1;

	public Transform KunLeftHandIndex2;

	public Transform KunLeftHandIndex3;

	public Transform KunLeftHandThumb1;

	public Transform KunLeftHandThumb2;

	public Transform KunLeftHandThumb3;

	public Transform KunRightHandPinky1;

	public Transform KunRightHandPinky2;

	public Transform KunRightHandPinky3;

	public Transform KunRightHandRing1;

	public Transform KunRightHandRing2;

	public Transform KunRightHandRing3;

	public Transform KunRightHandMiddle1;

	public Transform KunRightHandMiddle2;

	public Transform KunRightHandMiddle3;

	public Transform KunRightHandIndex1;

	public Transform KunRightHandIndex2;

	public Transform KunRightHandIndex3;

	public Transform KunRightHandThumb1;

	public Transform KunRightHandThumb2;

	public Transform KunRightHandThumb3;

	public SkinnedMeshRenderer SecondRenderer;

	public SkinnedMeshRenderer MyRenderer;

	public bool Kizuna;

	public int ID;

	private void Start()
	{
		if (!Kizuna)
		{
			KunHips.parent = ChanHips;
			KunSpine.parent = ChanSpine;
			KunSpine1.parent = ChanSpine1;
			KunSpine2.parent = ChanSpine2;
			KunSpine3.parent = ChanSpine3;
			KunNeck.parent = ChanNeck;
			KunHead.parent = ChanHead;
			KunRightUpLeg.parent = ChanRightUpLeg;
			KunRightLeg.parent = ChanRightLeg;
			KunRightFoot.parent = ChanRightFoot;
			KunRightToes.parent = ChanRightToes;
			KunLeftUpLeg.parent = ChanLeftUpLeg;
			KunLeftLeg.parent = ChanLeftLeg;
			KunLeftFoot.parent = ChanLeftFoot;
			KunLeftToes.parent = ChanLeftToes;
			KunRightShoulder.parent = ChanRightShoulder;
			KunRightArm.parent = ChanRightArm;
			KunRightArmRoll.parent = ChanRightArmRoll;
			KunRightForeArm.parent = ChanRightForeArm;
			KunRightForeArmRoll.parent = ChanRightForeArmRoll;
			KunRightHand.parent = ChanRightHand;
			KunLeftShoulder.parent = ChanLeftShoulder;
			KunLeftArm.parent = ChanLeftArm;
			KunLeftArmRoll.parent = ChanLeftArmRoll;
			KunLeftForeArmRoll.parent = ChanLeftForeArmRoll;
			KunLeftForeArm.parent = ChanLeftForeArm;
			KunLeftHand.parent = ChanLeftHand;
			KunLeftHandPinky1.parent = ChanLeftHandPinky1;
			KunLeftHandPinky2.parent = ChanLeftHandPinky2;
			KunLeftHandPinky3.parent = ChanLeftHandPinky3;
			KunLeftHandRing1.parent = ChanLeftHandRing1;
			KunLeftHandRing2.parent = ChanLeftHandRing2;
			KunLeftHandRing3.parent = ChanLeftHandRing3;
			KunLeftHandMiddle1.parent = ChanLeftHandMiddle1;
			KunLeftHandMiddle2.parent = ChanLeftHandMiddle2;
			KunLeftHandMiddle3.parent = ChanLeftHandMiddle3;
			KunLeftHandIndex1.parent = ChanLeftHandIndex1;
			KunLeftHandIndex2.parent = ChanLeftHandIndex2;
			KunLeftHandIndex3.parent = ChanLeftHandIndex3;
			KunLeftHandThumb1.parent = ChanLeftHandThumb1;
			KunLeftHandThumb2.parent = ChanLeftHandThumb2;
			KunLeftHandThumb3.parent = ChanLeftHandThumb3;
			KunRightHandPinky1.parent = ChanRightHandPinky1;
			KunRightHandPinky2.parent = ChanRightHandPinky2;
			KunRightHandPinky3.parent = ChanRightHandPinky3;
			KunRightHandRing1.parent = ChanRightHandRing1;
			KunRightHandRing2.parent = ChanRightHandRing2;
			KunRightHandRing3.parent = ChanRightHandRing3;
			KunRightHandMiddle1.parent = ChanRightHandMiddle1;
			KunRightHandMiddle2.parent = ChanRightHandMiddle2;
			KunRightHandMiddle3.parent = ChanRightHandMiddle3;
			KunRightHandIndex1.parent = ChanRightHandIndex1;
			KunRightHandIndex2.parent = ChanRightHandIndex2;
			KunRightHandIndex3.parent = ChanRightHandIndex3;
			KunRightHandThumb1.parent = ChanRightHandThumb1;
			KunRightHandThumb2.parent = ChanRightHandThumb2;
			KunRightHandThumb3.parent = ChanRightHandThumb3;
		}
		MyRenderer.enabled = true;
		if (SecondRenderer != null)
		{
			SecondRenderer.enabled = true;
		}
		base.gameObject.SetActive(false);
	}

	private void LateUpdate()
	{
		if (!Kizuna)
		{
			return;
		}
		KunItemParent.localPosition = new Vector3(0.066666f, -0.033333f, 0.02f);
		ChanItemParent.position = KunItemParent.position;
		KunHips.localPosition = ChanHips.localPosition;
		KunHips.localEulerAngles = ChanHips.localEulerAngles;
		KunSpine.localEulerAngles = ChanSpine.localEulerAngles;
		KunSpine1.localEulerAngles = ChanSpine1.localEulerAngles;
		KunSpine2.localEulerAngles = ChanSpine2.localEulerAngles;
		KunSpine3.localEulerAngles = ChanSpine3.localEulerAngles;
		KunNeck.localEulerAngles = ChanNeck.localEulerAngles;
		KunHead.localEulerAngles = ChanHead.localEulerAngles;
		KunRightUpLeg.localEulerAngles = ChanRightUpLeg.localEulerAngles;
		KunRightLeg.localEulerAngles = ChanRightLeg.localEulerAngles;
		KunRightFoot.localEulerAngles = ChanRightFoot.localEulerAngles;
		KunRightToes.localEulerAngles = ChanRightToes.localEulerAngles;
		KunLeftUpLeg.localEulerAngles = ChanLeftUpLeg.localEulerAngles;
		KunLeftLeg.localEulerAngles = ChanLeftLeg.localEulerAngles;
		KunLeftFoot.localEulerAngles = ChanLeftFoot.localEulerAngles;
		KunLeftToes.localEulerAngles = ChanLeftToes.localEulerAngles;
		KunRightShoulder.localEulerAngles = ChanRightShoulder.localEulerAngles;
		KunRightArm.localEulerAngles = ChanRightArm.localEulerAngles;
		KunRightArmRoll.localEulerAngles = ChanRightArmRoll.localEulerAngles;
		KunRightForeArm.localEulerAngles = ChanRightForeArm.localEulerAngles;
		KunRightForeArmRoll.localEulerAngles = ChanRightForeArmRoll.localEulerAngles;
		KunRightHand.localEulerAngles = ChanRightHand.localEulerAngles;
		KunLeftShoulder.localEulerAngles = ChanLeftShoulder.localEulerAngles;
		KunLeftArm.localEulerAngles = ChanLeftArm.localEulerAngles;
		KunLeftArmRoll.localEulerAngles = ChanLeftArmRoll.localEulerAngles;
		KunLeftForeArmRoll.localEulerAngles = ChanLeftForeArmRoll.localEulerAngles;
		KunLeftForeArm.localEulerAngles = ChanLeftForeArm.localEulerAngles;
		KunLeftHand.localEulerAngles = ChanLeftHand.localEulerAngles;
		KunLeftHandPinky1.localEulerAngles = ChanLeftHandPinky1.localEulerAngles;
		KunLeftHandPinky2.localEulerAngles = ChanLeftHandPinky2.localEulerAngles;
		KunLeftHandPinky3.localEulerAngles = ChanLeftHandPinky3.localEulerAngles;
		KunLeftHandRing1.localEulerAngles = ChanLeftHandRing1.localEulerAngles;
		KunLeftHandRing2.localEulerAngles = ChanLeftHandRing2.localEulerAngles;
		KunLeftHandRing3.localEulerAngles = ChanLeftHandRing3.localEulerAngles;
		KunLeftHandMiddle1.localEulerAngles = ChanLeftHandMiddle1.localEulerAngles;
		KunLeftHandMiddle2.localEulerAngles = ChanLeftHandMiddle2.localEulerAngles;
		KunLeftHandMiddle3.localEulerAngles = ChanLeftHandMiddle3.localEulerAngles;
		KunLeftHandIndex1.localEulerAngles = ChanLeftHandIndex1.localEulerAngles;
		KunLeftHandIndex2.localEulerAngles = ChanLeftHandIndex2.localEulerAngles;
		KunLeftHandIndex3.localEulerAngles = ChanLeftHandIndex3.localEulerAngles;
		KunLeftHandThumb1.localEulerAngles = ChanLeftHandThumb1.localEulerAngles;
		KunLeftHandThumb2.localEulerAngles = ChanLeftHandThumb2.localEulerAngles;
		KunLeftHandThumb3.localEulerAngles = ChanLeftHandThumb3.localEulerAngles;
		KunRightHandPinky1.localEulerAngles = ChanRightHandPinky1.localEulerAngles;
		KunRightHandPinky2.localEulerAngles = ChanRightHandPinky2.localEulerAngles;
		KunRightHandPinky3.localEulerAngles = ChanRightHandPinky3.localEulerAngles;
		KunRightHandRing1.localEulerAngles = ChanRightHandRing1.localEulerAngles;
		KunRightHandRing2.localEulerAngles = ChanRightHandRing2.localEulerAngles;
		KunRightHandRing3.localEulerAngles = ChanRightHandRing3.localEulerAngles;
		KunRightHandMiddle1.localEulerAngles = ChanRightHandMiddle1.localEulerAngles;
		KunRightHandMiddle2.localEulerAngles = ChanRightHandMiddle2.localEulerAngles;
		KunRightHandMiddle3.localEulerAngles = ChanRightHandMiddle3.localEulerAngles;
		KunRightHandIndex1.localEulerAngles = ChanRightHandIndex1.localEulerAngles;
		KunRightHandIndex2.localEulerAngles = ChanRightHandIndex2.localEulerAngles;
		KunRightHandIndex3.localEulerAngles = ChanRightHandIndex3.localEulerAngles;
		KunRightHandThumb1.localEulerAngles = ChanRightHandThumb1.localEulerAngles;
		KunRightHandThumb2.localEulerAngles = ChanRightHandThumb2.localEulerAngles;
		KunRightHandThumb3.localEulerAngles = ChanRightHandThumb3.localEulerAngles;
		if (!ControlFreak2.CF2Input.GetKeyDown(KeyCode.Space))
		{
			return;
		}
		if (ID > -1)
		{
			for (int i = 0; i < 32; i++)
			{
				SecondRenderer.SetBlendShapeWeight(i, 0f);
			}
			if (ID > 32)
			{
				ID = 0;
			}
			SecondRenderer.SetBlendShapeWeight(ID, 100f);
		}
		ID++;
	}
}
