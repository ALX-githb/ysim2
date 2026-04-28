using UnityEngine;

public class PathfindingTestScript : MonoBehaviour
{
	private byte[] bytes;

	private void Update()
	{
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.LeftArrow))
		{
			bytes = AstarPath.active.data.SerializeGraphs();
		}
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.RightArrow))
		{
			AstarPath.active.data.DeserializeGraphs(bytes);
			AstarPath.active.Scan();
		}
	}
}
