using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_succubus_a_seduced : MonoBehaviour
{
	public GameObject particleFile;

	private float wetingTime;

	private bool playFlg;

	private float time;

	public succubus_twins_character_pack_succubus_a_seduced()
	{
		wetingTime = 0.1f;
		playFlg = true;
	}

	public virtual void Update()
	{
		time += Time.deltaTime;
		GetComponent<Animation>().Play("succubus_a_death_lp");
		if (playFlg && !(time <= wetingTime))
		{
			Vector3 position = GameObject.Find("Head_null").transform.position;
			UnityEngine.Object.Instantiate(particleFile, position, gameObject.transform.rotation);
			playFlg = false;
		}
	}

	public virtual void Main()
	{
	}
}
