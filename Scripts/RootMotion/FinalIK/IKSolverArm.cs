using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000042 RID: 66
	[Serializable]
	public class IKSolverArm : IKSolver
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0000268B File Offset: 0x0000088B
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000268E File Offset: 0x0000088E
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002691 File Offset: 0x00000891
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002694 File Offset: 0x00000894
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002696 File Offset: 0x00000896
		public override void FixTransforms()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002698 File Offset: 0x00000898
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000269A File Offset: 0x0000089A
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000269C File Offset: 0x0000089C
		private void Solve()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000269E File Offset: 0x0000089E
		private void Read()
		{
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000026A0 File Offset: 0x000008A0
		private void Write()
		{
		}

		// Token: 0x04000208 RID: 520
		[Range(0f, 1f)]
		public float IKRotationWeight;

		// Token: 0x04000209 RID: 521
		public Quaternion IKRotation;

		// Token: 0x0400020A RID: 522
		public IKSolver.Point chest;

		// Token: 0x0400020B RID: 523
		public IKSolver.Point shoulder;

		// Token: 0x0400020C RID: 524
		public IKSolver.Point upperArm;

		// Token: 0x0400020D RID: 525
		public IKSolver.Point forearm;

		// Token: 0x0400020E RID: 526
		public IKSolver.Point hand;

		// Token: 0x0400020F RID: 527
		public bool isLeft;

		// Token: 0x04000210 RID: 528
		public IKSolverVR.Arm arm;

		// Token: 0x04000211 RID: 529
		private Vector3[] positions;

		// Token: 0x04000212 RID: 530
		private Quaternion[] rotations;
	}
}
