using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		// Token: 0x06000274 RID: 628 RVA: 0x00002705 File Offset: 0x00000905
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002708 File Offset: 0x00000908
		public int GetChainIndex(Transform transform)
		{
			return 0;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000270B File Offset: 0x0000090B
		public IKSolver.Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000270E File Offset: 0x0000090E
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
			chainIndex = 0;
			nodeIndex = 0;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000271E File Offset: 0x0000091E
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002721 File Offset: 0x00000921
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002724 File Offset: 0x00000924
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002727 File Offset: 0x00000927
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002729 File Offset: 0x00000929
		public override void FixTransforms()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000272B File Offset: 0x0000092B
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000272D File Offset: 0x0000092D
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000272F File Offset: 0x0000092F
		protected virtual void ReadPose()
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002731 File Offset: 0x00000931
		protected virtual void Solve()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002733 File Offset: 0x00000933
		protected virtual void ApplyBendConstraints()
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002735 File Offset: 0x00000935
		protected virtual void WritePose()
		{
		}

		// Token: 0x0400021D RID: 541
		[Range(0f, 10f)]
		public int iterations;

		// Token: 0x0400021E RID: 542
		public FBIKChain[] chain;

		// Token: 0x0400021F RID: 543
		public IKEffector[] effectors;

		// Token: 0x04000220 RID: 544
		public IKMappingSpine spineMapping;

		// Token: 0x04000221 RID: 545
		public IKMappingBone[] boneMappings;

		// Token: 0x04000222 RID: 546
		public IKMappingLimb[] limbMappings;

		// Token: 0x04000223 RID: 547
		public bool FABRIKPass;

		// Token: 0x04000224 RID: 548
		public IKSolver.UpdateDelegate OnPreRead;

		// Token: 0x04000225 RID: 549
		public IKSolver.UpdateDelegate OnPreSolve;

		// Token: 0x04000226 RID: 550
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x04000227 RID: 551
		public IKSolver.IterationDelegate OnPostIteration;

		// Token: 0x04000228 RID: 552
		public IKSolver.UpdateDelegate OnPreBend;

		// Token: 0x04000229 RID: 553
		public IKSolver.UpdateDelegate OnPostSolve;

		// Token: 0x0400022A RID: 554
		public IKSolver.UpdateDelegate OnStoreDefaultLocalState;

		// Token: 0x0400022B RID: 555
		public IKSolver.UpdateDelegate OnFixTransforms;
	}
}
