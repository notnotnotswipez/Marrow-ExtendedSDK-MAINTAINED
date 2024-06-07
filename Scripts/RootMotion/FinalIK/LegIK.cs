using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002B RID: 43
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00002486 File Offset: 0x00000686
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002488 File Offset: 0x00000688
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000248A File Offset: 0x0000068A
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000248C File Offset: 0x0000068C
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000248E File Offset: 0x0000068E
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000F2 RID: 242
		public IKSolverLeg solver;
	}
}
