using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000023 RID: 35
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		// Token: 0x06000137 RID: 311 RVA: 0x000023DF File Offset: 0x000005DF
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000023E1 File Offset: 0x000005E1
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000023E3 File Offset: 0x000005E3
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000023E5 File Offset: 0x000005E5
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000023E7 File Offset: 0x000005E7
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000023E9 File Offset: 0x000005E9
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000E8 RID: 232
		public IKSolverAim solver;
	}
}
