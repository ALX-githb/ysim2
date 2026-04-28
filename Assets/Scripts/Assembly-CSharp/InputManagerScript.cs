using UnityEngine;

public class InputManagerScript : MonoBehaviour
{
	public bool TappedUp;

	public bool TappedDown;

	public bool TappedRight;

	public bool TappedLeft;

	public bool DPadUp;

	public bool StickUp;

	public bool DPadDown;

	public bool StickDown;

	public bool DPadRight;

	public bool StickRight;

	public bool DPadLeft;

	public bool StickLeft;

	private void Update()
	{
		TappedUp = false;
		TappedDown = false;
		TappedRight = false;
		TappedLeft = false;
		if (ControlFreak2.CF2Input.GetAxis("DpadY") > 0.5f)
		{
			TappedUp = !DPadUp;
			DPadUp = true;
		}
		else if (ControlFreak2.CF2Input.GetAxis("DpadY") < -0.5f)
		{
			TappedDown = !DPadDown;
			DPadDown = true;
		}
		else
		{
			DPadUp = false;
			DPadDown = false;
		}
		if (!ControlFreak2.CF2Input.GetKey(KeyCode.W) && !ControlFreak2.CF2Input.GetKey(KeyCode.S))
		{
			if (ControlFreak2.CF2Input.GetAxis("Vertical") > 0.5f)
			{
				TappedUp = !StickUp;
				StickUp = !TappedDown;
			}
			else if (ControlFreak2.CF2Input.GetAxis("Vertical") < -0.5f)
			{
				TappedDown = !StickDown;
				StickDown = !TappedUp;
			}
			else
			{
				StickUp = false;
				StickDown = false;
			}
		}
		if (ControlFreak2.CF2Input.GetAxis("DpadX") > 0.5f)
		{
			TappedRight = !DPadRight;
			DPadRight = true;
		}
		else if (ControlFreak2.CF2Input.GetAxis("DpadX") < -0.5f)
		{
			TappedLeft = !DPadLeft;
			DPadLeft = true;
		}
		else
		{
			DPadRight = false;
			DPadLeft = false;
		}
		if (!ControlFreak2.CF2Input.GetKey(KeyCode.A) && !ControlFreak2.CF2Input.GetKey(KeyCode.D))
		{
			if (ControlFreak2.CF2Input.GetAxis("Horizontal") > 0.5f)
			{
				TappedRight = !StickRight;
				StickRight = true;
			}
			else if (ControlFreak2.CF2Input.GetAxis("Horizontal") < -0.5f)
			{
				TappedLeft = !StickLeft;
				StickLeft = true;
			}
			else
			{
				StickRight = false;
				StickLeft = false;
			}
		}
		if (ControlFreak2.CF2Input.GetAxis("Horizontal") < 0.5f && ControlFreak2.CF2Input.GetAxis("Horizontal") > -0.5f && ControlFreak2.CF2Input.GetAxis("DpadX") < 0.5f && ControlFreak2.CF2Input.GetAxis("DpadX") > -0.5f)
		{
			TappedRight = false;
			TappedLeft = false;
		}
		if (ControlFreak2.CF2Input.GetAxis("Vertical") < 0.5f && ControlFreak2.CF2Input.GetAxis("Vertical") > -0.5f && ControlFreak2.CF2Input.GetAxis("DpadY") < 0.5f && ControlFreak2.CF2Input.GetAxis("DpadY") > -0.5f)
		{
			TappedUp = false;
			TappedDown = false;
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.W) || ControlFreak2.CF2Input.GetKeyDown(KeyCode.UpArrow))
		{
			TappedUp = true;
			NoStick();
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.S) || ControlFreak2.CF2Input.GetKeyDown(KeyCode.DownArrow))
		{
			TappedDown = true;
			NoStick();
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.A) || ControlFreak2.CF2Input.GetKeyDown(KeyCode.LeftArrow))
		{
			TappedLeft = true;
			NoStick();
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.D) || ControlFreak2.CF2Input.GetKeyDown(KeyCode.RightArrow))
		{
			TappedRight = true;
			NoStick();
		}
	}

	private void NoStick()
	{
		StickUp = false;
		StickDown = false;
		StickLeft = false;
		StickRight = false;
	}
}
