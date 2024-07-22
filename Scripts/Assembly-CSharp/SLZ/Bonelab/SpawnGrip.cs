using System;
using SLZ.Marrow;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SpawnGrip : HandReciever
	{
		[Range(0f, 10f)]
		public float priority;

		public Action<Hand> onSpawnGrabDelegate;

		[SerializeField]
		private bool enableUpdateVolume;

		[SerializeField]
		private CapsuleCollider _interactableCol;

		[SerializeField]
		private Transform _t1Tran;

		public Vector3 t1PlaneOffset;

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		private void Update()
		{
		}

		public override (float, float, Vector3, Vector3) ValidateGripScore(Hand hand, SimpleTransform handTransform)
		{
			return default((float, float, Vector3, Vector3));
		}

		private void UpdateInteractionVolume()
		{
		}
	}
}
