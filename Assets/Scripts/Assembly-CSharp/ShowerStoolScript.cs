using UnityEngine;

public class ShowerStoolScript : MonoBehaviour
{
	public YandereScript Yandere;

	public PromptScript Prompt;

	public Transform StoolSpot;

	public ParticleSystem Water;

	private void Start()
	{
		Yandere = GameObject.Find("YandereChan").GetComponent<YandereScript>();
	}

	private void Update()
	{
		if (Yandere.Schoolwear > 0 || Yandere.PickUp != null || Yandere.Dragging)
		{
			Prompt.Hide();
			Prompt.enabled = false;
			return;
		}
		Prompt.enabled = true;
		if (Prompt.Circle[0].fillAmount == 0f)
		{
			Yandere.EmptyHands();
			Yandere.Stool = StoolSpot;
			Yandere.CanMove = false;
			Yandere.Bathing = true;
			Water.Play();
		}
	}
}
