using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class BipedReferences
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002095 File Offset: 0x00000295
		public virtual bool isFilled
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002098 File Offset: 0x00000298
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return false;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000209B File Offset: 0x0000029B
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, BipedReferences.AutoDetectParams autoDetectParams)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000209D File Offset: 0x0000029D
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, BipedReferences.AutoDetectParams autoDetectParams)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000209F File Offset: 0x0000029F
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return false;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020A2 File Offset: 0x000002A2
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020A5 File Offset: 0x000002A5
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return false;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020A8 File Offset: 0x000002A8
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return false;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020AB File Offset: 0x000002AB
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, BipedReferences.AutoDetectParams autoDetectParams)
		{
			return false;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020AE File Offset: 0x000002AE
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020B0 File Offset: 0x000002B0
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B2 File Offset: 0x000002B2
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return false;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020B5 File Offset: 0x000002B5
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020B8 File Offset: 0x000002B8
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return false;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020BB File Offset: 0x000002BB
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020BE File Offset: 0x000002BE
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return false;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020C1 File Offset: 0x000002C1
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020C4 File Offset: 0x000002C4
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020C7 File Offset: 0x000002C7
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020CA File Offset: 0x000002CA
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return 0f;
		}

		// Token: 0x04000017 RID: 23
		public Transform root;

		// Token: 0x04000018 RID: 24
		public Transform pelvis;

		// Token: 0x04000019 RID: 25
		public Transform leftThigh;

		// Token: 0x0400001A RID: 26
		public Transform leftCalf;

		// Token: 0x0400001B RID: 27
		public Transform leftFoot;

		// Token: 0x0400001C RID: 28
		public Transform rightThigh;

		// Token: 0x0400001D RID: 29
		public Transform rightCalf;

		// Token: 0x0400001E RID: 30
		public Transform rightFoot;

		// Token: 0x0400001F RID: 31
		public Transform leftUpperArm;

		// Token: 0x04000020 RID: 32
		public Transform leftForearm;

		// Token: 0x04000021 RID: 33
		public Transform leftHand;

		// Token: 0x04000022 RID: 34
		public Transform rightUpperArm;

		// Token: 0x04000023 RID: 35
		public Transform rightForearm;

		// Token: 0x04000024 RID: 36
		public Transform rightHand;

		// Token: 0x04000025 RID: 37
		public Transform head;

		// Token: 0x04000026 RID: 38
		public Transform[] spine;

		// Token: 0x04000027 RID: 39
		public Transform[] eyes;

		// Token: 0x02000073 RID: 115
		public struct AutoDetectParams
		{

			// Token: 0x040003A2 RID: 930
			public bool legsParentInSpine;

			// Token: 0x040003A3 RID: 931
			public bool includeEyes;
		}
	}
}
