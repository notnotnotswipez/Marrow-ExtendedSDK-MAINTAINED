using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public struct BipedRagdollReferences
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002218 File Offset: 0x00000418
		public bool IsValid(ref string msg)
		{
			return false;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000221B File Offset: 0x0000041B
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return false;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000221E File Offset: 0x0000041E
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		// Token: 0x04000053 RID: 83
		public Transform root;

		// Token: 0x04000054 RID: 84
		public Transform hips;

		// Token: 0x04000055 RID: 85
		public Transform spine;

		// Token: 0x04000056 RID: 86
		public Transform chest;

		// Token: 0x04000057 RID: 87
		public Transform head;

		// Token: 0x04000058 RID: 88
		public Transform leftUpperLeg;

		// Token: 0x04000059 RID: 89
		public Transform leftLowerLeg;

		// Token: 0x0400005A RID: 90
		public Transform leftFoot;

		// Token: 0x0400005B RID: 91
		public Transform rightUpperLeg;

		// Token: 0x0400005C RID: 92
		public Transform rightLowerLeg;

		// Token: 0x0400005D RID: 93
		public Transform rightFoot;

		// Token: 0x0400005E RID: 94
		public Transform leftUpperArm;

		// Token: 0x0400005F RID: 95
		public Transform leftLowerArm;

		// Token: 0x04000060 RID: 96
		public Transform leftHand;

		// Token: 0x04000061 RID: 97
		public Transform rightUpperArm;

		// Token: 0x04000062 RID: 98
		public Transform rightLowerArm;

		// Token: 0x04000063 RID: 99
		public Transform rightHand;
	}
}
