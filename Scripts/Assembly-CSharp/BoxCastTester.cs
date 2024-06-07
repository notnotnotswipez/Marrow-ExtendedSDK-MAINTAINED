using UnityEngine;

public class BoxCastTester : MonoBehaviour
{
	public int boxSize;

	private RaycastHit hit;

	private RaycastHit[] hits;

	private void OnDrawGizmos()
	{
	}

	[ContextMenu("Test Cast")]
	public void TestCast()
	{
	}

	[ContextMenu("Clear Hits")]
	public void ClearHits()
	{
	}
}
