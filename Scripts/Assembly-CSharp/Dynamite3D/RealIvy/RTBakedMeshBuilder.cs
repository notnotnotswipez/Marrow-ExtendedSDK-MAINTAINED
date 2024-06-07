using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	public class RTBakedMeshBuilder
	{
		public IvyParameters ivyParameters;

		public RTIvyContainer rtIvyContainer;

		public RTIvyContainer rtBakedIvyContainer;

		public GameObject ivyGO;

		public MeshRenderer meshRenderer;

		public MeshFilter meshFilter;

		private bool onOptimizedStretch;

		private MeshFilter leavesMeshFilter;

		private MeshRenderer leavesMeshRenderer;

		private MeshRenderer mrProcessedMesh;

		private Mesh processedMesh;

		private Mesh ivyMesh;

		public List<RTBranchContainer> activeBranches;

		public RTMeshData bakedMeshData;

		public RTMeshData buildingMeshData;

		public RTMeshData processedMeshData;

		public List<List<int>> processedVerticesIndicesPerBranch;

		public List<List<int>> processedBranchesVerticesIndicesPerBranch;

		private int[] vertCountsPerBranch;

		private int[] lastTriangleIndexPerBranch;

		private int[] vertCountLeavesPerBranch;

		private int lastPointCopied;

		private int vertCount;

		private int lastVertCount;

		private int triCount;

		private int lastVerticesCountProcessed;

		private int lastLeafVertProcessed;

		private int submeshCount;

		private int[] submeshByChoseLeaf;

		private int initIdxLeaves;

		private int endIdxLeaves;

		private int backtrackingPoints;

		private int[] fromTo;

		private Vector3[] vectors;

		private RTMeshData[] leavesMeshesByChosenLeaf;

		private int lastVertexIndex;

		private float angle;

		public List<Material> leavesMaterials;

		public List<List<int>> typesByMat;

		public Rect[] uv2Rects;

		public bool leavesDataInitialized;

		private float growthSpeed;

		private float leafLengthCorrrectionFactor;

		private Vector3 ivyGoPosition;

		private Quaternion ivyGoRotation;

		private Quaternion ivyGoInverseRotation;

		private Vector3 zeroVector3;

		private Vector2 zeroVector2;

		private Color blackColor;

		public void InitializeMeshBuilder(IvyParameters ivyParameters, RTIvyContainer ivyContainer, RTIvyContainer bakedIvyContainer, GameObject ivyGO, Mesh bakedMesh, MeshRenderer meshRenderer, MeshFilter meshFilter, int numBranches, Mesh processedMesh, float growSpeed, MeshRenderer mrProcessedMesh, int backtrackingPoints, int[] submeshByChoseLeaf, RTMeshData[] leavesMeshesByChosenLeaf, Material[] materials)
		{
		}

		public void InitializeMeshesDataBaked(Mesh bakedMesh, int numBranches)
		{
		}

		public void InitializeMeshesDataProcedural(Mesh bakedMesh, int numBranches, float lifetime, float velocity)
		{
		}

		public void CreateBuildingMeshData(Mesh bakedMesh, int numBranches)
		{
		}

		public void CreateBakedMeshData(Mesh bakedMesh)
		{
		}

		public void CreateProcessedMeshDataProcedural(Mesh bakedMesh, float lifetime, float velocity)
		{
		}

		public void CreateProcessedMeshData(Mesh bakedMesh)
		{
		}

		public void SetLeafLengthCorrectionFactor(float leafLengthCorrrectionFactor)
		{
		}

		public void ClearMesh()
		{
		}

		public RTBakedMeshBuilder()
		{
		}

		public RTBakedMeshBuilder(RTIvyContainer ivyContainer, GameObject ivyGo)
		{
		}

		private void ClearTipMesh()
		{
		}

		public void CheckCopyMesh(int branchIndex, List<RTBranchContainer> bakedBranches)
		{
		}

		public void BuildGeometry02(List<RTBranchContainer> activeBakedBranches, List<RTBranchContainer> activeBuildingBranches)
		{
		}

		private float CalculateRadius(BranchPoint branchPoint, BranchContainer buildingBranchContainer)
		{
			return 0f;
		}

		private void SetTriangles(RTBranchContainer branch, int vertCount, int initIndex, int branchIndex)
		{
		}

		private void BuildLeaves(int branchIndex, RTBranchContainer buildingBranchContainer, RTBranchContainer bakedBranchContainer)
		{
		}

		public void CopyToFixedMesh(int branchIndex, int initSegmentIdx, int endSegmentIdx, RTBranchContainer branchContainer, RTBranchContainer bakedBranchContainer)
		{
		}

		public void RefreshProcessedMesh()
		{
		}

		private void RefreshMesh()
		{
		}
	}
}
