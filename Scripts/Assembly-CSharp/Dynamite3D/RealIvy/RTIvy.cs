using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public abstract class RTIvy : MonoBehaviour
	{
		protected IvyParameters ivyParameters;

		protected RTIvyContainer rtIvyContainer;

		protected RTIvyContainer rtBuildingIvyContainer;

		public MeshFilter meshFilter;

		public MeshRenderer meshRenderer;

		public MeshRenderer mrProcessedMesh;

		public MeshFilter mfProcessedMesh;

		protected List<RTBranchContainer> activeBakedBranches;

		protected List<RTBranchContainer> activeBuildingBranches;

		protected int lastIdxActiveBranch;

		public List<float> srcTotalLengthPerBranch;

		public List<float> dstTotalLengthPerBranch;

		public List<float> growingFactorPerBranch;

		public List<float> lengthPerBranch;

		protected List<int> lastCopiedIndexPerBranch;

		protected List<Vector3> srcPoints;

		protected List<Vector3> dstPoints;

		protected List<LeafPoint> leavesToCopyMesh;

		public RTBakedMeshBuilder meshBuilder;

		private Mesh bakedMesh;

		private Mesh processedMesh;

		private bool refreshProcessedMesh;

		private int backtrackingPoints;

		protected float currentLifetime;

		protected float currentSpeed;

		protected float currentGrowthSpeed;

		protected float leafLengthCorrrectionFactor;

		protected float currentTimer;

		protected RuntimeGrowthParameters growthParameters;

		protected List<Material> leavesMaterials;

		protected RTMeshData[] leavesMeshesByChosenLeaf;

		protected int[] submeshByChoseLeaf;

		protected int maxBranches;

		public void AwakeInit()
		{
		}

		protected virtual void Init(IvyContainer ivyContainer, IvyParameters ivyParameters)
		{
		}

		private void SetUpMaxBranches(IvyContainer ivyContainer)
		{
		}

		protected void InitMeshBuilder()
		{
		}

		protected virtual void AddFirstBranch()
		{
		}

		private int GetBacktrackingPoints()
		{
			return 0;
		}

		public virtual void UpdateIvy(float deltaTime)
		{
		}

		protected virtual void Growing(int branchIndex, float deltaTime)
		{
		}

		protected virtual void NextPoints(int branchIndex)
		{
		}

		private void CalculateFactors(Vector3 srcPoint, Vector3 dstPoint)
		{
		}

		protected virtual void AddNextBranch(int branchNumber)
		{
		}

		private void UpdateGrowingPoints(int branchIndex)
		{
		}

		private void RefreshGeometry()
		{
		}

		private void UpdateGrowthSpeed()
		{
		}

		public bool IsVertexLimitReached()
		{
			return false;
		}

		private Vector3 CalculateFirstVertexVector()
		{
			return default(Vector3);
		}

		private void CreateLeavesDict()
		{
		}

		protected abstract void InitializeMeshesData(Mesh bakedMesh, int numBranches);

		protected abstract float GetNormalizedLifeTime();

		protected abstract int GetMaxNumPoints();

		protected abstract int GetMaxNumLeaves();

		public abstract bool IsGrowingFinished();

		public abstract void InitIvy(RuntimeGrowthParameters growthParameters, IvyContainer ivyContainer, IvyParameters ivyParameters);
	}
}
