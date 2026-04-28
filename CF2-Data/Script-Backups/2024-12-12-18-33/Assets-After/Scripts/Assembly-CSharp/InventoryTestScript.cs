using UnityEngine;

public class InventoryTestScript : MonoBehaviour
{
	public GameObject Character;

	public GameObject InverseSkirt;

	public Transform RightGrid;

	public Transform LeftGrid;

	public bool Open = true;

	private void Start()
	{
		RightGrid.localScale = new Vector3(0.7f, 0.7f, 0.7f);
		LeftGrid.localScale = new Vector3(0.7f, 0.7f, 0.7f);
	}

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetButtonDown("A"))
		{
			Open = !Open;
		}
		AnimationState animationState = Character.GetComponent<Animation>()["f02_inventory_00"];
		AnimationState animationState2 = InverseSkirt.GetComponent<Animation>()["InverseSkirtOpen"];
		if (Open)
		{
			RightGrid.localScale = Vector3.MoveTowards(RightGrid.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime);
			LeftGrid.localScale = Vector3.MoveTowards(LeftGrid.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, Mathf.Lerp(base.transform.position.z, 0.5f, Time.deltaTime * 2.5f));
			animationState.speed = 1f;
			animationState2.speed = 1f;
		}
		else
		{
			RightGrid.localScale = Vector3.MoveTowards(RightGrid.localScale, new Vector3(0.7f, 0.7f, 0.7f), Time.deltaTime);
			LeftGrid.localScale = Vector3.MoveTowards(LeftGrid.localScale, new Vector3(0.7f, 0.7f, 0.7f), Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, Mathf.Lerp(base.transform.position.z, 1f, Time.deltaTime * 2.5f));
			animationState.speed = -1f;
			animationState2.speed = -1f;
		}
		if (animationState.time > animationState.length)
		{
			animationState.time = animationState.length;
		}
		if (animationState.time < 0f)
		{
			animationState.time = 0f;
		}
		if (animationState2.time > animationState2.length)
		{
			animationState2.time = animationState2.length;
		}
		if (animationState2.time < 0f)
		{
			animationState2.time = 0f;
		}
	}
}
