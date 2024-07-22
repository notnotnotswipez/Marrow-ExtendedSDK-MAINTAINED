using System.Collections.Generic;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GravityStaffReciever : MonoBehaviour
	{
		public float pickupCooldown;

		public GravityManipulatorJob manipulator;

		private CoreBomb _activeCore;

		private List<Collider> _activeCoreColliders;

		private bool _isActive;

		public float _lastDropTime;

		private void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public void Deactivate()
		{
		}

		public void Activate()
		{
		}

		private void OnCoreCiticalHit()
		{
		}
	}
}
