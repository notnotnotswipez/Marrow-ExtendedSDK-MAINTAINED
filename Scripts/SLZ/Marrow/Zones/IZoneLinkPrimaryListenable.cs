using System;
using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000036 RID: 54
	public interface IZoneLinkPrimaryListenable
	{
		// Token: 0x06000255 RID: 597
		void OnZoneLinkPrimaryEnter(MarrowEntity activator);

		// Token: 0x06000256 RID: 598
		void OnZoneLinkPrimaryExit(MarrowEntity activator);
	}
}
