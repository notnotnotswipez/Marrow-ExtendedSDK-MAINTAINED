using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dynamite3D.RealIvy
{
	[Serializable]
	public class IvyParametersGUI : ScriptableObject
	{
		public IvyParameterFloat stepSize;

		public IvyParameterFloat branchProvability;

		public IvyParameterInt maxBranchs;

		public LayerMask layerMask;

		public IvyParameterFloat minDistanceToSurface;

		public IvyParameterFloat maxDistanceToSurface;

		public IvyParameterFloat DTSFrequency;

		public IvyParameterFloat DTSRandomness;

		public IvyParameterFloat directionFrequency;

		public IvyParameterFloat directionAmplitude;

		public IvyParameterFloat directionRandomness;

		public IvyParameterFloat gravityX;

		public IvyParameterFloat gravityY;

		public IvyParameterFloat gravityZ;

		public IvyParameterFloat grabProvabilityOnFall;

		public IvyParameterFloat stiffness;

		public IvyParameterFloat optAngleBias;

		public IvyParameterInt leaveEvery;

		public IvyParameterInt randomLeaveEvery;

		public bool buffer32Bits;

		public bool halfgeom;

		public IvyParameterInt sides;

		public IvyParameterFloat minRadius;

		public IvyParameterFloat maxRadius;

		public IvyParameterFloat radiusVarFreq;

		public IvyParameterFloat radiusVarOffset;

		public IvyParameterFloat tipInfluence;

		public IvyParameterFloat uvScaleX;

		public IvyParameterFloat uvScaleY;

		public IvyParameterFloat uvOffsetX;

		public IvyParameterFloat uvOffsetY;

		public IvyParameterFloat minScale;

		public IvyParameterFloat maxScale;

		public bool globalOrientation;

		public IvyParameterFloat globalRotationX;

		public IvyParameterFloat globalRotationY;

		public IvyParameterFloat globalRotationZ;

		public IvyParameterFloat rotationX;

		public IvyParameterFloat rotationY;

		public IvyParameterFloat rotationZ;

		public IvyParameterFloat randomRotationX;

		public IvyParameterFloat randomRotationY;

		public IvyParameterFloat randomRotationZ;

		public IvyParameterFloat offsetX;

		public IvyParameterFloat offsetY;

		public IvyParameterFloat offsetZ;

		public float LMUVPadding;

		public Material branchesMaterial;

		public List<GameObject> leavesPrefabs;

		public List<float> leavesProb;

		public bool generateBranches;

		public bool generateLeaves;

		public bool generateLightmapUVs;

		public void CopyFrom(IvyPreset ivyPreset)
		{
		}

		public void CopyFrom(IvyParameters copyFrom)
		{
		}
	}
}
