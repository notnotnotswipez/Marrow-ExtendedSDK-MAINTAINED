using System;
using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000037 RID: 55
	public interface IZoneLinkSecondaryListenable
	{
		// Token: 0x06000257 RID: 599
		void OnZoneLinkSecondaryEnter(MarrowEntity activator);

		// Token: 0x06000258 RID: 600
		void OnZoneLinkSecondaryExit(MarrowEntity activator);
	}
}
