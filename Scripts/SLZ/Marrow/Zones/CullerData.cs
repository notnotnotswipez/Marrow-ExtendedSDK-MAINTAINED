using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200003C RID: 60
	internal class CullerData
	{
		// Token: 0x0600028B RID: 651 RVA: 0x00002E00 File Offset: 0x00001000
		public CullerData(int priority)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002E08 File Offset: 0x00001008
		public bool IsCulled()
		{
			return false;
		}

		// Token: 0x04000185 RID: 389
		public bool isSet;

		// Token: 0x04000186 RID: 390
		public bool isCulled;

		// Token: 0x04000187 RID: 391
		public bool isCullForced;

		// Token: 0x04000188 RID: 392
		public int priority;

		// Token: 0x04000189 RID: 393
		public List<InactiveStatus> disableables;

		// Token: 0x0400018A RID: 394
		public List<InactiveStatus> orphanDisableables;
	}
}
