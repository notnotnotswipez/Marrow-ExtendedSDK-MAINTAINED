using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000027 RID: 39
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		// Token: 0x06000150 RID: 336 RVA: 0x0000242D File Offset: 0x0000062D
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000242F File Offset: 0x0000062F
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002431 File Offset: 0x00000631
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002433 File Offset: 0x00000633
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002435 File Offset: 0x00000635
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000EC RID: 236
		public IKSolverFABRIKRoot solver;
	}
}
