using System;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000029 RID: 41
	internal class DisableCount
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002D1A File Offset: 0x00000F1A
		public bool IsDisabled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000146 RID: 326
		public bool lastIsHidden;

		// Token: 0x04000147 RID: 327
		public bool isHidden;

		// Token: 0x04000148 RID: 328
		public bool lastIsCulled;

		// Token: 0x04000149 RID: 329
		public bool isCulled;

		// Token: 0x0400014A RID: 330
		public bool lastIsDespawned;

		// Token: 0x0400014B RID: 331
		public bool isDespawned;
	}
}
