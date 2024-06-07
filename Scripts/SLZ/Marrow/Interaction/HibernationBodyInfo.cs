using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000130 RID: 304
	public struct HibernationBodyInfo
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x000044FB File Offset: 0x000026FB
		public void CopyFrom(Rigidbody rb)
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000044FD File Offset: 0x000026FD
		public void CopyTo(Rigidbody rb)
		{
		}

		// Token: 0x04000684 RID: 1668
		public bool isSleeping;

		// Token: 0x04000685 RID: 1669
		public Vector3 velocity;

		// Token: 0x04000686 RID: 1670
		public Vector3 angularVelocity;

		// Token: 0x04000687 RID: 1671
		public Vector3 inertiaTensor;

		// Token: 0x04000688 RID: 1672
		public float sleepThreshold;

		// Token: 0x04000689 RID: 1673
		public RigidbodyConstraints constraints;
	}
}
