using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_seduce_particle_instance : MonoBehaviour
{
	public GameObject particle;

	public float wetingTime;

	private Transform playerBone;

	private Transform followBone;

	private float time;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		time += Time.deltaTime;
		if (!(time <= wetingTime))
		{
			followBone = GameObject.Find("b_lip_center").transform;
			playerBone = GameObject.Find("succubus").transform;
			UnityEngine.Object.Instantiate(particle, followBone.position, playerBone.rotation);
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
