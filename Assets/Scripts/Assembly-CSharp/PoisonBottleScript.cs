using UnityEngine;

public class PoisonBottleScript : MonoBehaviour
{
	public PromptScript Prompt;

	public int ID;

	private void Update()
	{
		if (Prompt.Circle[0].fillAmount == 0f)
		{
			Prompt.Yandere.TheftTimer = 0.1f;
			InventoryScript inventory = Prompt.Yandere.Inventory;
			if (ID == 1)
			{
				inventory.EmeticPoison = true;
			}
			else if (ID == 2)
			{
				inventory.LethalPoison = true;
			}
			else if (ID == 3)
			{
				inventory.RatPoison = true;
			}
			Object.Destroy(base.gameObject);
		}
	}
}
