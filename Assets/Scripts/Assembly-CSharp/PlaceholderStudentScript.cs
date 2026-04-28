using UnityEngine;

public class PlaceholderStudentScript : MonoBehaviour
{
	public GameObject EmptyGameObject;

	public Transform Target;

	public int NESW;

	private void Start()
	{
		Target = Object.Instantiate(EmptyGameObject).transform;
		ChooseNewDestination();
	}

	private void Update()
	{
		base.transform.LookAt(Target.position);
		base.transform.position = Vector3.MoveTowards(base.transform.position, Target.position, Time.deltaTime);
		if (Vector3.Distance(base.transform.position, Target.position) < 1f)
		{
			ChooseNewDestination();
		}
	}

	private void ChooseNewDestination()
	{
		if (NESW == 1)
		{
			Target.position = new Vector3(Random.Range(-21f, 21f), base.transform.position.y, Random.Range(21f, 19f));
		}
		else if (NESW == 2)
		{
			Target.position = new Vector3(Random.Range(19f, 21f), base.transform.position.y, Random.Range(29f, -37f));
		}
		else if (NESW == 3)
		{
			Target.position = new Vector3(Random.Range(-21f, 21f), base.transform.position.y, Random.Range(-21f, -19f));
		}
		else if (NESW == 4)
		{
			Target.position = new Vector3(Random.Range(-19f, -21f), base.transform.position.y, Random.Range(29f, -37f));
		}
	}
}
