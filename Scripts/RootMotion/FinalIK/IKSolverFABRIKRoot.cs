using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000045 RID: 69
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		// Token: 0x06000269 RID: 617 RVA: 0x000026E7 File Offset: 0x000008E7
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000026EA File Offset: 0x000008EA
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000026EC File Offset: 0x000008EC
		public override void FixTransforms()
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000026EE File Offset: 0x000008EE
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000026F0 File Offset: 0x000008F0
		private bool IsRoot(int index)
		{
			return false;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000026F3 File Offset: 0x000008F3
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000026F5 File Offset: 0x000008F5
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000026F8 File Offset: 0x000008F8
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000026FB File Offset: 0x000008FB
		private void AddPointsToArray(ref IKSolver.Point[] array, FABRIKChain chain)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003754 File Offset: 0x00001954
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		// Token: 0x04000217 RID: 535
		public int iterations;

		// Token: 0x04000218 RID: 536
		[Range(0f, 1f)]
		public float rootPin;

		// Token: 0x04000219 RID: 537
		public FABRIKChain[] chains;

		// Token: 0x0400021A RID: 538
		private bool zeroWeightApplied;

		// Token: 0x0400021B RID: 539
		private bool[] isRoot;

		// Token: 0x0400021C RID: 540
		private Vector3 rootDefaultPosition;
	}
}
