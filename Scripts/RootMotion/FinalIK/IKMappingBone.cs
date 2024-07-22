using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003D RID: 61
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		// Token: 0x06000206 RID: 518 RVA: 0x000025FB File Offset: 0x000007FB
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return false;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002606 File Offset: 0x00000806
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002608 File Offset: 0x00000808
		public void FixTransforms()
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000260A File Offset: 0x0000080A
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000260C File Offset: 0x0000080C
		public void ReadPose()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000260E File Offset: 0x0000080E
		public void WritePose(float solverWeight)
		{
		}

		// Token: 0x040001D7 RID: 471
		public Transform bone;

		// Token: 0x040001D8 RID: 472
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x040001D9 RID: 473
		private IKMapping.BoneMap boneMap;
	}
}
