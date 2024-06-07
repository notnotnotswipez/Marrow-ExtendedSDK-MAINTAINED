using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RTBranchContainer
	{
		public List<RTBranchPoint> branchPoints;

		public RTLeafPoint[][] leavesOrderedByInitSegment;

		public float totalLength;

		public Vector3 growDirection;

		public float randomizeHeight;

		public float heightVar;

		public float newHeight;

		public float heightParameter;

		public float deltaHeight;

		public float currentHeight;

		public int branchSense;

		public bool falling;

		public Quaternion rotationOnFallIteration;

		public float fallIteration;

		public int branchNumber;

		public RTBranchContainer(BranchContainer branchContainer, IvyParameters ivyParameters, RTIvyContainer rtIvyContainer, GameObject ivyGO, RTMeshData[] leavesMeshesByChosenLeaf)
		{
		}

		public Vector2 GetLastUV(IvyParameters ivyParameters)
		{
			return default(Vector2);
		}

		public RTBranchContainer(int numPoints, int numLeaves)
		{
		}

		private void Init(int numPoints, int numLeaves)
		{
		}

		public void AddBranchPoint(RTBranchPoint rtBranchPoint, float deltaLength)
		{
		}

		public RTBranchPoint GetLastBranchPoint()
		{
			return null;
		}

		public void AddLeaf(RTLeafPoint leafAdded)
		{
		}
	}
}
