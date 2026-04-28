using UnityEngine;

public class YouTubeScript : MonoBehaviour
{
	public float Timer;

	private void Update()
	{
		Timer += Time.deltaTime;
		if (Timer > 1f)
		{
			GetComponent<AudioSource>().Play();
			Object.Destroy(this);
		}
	}
}
