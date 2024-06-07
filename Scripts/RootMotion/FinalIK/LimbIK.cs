using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002C RID: 44
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class LimbIK : IK
	{
		// Token: 0x06000177 RID: 375 RVA: 0x00002499 File Offset: 0x00000699
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000249B File Offset: 0x0000069B
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000249D File Offset: 0x0000069D
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000249F File Offset: 0x0000069F
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000024A1 File Offset: 0x000006A1
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000F3 RID: 243
		public IKSolverLimb solver;
	}
}
