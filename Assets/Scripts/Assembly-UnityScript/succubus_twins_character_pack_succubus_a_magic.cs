using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_succubus_a_magic : MonoBehaviour
{
	public GameObject particleInstanceFile;

	private float time;

	private float weitingTime;

	public succubus_twins_character_pack_succubus_a_magic()
	{
		weitingTime = 3.5f;
	}

	public virtual void Update()
	{
		time += Time.deltaTime;
		if (Input.GetMouseButtonDown(0))
		{
			setParticle();
		}
		if (!(time <= weitingTime))
		{
			GetComponent<Animation>().wrapMode = WrapMode.Loop;
			GetComponent<Animation>().CrossFade("succubus_a_idle_01");
		}
	}

	public virtual void setParticle()
	{
		if (!GetComponent<Animation>().IsPlaying("succubus_a_magic_01"))
		{
			time = 0f;
			GetComponent<Animation>().wrapMode = WrapMode.ClampForever;
			GetComponent<Animation>().CrossFade("succubus_a_magic_01");
			UnityEngine.Object.Instantiate(particleInstanceFile, new Vector3(0f, 0f, 0f), Quaternion.identity);
		}
	}

	public virtual void Main()
	{
	}
}
