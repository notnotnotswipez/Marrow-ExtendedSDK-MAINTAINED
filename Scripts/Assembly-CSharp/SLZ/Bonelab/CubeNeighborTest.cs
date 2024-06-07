using UnityEngine;

namespace SLZ.Bonelab
{
	public class CubeNeighborTest : MonoBehaviour
	{
		public float cubeSize;

		public bool drawGizmos;

		public Vector3[] neighbors;

		public Color innerCubeColor;

		public Color[] outerCubeColors;

		private void OnDrawGizmos()
		{
		}

		[ContextMenu("Get Neighbors")]
		public void GetNeighbors()
		{
		}
	}
}
