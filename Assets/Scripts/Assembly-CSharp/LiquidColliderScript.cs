using UnityEngine;

public class LiquidColliderScript : MonoBehaviour
{
	private GameObject NewPool;

	public AudioClip SplashSound;

	public GameObject GroundSplash;

	public GameObject Splash;

	public GameObject Pool;

	public bool Static;

	public bool Bucket;

	public bool Blood;

	public bool Gas;

	private void Start()
	{
		if (Bucket)
		{
			GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 400f);
		}
	}

	private void Update()
	{
		if (Static)
		{
			return;
		}
		if (!Bucket)
		{
			if (base.transform.position.y < 0f)
			{
				Object.Instantiate(GroundSplash, new Vector3(base.transform.position.x, 0f, base.transform.position.z), Quaternion.identity);
				NewPool = Object.Instantiate(Pool, new Vector3(base.transform.position.x, 0.012f, base.transform.position.z), Quaternion.identity);
				NewPool.transform.localEulerAngles = new Vector3(90f, Random.Range(0f, 360f), 0f);
				if (Blood)
				{
					NewPool.transform.parent = GameObject.Find("BloodParent").transform;
				}
				Object.Destroy(base.gameObject);
			}
		}
		else
		{
			base.transform.localScale = new Vector3(base.transform.localScale.x + Time.deltaTime * 2f, base.transform.localScale.y + Time.deltaTime * 2f, base.transform.localScale.z + Time.deltaTime * 2f);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer != 9)
		{
			return;
		}
		StudentScript component = other.gameObject.GetComponent<StudentScript>();
		if (component != null && (component.StudentID == 7 || component.StudentID == component.StudentManager.RivalID))
		{
			AudioSource.PlayClipAtPoint(SplashSound, base.transform.position);
			Object.Instantiate(Splash, new Vector3(base.transform.position.x, 1.5f, base.transform.position.z), Quaternion.identity);
			if (Blood)
			{
				component.Bloody = true;
			}
			else if (Gas)
			{
				component.Gas = true;
			}
			component.GetWet();
		}
	}
}
