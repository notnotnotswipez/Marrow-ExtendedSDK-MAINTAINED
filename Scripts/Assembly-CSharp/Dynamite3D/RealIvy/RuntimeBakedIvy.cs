using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RuntimeBakedIvy : RTIvy
	{
		public override bool IsGrowingFinished()
		{
			return false;
		}

		protected override void Init(IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		private void CalculateLifetime()
		{
		}

		protected override float GetNormalizedLifeTime()
		{
			return 0f;
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

		public void InitIvyEditor(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}
	}
}
