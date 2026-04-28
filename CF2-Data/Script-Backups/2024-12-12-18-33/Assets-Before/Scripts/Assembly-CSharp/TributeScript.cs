using UnityEngine;

public class TributeScript : MonoBehaviour
{
	public GameObject Rainey;

	public string[] Letter;

	public int ID;

	private void Start()
	{
		Rainey.SetActive(false);
	}

	private void Update()
	{
		if (Input.GetKeyDown(Letter[ID]))
		{
			ID++;
			if (ID == Letter.Length)
			{
				Rainey.SetActive(true);
				base.enabled = false;
			}
		}
	}
}
