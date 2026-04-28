using UnityEngine;

public class SentenceScript : MonoBehaviour
{
	public UILabel Sentence;

	public string[] Words;

	public int ID;

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetButtonDown("A"))
		{
			Sentence.text = Words[ID];
			ID++;
		}
	}
}
