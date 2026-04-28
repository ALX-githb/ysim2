using System;
using UnityEngine;

[Serializable]
public class succubus_twins_character_pack_right_hand_follow : MonoBehaviour
{
	public virtual void Update()
	{
		transform.position = GameObject.Find("RightHanditem_Null").transform.position;
	}

	public virtual void Main()
	{
	}
}
