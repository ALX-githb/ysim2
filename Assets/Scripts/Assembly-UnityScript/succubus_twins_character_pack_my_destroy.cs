using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_my_destroy : MonoBehaviour
{
	public float waitingTime;

	private float time;

	public succubus_twins_character_pack_my_destroy()
	{
		waitingTime = 1f;
	}

	public virtual void Update()
	{
		time += Time.deltaTime;
		if (!(time <= waitingTime))
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
