using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voxelization
{
	public static class StaticVoxelizer
	{
		private static Collider[] _nonAllocColliders;

		public static ulong VoxelizeLeafs(Vector3 position, int voxelSize, List<Collider> colliders, bool terrainDetected = false, bool debug = false)
		{
			return 0uL;
		}

		public static uint[] VoxelizeAtMortonPosition(Vector3 position, int voxelSize, int gridSize, int nbLayers, int currentLayer, Collider[] colliders, bool terrainDetected = false, Collider[] removedColliders = null, bool debug = false)
		{
			return null;
		}

		public static void DrawCube(Vector3 position, Vector3 extents, Color color, float duration = 0f)
		{
		}

		private static bool DetectTerrainBoxCast(Vector3 position, Vector3 extents, bool debugDraw = false)
		{
			return false;
		}

		public static bool FilterNonConvex(Collider[] colliders, out int separatorIndex)
		{
			separatorIndex = default(int);
			return false;
		}

		[MethodImpl(256)]
		public static int MinRootSize(int voxelSize)
		{
			return 0;
		}

		public static int GetNextRootSize(int voxelSize, int currentRootSize)
		{
			return 0;
		}

		public static int RootSizeFromLayers(int voxelSize, int nbLayers)
		{
			return 0;
		}

		public static int GetNodeSize(uint link, int finalRes)
		{
			return 0;
		}

		[MethodImpl(256)]
		public static int GetOctantSizeAtLayer(int layer, int finalRes)
		{
			return 0;
		}

		[MethodImpl(256)]
		public static int TotalCellsAtLayer(int nbLayers, int layer)
		{
			return 0;
		}

		[MethodImpl(256)]
		public static int GetNumOctantsPerDirectionAtLayer(int layer)
		{
			return 0;
		}

		public static int GetNumLayers(int voxelSize, int rootSize)
		{
			return 0;
		}

		public static Vector3 GetFrontLeftCube(Vector3 position, int voxelSize, int gridSize)
		{
			return default(Vector3);
		}

		public static Vector3 GetOctantCenter(Vector3 frontLeftCenterPos, Vector3 mortonPosition, int voxelSize)
		{
			return default(Vector3);
		}

		public static Vector3 GetOctantCenter(Vector3 position, int voxelSize, int gridSize, uint mortonCode)
		{
			return default(Vector3);
		}

		[MethodImpl(256)]
		public static uint CreateLink(int layer, uint index, uint subNodeInd)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint LinkToLayer(uint link)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint LinkToIndex(uint link)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint LinkToSubnode(uint link)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint VoxelToOctant(uint link)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint OctantToVoxel(uint link)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint OctantToVoxel(uint link, int ind)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint LinkToLeaf(uint link)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static bool IsValidLink(uint link)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsLeafFull(ulong voxels)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool IsLeafFEmpty(ulong voxels)
		{
			return false;
		}

		public static void PrintBitField(ulong subNodes)
		{
		}

		public static int MortonToNodeInd(int layer, int totalLayers, uint mortonCode)
		{
			return 0;
		}
	}
}
