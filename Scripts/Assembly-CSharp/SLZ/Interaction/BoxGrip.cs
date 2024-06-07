using System;
using System.Collections.Generic;
using SLZ.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Interaction
{
	[DisallowMultipleComponent]
	public class BoxGrip : TargetGrip
	{
		private class GrabConfiguration
		{
			public bool isZoneValid;

			public bool isSandwich;

			public bool isFace;

			public Faces face;

			public bool isEdge;

			public Edges edge;

			public bool isCorner;

			public Corners corner;

			public Vector3 gripWorld;

			public Vector3 handleWorld;

			public Vector3 normal;

			public Vector3 localPosition;

			public Quaternion localRotation;
		}

		[Flags]
		public enum Faces
		{
			PositiveX = 1,
			NegativeX = 2,
			PositiveY = 4,
			NegativeY = 8,
			PositiveZ = 0x10,
			NegativeZ = 0x20
		}

		[Flags]
		public enum Edges
		{
			PositiveXPositiveY = 1,
			NegativeXPositiveY = 2,
			PositiveXNegativeY = 4,
			NegativeXNegativeY = 8,
			PositiveXPositiveZ = 0x10,
			NegativeXPositiveZ = 0x20,
			PositiveXNegativeZ = 0x40,
			NegativeXNegativeZ = 0x80,
			PositiveYPositiveZ = 0x100,
			NegativeYPositiveZ = 0x200,
			PositiveYNegativeZ = 0x400,
			NegativeYNegativeZ = 0x800
		}

		[Flags]
		public enum Corners
		{
			PositiveXPositiveYPositiveZ = 1,
			NegativeXPositiveYPositiveZ = 2,
			PositiveXNegativeYPositiveZ = 4,
			NegativeXNegativeYPositiveZ = 8,
			PositiveXPositiveYNegativeZ = 0x10,
			NegativeXPositiveYNegativeZ = 0x20,
			PositiveXNegativeYNegativeZ = 0x40,
			NegativeXNegativeYNegativeZ = 0x80
		}

		private struct HandToBoxGripState
		{
			public float radius;

			public HandPose handPose;
		}

		[FormerlySerializedAs("sandwitchSize")]
		[Header("BoxGrip Options")]
		public float sandwichSize;

		public float edgePadding;

		public float faceInsetdistance;

		public float faceDepth;

		[FormerlySerializedAs("sandwitchHandPose")]
		public HandPose sandwichHandPose;

		public bool canBeSandwichedGrabbed;

		public HandPose edgeHandPose;

		public float edgeHandPoseRadius;

		public bool canBeEdgeGrabbed;

		public HandPose cornerHandPose;

		public float cornerHandPoseRadius;

		public bool canBeCornerGrabbed;

		public HandPose faceHandPose;

		public float faceHandPoseRadius;

		public bool canBeFaceGrabbed;

		private Bounds _bounds;

		private Dictionary<Hand, GrabConfiguration> _grabConfig;

		[Header("BoxGrip Face Options")]
		[SerializeField]
		[EnumFlags]
		public Faces enabledFaces;

		[EnumFlags]
		[SerializeField]
		public Edges enabledEdges;

		[EnumFlags]
		[SerializeField]
		public Corners enabledCorners;

		[Tooltip("Defines the primary face for force grab orentation")]
		[SerializeField]
		private Faces forceGrabFace;

		[SerializeField]
		[Tooltip("Defines the secondary face for force grab orentation")]
		private Faces forceGrabTop;

		[SerializeField]
		[Header("References")]
		public BoxCollider _boxCollider;

		private Dictionary<Hand, HandToBoxGripState> boxHandStates;

		private float _45DegSin;

		private Vector3 _boxCenter;

		private Vector3 _boxSize;

		private Vector3 _boxExtents;

		protected override void Awake()
		{
		}

		private float GetDistanceBetweenFace(Faces face)
		{
			return 0f;
		}

		private Vector3 FaceToVector(Faces face)
		{
			return default(Vector3);
		}

		public override SimpleTransform GetForcePullTransform(Hand hand)
		{
			return default(SimpleTransform);
		}

		public void UpdateForcePullTransform(Hand hand)
		{
		}

		public float GetEdgePadding()
		{
			return 0f;
		}

		public override void OnFarHandHoverBegin(Hand hand)
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public override bool OnHandHoverUpdate(Hand hand, bool isOverride)
		{
			return false;
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		public override (float, float, Vector3, Vector3) ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default((float, float, Vector3, Vector3));
		}

		private void OnDrawGizmosSelected()
		{
		}

		public bool CheckZones(Hand hand)
		{
			return false;
		}
	}
}
