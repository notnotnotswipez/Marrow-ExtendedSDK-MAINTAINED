using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006A RID: 106
	public class OffsetPose : MonoBehaviour
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x00002BBF File Offset: 0x00000DBF
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002BC1 File Offset: 0x00000DC1
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		// Token: 0x04000373 RID: 883
		public OffsetPose.EffectorLink[] effectorLinks;

		// Token: 0x020000B8 RID: 184
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x06000590 RID: 1424 RVA: 0x00003029 File Offset: 0x00001229
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			// Token: 0x0400058A RID: 1418
			public FullBodyBipedEffector effector;

			// Token: 0x0400058B RID: 1419
			public Vector3 offset;

			// Token: 0x0400058C RID: 1420
			public Vector3 pin;

			// Token: 0x0400058D RID: 1421
			public Vector3 pinWeight;
		}
	}
}
