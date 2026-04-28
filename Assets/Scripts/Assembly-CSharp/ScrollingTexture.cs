using UnityEngine;

public class ScrollingTexture : MonoBehaviour
{
	public float Offset;

	public float Speed;

	private void Update()
	{
		Offset += Time.deltaTime * Speed;
		GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(Offset, Offset));
	}
}
