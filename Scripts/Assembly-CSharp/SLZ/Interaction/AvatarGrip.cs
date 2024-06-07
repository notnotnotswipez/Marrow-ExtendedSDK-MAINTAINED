using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Interaction
{
	public class AvatarGrip : Grip
	{
		public enum BodyRb
		{
			Head = 0,
			Neck = 1,
			Chest = 2,
			Spine = 3,
			Pelvis = 4
		}

		private class HandToGenericGripState
		{
			public Vector3 raycastNormal;

			public Vector3 raycastPoint;

			public float softDisplace;
		}

		[SerializeField]
		private PhysicsRig _physRig;

		public BodyRb bodyRb;

		private Dictionary<Hand, HandToGenericGripState> genericHandStates;

		[SerializeField]
		private MeshCollider[] _targetColliders;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		public override void OnHandAttachedUpdate(Hand hand)
		{
		}

		public override (float, float, Vector3, Vector3) ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default((float, float, Vector3, Vector3));
		}

		protected override void UpdateJointConfiguration(Hand hand)
		{
		}

		protected override void SetupConfiguration(HandJointConfiguration config)
		{
		}
	}
}
