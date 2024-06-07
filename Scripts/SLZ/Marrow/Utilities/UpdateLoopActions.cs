using System;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000107 RID: 263
	public enum UpdateLoopActions
	{
		// Token: 0x0400062D RID: 1581
		PostTimeUpdate,
		// Token: 0x0400062E RID: 1582
		StartFrame,
		// Token: 0x0400062F RID: 1583
		PreNewInputUpdate,
		// Token: 0x04000630 RID: 1584
		PostNewInputUpdate,
		// Token: 0x04000631 RID: 1585
		EarlyUpdate,
		// Token: 0x04000632 RID: 1586
		PreFixedUpdate,
		// Token: 0x04000633 RID: 1587
		PostFixedUpdate,
		// Token: 0x04000634 RID: 1588
		Update,
		// Token: 0x04000635 RID: 1589
		EndFrame
	}
}
