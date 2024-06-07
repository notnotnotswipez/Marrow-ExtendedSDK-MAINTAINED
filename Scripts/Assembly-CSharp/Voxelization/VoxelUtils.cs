using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voxelization
{
	public static class VoxelUtils
	{
		public static bool IsOnOctantEdge(Vector3 location, float octantSize, int octantsPerAxis)
		{
			return false;
		}

		public static void GenerateInternalMortonFace(uint startingVoxel, int dirInd, ref Span<uint> faceCodes)
		{
		}

		public static void GenerateLocalMortonFace(uint startingVoxel, int dirInd, ref List<uint> faceCodes)
		{
		}

		public static void GetVoxelsOnFace(int dirInd, ref Span<uint> faceCodes)
		{
		}

		private static void GetOpenInds(uint indMask, ref Span<int> openInds)
		{
		}

		private static void GetOpenInds(Span<uint> indMask, ref Span<int> openInds)
		{
		}

		public static int ClosestFaceIndex(Vector3 center, float cubeSize, Vector3 point)
		{
			return 0;
		}

		public static float ClosestCornerDistance(Vector3 center, float cubeSize, Vector3 point)
		{
			return 0f;
		}

		public static float ClosestEdgeCenterDistance(Vector3 center, float cubeSize, Vector3 point)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public static bool CheckInCube(Vector3 centerPoint, float area, Vector3 itemPosition)
		{
			return false;
		}

		[MethodImpl(256)]
		public static Vector3[] CalcCubeMinMax(Vector3 center, float size)
		{
			return null;
		}

		[MethodImpl(256)]
		public static Vector3[] CalcCubeMinMax(Vector3 center, Vector3 size)
		{
			return null;
		}

		[MethodImpl(256)]
		public static bool CheckInVolume(Vector3 centerPoint, Vector3 volumeSize, Vector3 itemPosition, Vector3 itemSize, bool debugDraw = false)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool DoCubesOverlap(Vector3[] cube1MinMax, Vector3[] cube2MinMax)
		{
			return false;
		}

		[MethodImpl(256)]
		public static bool DoCubesOverlap(Span<Vector3> cube1MinMax, Span<Vector3> cube2MinMax)
		{
			return false;
		}

		public static Vector3 CalculateOverlapVolume(Vector3 centerPoint1, Vector3 volumeSize1, Vector3 centerPoint2, Vector3 volumeSize2, bool useMinHeight = false, float minHeight = 0f, bool debugDraw = false)
		{
			return default(Vector3);
		}

		public static bool AboveMinHeight(Vector3[] cubeMinMax, float minHeight, Vector3 centerPos)
		{
			return false;
		}

		public static bool AboveMinHeight(Span<Vector3> cubeMinMax, float minHeight, Vector3 centerPos)
		{
			return false;
		}

		public static Vector3 GetRandomPointOnSphereInsideCube(Vector3[] cubeMinMax, Vector3 sphereCenter, float sphereRadius, float minHeightAboveCenter = 0f)
		{
			return default(Vector3);
		}

		public static List<Vector2> GetPhiRangesForEdges(Vector3 minCorner, Vector3 maxCorner, Vector3 sphereCenter, float sphereRadius, float minHeightAboveCenter = 0f)
		{
			return null;
		}

		public static Vector2 GetThetaRangeForCube(Vector3 minCorner, Vector3 maxCorner, Vector3 sphereCenter, float sphereRadius, float minHeightAboveCenter = 0f)
		{
			return default(Vector2);
		}

		public static bool CubeSphereOverlap(Vector3[] cube1MinMax, Vector3 sphereCenter, float sphereRadius)
		{
			return false;
		}

		public static bool CubeSphereSurfaceIntersect(Vector3[] cube1MinMax, Vector3 sphereCenter, float sphereRadius, bool useMinHeight = false, float minHeight = 0f, bool terminal = false)
		{
			return false;
		}

		public static Vector3[] GetCubeNeighbors(Vector3 position, float cubeSize)
		{
			return null;
		}

		public static int NbCellsAtLayer3D(int layer)
		{
			return 0;
		}

		public static int NbCellsAtLayer2D(int layer)
		{
			return 0;
		}

		public static Vector3 BottomLeftOctantPosition(Vector3 position, int gridSize, int voxelSize)
		{
			return default(Vector3);
		}

		public static Vector3 GetCubePosition(Vector3 _bottomLeftCenterPos, int _ind, int gridSize, int voxelSize)
		{
			return default(Vector3);
		}

		public static List<Vector3> CalcCubeCorners(Vector3 center, float size)
		{
			return null;
		}
	}
}
