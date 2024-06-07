using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class EditorIvyGrowth : GrowthBuilder
	{
		public Random.State randomstate;

		public void Initialize(Vector3 firstPoint, Vector3 firstGrabVector)
		{
		}

		private void CalculateNewHeight(BranchContainer branch)
		{
		}

		private int ChooseBranchSense()
		{
			return 0;
		}

		public void Step()
		{
		}

		private void CalculateNewPoint(BranchContainer branch)
		{
		}

		private void CheckWall(BranchContainer branch)
		{
		}

		private void CheckFloor(BranchContainer branch, BranchPoint potentialPoint, Vector3 oldSurfaceNormal)
		{
		}

		private void CheckCorner(BranchContainer branch, BranchPoint potentialPoint, Vector3 oldSurfaceNormal)
		{
		}

		private void CheckFall(BranchContainer branch)
		{
		}

		private void CheckGrabPoint(BranchContainer branch)
		{
		}

		public void AddPoint(BranchContainer branch, Vector3 point, Vector3 normal)
		{
		}

		private void AddFallingPoint(BranchContainer branch)
		{
		}

		private void AddLeave(BranchContainer branch)
		{
		}

		public void DeleteLastBranch()
		{
		}

		public void AddBranch(BranchContainer branch, BranchPoint originBranchPoint, Vector3 point, Vector3 normal)
		{
		}

		private void NewGrowDirection(BranchContainer branch)
		{
		}

		private void NewGrowDirectionAfterWall(BranchContainer branch, Vector3 oldSurfaceNormal, Vector3 newSurfaceNormal)
		{
		}

		private void NewGrowDirectionFalling(BranchContainer branch)
		{
		}

		private void NewGrowDirectionAfterFall(BranchContainer branch, Vector3 newSurfaceNormal)
		{
		}

		private void NewGrowDirectionAfterGrab(BranchContainer branch, Vector3 newSurfaceNormal)
		{
		}

		private void NewGrowDirectionAfterCorner(BranchContainer branch, Vector3 oldSurfaceNormal, Vector3 newSurfaceNormal)
		{
		}

		private void Refine(BranchContainer branch)
		{
		}

		public void Optimize()
		{
		}
	}
}
