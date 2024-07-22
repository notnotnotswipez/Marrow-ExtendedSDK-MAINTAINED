using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000026 RID: 38
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		// Token: 0x0600014A RID: 330 RVA: 0x0000241A File Offset: 0x0000061A
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000241C File Offset: 0x0000061C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000241E File Offset: 0x0000061E
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002420 File Offset: 0x00000620
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002422 File Offset: 0x00000622
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000EB RID: 235
		public IKSolverFABRIK solver;
	}
}
