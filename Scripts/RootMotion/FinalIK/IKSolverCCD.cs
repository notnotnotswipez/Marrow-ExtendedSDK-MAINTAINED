using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000043 RID: 67
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic
	{
		// Token: 0x0600024C RID: 588 RVA: 0x000026AA File Offset: 0x000008AA
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000026AC File Offset: 0x000008AC
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000026AE File Offset: 0x000008AE
		private void Solve(Vector3 targetPosition)
		{
		}

		// Token: 0x04000213 RID: 531
		public IKSolver.IterationDelegate OnPreIteration;
	}
}
