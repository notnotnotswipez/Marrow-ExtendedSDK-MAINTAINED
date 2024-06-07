using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class BranchPoint
	{
		public Vector3 originalPoint;

		public Vector3 point;

		public Vector3 grabVector;

		public Vector2 pointSS;

		public float length;

		public Vector3 initialGrowDir;

		public BranchContainer branchContainer;

		public int index;

		public bool newBranch;

		public int newBranchNumber;

		public float radius;

		public float currentRadius;

		public Quaternion forwardRotation;

		public List<RTVertexData> verticesLoop;

		public Vector3 firstVector;

		public Vector3 axis;

		public void SetValues(Vector3 point, Vector3 grabVector, Vector2 pointSS, BranchContainer branchContainer, int index, bool blocked, bool newBranch, int newBranchNumber, float length)
		{
		}

		public BranchPoint()
		{
		}

		public void InitializeRuntime(IvyParameters ivyParameters)
		{
		}

		public BranchPoint(Vector3 point, Vector3 grabVector, int index, bool newBranch, int newBranchNumber, float length, BranchContainer branchContainer)
		{
		}

		public BranchPoint(Vector3 point, Vector3 grabVector, int index, float length, BranchContainer branchContainer)
		{
		}

		public BranchPoint(Vector3 point, int index, float length, BranchContainer branchContainer)
		{
		}

		public void SetOriginalPoint()
		{
		}

		public BranchPoint GetNextPoint()
		{
			return null;
		}

		public BranchPoint GetPreviousPoint()
		{
			return null;
		}

		public void Move(Vector3 newPosition)
		{
		}

		public void InitBranchInThisPoint(int branchNumber)
		{
		}

		public void ReleasePoint()
		{
		}
	}
}
