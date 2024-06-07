using SLZ.Marrow.Utilities;

namespace SLZ.Interaction
{
	public class VirtualControlerPayload
	{
		public bool isSingleHandedMode;

		public SimpleTransform wOverrideHost;

		public SimpleTransform rigInHost;

		public SimpleTransform vcInWorld;

		public SimpleTransform priContHandleInVc;

		public SimpleTransform secContHandleInVc;

		public SimpleTransform priGripInRig;

		public SimpleTransform secGripInRig;

		public HandGripPair priHandGripPair;

		public HandGripPair secHandGripPair;
	}
}
