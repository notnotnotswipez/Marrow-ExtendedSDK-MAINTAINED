namespace SLZ.Interaction
{
	public class HingeVirtualController : VirtualControllerOverride
	{
		public Servo servo;

		private float _lastPhysTwist;

		private float _lastTargetTwist;

		private float _twistWindup;

		protected virtual void Reset()
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
