using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x0200013D RID: 317
	[Serializable]
	public class TrackerSettingsGroup
	{
		// Token: 0x04000709 RID: 1801
		[SerializeField]
		public TrackerLayers layers;

		// Token: 0x0400070A RID: 1802
		[SerializeField]
		public TrackerSettings[] settings;
	}
}
