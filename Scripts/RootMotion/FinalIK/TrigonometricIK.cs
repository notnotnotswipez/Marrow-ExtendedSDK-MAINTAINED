using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002E RID: 46
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		// Token: 0x06000183 RID: 387 RVA: 0x000024BF File Offset: 0x000006BF
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000024C1 File Offset: 0x000006C1
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000024C3 File Offset: 0x000006C3
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000024C5 File Offset: 0x000006C5
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000024C7 File Offset: 0x000006C7
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000F5 RID: 245
		public IKSolverTrigonometric solver;
	}
}
