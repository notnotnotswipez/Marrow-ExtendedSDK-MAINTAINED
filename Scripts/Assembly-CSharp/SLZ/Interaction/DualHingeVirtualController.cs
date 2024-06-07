namespace SLZ.Interaction
{
	public class DualHingeVirtualController : HingeVirtualController
	{
		public Servo servo2;

		private float _lastPhysTwist2;

		private float _lastTargetTwist2;

		private float _twistWindup2;

		protected override void Reset()
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
