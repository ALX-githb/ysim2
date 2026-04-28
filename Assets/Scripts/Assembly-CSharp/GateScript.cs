using UnityEngine;

public class GateScript : MonoBehaviour
{
	public Collider EmergencyDoor;

	public ClockScript Clock;

	public Collider GateCollider;

	public Transform RightGate;

	public Transform LeftGate;

	public bool UpdateGates;

	public bool Closed;

	private void Update()
	{
		if (Clock.PresentTime / 60f > 8f && Clock.PresentTime / 60f < 15.5f)
		{
			Closed = true;
			if (EmergencyDoor.enabled)
			{
				EmergencyDoor.enabled = false;
			}
		}
		else
		{
			Closed = false;
			if (!EmergencyDoor.enabled)
			{
				EmergencyDoor.enabled = true;
			}
		}
		if (!Closed)
		{
			RightGate.localPosition = new Vector3(Mathf.Lerp(RightGate.localPosition.x, 7f, Time.deltaTime), RightGate.localPosition.y, RightGate.localPosition.z);
			LeftGate.localPosition = new Vector3(Mathf.Lerp(LeftGate.localPosition.x, -7f, Time.deltaTime), LeftGate.localPosition.y, LeftGate.localPosition.z);
		}
		else
		{
			RightGate.localPosition = new Vector3(Mathf.Lerp(RightGate.localPosition.x, 2.325f, Time.deltaTime), RightGate.localPosition.y, RightGate.localPosition.z);
			LeftGate.localPosition = new Vector3(Mathf.Lerp(LeftGate.localPosition.x, -2.325f, Time.deltaTime), LeftGate.localPosition.y, LeftGate.localPosition.z);
		}
	}
}
