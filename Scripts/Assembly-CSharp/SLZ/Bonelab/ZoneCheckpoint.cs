using SLZ.Marrow;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Zones;

namespace SLZ.Bonelab
{
	public class ZoneCheckpoint : ZoneLinkItem
	{
		public bool onlySetOnce;

		public bool setOnEnter;

		public bool setOnExit;

		private bool _hasSetOnce;

		private void Set(RigManager rigManager)
		{
		}

		public void SetCheckpoint()
		{
		}

	}
}
