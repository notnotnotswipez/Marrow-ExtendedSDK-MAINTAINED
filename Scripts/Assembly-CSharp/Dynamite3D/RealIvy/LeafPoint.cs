using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class LeafPoint
	{
		public Vector3 point;

		public Vector2 pointSS;

		public float lpLength;

		public Vector3 left;

		public Vector3 lpForward;

		public Vector3 lpUpward;

		public int chosenLeave;

		public Quaternion forwarRot;

		public int initSegmentIdx;

		public int endSegmentIdx;

		public float displacementFromInitSegment;

		public Quaternion leafRotation;

		public float currentScale;

		public float dstScale;

		public Vector3 leafCenter;

		public List<RTVertexData> verticesLeaves;

		public float leafScale;

		public void InitializeRuntime()
		{
		}

		public LeafPoint()
		{
		}

		public LeafPoint(Vector3 point, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, BranchPoint initSegment, BranchPoint endSegment)
		{
		}

		public void SetValues(Vector3 point, float lpLength, Vector3 lpForward, Vector3 lpUpward, int chosenLeave, BranchPoint initSegment, BranchPoint endSegment)
		{
		}

		public void DrawVectors()
		{
		}

		public float GetLengthFactor(BranchContainer branchContainer, float correctionFactor)
		{
			return 0f;
		}

		public void CreateVertices(IvyParameters ivyParameters, RTMeshData leafMeshData, GameObject ivyGO)
		{
		}
	}
}
