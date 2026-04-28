using UnityEngine;

public class FramerateScript : MonoBehaviour
{
	public float updateInterval = 0.5f;

	private UILabel fpsText;

	private float accum;

	private int frames;

	private float timeleft;

	public float FPS;

	private void Start()
	{
		fpsText = GetComponent<UILabel>();
		timeleft = updateInterval;
	}

	private void Update()
	{
		timeleft -= Time.deltaTime;
		accum += Time.timeScale / Time.deltaTime;
		frames++;
		if (timeleft <= 0f)
		{
			FPS = accum / (float)frames;
			int num = Mathf.Clamp((int)FPS, 0, Application.targetFrameRate);
			if (num > 0)
			{
				fpsText.text = "FPS: " + num;
			}
			timeleft = updateInterval;
			accum = 0f;
			frames = 0;
		}
	}
}
