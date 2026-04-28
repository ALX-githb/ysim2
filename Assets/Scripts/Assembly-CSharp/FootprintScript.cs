using UnityEngine;

public class FootprintScript : MonoBehaviour
{
	public YandereScript Yandere;

	public Texture Footprint;

	private void Start()
	{
		if (Yandere.Schoolwear == 0 || Yandere.Schoolwear == 2 || (Yandere.ClubAttire && ClubGlobals.Club == ClubType.MartialArts) || Yandere.Hungry)
		{
			GetComponent<Renderer>().material.mainTexture = Footprint;
		}
		Object.Destroy(this);
	}
}
