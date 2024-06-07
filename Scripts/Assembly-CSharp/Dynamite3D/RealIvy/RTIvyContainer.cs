using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class RTIvyContainer
	{
		public int lastBranchNumberAssigned;

		public List<RTBranchContainer> branches;

		public Vector3 firstVertexVector;

		public void Initialize(Vector3 firstVertexVector)
		{
		}

		public void Initialize(IvyContainer ivyContainer, IvyParameters ivyParameters, GameObject ivyGO, RTMeshData[] leavesMeshesByChosenLeaf, Vector3 firstVertexVector)
		{
		}

		public void Initialize()
		{
		}

		public void AddBranch(RTBranchContainer rtBranch)
		{
		}

		public RTBranchContainer GetBranchContainerByBranchNumber(int newBranchNumber)
		{
			return null;
		}
	}
}
