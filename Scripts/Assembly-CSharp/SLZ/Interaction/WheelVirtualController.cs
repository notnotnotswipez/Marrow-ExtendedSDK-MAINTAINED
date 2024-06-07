using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class WheelVirtualController : VirtualControllerOverride
	{
		public GameObject dbg_obj;

		public Transform shoulderTransform;

		public Rigidbody frontAxle;

		public float steeringDamp;

		public float maxDistance;

		public float rotationMult;

		public float positionMult;

		private float _lastX;

		private float _lastTime;

		private Vector2 _lastTt;

		private bool _resetX;

		private bool _secIsLead;

		private bool _firstPass;

		private SimpleTransform _buttInRig;

		private SimpleTransform _hostOffset;

		private SimpleTransform _lastBlendTransform;

		private SimpleTransform _lastVcInLocal;

		private Vector3 _acceleration;

		private Vector3 _velocity;

		private Vector3 lastHandVec;

		private Vector3 currentHandVec;

		protected void Reset()
		{
		}

		public override void OnVirtualControllerStart(VirtualControlerPayload payload)
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload payload)
		{
		}
	}
}
