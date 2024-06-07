using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Trees;
using UnityEngine;

namespace Navigation
{
	public class HeightRangeCost : ICostStrategy
	{
		public float MaxHeight;

		public float MinHeight;

		public Vector3 RefPoint;

		public Vector3 CurPos;

		private int stopDrawCount;

		private Color[] selectedColors;

		private int colorInd;

		public SparseVoxelOctree SVO
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<uint, float> GScore
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<uint, float> FScore
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<uint, uint> CameFrom
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private Dictionary<uint, float[]> HeightScore
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<uint> TotalPath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public HeightRangeCost(SparseVoxelOctree svo)
		{
		}

		public bool ValidateStartEndPoints(uint startLink, uint endLink)
		{
			return false;
		}

		public bool ValidateStartEndPoints(Vector3 startPos, Vector3 endPos)
		{
			return false;
		}

		public float CalculateCost(uint curLink, uint neighborLink, float tempGScore, uint endNode)
		{
			return 0f;
		}

		public float GetTempGCost(SparseVoxelOctree svo, uint curLink, uint neighborLink, float agentHeight, float agentRadius)
		{
			return 0f;
		}

		public float HCost(uint link, uint endNode)
		{
			return 0f;
		}

		public float DCost(uint curLink, uint neighborLink)
		{
			return 0f;
		}

		public float FCost(float gScore, uint link, uint endNode)
		{
			return 0f;
		}

		public float TentativeGCost(uint current, uint neighbor, bool unitMode = false)
		{
			return 0f;
		}

		public float GCost(uint nodeLink)
		{
			return 0f;
		}

		private float[] HeightCost(uint nodeLink)
		{
			return null;
		}

		private (float, float) GetValidIntersectionBounds(uint nodeLink)
		{
			return default((float, float));
		}

		private float InverseHeightCost(float intersectionMinY, float intersectionMaxY)
		{
			return 0f;
		}

		public void SetHeightInfo(Vector3 refPos, float minHeight = float.MinValue, float maxHeight = float.MaxValue)
		{
		}

		public void InitDicts()
		{
		}

		public void ClearDicts()
		{
		}

		public void ReconstructPath(uint startNode, uint currentNode, int iterCount, bool debugLogPath = false)
		{
		}

		public void ConvertPath(ref List<Vector3> vecPath, List<uint> linkPath)
		{
		}

		public void DrawPath(ref List<Vector3> pathList, Vector3 startPos, Vector3 endPos, float debugDrawTime, Color color)
		{
		}

		public void DrawAllowedVolume(Vector3 nodePosition, float nodeSize, Vector2 intersectionBounds)
		{
		}

		public static void DrawCube(Vector3 position, float size, Color color, float drawTime)
		{
		}
	}
}
