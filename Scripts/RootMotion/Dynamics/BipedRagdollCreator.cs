using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	// Token: 0x02000013 RID: 19
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Biped Ragdoll Creator")]
	public class BipedRagdollCreator : RagdollCreator
	{
		// Token: 0x06000070 RID: 112 RVA: 0x000021F7 File Offset: 0x000003F7
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000021F9 File Offset: 0x000003F9
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000021FB File Offset: 0x000003FB
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003264 File Offset: 0x00001464
		public static BipedRagdollCreator.Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(BipedRagdollCreator.Options);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000021FD File Offset: 0x000003FD
		public static void Create(BipedRagdollReferences r, BipedRagdollCreator.Options options)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000021FF File Offset: 0x000003FF
		private static void CreateColliders(BipedRagdollReferences r, BipedRagdollCreator.Options options)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002201 File Offset: 0x00000401
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, BipedRagdollCreator.Options options)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002203 File Offset: 0x00000403
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, BipedRagdollCreator.Options options)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000327C File Offset: 0x0000147C
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002205 File Offset: 0x00000405
		private static void MassDistribution(BipedRagdollReferences r, BipedRagdollCreator.Options o)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002207 File Offset: 0x00000407
		private static void CreateJoints(BipedRagdollReferences r, BipedRagdollCreator.Options o)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002209 File Offset: 0x00000409
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, RagdollCreator.JointType jointType, RagdollCreator.CreateJointParams.Limits limits1, RagdollCreator.CreateJointParams.Limits limits2, RagdollCreator.CreateJointParams.Limits limits3)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000220B File Offset: 0x0000040B
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000220D File Offset: 0x0000040D
		public static bool IsClear(BipedRagdollReferences r)
		{
			return false;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003294 File Offset: 0x00001494
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000032AC File Offset: 0x000014AC
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		// Token: 0x04000050 RID: 80
		public bool canBuild;

		// Token: 0x04000051 RID: 81
		public BipedRagdollReferences references;

		// Token: 0x04000052 RID: 82
		public BipedRagdollCreator.Options options;

		// Token: 0x02000075 RID: 117
		[Serializable]
		public struct Options
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x00003A74 File Offset: 0x00001C74
			public static BipedRagdollCreator.Options Default
			{
				get
				{
					return default(BipedRagdollCreator.Options);
				}
			}

			// Token: 0x040003A4 RID: 932
			public float weight;

			// Token: 0x040003A5 RID: 933
			[Header("Optional Bones")]
			public bool spine;

			// Token: 0x040003A6 RID: 934
			public bool chest;

			// Token: 0x040003A7 RID: 935
			public bool hands;

			// Token: 0x040003A8 RID: 936
			public bool feet;

			// Token: 0x040003A9 RID: 937
			[Header("Joints")]
			public RagdollCreator.JointType joints;

			// Token: 0x040003AA RID: 938
			public float jointRange;

			// Token: 0x040003AB RID: 939
			[Header("Colliders")]
			public float colliderLengthOverlap;

			// Token: 0x040003AC RID: 940
			public RagdollCreator.ColliderType torsoColliders;

			// Token: 0x040003AD RID: 941
			public RagdollCreator.ColliderType headCollider;

			// Token: 0x040003AE RID: 942
			public RagdollCreator.ColliderType armColliders;

			// Token: 0x040003AF RID: 943
			public RagdollCreator.ColliderType handColliders;

			// Token: 0x040003B0 RID: 944
			public RagdollCreator.ColliderType legColliders;

			// Token: 0x040003B1 RID: 945
			public RagdollCreator.ColliderType footColliders;
		}
	}
}
