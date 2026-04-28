using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_succubus_b_damage : MonoBehaviour
{
	public GameObject particleFile;

	public virtual void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			setParticle();
		}
		if (!GetComponent<Animation>().IsPlaying("succubus_b_damage_l"))
		{
			GetComponent<Animation>().wrapMode = WrapMode.Loop;
			GetComponent<Animation>().CrossFade("succubus_b_idle_01");
		}
	}

	public virtual void setParticle()
	{
		if (!GetComponent<Animation>().IsPlaying("succubus_b_damage_l"))
		{
			GetComponent<Animation>().wrapMode = WrapMode.Once;
			GetComponent<Animation>().CrossFade("succubus_b_damage_l");
			Vector3 position = GameObject.Find("Head").transform.position;
			UnityEngine.Object.Instantiate(particleFile, position, gameObject.transform.rotation);
		}
	}

	public virtual void Main()
	{
	}
}
