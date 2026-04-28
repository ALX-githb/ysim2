using UnityEngine;

public class TranquilizerScript : MonoBehaviour
{
	public YandereScript Yandere;

	public PromptScript Prompt;

	private void Update()
	{
		if (Prompt.Circle[0].fillAmount == 0f)
		{
			Yandere.Inventory.Tranquilizer = true;
			Yandere.TheftTimer = 0.1f;
			Object.Destroy(base.gameObject);
		}
	}
}
