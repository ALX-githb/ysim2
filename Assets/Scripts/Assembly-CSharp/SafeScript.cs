using UnityEngine;

public class SafeScript : MonoBehaviour
{
	public MissionModeScript MissionMode;

	public PromptScript ContentsPrompt;

	public PromptScript SafePrompt;

	public PromptScript KeyPrompt;

	public Transform Door;

	public GameObject Key;

	public float Rotation;

	public bool Open;

	private void Start()
	{
		ContentsPrompt.MyCollider.enabled = false;
		SafePrompt.enabled = false;
	}

	private void Update()
	{
		if (Key.activeInHierarchy && KeyPrompt.Circle[0].fillAmount == 0f)
		{
			KeyPrompt.Yandere.Inventory.SafeKey = true;
			SafePrompt.enabled = true;
			Key.SetActive(false);
		}
		if (SafePrompt.Circle[0].fillAmount == 0f)
		{
			KeyPrompt.Yandere.Inventory.SafeKey = false;
			ContentsPrompt.MyCollider.enabled = true;
			Open = true;
			SafePrompt.Hide();
			SafePrompt.enabled = false;
		}
		if (ContentsPrompt.Circle[0].fillAmount == 0f)
		{
			MissionMode.DocumentsStolen = true;
			base.enabled = false;
			ContentsPrompt.Hide();
			ContentsPrompt.enabled = false;
			ContentsPrompt.gameObject.SetActive(false);
		}
		if (Open)
		{
			Rotation = Mathf.Lerp(Rotation, 0f, Time.deltaTime * 10f);
			Door.localEulerAngles = new Vector3(Door.localEulerAngles.x, Rotation, Door.localEulerAngles.z);
			if (Rotation < 1f)
			{
				Open = false;
			}
		}
	}
}
