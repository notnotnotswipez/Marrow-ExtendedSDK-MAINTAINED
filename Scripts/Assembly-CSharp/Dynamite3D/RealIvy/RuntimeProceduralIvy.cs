using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RuntimeProceduralIvy : RTIvy
	{
		private RuntimeIvyGrowth rtIvyGrowth;

		protected override void Init(IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		protected override void NextPoints(int branchIndex)
		{
		}

		public override bool IsGrowingFinished()
		{
			return false;
		}

		protected override float GetNormalizedLifeTime()
		{
			return 0f;
		}

		public void SetIvyParameters(IvyPreset ivyPreset)
		{
		}

		protected override void InitializeMeshesData(Mesh bakedMesh, int numBranches)
		{
		}

		protected override int GetMaxNumPoints()
		{
			return 0;
		}

		protected override int GetMaxNumLeaves()
		{
			return 0;
		}

		public override void InitIvy(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		private int GetMaxNumVerticesPerLeaf()
		{
			return 0;
		}
	}
}
