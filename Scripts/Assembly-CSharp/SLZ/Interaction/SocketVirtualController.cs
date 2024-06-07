using UnityEngine;

namespace SLZ.Interaction
{
	public class SocketVirtualController : MonoBehaviour
	{
		public enum TwistAlingment
		{
			OMNIDIRECTIONAL = 0,
			UNIDIRECTIONAL = 1,
			BIDIRECTIONAL = 2,
			QUADDIRECTIONAL = 4
		}

		public enum PositionalAlignment
		{
			FIXED = 0,
			LINE = 1,
			PLANE = 2
		}

		public PlugVirtualController.FormFactor formFactor;

		public TwistAlingment twistAlingment;

		public PositionalAlignment positionalAlignment;

		public Transform alignTransform;

		public Transform insertTransform;

		public void OnAttach()
		{
		}

		public void OnDettach()
		{
		}
	}
}
