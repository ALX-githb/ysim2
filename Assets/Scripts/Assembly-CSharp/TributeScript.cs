#pragma warning disable 618 // Unity-deprecated APIs (AIBase.target, AIPath.speed, WWW, GetInstanceID, CF2Input.GetKeyDown(string), Physics2D.OverlapPointNonAlloc) still functional; full migration would change behavior or require coroutine refactors.
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
		if (ControlFreak2.CF2Input.GetKeyDown(Letter[ID]))
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
