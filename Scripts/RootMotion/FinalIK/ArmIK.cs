using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000024 RID: 36
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		// Token: 0x0600013E RID: 318 RVA: 0x000023F4 File Offset: 0x000005F4
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000023F6 File Offset: 0x000005F6
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000023F8 File Offset: 0x000005F8
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000023FA File Offset: 0x000005FA
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000023FC File Offset: 0x000005FC
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x040000E9 RID: 233
		public IKSolverArm solver;
	}
}
