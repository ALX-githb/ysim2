using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_succubus_a_seduce : MonoBehaviour
{
	public GameObject particleInstanceFile;

	public virtual void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			setParticle();
		}
		if (!GetComponent<Animation>().IsPlaying("succubus_a_charm_02"))
		{
			GetComponent<Animation>().wrapMode = WrapMode.Loop;
			GetComponent<Animation>().CrossFade("succubus_a_idle_01");
		}
	}

	public virtual void setParticle()
	{
		if (!GetComponent<Animation>().IsPlaying("succubus_a_charm_02"))
		{
			GetComponent<Animation>().wrapMode = WrapMode.Once;
			GetComponent<Animation>().CrossFade("succubus_a_charm_02");
			UnityEngine.Object.Instantiate(particleInstanceFile, new Vector3(0f, 0f, 0f), Quaternion.identity);
		}
	}

	public virtual void Main()
	{
	}
}
