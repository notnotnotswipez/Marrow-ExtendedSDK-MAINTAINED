using SLZ.Marrow.Utilities;

namespace SLZ.Interaction
{
	public class Plug : MarrowBehaviour
	{
		public InteractableHost host;

		public float effectiveRadius;

		private void Reset()
		{
		}

		public virtual void OnPlugHoverBegin(Socket socket)
		{
		}

		public virtual void OnPlugHoverEnd(Socket socket)
		{
		}

		public virtual void OnPlugHoverUpdate(Socket socket)
		{
		}

		public virtual void OnDespawn()
		{
		}
	}
}
