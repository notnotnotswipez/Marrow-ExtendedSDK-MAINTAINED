using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Interaction
{
	public class StaticSlideVirtualController : VirtualControllerOverride
	{
		public ConfigurableJoint joint;

		private float _lastPosInJoint;

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
