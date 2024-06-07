using System;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200002E RID: 46
	[Flags]
	public enum InactiveStates
	{
		// Token: 0x0400015E RID: 350
		None = 0,
		// Token: 0x0400015F RID: 351
		Hide = 1,
		// Token: 0x04000160 RID: 352
		Cull = 2,
		// Token: 0x04000161 RID: 353
		Despawn = 4,
		// Token: 0x04000162 RID: 354
		All = 7
	}
}
