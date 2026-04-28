using UnityEngine;

public class DemonArmScript : MonoBehaviour
{
	public GameObject DismembermentCollider;

	public Collider ClawCollider;

	public bool Attacking;

	public bool Attacked;

	public bool Rising = true;

	public string IdleAnim = "DemonArmIdle";

	public AudioClip Whoosh;

	private void Update()
	{
		Animation component = GetComponent<Animation>();
		if (!Rising)
		{
			if (!Attacking)
			{
				component.CrossFade(IdleAnim);
			}
			else if (!Attacked)
			{
				if (component["DemonArmAttack"].time >= component["DemonArmAttack"].length * 0.25f)
				{
					ClawCollider.enabled = true;
					Attacked = true;
				}
			}
			else if (component["DemonArmAttack"].time >= component["DemonArmAttack"].length)
			{
				component.CrossFade(IdleAnim);
				Attacking = false;
				Attacked = false;
			}
		}
		else if (component["DemonArmRise"].time > component["DemonArmRise"].length)
		{
			Rising = false;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		StudentScript component = other.gameObject.GetComponent<StudentScript>();
		if (component != null && component.StudentID > 1)
		{
			AudioSource component2 = GetComponent<AudioSource>();
			component2.clip = Whoosh;
			component2.pitch = Random.Range(-0.9f, 1.1f);
			component2.Play();
			GetComponent<Animation>().CrossFade("DemonArmAttack");
			Attacking = true;
		}
	}
}
