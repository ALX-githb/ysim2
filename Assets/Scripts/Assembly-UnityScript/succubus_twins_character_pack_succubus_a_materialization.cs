using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_succubus_a_materialization : MonoBehaviour
{
	public GameObject particleFile;

	public virtual void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			setParticle();
		}
		if (!GetComponent<Animation>().IsPlaying("succubus_a_appear_float"))
		{
			GetComponent<Animation>().wrapMode = WrapMode.Loop;
			GetComponent<Animation>().CrossFade("succubus_a_idle_01");
		}
	}

	public virtual void setParticle()
	{
		if (!GetComponent<Animation>().IsPlaying("succubus_a_appear_float"))
		{
			GetComponent<Animation>().wrapMode = WrapMode.Once;
			GetComponent<Animation>().CrossFade("succubus_a_appear_float");
			Vector3 position = gameObject.transform.position;
			position.y += 0.01f;
			UnityEngine.Object.Instantiate(particleFile, position, gameObject.transform.rotation);
		}
	}

	public virtual void Main()
	{
	}
}
