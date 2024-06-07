using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RTBranchPoint
	{
		public Vector3 point;

		public Vector3 grabVector;

		public float length;

		public int index;

		public bool newBranch;

		public int newBranchNumber;

		public float radius;

		public Vector3 firstVector;

		public Vector3 axis;

		public Vector3 centerLoop;

		public RTBranchContainer branchContainer;

		public RTVertexData[] verticesLoop;

		public Vector3 lastVectorNormal;

		public RTBranchPoint()
		{
		}

		public RTBranchPoint(BranchPoint branchPoint, RTBranchContainer rtBranchContainer)
		{
		}

		public void PreInit(IvyParameters ivyParameters)
		{
		}

		public void SetValues(Vector3 point, Vector3 grabVector)
		{
		}

		public void SetValues(Vector3 point, Vector3 grabVector, bool newBranch, int newBranchNumber)
		{
		}

		public void InitBranchInThisPoint(int branchNumber)
		{
		}

		public void CalculateVerticesLoop(IvyParameters ivyParameters, RTIvyContainer rtIvyContainer, GameObject ivyGO, Vector3 firstVector, Vector3 axis, float radius)
		{
		}

		public void CalculateVerticesLoop(IvyParameters ivyParameters, RTIvyContainer rtIvyContainer, GameObject ivyGO)
		{
		}

		public void CalculateCenterLoop(GameObject ivyGO)
		{
		}

		public RTBranchPoint GetNextPoint()
		{
			return null;
		}

		public RTBranchPoint GetPreviousPoint()
		{
			return null;
		}
	}
}
