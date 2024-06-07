using SLZ.Vehicle;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SeatIngressVirtualController : VirtualControllerOverride
	{
		public Seat seat;

		private Vector3 _vcFromChestInWorld;

		public override void OnVirtualControllerStart(VirtualControlerPayload payload)
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload payload)
		{
		}

		public override void OnVirtualControllerEnd()
		{
		}
	}
}
