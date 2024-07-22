using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000052 RID: 82
	[Serializable]
	public class InteractionLookAt
	{
		// Token: 0x06000328 RID: 808 RVA: 0x00002904 File Offset: 0x00000B04
		public void Look(Transform target, float time)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002906 File Offset: 0x00000B06
		public void OnFixTransforms()
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002908 File Offset: 0x00000B08
		public void Update()
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000290A File Offset: 0x00000B0A
		public void SolveSpine()
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000290C File Offset: 0x00000B0C
		public void SolveHead()
		{
		}

		// Token: 0x040002CB RID: 715
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		// Token: 0x040002CC RID: 716
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		// Token: 0x040002CD RID: 717
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		// Token: 0x040002CE RID: 718
		[HideInInspector]
		public bool isPaused;

		// Token: 0x040002CF RID: 719
		private Transform lookAtTarget;

		// Token: 0x040002D0 RID: 720
		private float stopLookTime;

		// Token: 0x040002D1 RID: 721
		private float weight;

		// Token: 0x040002D2 RID: 722
		private bool firstFBBIKSolve;
	}
}
