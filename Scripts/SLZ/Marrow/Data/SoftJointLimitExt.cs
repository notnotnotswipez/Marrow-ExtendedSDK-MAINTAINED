using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200019A RID: 410
	[Serializable]
	public struct SoftJointLimitExt
	{

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00008374 File Offset: 0x00006574
		public SoftJointLimit ToUnitySoftJointLimit()
		{
			return default(SoftJointLimit);
		}

		// Token: 0x04000AA8 RID: 2728
		public float limit;

		// Token: 0x04000AA9 RID: 2729
		public float bounciness;

		// Token: 0x04000AAA RID: 2730
		public float contactDistance;
	}
}
