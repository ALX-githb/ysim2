#pragma warning disable 618 // Unity-deprecated APIs (AIBase.target, AIPath.speed, WWW, GetInstanceID, CF2Input.GetKeyDown(string), Physics2D.OverlapPointNonAlloc) still functional; full migration would change behavior or require coroutine refactors.
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
