using UnityEngine;

public class VendingMachineScript : MonoBehaviour
{
	public PromptScript Prompt;

	public Transform CanSpawn;

	public GameObject Can;

	private void Update()
	{
		if (Prompt.Circle[0].fillAmount == 0f)
		{
			Prompt.Circle[0].fillAmount = 1f;
			GameObject gameObject = Object.Instantiate(Can, CanSpawn.position, Quaternion.identity);
			gameObject.transform.eulerAngles = new Vector3(90f, 90f, gameObject.transform.eulerAngles.z);
			gameObject.GetComponent<AudioSource>().pitch = Random.Range(0.9f, 1.1f);
		}
	}
}
