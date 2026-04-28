using UnityEngine;

public class MatchTriggerScript : MonoBehaviour
{
	public StudentScript Student;

	public bool Fireball;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 9)
		{
			Student = other.gameObject.GetComponent<StudentScript>();
			if (Student == null)
			{
				GameObject gameObject = other.gameObject.transform.root.gameObject;
				Student = gameObject.GetComponent<StudentScript>();
			}
			if (Student != null && (Student.Gas || Fireball))
			{
				Student.Combust();
				Object.Destroy(base.gameObject);
			}
		}
	}
}
