using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000121 RID: 289
	public readonly struct TemporalTransform
	{

		// Token: 0x04000650 RID: 1616
		public readonly SimpleTransform transform;

		// Token: 0x04000651 RID: 1617
		public readonly Vector3 velocity;

		// Token: 0x04000652 RID: 1618
		public readonly Vector3 angularVelocity;

		// Token: 0x04000653 RID: 1619
		public readonly double time;
	}
}
