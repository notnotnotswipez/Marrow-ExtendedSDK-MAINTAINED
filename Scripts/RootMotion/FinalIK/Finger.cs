using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class Finger
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000022AB File Offset: 0x000004AB
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000022AE File Offset: 0x000004AE
		public bool initiated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000022B0 File Offset: 0x000004B0
		public Vector3 IKPosition
		{
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000336C File Offset: 0x0000156C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000022B2 File Offset: 0x000004B2
		public Quaternion IKRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000022B4 File Offset: 0x000004B4
		public bool IsValid(ref string errorMessage)
		{
			return false;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000022B7 File Offset: 0x000004B7
		public void Initiate(Transform hand, int index)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000022B9 File Offset: 0x000004B9
		public void FixTransforms()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000022BB File Offset: 0x000004BB
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000022BD File Offset: 0x000004BD
		public void Update(float masterWeight)
		{
		}

		// Token: 0x0400007C RID: 124
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x0400007D RID: 125
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x0400007E RID: 126
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public Finger.DOF rotationDOF;

		// Token: 0x0400007F RID: 127
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		// Token: 0x04000080 RID: 128
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		// Token: 0x04000081 RID: 129
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		// Token: 0x04000082 RID: 130
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		// Token: 0x04000083 RID: 131
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		// Token: 0x04000085 RID: 133
		private IKSolverLimb solver;

		// Token: 0x04000086 RID: 134
		private Quaternion bone3RelativeToTarget;

		// Token: 0x04000087 RID: 135
		private Vector3 bone3DefaultLocalPosition;

		// Token: 0x04000088 RID: 136
		private Quaternion bone3DefaultLocalRotation;

		// Token: 0x04000089 RID: 137
		private Vector3 bone1Axis;

		// Token: 0x0400008A RID: 138
		private Vector3 tipAxis;

		// Token: 0x0200007B RID: 123
		[Serializable]
		public enum DOF
		{
			// Token: 0x040003C6 RID: 966
			One,
			// Token: 0x040003C7 RID: 967
			Three
		}
	}
}
