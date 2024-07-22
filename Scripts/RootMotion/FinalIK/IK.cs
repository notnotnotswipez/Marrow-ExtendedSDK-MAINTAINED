using System;

namespace RootMotion.FinalIK
{
	// Token: 0x02000029 RID: 41
	public abstract class IK : SolverManager
	{
		// Token: 0x06000163 RID: 355
		public abstract IKSolver GetIKSolver();

		// Token: 0x06000164 RID: 356 RVA: 0x00002463 File Offset: 0x00000663
		protected override void UpdateSolver()
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002465 File Offset: 0x00000665
		protected override void InitiateSolver()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002467 File Offset: 0x00000667
		protected override void FixTransforms()
		{
		}

		// Token: 0x06000167 RID: 359
		protected abstract void OpenUserManual();

		// Token: 0x06000168 RID: 360
		protected abstract void OpenScriptReference();
	}
}
