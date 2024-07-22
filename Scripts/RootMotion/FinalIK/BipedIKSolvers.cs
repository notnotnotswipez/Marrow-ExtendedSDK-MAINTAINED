using System;

namespace RootMotion.FinalIK
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class BipedIKSolvers
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000228F File Offset: 0x0000048F
		public IKSolverLimb[] limbs
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002292 File Offset: 0x00000492
		public void AssignReferences(BipedReferences references)
		{
		}

		// Token: 0x0400006A RID: 106
		public IKSolverLimb leftFoot;

		// Token: 0x0400006B RID: 107
		public IKSolverLimb rightFoot;

		// Token: 0x0400006C RID: 108
		public IKSolverLimb leftHand;

		// Token: 0x0400006D RID: 109
		public IKSolverLimb rightHand;

		// Token: 0x0400006E RID: 110
		public IKSolverFABRIK spine;

		// Token: 0x0400006F RID: 111
		public IKSolverLookAt lookAt;

		// Token: 0x04000070 RID: 112
		public IKSolverAim aim;

		// Token: 0x04000071 RID: 113
		public Constraints pelvis;

		// Token: 0x04000072 RID: 114
		private IKSolverLimb[] _limbs;

		// Token: 0x04000073 RID: 115
		private IKSolver[] _ikSolvers;
	}
}
