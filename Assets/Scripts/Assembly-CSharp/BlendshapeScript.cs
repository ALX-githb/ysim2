using UnityEngine;

public class BlendshapeScript : MonoBehaviour
{
	public SkinnedMeshRenderer MyMesh;

	public float Happiness;

	public float Blink;

	private void LateUpdate()
	{
		if (MyMesh == null) return;
		Happiness += Time.deltaTime * 10f;
		if (MyMesh.sharedMesh != null && MyMesh.sharedMesh.blendShapeCount > 0)
			MyMesh.SetBlendShapeWeight(0, Happiness);
		Blink += Time.deltaTime * 10f;
		if (MyMesh.sharedMesh != null && MyMesh.sharedMesh.blendShapeCount > 8)
			MyMesh.SetBlendShapeWeight(8, 100f);
	}
}
