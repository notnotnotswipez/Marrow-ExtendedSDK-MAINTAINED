using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000025 RID: 37
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00002407 File Offset: 0x00000607
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002409 File Offset: 0x00000609
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000240B File Offset: 0x0000060B
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000240D File Offset: 0x0000060D
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000240F File Offset: 0x0000060F
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000EA RID: 234
		public IKSolverCCD solver;
	}
}
