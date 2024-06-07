using UnityEngine;

namespace SLZ.Bonelab
{
	public class GridGenTest : MonoBehaviour
	{
		public int voxelSize;

		private Vector3 _localPosition;

		private Vector3 _bottomLeftCenterPos;

		private Vector3 _previousCenter;

		private Vector3 _newCenter;

		private int _counter;

		private void OnDrawGizmos()
		{
		}

		[ContextMenu("Draw Grid")]
		public void DrawGrid()
		{
		}
	}
}
