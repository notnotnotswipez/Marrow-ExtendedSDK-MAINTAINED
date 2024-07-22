using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Trees
{
	[Serializable]
	public class SparseVoxelOctree
	{
		[Serializable]
		public struct SparseNode
		{
			public uint parent;

			public uint firstChild;

			public uint[] neighbors;

			public uint code;

			public uint link;

		}

		[Serializable]
		public struct LeafNode
		{
			public uint parent;

			public ulong voxels;

		}

		[Serializable]
		public struct Layer
		{
			public SparseNode[] nodes;

			public int cubeSize;

			public int gridSize;

		
		}

		public LeafNode[] leafNodes;

		public Layer[] layers;

		public int nbNodes;

		[NonSerialized]
		public Vector3 position;

		[NonSerialized]
		public int rootResolution;

		[NonSerialized]
		public int finalResolution;

		[NonSerialized]
		private int _nbLayers;

		[NonSerialized]
		public bool debugPrinter;

		[NonSerialized]
		private Collider[] _tempColliders;

		[NonSerialized]
		private Collider[] _removedColliders;

		[NonSerialized]
		private bool _terrainDetected;

		[NonSerialized]
		private SparseNode _tempChildNode;

		private Dictionary<uint, int> borderNbrDict;

		private static readonly float GOLDEN_ANGLE;

		private List<Vector3> _sphereSurfaceKeep;

		public int NbNodes => 0;

		public void ReloadParams(Vector3 loaderPos)
		{
		}

		public SparseVoxelOctree(Vector3 position, int rootResolution, int finalResolution)
		{
		}

		public void BuildOctree(bool debugPrint = false)
		{
		}

		private List<SparseNode> BuildSpecificLevel(Collider[] colliders, int level)
		{
			return null;
		}

		private List<SparseNode> BuildBottomUp(int layer, ref List<SparseNode> activeNodes)
		{
			return null;
		}

		private void DefineRoot()
		{
		}

		private void DefineNeighborsInLayer(int layer)
		{
		}

		public SparseNode GetNode(uint link, int offset = 0)
		{
			return default(SparseNode);
		}

		public Vector3 GetNodePosition(uint link, bool octantOverride = false)
		{
			return default(Vector3);
		}

		public Vector3 GetLeafPosition(uint link)
		{
			return default(Vector3);
		}

		public Vector3 GetLeafPosition(uint parentLink, int voxelInd)
		{
			return default(Vector3);
		}

		public uint OctantFromPosition(SparseNode parentNode, int currentLayer, Vector3 searchPos)
		{
			return 0u;
		}

		public uint FindPositionInTree(Vector3 incomingPos)
		{
			return 0u;
		}

		private uint FindCodeInTree(SparseNode parentNode, int targetLayer, int currentLayer, uint neighborSearchCode)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public Vector3 GetOctantPosition(Vector3 pos)
		{
			return default(Vector3);
		}

		public bool CheckNeighborSpace(Vector3 point, uint node)
		{
			return false;
		}

		public uint GetNextFreeLocation(uint currentLink, Vector3 dir)
		{
			return 0u;
		}

		public bool AllNeighborsOccupied(IList<uint> neighbors)
		{
			return false;
		}

		public bool AllNeighborsUnOccupied(IList<uint> neighbors)
		{
			return false;
		}

		public void FindLowestBorderPositions(uint parentLink, uint fromLink, int fromDir, ref Dictionary<uint, int> borderNodes, ref List<uint> tempNodeList)
		{
		}

		public float GetMinDistanceFromNeighbors(Dictionary<uint, int> nbrs, Vector3 point)
		{
			return 0f;
		}

		public bool HasVoxelNeighbors(IList<uint> nbrs)
		{
			return false;
		}

		private uint[] FindNeighbors(uint link)
		{
			return null;
		}

		public uint[] SVOGetVoxelNeighbors(LeafNode leafNode, uint voxelLink)
		{
			return null;
		}

		public bool HasChildren(uint link)
		{
			return false;
		}

		public int GetNearestMultiple(float num, int multiple)
		{
			return 0;
		}

		private void ClearTempVariables()
		{
		}

		private void GetParentList(ref Span<uint> parentInds, List<SparseNode> nodes)
		{
		}

		private void CheckParentDuplicates(ref Span<uint> codes, ref Span<int> duplicateFlags)
		{
		}

		private void TotalNodes()
		{
		}

		private void DebugPrintNodes(bool debugPrint)
		{
		}

		private void PrintAllNodeNeighbors(int layer)
		{
		}

		public ulong LinkInArea()
		{
			return 0uL;
		}

		public Vector3 PointOnSphereSurface(Vector3 centerPos, float pointDensity, float radius, bool useMinHeight = false, float minHeight = 0f)
		{
			return default(Vector3);
		}

		public int GetNodesInSphere(SparseNode parentNode, int parentLayer, Vector3 centerPos, float sphereRadius, List<uint> keepList)
		{
			return 0;
		}

		public int GetNodesOnSphere(SparseNode parentNode, int parentLayer, Vector3 centerPos, float sphereRadius, List<uint> keepList, bool useMinHeight = false, float minHeight = 0f)
		{
			return 0;
		}

		public List<uint> OverlapDictFromSphereSurface(Vector3 centerPos, float radius, bool useMinHeight = false, float minHeight = 0f)
		{
			return null;
		}

		public List<uint> OverlapDictFromSphereVolume(Vector3 centerPos, float radius)
		{
			return null;
		}

		public Vector3 PositionFromSphereSurface(Vector3 centerPos, float radius, bool useMinHeight = false, float minHeight = 0f)
		{
			return default(Vector3);
		}

		public Vector3 PositionFromSphereVolume(Vector3 centerPos, float radius)
		{
			return default(Vector3);
		}

		public int GetNodesInArea(SparseNode parentNode, int parentLayer, Vector3 centerPos, Vector3 areaScale, List<uint> keepList, bool useMinHeight = false, float minHeight = 0f)
		{
			return 0;
		}

		public List<uint> OverlapDictFromArea(Vector3 centerPos, Vector3 areaScale)
		{
			return null;
		}

		public Vector3 PositionFromArea(Vector3 centerPos, Vector3 areaScale, bool useMinHeight = false, float minHeight = 0f)
		{
			return default(Vector3);
		}

		public Vector3 PositionFromArea(ref List<uint> keepList, Vector3 centerPos, Vector3 areaScale)
		{
			return default(Vector3);
		}

		public uint WeightedSelection(List<uint> list, int totalWeight)
		{
			return 0u;
		}

		public IList<T> KnuthShuffle<T>(IList<T> list)
		{
			return null;
		}

		public void FindPos(Vector3 point)
		{
		}

		public Vector3 FindTestPos(Vector3 point)
		{
			return default(Vector3);
		}

		private void VoxelizeLeafNodes(Collider[] colliders)
		{
		}

		[MethodImpl(256)]
		public LeafNode GetLeafNode(uint link)
		{
			return default(LeafNode);
		}

		[MethodImpl(256)]
		public bool IsVoxelOccupied(uint link)
		{
			return false;
		}

		[MethodImpl(256)]
		public static uint GetVoxelLink(LeafNode leaf, int voxelInd)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static bool IsLeafNode(uint link)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsVoxelOccupied(ulong voxels, int ind)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool CheckVoxelSiblings(uint linkA, uint linkB)
		{
			return false;
		}
	}
}
