using UnityEngine;

public class InputDeviceScript : MonoBehaviour
{
	public InputDeviceType Type = InputDeviceType.Gamepad;

	public Vector3 MousePrevious;

	public Vector3 MouseDelta;

	public float Horizontal;

	public float Vertical;

	private void Update()
	{
		MouseDelta = ControlFreak2.CF2Input.mousePosition - MousePrevious;
		MousePrevious = ControlFreak2.CF2Input.mousePosition;
		InputDeviceType type = Type;
		if (ControlFreak2.CF2Input.anyKey || ControlFreak2.CF2Input.GetMouseButton(0) || ControlFreak2.CF2Input.GetMouseButton(1) || ControlFreak2.CF2Input.GetMouseButton(2) || MouseDelta != Vector3.zero)
		{
			Type = InputDeviceType.MouseAndKeyboard;
		}
		if (ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button0) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button1) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button2) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button3) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button4) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button5) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button6) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button7) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button8) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button9) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button10) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button11) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button12) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button13) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button14) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button15) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button16) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button17) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button18) || ControlFreak2.CF2Input.GetKey(KeyCode.Joystick1Button19) || ControlFreak2.CF2Input.GetAxis("DpadX") > 0.5f || ControlFreak2.CF2Input.GetAxis("DpadX") < -0.5f || ControlFreak2.CF2Input.GetAxis("DpadY") > 0.5f || ControlFreak2.CF2Input.GetAxis("DpadY") < -0.5f)
		{
			Type = InputDeviceType.Gamepad;
		}
		if (!ControlFreak2.CF2Input.GetKey(KeyCode.W) && !ControlFreak2.CF2Input.GetKey(KeyCode.A) && !ControlFreak2.CF2Input.GetKey(KeyCode.S) && !ControlFreak2.CF2Input.GetKey(KeyCode.D) && (ControlFreak2.CF2Input.GetAxis("Vertical") == 1f || ControlFreak2.CF2Input.GetAxis("Vertical") == -1f || ControlFreak2.CF2Input.GetAxis("Horizontal") == 1f || ControlFreak2.CF2Input.GetAxis("Horizontal") == -1f))
		{
			Type = InputDeviceType.Gamepad;
		}
		if (Type != type)
		{
			PromptSwapScript[] array = Resources.FindObjectsOfTypeAll<PromptSwapScript>();
			PromptSwapScript[] array2 = array;
			foreach (PromptSwapScript promptSwapScript in array2)
			{
				promptSwapScript.UpdateSpriteType(Type);
			}
		}
		Horizontal = ControlFreak2.CF2Input.GetAxis("Horizontal");
		Vertical = ControlFreak2.CF2Input.GetAxis("Vertical");
	}
}
