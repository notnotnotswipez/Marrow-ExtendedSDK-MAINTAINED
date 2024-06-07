using System;
using System.Collections.Generic;
using Trees;
using UnityEngine;

namespace Navigation
{
	public class GreedyAStar
	{
		private int doDraw;

		private Color[] colors;

		private SparseVoxelOctree _svo;

		private ICostStrategy _costStrategy;

		private Vector3 _startPos;

		private Vector3 _endPos;

		private uint _startNode;

		private uint _endNode;

		private float _agentHeight;

		private float _agentRadius;

		private readonly int _maxIterCount;

		private readonly bool _debugDrawPath;

		private readonly bool _debugLogPath;

		private readonly float _debugDrawTime;

		private bool _debugDrawNeighbors;

		private uint _currentNode;

		private int _iterCount;

		private MinHashHeap _openStack;

		private readonly Color[] _dbgColors;

		private Color[] selectedColors;

		private int colorInd;

		public ICostStrategy CostStrategy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private uint ExpandNode(uint link)
		{
			return 0u;
		}

		private uint SelectExpandedChildren(uint bestParentNode)
		{
			return 0u;
		}

		private void ProcessChildOctants(uint bestParentNode, uint _cameFromNode, int dirInd)
		{
		}

		private void ProcessChildVoxels(uint _bestParentNode, uint _cameFromNode, int dirInd)
		{
		}

		public float GetNeighborCost(uint neighborLink, int ind, bool leafNode)
		{
			return 0f;
		}

		protected virtual void ScoreNodeCollection(uint curLink, ReadOnlySpan<uint> neighbors)
		{
		}

		protected virtual void ScoreNode(uint curLink, uint nextLink)
		{
		}

		private bool CheckAvailableSpace(uint node)
		{
			return false;
		}

		private bool MeasureNeighborSpace(uint node)
		{
			return false;
		}

		private float NeighborSpaceInDir(int directionInd, float accumulatedSpace, float agentSizeRef, ref ReadOnlySpan<uint> nbrs)
		{
			return 0f;
		}

		private (uint, uint) GetStartEndCodes()
		{
			return default((uint, uint));
		}

		private uint[] FindNeighbors(uint link)
		{
			return null;
		}

		private bool CheckForCompletion()
		{
			return false;
		}

		private void AddToDict(ref Dictionary<uint, uint> dict, uint linkKey, uint linkValue)
		{
		}

		private void AddToDict(ref Dictionary<uint, float> dict, uint linkKey, float linkValue)
		{
		}

		private void DebugDrawNeighbors(uint neighborLink, int ind)
		{
		}

		private void DebugNeighborPrinter(uint link, Span<uint> neighbs)
		{
		}

		private void ClearVariables()
		{
		}

		public GreedyAStar(SparseVoxelOctree svo, ICostStrategy costStrategy, int maxIterCount = 10000, bool debugDrawPath = false, float debugDrawTime = 10f, bool debugDrawNeighbors = false)
		{
		}

		private void Init()
		{
		}

		private void CostStrategySetup()
		{
		}

		public List<uint> Query(Vector3 start, Vector3 end, SvoAgent svoAgent = null, bool getNextFreeLocation = false)
		{
			return null;
		}

		private void FindPath()
		{
		}

		private void ProcessNeighbors(uint link)
		{
		}
	}
}
