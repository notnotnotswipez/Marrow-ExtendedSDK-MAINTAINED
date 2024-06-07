using SLZ.Combat;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SwordVirtualController : VirtualControllerOverride
	{
		public StabSlash stabSlash;

		private Vector3 _inputMagCache;

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
