using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class IvyContainer : ScriptableObject
	{
		public int lastNumberAssigned;

		public GameObject ivyGO;

		public List<BranchContainer> branches;

		public Vector3 firstVertexVector;

		private IvyContainer()
		{
		}

		public void Clear()
		{
		}

		public void RemoveBranch(BranchContainer branchToDelete)
		{
		}

		public BranchContainer GetBranchContainerByBranchNumber(int branchNumber)
		{
			return null;
		}

		public BranchPoint[] GetNearestSegmentSSBelowDistance(Vector2 pointSS, float distanceThreshold)
		{
			return null;
		}

		public BranchPoint[] GetNearestSegmentSS(Vector2 pointSS)
		{
			return null;
		}

		public void AddBranch(BranchContainer newBranchContainer)
		{
		}

		public BranchPoint GetNearestPointAllBranchesSSFrom(Vector2 pointSS)
		{
			return null;
		}
	}
}
