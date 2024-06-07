using System;

namespace SLZ.Marrow.Data
{
	// Token: 0x02000188 RID: 392
	[Flags]
	public enum AttackType
	{
		// Token: 0x04000A28 RID: 2600
		Piercing = 1,
		// Token: 0x04000A29 RID: 2601
		Blunt = 2,
		// Token: 0x04000A2A RID: 2602
		Explosive = 4,
		// Token: 0x04000A2B RID: 2603
		Fire = 8,
		// Token: 0x04000A2C RID: 2604
		Slicing = 16,
		// Token: 0x04000A2D RID: 2605
		Stabbing = 32,
		// Token: 0x04000A2E RID: 2606
		None = 64,
		// Token: 0x04000A2F RID: 2607
		Ice = 128,
		// Token: 0x04000A30 RID: 2608
		Electric = 256
	}
}
