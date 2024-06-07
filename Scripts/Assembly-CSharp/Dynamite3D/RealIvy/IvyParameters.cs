using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class IvyParameters
	{
		public float stepSize;

		public int randomSeed;

		public float branchProvability;

		public int maxBranchs;

		public LayerMask layerMask;

		public float minDistanceToSurface;

		public float maxDistanceToSurface;

		public float DTSFrequency;

		public float DTSRandomness;

		public float directionFrequency;

		public float directionAmplitude;

		public float directionRandomness;

		public Vector3 gravity;

		public float grabProvabilityOnFall;

		public float stiffness;

		public float optAngleBias;

		public int leaveEvery;

		public int randomLeaveEvery;

		public bool buffer32Bits;

		public bool halfgeom;

		public int sides;

		public float minRadius;

		public float maxRadius;

		public float radiusVarFreq;

		public float radiusVarOffset;

		public float tipInfluence;

		public Vector2 uvScale;

		public Vector2 uvOffset;

		public float minScale;

		public float maxScale;

		public bool globalOrientation;

		public Vector3 globalRotation;

		public Vector3 rotation;

		public Vector3 randomRotation;

		public Vector3 offset;

		public float LMUVPadding;

		public Material branchesMaterial;

		public GameObject[] leavesPrefabs;

		public float[] leavesProb;

		public Dictionary<int, Vector2> UV2IslesSizes;

		public bool generateBranches;

		public bool generateLeaves;

		public bool generateLightmapUVs;

		public IvyParameters()
		{
		}

		public IvyParameters(IvyParameters copyFrom)
		{
		}

		public void CopyFrom(IvyPreset ivyPreset)
		{
		}

		public void CopyFrom(IvyParametersGUI copyFrom)
		{
		}

		public void CopyFrom(IvyParameters copyFrom)
		{
		}

		public bool IsEqualTo(IvyParameters compareTo)
		{
			return false;
		}
	}
}
