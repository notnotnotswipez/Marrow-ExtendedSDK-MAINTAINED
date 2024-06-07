using UnityEngine;

public class PointRemover : MonoBehaviour
{
	public Vector3[] positions;

	public float distanceThreshold;

	public int indexThresh;

	public GenPointsInSpline genPointSpline;

	[ContextMenu("GetPoints")]
	private void GetPoints()
	{
	}

	[ContextMenu("RemovePoints")]
	private void RemovePoints()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
