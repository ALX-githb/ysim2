using UnityEngine;

public class SlowMoScript : MonoBehaviour
{
	public bool Spinning;

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.S))
		{
			Spinning = !Spinning;
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Space))
		{
			Time.timeScale = 0.5f;
		}
		if (ControlFreak2.CF2Input.GetKeyDown("-"))
		{
			Time.timeScale -= 1f;
		}
		if (ControlFreak2.CF2Input.GetKeyDown("="))
		{
			Time.timeScale += 1f;
		}
		if (Spinning)
		{
			base.transform.parent.transform.localEulerAngles += new Vector3(0f, Time.deltaTime * 36f, 0f);
		}
	}
}
