using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000063 RID: 99
	public class BodyTilt : OffsetModifier
	{
		// Token: 0x060003FE RID: 1022 RVA: 0x00002B4A File Offset: 0x00000D4A
		protected override void Start()
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002B4C File Offset: 0x00000D4C
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x0400034C RID: 844
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		// Token: 0x0400034D RID: 845
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		// Token: 0x0400034E RID: 846
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		// Token: 0x0400034F RID: 847
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		// Token: 0x04000350 RID: 848
		private float tiltAngle;

		// Token: 0x04000351 RID: 849
		private Vector3 lastForward;
	}
}
