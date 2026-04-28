using UnityEngine;

public class CabinetDoorScript : MonoBehaviour
{
	public PromptScript Prompt;

	public bool Locked;

	public bool Open;

	private void Update()
	{
		if (Locked)
		{
			Prompt.Circle[0].fillAmount = 1f;
			return;
		}
		if (Prompt.Circle[0].fillAmount == 0f)
		{
			Prompt.Yandere.TheftTimer = 0.1f;
			Prompt.Circle[0].fillAmount = 1f;
			Open = !Open;
			UpdateLabel();
		}
		base.transform.localPosition = new Vector3(Mathf.Lerp(base.transform.localPosition.x, (!Open) ? 0f : 0.41775f, Time.deltaTime * 10f), base.transform.localPosition.y, base.transform.localPosition.z);
	}

	private void UpdateLabel()
	{
		if (Open)
		{
			Prompt.Label[0].text = "     Close";
		}
		else
		{
			Prompt.Label[0].text = "     Open";
		}
	}
}
