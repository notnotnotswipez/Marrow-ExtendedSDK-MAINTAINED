using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004B RID: 75
	[Serializable]
	public class IKSolverLeg : IKSolver
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x000027C9 File Offset: 0x000009C9
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000027CC File Offset: 0x000009CC
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000027CF File Offset: 0x000009CF
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000027D2 File Offset: 0x000009D2
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000027D4 File Offset: 0x000009D4
		public override void FixTransforms()
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000027D6 File Offset: 0x000009D6
		protected override void OnInitiate()
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000027D8 File Offset: 0x000009D8
		protected override void OnUpdate()
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000027DA File Offset: 0x000009DA
		private void Solve()
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000027DC File Offset: 0x000009DC
		private void Read()
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000027DE File Offset: 0x000009DE
		private void Write()
		{
		}

		// Token: 0x04000249 RID: 585
		[Range(0f, 1f)]
		public float IKRotationWeight;

		// Token: 0x0400024A RID: 586
		public Quaternion IKRotation;

		// Token: 0x0400024B RID: 587
		public IKSolver.Point pelvis;

		// Token: 0x0400024C RID: 588
		public IKSolver.Point thigh;

		// Token: 0x0400024D RID: 589
		public IKSolver.Point calf;

		// Token: 0x0400024E RID: 590
		public IKSolver.Point foot;

		// Token: 0x0400024F RID: 591
		public IKSolver.Point toe;

		// Token: 0x04000250 RID: 592
		public IKSolverVR.Leg leg;

		// Token: 0x04000251 RID: 593
		public Vector3 heelOffset;

		// Token: 0x04000252 RID: 594
		private Vector3[] positions;

		// Token: 0x04000253 RID: 595
		private Quaternion[] rotations;
	}
}
