using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RTLeafPoint
	{
		public Vector3 point;

		public float lpLength;

		public Vector3 left;

		public Vector3 lpForward;

		public Vector3 lpUpward;

		public int initSegmentIdx;

		public int endSegmentIdx;

		public int chosenLeave;

		public RTVertexData[] vertices;

		public Vector3 leafCenter;

		public Quaternion leafRotation;

		public float leafScale;

		public void InitializeRuntime()
		{
		}

		public RTLeafPoint()
		{
		}

		public RTLeafPoint(LeafPoint leafPoint, IvyParameters ivyParameters)
		{
		}

		public void PreInit(int numVertices)
		{
		}

		public void PreInit(RTMeshData leafMeshData)
		{
		}

		public void SetValues(Vector3 point, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, RTBranchPoint initSegment, RTBranchPoint endSegment, float leafScale, IvyParameters ivyParameters)
		{
		}

		private void CalculateLeafRotation(IvyParameters ivyParameters)
		{
		}

		public void CreateVertices(IvyParameters ivyParameters, RTMeshData leafMeshData, GameObject ivyGO)
		{
		}
	}
}
