using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public class FABRIKChain
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x00002550 File Offset: 0x00000750
		public bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002553 File Offset: 0x00000753
		public void Initiate()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002555 File Offset: 0x00000755
		public void Stage1(FABRIKChain[] chain)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002557 File Offset: 0x00000757
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00003564 File Offset: 0x00001764
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		// Token: 0x04000154 RID: 340
		public FABRIK ik;

		// Token: 0x04000155 RID: 341
		[Range(0f, 1f)]
		public float pull;

		// Token: 0x04000156 RID: 342
		[Range(0f, 1f)]
		public float pin;

		// Token: 0x04000157 RID: 343
		public int[] children;
	}
}
