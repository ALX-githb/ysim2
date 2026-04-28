using UnityEngine;

public class FakeStudentSpawnerScript : MonoBehaviour
{
	public Transform FakeStudentParent;

	public GameObject NewStudent;

	public GameObject FakeFemale;

	public GameObject FakeMale;

	public GameObject Student;

	public bool AlreadySpawned;

	public int CurrentFloor;

	public int CurrentRow;

	public int FloorLimit;

	public int RowLimit;

	public int Spawned;

	public int Height;

	public int NESW;

	public void Spawn()
	{
		if (!AlreadySpawned)
		{
			Student = FakeFemale;
			NESW = 1;
			while (Spawned < FloorLimit * 3)
			{
				if (NESW == 1)
				{
					NewStudent = Object.Instantiate(Student, new Vector3(Random.Range(-21f, 21f), Height, Random.Range(21f, 19f)), Quaternion.identity);
				}
				else if (NESW == 2)
				{
					NewStudent = Object.Instantiate(Student, new Vector3(Random.Range(19f, 21f), Height, Random.Range(29f, -37f)), Quaternion.identity);
				}
				else if (NESW == 3)
				{
					NewStudent = Object.Instantiate(Student, new Vector3(Random.Range(-21f, 21f), Height, Random.Range(-21f, -19f)), Quaternion.identity);
				}
				else if (NESW == 4)
				{
					NewStudent = Object.Instantiate(Student, new Vector3(Random.Range(-19f, -21f), Height, Random.Range(29f, -37f)), Quaternion.identity);
				}
				NewStudent.GetComponent<PlaceholderStudentScript>().NESW = NESW;
				NewStudent.transform.parent = FakeStudentParent;
				CurrentFloor++;
				CurrentRow++;
				Spawned++;
				if (CurrentFloor == FloorLimit)
				{
					CurrentFloor = 0;
					Height += 4;
				}
				if (CurrentRow == RowLimit)
				{
					CurrentRow = 0;
					NESW++;
					if (NESW > 4)
					{
						NESW = 1;
					}
				}
				Student = ((!(Student == FakeFemale)) ? FakeFemale : FakeMale);
			}
			AlreadySpawned = true;
		}
		else
		{
			FakeStudentParent.gameObject.SetActive(!FakeStudentParent.gameObject.activeInHierarchy);
		}
	}
}
