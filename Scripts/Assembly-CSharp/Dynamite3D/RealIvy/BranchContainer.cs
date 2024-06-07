using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class BranchContainer : ScriptableObject
	{
		public List<BranchPoint> branchPoints;

		public Vector3 growDirection;

		public List<LeafPoint> leaves;

		public float totalLenght;

		public float fallIteration;

		public bool falling;

		public Quaternion rotationOnFallIteration;

		public int branchSense;

		public float heightParameter;

		public float randomizeHeight;

		public float heightVar;

		public float currentHeight;

		public float deltaHeight;

		public float newHeight;

		public BranchPoint originPointOfThisBranch;

		public int branchNumber;

		public Dictionary<int, List<LeafPoint>> dictRTLeavesByInitSegment;

		public int GetNumLeaves()
		{
			return 0;
		}

		public void SetValues(Vector3 growDirection, float randomizeHeight, float currentHeight, float heightParameter, int branchSense, BranchPoint originPointOfThisBranch)
		{
		}

		public void AddBranchPoint(BranchPoint branchPoint, float length, float stepSize)
		{
		}

		public void Init(int branchPointsSize, int numLeaves)
		{
		}

		public void Init()
		{
		}

		public void PrepareRTLeavesDict()
		{
		}

		public void UpdateLeavesDictEntry(int initSegmentIdx, LeafPoint leaf)
		{
		}

		public void AddBranchPoint(BranchPoint branchPoint)
		{
		}

		public void AddBranchPoint(Vector3 point, Vector3 grabVector)
		{
		}

		public void AddBranchPoint(Vector3 point, Vector3 grabVector, bool isNewBranch, int newBranchIndex)
		{
		}

		public BranchPoint InsertBranchPoint(Vector3 point, Vector3 grabVector, int index)
		{
			return null;
		}

		public void GetLeavesInSegmentRT(int initSegmentIdx, int endSegmentIdx, List<LeafPoint> res)
		{
		}

		public void GetLeavesInSegment(BranchPoint initSegment, List<LeafPoint> res)
		{
		}

		public List<LeafPoint> GetLeavesInSegment(BranchPoint initSegment)
		{
			return null;
		}

		public LeafPoint AddRandomLeaf(Vector3 pointWS, BranchPoint initSegment, BranchPoint endSegment, int leafIndex, InfoPool infoPool)
		{
			return null;
		}

		public void RepositionLeavesAfterAdd02(BranchPoint newPoint)
		{
		}

		public void RepositionLeavesAfterRemove02(BranchPoint removedPoint)
		{
		}

		public void RemoveBranchPoint(int indexToRemove)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public BranchPoint GetNearestPointFrom(Vector3 from)
		{
			return null;
		}

		public BranchPoint GetNearestPointWSFrom(Vector3 from)
		{
			return null;
		}

		public BranchPoint GetNearestPointSSFrom(Vector2 from)
		{
			return null;
		}

		public Vector3[] GetSegmentPoints(Vector3 worldPoint)
		{
			return null;
		}

		public BranchPoint GetLastBranchPoint()
		{
			return null;
		}

		public void AddLeaf(LeafPoint leafPoint)
		{
		}

		public LeafPoint AddLeaf(Vector3 leafPoint, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, BranchPoint initSegment, BranchPoint endSegment)
		{
			return null;
		}

		public LeafPoint InsertLeaf(Vector3 leafPoint, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, int leafIndex, BranchPoint initSegment, BranchPoint endSegment)
		{
			return null;
		}

		public void RemoveLeaves(List<LeafPoint> leaves)
		{
		}

		public void DrawLeavesVectors(List<BranchPoint> branchPointsToFilter)
		{
		}

		public void GetInitIdxEndIdxLeaves(int initIdxBranchPoint, float stepSize, out int initIdxLeaves, out int endIdxLeaves)
		{
			initIdxLeaves = default(int);
			endIdxLeaves = default(int);
		}

		public void ReleasePoint(int indexPoint)
		{
		}

		public void GetInitIdxEndIdxLeaves(int initIdxBranchPoint, int endIdxBranchPoint, float stepSize, out int initIdxLeaves, out int endIdxLeaves)
		{
			initIdxLeaves = default(int);
			endIdxLeaves = default(int);
		}
	}
}
