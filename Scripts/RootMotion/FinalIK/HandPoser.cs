using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000058 RID: 88
	public class HandPoser : Poser
	{
		// Token: 0x0600039D RID: 925 RVA: 0x00002A5E File Offset: 0x00000C5E
		public override void AutoMapping()
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002A60 File Offset: 0x00000C60
		protected override void InitiatePoser()
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002A62 File Offset: 0x00000C62
		protected override void FixPoserTransforms()
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002A64 File Offset: 0x00000C64
		protected override void UpdatePoser()
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002A66 File Offset: 0x00000C66
		protected void StoreDefaultState()
		{
		}

		// Token: 0x04000300 RID: 768
		protected Transform[] children;

		// Token: 0x04000301 RID: 769
		private Transform _poseRoot;

		// Token: 0x04000302 RID: 770
		private Transform[] poseChildren;

		// Token: 0x04000303 RID: 771
		private Vector3[] defaultLocalPositions;

		// Token: 0x04000304 RID: 772
		private Quaternion[] defaultLocalRotations;
	}
}
