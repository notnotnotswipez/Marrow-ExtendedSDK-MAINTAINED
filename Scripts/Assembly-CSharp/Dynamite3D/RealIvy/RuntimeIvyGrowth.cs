using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RuntimeIvyGrowth
	{
		private RTIvyContainer rtIvyContainer;

		private IvyParameters ivyParameters;

		private GameObject ivyGO;

		private RTMeshData[] leavesMeshesByChosenLeaf;

		private RTBranchContainer[] branchesPool;

		private int branchesPoolIndex;

		private RTBranchPoint[] branchPointsPool;

		private int branchPointPoolIndex;

		private RTLeafPoint[] leavesPool;

		private int leavesPoolIndex;

		private int numPoints;

		private int numLeaves;

		private int maxNumVerticesPerLeaf;

		public Random.State randomstate;

		public void Init(RTIvyContainer ivyContainer, IvyParameters ivyParameters, GameObject ivyGO, RTMeshData[] leavesMeshesByChosenLeaf, int numPoints, int numLeaves, int maxNumVerticesPerLeaf)
		{
		}

		private void CalculateNewHeight(RTBranchContainer branch)
		{
		}

		private int ChooseBranchSense()
		{
			return 0;
		}

		public void Step()
		{
		}

		private void CalculateNewPoint(RTBranchContainer branch)
		{
		}

		private void CheckWall(RTBranchContainer branch)
		{
		}

		private void CheckFloor(RTBranchContainer branch, RTBranchPoint potentialPoint, Vector3 oldSurfaceNormal)
		{
		}

		private void CheckCorner(RTBranchContainer branch, RTBranchPoint potentialPoint, Vector3 oldSurfaceNormal)
		{
		}

		private void CheckFall(RTBranchContainer branch)
		{
		}

		private void CheckGrabPoint(RTBranchContainer branch)
		{
		}

		public void AddPoint(RTBranchContainer branch, Vector3 point, Vector3 normal)
		{
		}

		private float CalculateRadius(float lenght)
		{
			return 0f;
		}

		private float CalculateLeafScale(BranchContainer branch, LeafPoint leafPoint)
		{
			return 0f;
		}

		private Quaternion CalculateLeafRotation(LeafPoint leafPoint)
		{
			return default(Quaternion);
		}

		private void AddFallingPoint(RTBranchContainer branch)
		{
		}

		private void CalculateVerticesLastPoint(RTBranchContainer rtBranchContainer)
		{
		}

		private void AddLeave(RTBranchContainer branch)
		{
		}

		public void DeleteLastBranch()
		{
		}

		public void AddBranch(RTBranchContainer branch, RTBranchPoint originBranchPoint, Vector3 point, Vector3 normal)
		{
		}

		private void NewGrowDirection(RTBranchContainer branch)
		{
		}

		private void NewGrowDirectionAfterWall(RTBranchContainer branch, Vector3 oldSurfaceNormal, Vector3 newSurfaceNormal)
		{
		}

		private void NewGrowDirectionFalling(RTBranchContainer branch)
		{
		}

		private void NewGrowDirectionAfterFall(RTBranchContainer branch, Vector3 newSurfaceNormal)
		{
		}

		private void NewGrowDirectionAfterGrab(RTBranchContainer branch, Vector3 newSurfaceNormal)
		{
		}

		private void NewGrowDirectionAfterCorner(RTBranchContainer branch, Vector3 oldSurfaceNormal, Vector3 newSurfaceNormal)
		{
		}

		public Vector3 GetFirstVector(RTBranchPoint rtBranchPoint, RTBranchContainer rtBranchContainer, RTIvyContainer rtIvyContainer, IvyParameters ivyParameters, Vector3 axis)
		{
			return default(Vector3);
		}

		public Vector3 GetLoopAxis(RTBranchPoint rtBranchPoint, RTBranchContainer rtBranchContainer, RTIvyContainer rtIvyContainer, GameObject ivyGo)
		{
			return default(Vector3);
		}

		private RTBranchPoint GetNextFreeBranchPoint()
		{
			return null;
		}

		private RTLeafPoint GetNextLeafPoint()
		{
			return null;
		}

		private RTBranchContainer GetNextBranchContainer()
		{
			return null;
		}
	}
}
