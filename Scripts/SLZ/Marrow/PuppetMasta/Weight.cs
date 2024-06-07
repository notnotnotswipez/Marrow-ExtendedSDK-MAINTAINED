using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000EC RID: 236
	[Serializable]
	public class Weight
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x000040F3 File Offset: 0x000022F3
		public Weight(float floatValue)
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000040FB File Offset: 0x000022FB
		public Weight(float floatValue, string tooltip)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00004103 File Offset: 0x00002303
		public float GetValue(float param)
		{
			return 0f;
		}

		// Token: 0x040005E5 RID: 1509
		public Weight.Mode mode;

		// Token: 0x040005E6 RID: 1510
		public float floatValue;

		// Token: 0x040005E7 RID: 1511
		public AnimationCurve curve;

		// Token: 0x040005E8 RID: 1512
		public string tooltip;

		// Token: 0x02000254 RID: 596
		[Serializable]
		public enum Mode
		{
			// Token: 0x04000F0C RID: 3852
			Float,
			// Token: 0x04000F0D RID: 3853
			Curve
		}
	}
}
