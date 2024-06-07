using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200018E RID: 398
	[CreateAssetMenu(fileName = "NewHandPoseData", menuName = "StressLevelZero/HandPoseData", order = 1)]
	public class HandPoseData : ScriptableObject
	{
		// Token: 0x04000A63 RID: 2659
		public Quaternion hand2;

		// Token: 0x04000A64 RID: 2660
		public Vector3 handleInHandPos;

		// Token: 0x04000A65 RID: 2661
		public Quaternion handleInHandRot;

		// Token: 0x04000A66 RID: 2662
		public Quaternion thumb1;

		// Token: 0x04000A67 RID: 2663
		public Vector3 thumb23;

		// Token: 0x04000A68 RID: 2664
		public Quaternion index1;

		// Token: 0x04000A69 RID: 2665
		public Vector3 index23;

		// Token: 0x04000A6A RID: 2666
		public Quaternion middle1;

		// Token: 0x04000A6B RID: 2667
		public Vector3 middle23;

		// Token: 0x04000A6C RID: 2668
		public Quaternion ring1;

		// Token: 0x04000A6D RID: 2669
		public Vector3 ring23;

		// Token: 0x04000A6E RID: 2670
		public Quaternion pinky1;

		// Token: 0x04000A6F RID: 2671
		public Vector3 pinky23;
	}
}
