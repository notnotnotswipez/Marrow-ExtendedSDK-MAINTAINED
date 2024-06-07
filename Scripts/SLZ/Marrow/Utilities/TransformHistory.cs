using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000124 RID: 292
	public class TransformHistory
	{
		// Token: 0x06000A56 RID: 2646 RVA: 0x00004400 File Offset: 0x00002600
		public void AddTransform(in TemporalTransform transform, double toTime)
		{
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00004402 File Offset: 0x00002602
		private float GetBlendPercentage(in double fromTime, in double toTime, in double atTime)
		{
			return 0f;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00004409 File Offset: 0x00002609
		public void CopyPoseAtTime(double atTime, in Transform transform)
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0000440B File Offset: 0x0000260B
		private bool GetPosesIndexAtTime(in double atTime, out int atIndex)
		{
			atIndex = 0;
			return false;
		}

		// Token: 0x04000659 RID: 1625
		public RingBuffer<TemporalTransform> transforms;

		// Token: 0x0400065A RID: 1626
		public RingBuffer<TemporalTransform> extrapTransforms;
	}
}
