using UnityEngine;

public class PathfindingTestScript : MonoBehaviour
{
	private byte[] bytes;

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.LeftArrow))
		{
			bytes = AstarPath.active.astarData.SerializeGraphs();
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.RightArrow))
		{
			AstarPath.active.astarData.DeserializeGraphs(bytes);
			AstarPath.active.Scan();
		}
	}
}
