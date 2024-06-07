using System.Collections.Generic;
using Trees;
using UnityEngine;

namespace Navigation
{
	public interface ICostStrategy
	{
		SparseVoxelOctree SVO { get; set; }

		Dictionary<uint, float> GScore { get; set; }

		Dictionary<uint, float> FScore { get; set; }

		Dictionary<uint, uint> CameFrom { get; set; }

		List<uint> TotalPath { get; set; }

		bool ValidateStartEndPoints(uint startLink, uint endLink);

		bool ValidateStartEndPoints(Vector3 startLink, Vector3 endLink);

		float CalculateCost(uint curLink, uint neighborLink, float tempGScore, uint endNode);

		float GetTempGCost(SparseVoxelOctree svo, uint curLink, uint neighborLink, float agentHeight, float agentRadius);

		float HCost(uint link, uint endNode);

		float DCost(uint curLink, uint neighborLink);

		float FCost(float gScore, uint link, uint endNode);

		float TentativeGCost(uint current, uint neighbor, bool unitMode = false);

		float GCost(uint nodeLink);

		void InitDicts();

		void ClearDicts();

		void ReconstructPath(uint startNode, uint currentNode, int iterCount, bool debugLogPath = false);

		void ConvertPath(ref List<Vector3> vecPath, List<uint> linkPath);

		void DrawPath(ref List<Vector3> pathList, Vector3 startPos, Vector3 endPos, float debugDrawTime, Color color);
	}
}
