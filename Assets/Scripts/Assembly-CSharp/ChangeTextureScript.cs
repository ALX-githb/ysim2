using UnityEngine;

public class ChangeTextureScript : MonoBehaviour
{
	public Renderer MyRenderer;

	public Texture[] Textures;

	public int ID = 1;

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Space))
		{
			ID++;
			if (ID == Textures.Length)
			{
				ID = 1;
			}
			MyRenderer.material.mainTexture = Textures[ID];
		}
	}
}
