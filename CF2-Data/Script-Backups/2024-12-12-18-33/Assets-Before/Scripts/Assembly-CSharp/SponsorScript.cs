using UnityEngine;
using UnityEngine.SceneManagement;

public class SponsorScript : MonoBehaviour
{
	public GameObject[] Set;

	public UISprite Darkness;

	public float Timer;

	public int ID;

	private void Start()
	{
		Set[1].SetActive(true);
		Set[2].SetActive(false);
		Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, 1f);
		GetComponent<AudioSource>().Play();
	}

	private void Update()
	{
		Timer += Time.deltaTime * 1.3333334f;
		if (Timer < 6f)
		{
			Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, Darkness.color.a - Time.deltaTime * 1.3333334f);
			if (Darkness.color.a < 0f)
			{
				Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, 0f);
				if (Input.anyKeyDown)
				{
					Timer = 6f;
				}
			}
			return;
		}
		Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, Darkness.color.a + Time.deltaTime * 1.3333334f);
		if (Darkness.color.a >= 1f)
		{
			Darkness.color = new Color(Darkness.color.r, Darkness.color.g, Darkness.color.b, 1f);
			Set[ID].SetActive(false);
			ID++;
			if (ID < Set.Length)
			{
				Set[ID].SetActive(true);
				Timer = 0f;
			}
			else
			{
				SceneManager.LoadScene("TitleScene");
			}
		}
	}
}
