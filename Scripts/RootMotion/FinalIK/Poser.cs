using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000059 RID: 89
	public abstract class Poser : SolverManager
	{
		// Token: 0x060003A3 RID: 931
		public abstract void AutoMapping();

		// Token: 0x060003A4 RID: 932 RVA: 0x00002A70 File Offset: 0x00000C70
		public void UpdateManual()
		{
		}

		// Token: 0x060003A5 RID: 933
		protected abstract void InitiatePoser();

		// Token: 0x060003A6 RID: 934
		protected abstract void UpdatePoser();

		// Token: 0x060003A7 RID: 935
		protected abstract void FixPoserTransforms();

		// Token: 0x060003A8 RID: 936 RVA: 0x00002A72 File Offset: 0x00000C72
		protected override void UpdateSolver()
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002A74 File Offset: 0x00000C74
		protected override void InitiateSolver()
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002A76 File Offset: 0x00000C76
		protected override void FixTransforms()
		{
		}

		// Token: 0x04000305 RID: 773
		public Transform poseRoot;

		// Token: 0x04000306 RID: 774
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04000307 RID: 775
		[Range(0f, 1f)]
		public float localRotationWeight;

		// Token: 0x04000308 RID: 776
		[Range(0f, 1f)]
		public float localPositionWeight;

		// Token: 0x04000309 RID: 777
		private bool initiated;
	}
}
