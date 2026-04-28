using UnityEngine;

public class ChemistScannerScript : MonoBehaviour
{
	public StudentScript Student;

	public Renderer MyRenderer;

	public Texture AlarmedEyes;

	public Texture DeadEyes;

	public Texture[] Textures;

	public float Timer;

	public int PreviousID;

	public int ID;

	private void Update()
	{
		if (Student.Ragdoll.enabled)
		{
			MyRenderer.materials[1].mainTexture = DeadEyes;
			base.enabled = false;
			return;
		}
		if (Student.WitnessedMurder || Student.WitnessedCorpse)
		{
			if (MyRenderer.materials[1].mainTexture != AlarmedEyes)
			{
				MyRenderer.materials[1].mainTexture = AlarmedEyes;
			}
			return;
		}
		Timer += Time.deltaTime;
		if (Timer > 2f)
		{
			while (ID == PreviousID)
			{
				ID = Random.Range(0, Textures.Length);
			}
			MyRenderer.materials[1].mainTexture = Textures[ID];
			PreviousID = ID;
			Timer = 0f;
		}
	}
}
