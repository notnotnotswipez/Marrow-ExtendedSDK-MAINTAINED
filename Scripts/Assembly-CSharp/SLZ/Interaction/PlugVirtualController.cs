using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class PlugVirtualController : VirtualControllerOverride
	{
		public enum FormFactor
		{
			FORMFACTOR_NONE = 0,
			FORMFACTOR_A = 10,
			FORMFACTOR_B = 11,
			FORMFACTOR_C = 12,
			FORMFACTOR_D = 13,
			FORMFACTOR_E = 14,
			FORMFACTOR_F = 15,
			FORMFACTOR_G = 16
		}

		private enum Phases
		{
			NONE = 0,
			INSERT = 1,
			ATTACH = 2,
			COMPLETE = 3
		}

		private Phases _curPhase;

		public FormFactor formFactor;

		public Transform alignTransform;

		private SimpleTransform _alignTInHost;

		private SocketVirtualController _socket;

		protected override void Awake()
		{
		}

		public override void OnVirtualControllerStart(VirtualControlerPayload payload)
		{
		}

		public override void OnVirtualControllerSolve(VirtualControlerPayload payload)
		{
		}

		public bool AlignmentPhase(VirtualControlerPayload payload)
		{
			return false;
		}

		public void InsertPhase()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
