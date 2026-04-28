using UnityEngine;

public class HomeSleepScript : MonoBehaviour
{
	public HomeDarknessScript HomeDarkness;

	public HomeYandereScript HomeYandere;

	public HomeCameraScript HomeCamera;

	public HomeWindowScript HomeWindow;

	private void Update()
	{
		if (!HomeYandere.CanMove && !HomeDarkness.FadeOut)
		{
			if (ControlFreak2.CF2Input.GetButtonDown("A"))
			{
				HomeDarkness.Sprite.color = new Color(0f, 0f, 0f, 0f);
				HomeDarkness.FadeOut = true;
				HomeWindow.Show = false;
				base.enabled = false;
			}
			if (ControlFreak2.CF2Input.GetButtonDown("B"))
			{
				HomeCamera.Destination = HomeCamera.Destinations[0];
				HomeCamera.Target = HomeCamera.Targets[0];
				HomeYandere.CanMove = true;
				HomeWindow.Show = false;
				base.enabled = false;
			}
		}
	}
}
