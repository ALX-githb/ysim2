using UnityEngine;

public class GradingPaperScript : MonoBehaviour
{
	public StudentScript Teacher;

	public GameObject Character;

	public Transform LeftHand;

	public Transform Chair;

	public Transform Paper;

	public float PickUpTime1;

	public float SetDownTime1;

	public float PickUpTime2;

	public float SetDownTime2;

	public Vector3 OriginalPosition;

	public Vector3 PickUpPosition1;

	public Vector3 SetDownPosition1;

	public Vector3 PickUpPosition2;

	public Vector3 PickUpRotation1;

	public Vector3 SetDownRotation1;

	public Vector3 PickUpRotation2;

	public int Phase = 1;

	public float Speed = 1f;

	public bool Writing;

	private void Start()
	{
		OriginalPosition = Chair.position;
	}

	private void Update()
	{
		if (!Writing)
		{
			Chair.position = Vector3.Lerp(Chair.position, OriginalPosition, Time.deltaTime * 10f);
		}
		else
		{
			if (!(Character != null))
			{
				return;
			}
			Chair.position = Vector3.Lerp(Chair.position, Character.transform.position + Character.transform.forward * 0.1f, Time.deltaTime * 10f);
			if (Phase == 1)
			{
				if (Character.GetComponent<Animation>()["f02_deskWrite"].time > PickUpTime1)
				{
					Character.GetComponent<Animation>()["f02_deskWrite"].speed = Speed;
					Paper.parent = LeftHand;
					Paper.localPosition = PickUpPosition1;
					Paper.localEulerAngles = PickUpRotation1;
					Paper.localScale = new Vector3(0.9090909f, 0.9090909f, 0.9090909f);
					Phase++;
				}
			}
			else if (Phase == 2)
			{
				if (Character.GetComponent<Animation>()["f02_deskWrite"].time > SetDownTime1)
				{
					Paper.parent = Character.transform;
					Paper.localPosition = SetDownPosition1;
					Paper.localEulerAngles = SetDownRotation1;
					Phase++;
				}
			}
			else if (Phase == 3)
			{
				if (Character.GetComponent<Animation>()["f02_deskWrite"].time > PickUpTime2)
				{
					Paper.parent = LeftHand;
					Paper.localPosition = PickUpPosition2;
					Paper.localEulerAngles = PickUpRotation2;
					Phase++;
				}
			}
			else if (Phase == 4)
			{
				if (Character.GetComponent<Animation>()["f02_deskWrite"].time > SetDownTime2)
				{
					Paper.parent = Character.transform;
					Paper.localScale = Vector3.zero;
					Phase++;
				}
			}
			else if (Phase == 5 && Character.GetComponent<Animation>()["f02_deskWrite"].time >= Character.GetComponent<Animation>()["f02_deskWrite"].length)
			{
				Character.GetComponent<Animation>()["f02_deskWrite"].time = 0f;
				Character.GetComponent<Animation>().Play("f02_deskWrite");
				Phase = 1;
			}
			if (Teacher.Actions[Teacher.Phase] != StudentActionType.GradePapers || !Teacher.Routine || Teacher.Stop)
			{
				Paper.localScale = Vector3.zero;
				Teacher.Obstacle.enabled = false;
				Teacher.Pen.SetActive(false);
				Writing = false;
				Phase = 1;
			}
		}
	}
}
