namespace SLZ.Interaction
{
	public class PumpShotgunVirtualController : SlideVirtualController
	{
		private float _virtualPerc;

		private float _currentPerc;

		private float _finalSlideDistance;

		public VirtualControllerOverride rifleVirtualController;

		public override void OnVirtualControllerStart(VirtualControlerPayload p)
		{
		}

		public override void OnVirtualControllerEnd()
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload p)
		{
		}
	}
}
