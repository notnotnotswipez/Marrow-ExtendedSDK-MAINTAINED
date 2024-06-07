using System;
using System.Runtime.CompilerServices;
using Trees;
using UnityEngine;

namespace BitOperators
{
	public static class MortonCodes
	{
		private static uint[] _neighborLinks;

		public static Vector3[] directions;

		public static int DirectionInd(Vector3 direction)
		{
			return 0;
		}

		[MethodImpl(256)]
		public static uint Morton3D(Vector3 position)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint Morton3D(int positionX, int positionY, int positionZ)
		{
			return 0u;
		}

		[MethodImpl(256)]
		private static uint EncodeFor3D(uint x)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint Morton2D(Vector2 position)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint EncodeFor2D(uint x)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static Vector3 FromMorton3D(uint x)
		{
			return default(Vector3);
		}

		[MethodImpl(256)]
		private static uint DecodeFor3D(uint x)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static Vector3 FromMorton2D(uint x)
		{
			return default(Vector3);
		}

		private static uint DecodeFor2D(uint x)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static uint GetParentInd3D(uint childCode)
		{
			return 0u;
		}

		[MethodImpl(256)]
		private static uint GetChildInd3D(uint parentCode, uint ind)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static (uint, uint) GetChildrenMinMax3D(uint parentCode)
		{
			return default((uint, uint));
		}

		public static uint RecursiveParent(uint childCode, int nbGenerations)
		{
			return 0u;
		}

		public static void GetNeighbors(uint code, int gridSize, ref Span<uint> neighborCodes)
		{
		}

		public static uint[] GetVoxelNeighbors(this SparseVoxelOctree svo, SparseVoxelOctree.LeafNode leafNode, uint voxelLink)
		{
			return null;
		}

		public static void GenerateMortonCodesForFace(int dirInd, ref Span<uint> faceCodes)
		{
		}

		[MethodImpl(256)]
		public static bool IsVoxelOnFace(uint link)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool NextVoxelNewOctant(uint link, Vector3 dir)
		{
			return false;
		}

		public static uint GetWrapAroundVoxelCode(uint ogCode, Vector3 moveDirection)
		{
			return 0u;
		}

		[MethodImpl(256)]
		public static int GetMortonDirectionInd(uint from, uint to, int delta)
		{
			return 0;
		}

		public static void ExclusiveScan(Span<int> codes, ref Span<int> scanArray)
		{
		}

		public static void DrawMortonLines(ulong i, Vector3 previousCenter, Vector3 newCenter, float time = 10f)
		{
		}
	}
}
