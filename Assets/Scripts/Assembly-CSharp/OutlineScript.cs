using HighlightingSystem;
using UnityEngine;

public class OutlineScript : MonoBehaviour
{
	public Highlighter h;

	public Color color = new Color(1f, 1f, 1f, 1f);

	public void Awake()
	{
		h = GetComponent<Highlighter>();
		if (h == null)
		{
			h = base.gameObject.AddComponent<Highlighter>();
		}
	}

	private void Update()
	{
		if (OptionGlobals.DisableOutlines)
		{
			if (h != null) h.ConstantOffImmediate();
			return;
		}
		if (h != null)
			h.ConstantOnImmediate(color);
	}
}
