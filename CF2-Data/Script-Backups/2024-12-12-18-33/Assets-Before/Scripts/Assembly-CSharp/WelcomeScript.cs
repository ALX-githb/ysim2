using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeScript : MonoBehaviour
{
	[SerializeField]
	private JsonScript JSON;

	[SerializeField]
	private GameObject WelcomePanel;

	[SerializeField]
	private UILabel[] FlashingLabels;

	[SerializeField]
	private UILabel BeginLabel;

	[SerializeField]
	private UISprite Darkness;

	[SerializeField]
	private bool Continue;

	[SerializeField]
	private bool FlashRed;

	[SerializeField]
	private float VersionNumber;

	[SerializeField]
	private float Timer;

	private string Text;

	private int ID;

	private void Start()
	{
		BeginLabel.color = new Color(BeginLabel.color.r, BeginLabel.color.g, BeginLabel.color.b, 0f);
		Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, 2f);
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		if (ApplicationGlobals.VersionNumber != VersionNumber)
		{
			Globals.DeleteAll();
			ApplicationGlobals.VersionNumber = VersionNumber;
		}
	}

	private void Update()
	{
		if (!Continue)
		{
			Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, Darkness.color.a - Time.deltaTime);
			if (Darkness.color.a <= 0f)
			{
				Input.GetKeyDown(KeyCode.W);
				if (Input.anyKeyDown)
				{
					Timer = 5f;
				}
				Timer += Time.deltaTime;
				if (Timer > 5f)
				{
					BeginLabel.color = new Color(BeginLabel.color.r, BeginLabel.color.g, BeginLabel.color.b, BeginLabel.color.a + Time.deltaTime);
					if (BeginLabel.color.a >= 1f && WelcomePanel.activeInHierarchy && Input.anyKeyDown)
					{
						Darkness.color = new Color(1f, 1f, 1f, 0f);
						Continue = true;
					}
				}
			}
		}
		else
		{
			Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, Darkness.color.a + Time.deltaTime);
			if (Darkness.color.a >= 1f)
			{
				SceneManager.LoadScene("SponsorScene");
			}
		}
		if (!FlashRed)
		{
			ID = 0;
			while (ID < 3)
			{
				ID++;
				FlashingLabels[ID].color = new Color(FlashingLabels[ID].color.r + Time.deltaTime * 10f, FlashingLabels[ID].color.g, FlashingLabels[ID].color.b, FlashingLabels[ID].color.a);
				if (FlashingLabels[ID].color.r > 1f)
				{
					FlashRed = true;
				}
			}
			return;
		}
		ID = 0;
		while (ID < 3)
		{
			ID++;
			FlashingLabels[ID].color = new Color(FlashingLabels[ID].color.r - Time.deltaTime * 10f, FlashingLabels[ID].color.g, FlashingLabels[ID].color.b, FlashingLabels[ID].color.a);
			if (FlashingLabels[ID].color.r < 0f)
			{
				FlashRed = false;
			}
		}
	}
}
