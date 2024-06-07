using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002D RID: 45
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page8.html")]
	public class LookAtIK : IK
	{
		// Token: 0x0600017D RID: 381 RVA: 0x000024AC File Offset: 0x000006AC
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000024AE File Offset: 0x000006AE
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000024B0 File Offset: 0x000006B0
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000024B2 File Offset: 0x000006B2
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000024B4 File Offset: 0x000006B4
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000F4 RID: 244
		public IKSolverLookAt solver;
	}
}
