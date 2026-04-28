using UnityEngine;

public class RPG_Controller : MonoBehaviour
{
	public static RPG_Controller instance;

	public CharacterController characterController;

	public float walkSpeed = 10f;

	public float turnSpeed = 2.5f;

	public float jumpHeight = 10f;

	public float gravity = 20f;

	public float fallingThreshold = -6f;

	private Vector3 playerDir;

	private Vector3 playerDirWorld;

	private Vector3 rotation = Vector3.zero;

	private void Awake()
	{
		instance = this;
		characterController = GetComponent("CharacterController") as CharacterController;
		RPG_Camera.CameraSetup();
	}

	private void Update()
	{
		if (!(Camera.main == null))
		{
			if (characterController == null)
			{
				Debug.Log("Error: No Character Controller component found! Please add one to the GameObject which has this script attached.");
				return;
			}
			GetInput();
			StartMotor();
		}
	}

	private void GetInput()
	{
		float num = 0f;
		float num2 = 0f;
		if (ControlFreak2.CF2Input.GetButton("Horizontal Strafe"))
		{
			num = ((ControlFreak2.CF2Input.GetAxis("Horizontal Strafe") < 0f) ? (-1f) : ((!(ControlFreak2.CF2Input.GetAxis("Horizontal Strafe") > 0f)) ? 0f : 1f));
		}
		if (ControlFreak2.CF2Input.GetButton("Vertical"))
		{
			num2 = ((ControlFreak2.CF2Input.GetAxis("Vertical") < 0f) ? (-1f) : ((!(ControlFreak2.CF2Input.GetAxis("Vertical") > 0f)) ? 0f : 1f));
		}
		if (ControlFreak2.CF2Input.GetMouseButton(0) && ControlFreak2.CF2Input.GetMouseButton(1))
		{
			num2 = 1f;
		}
		playerDir = num * Vector3.right + num2 * Vector3.forward;
		if (RPG_Animation.instance != null)
		{
			RPG_Animation.instance.SetCurrentMoveDir(playerDir);
		}
		if (characterController.isGrounded)
		{
			playerDirWorld = base.transform.TransformDirection(playerDir);
			if (Mathf.Abs(playerDir.x) + Mathf.Abs(playerDir.z) > 1f)
			{
				playerDirWorld.Normalize();
			}
			playerDirWorld *= walkSpeed;
			playerDirWorld.y = fallingThreshold;
			if (ControlFreak2.CF2Input.GetButtonDown("Jump"))
			{
				playerDirWorld.y = jumpHeight;
				if (RPG_Animation.instance != null)
				{
					RPG_Animation.instance.Jump();
				}
			}
		}
		rotation.y = ControlFreak2.CF2Input.GetAxis("Horizontal") * turnSpeed;
	}

	private void StartMotor()
	{
		playerDirWorld.y -= gravity * Time.deltaTime;
		characterController.Move(playerDirWorld * Time.deltaTime);
		base.transform.Rotate(rotation);
		if (!ControlFreak2.CF2Input.GetMouseButton(0))
		{
			RPG_Camera.instance.RotateWithCharacter();
		}
	}
}
