using UnityEngine;

public class ShoePairScript : MonoBehaviour
{
	public PoliceScript Police;

	public PromptScript Prompt;

	public GameObject Note;

	private void Start()
	{
		GameObject policeObj = GameObject.Find("Police");
		if (policeObj != null) Police = policeObj.GetComponent<PoliceScript>();
		if (ClassGlobals.LanguageGrade + ClassGlobals.LanguageBonus < 1)
		{
			Prompt.enabled = false;
		}
		Note.SetActive(false);
	}

	private void Update()
	{
		if (Prompt.Circle[0].fillAmount == 0f)
		{
			Prompt.Hide();
			Prompt.enabled = false;
			Police.Suicide = true;
			Note.SetActive(true);
		}
	}
}
