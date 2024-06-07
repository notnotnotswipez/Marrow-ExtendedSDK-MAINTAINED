using UnityEngine;

namespace SLZ.Interaction
{
	public class SwingVirtualController : VirtualControllerOverride
	{
		public ConfigurableJoint joint;

		public bool allowTwist;

		private Vector3 _inputMagCache;

		private Quaternion _initialRotation;

		private Vector3 _lastSwing;

		protected void Reset()
		{
		}

		protected void Start()
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
