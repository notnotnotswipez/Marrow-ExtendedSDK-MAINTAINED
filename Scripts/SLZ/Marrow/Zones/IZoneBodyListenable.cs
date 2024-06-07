using System;
using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000032 RID: 50
	public interface IZoneBodyListenable
	{
		// Token: 0x0600024A RID: 586
		void OnZoneBodyEnter(MarrowBody body);

		// Token: 0x0600024B RID: 587
		void OnZoneBodyExit(MarrowBody body);
	}
}
