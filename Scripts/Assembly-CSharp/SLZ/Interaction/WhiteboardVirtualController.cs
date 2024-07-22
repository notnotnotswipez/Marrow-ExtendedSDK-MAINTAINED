using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Interaction
{
	public class WhiteboardVirtualController : VirtualControllerOverride
	{
		private WhiteboardZone _wbz;

		private bool hasWBZ;

		public Transform tip;

		protected void Reset()
		{
		}

		public void Activate(WhiteboardZone wbz)
		{
		}

		public void Deactivate(WhiteboardZone wbz)
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
