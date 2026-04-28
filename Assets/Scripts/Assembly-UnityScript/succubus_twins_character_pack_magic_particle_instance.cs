using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_magic_particle_instance : MonoBehaviour
{
	public GameObject particle1;

	public GameObject particle2;

	public GameObject particle3;

	public float waitingTime1;

	public float waitingTime2;

	public string positionBoneName;

	private string rotationBoneName;

	private Transform rotationBone;

	private Transform positionBone;

	private float time;

	private int mode;

	public succubus_twins_character_pack_magic_particle_instance()
	{
		positionBoneName = "RightHanditem_Null";
		rotationBoneName = "succubus";
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		positionBone = GameObject.Find(positionBoneName).transform;
		rotationBone = GameObject.Find(rotationBoneName).transform;
		time += Time.deltaTime;
		if (mode == 0 && !(time <= waitingTime1))
		{
			mode = 1;
			time = 0f;
			UnityEngine.Object.Instantiate(particle1, positionBone.position, rotationBone.rotation);
		}
		if (mode == 1 && !(time <= waitingTime2))
		{
			mode = 2;
			time = 0f;
			UnityEngine.Object.Instantiate(particle2, positionBone.position, rotationBone.rotation);
			UnityEngine.Object.Instantiate(particle3, positionBone.position, rotationBone.rotation);
		}
		if (mode == 2)
		{
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	public virtual void Main()
	{
	}
}
