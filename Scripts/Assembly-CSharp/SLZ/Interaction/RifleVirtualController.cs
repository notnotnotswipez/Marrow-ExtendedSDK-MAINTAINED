using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class RifleVirtualController : VirtualControllerOverride
	{
		public Transform shoulderTransform;

		public Collider testCollider;

		public float maxDistance;

		public float rotationMult;

		public float positionMult;

		private Vector2 _lastTt;

		private bool _resetX;

		private bool _secIsLead;

		private SimpleTransform _buttInRig;

		private SimpleTransform _colliderInRig;

		protected void Reset()
		{
		}

		private Vector2 ShoulderPoint(Vector3 shoulderLf, Vector3 shoulderRt, Vector3 butt, Vector3 sacrum)
		{
			return default(Vector2);
		}

		private Vector3 CalcShoulder(Vector3 shoulderLf, Vector3 shoulderRt, Vector3 sacrum, Vector2 tt)
		{
			return default(Vector3);
		}

		public override void OnVirtualControllerStart(VirtualControlerPayload payload)
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload payload)
		{
		}

		private void OnVirtualControllerStart2(VirtualControlerPayload payload)
		{
		}

		private void OnVirtualControllerSolve2(VirtualControlerPayload payload)
		{
		}
	}
}
