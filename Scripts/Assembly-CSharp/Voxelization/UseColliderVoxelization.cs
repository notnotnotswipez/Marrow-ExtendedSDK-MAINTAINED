using UnityEngine;

namespace Voxelization
{
	public class UseColliderVoxelization : MonoBehaviour
	{
		public int gridSize;

		public int voxelSize;

		public Collider testCollider;

		public bool debugDraw;

		private ColliderVoxelization _voxelizer;

		private string _tempString;

		private Color _filledColor;

		private Color _emptyColor;

		private int _ind;

		private int _flatInd;

		private int _i;

		private int _j;

		private int _k;

		private Vector3 _bottomLeftCenterPos;

		private Vector3 _newCenter;

		private void OnDrawGizmos()
		{
		}

		[ContextMenu("Voxelize")]
		public void Voxelize()
		{
		}

		public void ClearVoxelizer()
		{
		}
	}
}
