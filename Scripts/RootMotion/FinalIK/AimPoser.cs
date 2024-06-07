using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000061 RID: 97
	public class AimPoser : MonoBehaviour
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x00002B33 File Offset: 0x00000D33
		public AimPoser.Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002B36 File Offset: 0x00000D36
		public void SetPoseActive(AimPoser.Pose pose)
		{
		}

		// Token: 0x04000349 RID: 841
		public float angleBuffer;

		// Token: 0x0400034A RID: 842
		public AimPoser.Pose[] poses;

		// Token: 0x020000AC RID: 172
		[Serializable]
		public class Pose
		{
			// Token: 0x0600054B RID: 1355 RVA: 0x00002F31 File Offset: 0x00001131
			public bool IsInDirection(Vector3 d)
			{
				return false;
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x00002F34 File Offset: 0x00001134
			public void SetAngleBuffer(float value)
			{
			}

			// Token: 0x0400053F RID: 1343
			public bool visualize;

			// Token: 0x04000540 RID: 1344
			public string name;

			// Token: 0x04000541 RID: 1345
			public Vector3 direction;

			// Token: 0x04000542 RID: 1346
			public float yaw;

			// Token: 0x04000543 RID: 1347
			public float pitch;

			// Token: 0x04000544 RID: 1348
			private float angleBuffer;
		}
	}
}
