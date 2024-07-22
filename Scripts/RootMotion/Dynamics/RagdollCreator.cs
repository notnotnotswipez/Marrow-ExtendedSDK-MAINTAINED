using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	// Token: 0x02000015 RID: 21
	public abstract class RagdollCreator : MonoBehaviour
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00002221 File Offset: 0x00000421
		public static void ClearAll(Transform root)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002223 File Offset: 0x00000423
		protected static void ClearTransform(Transform transform)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002225 File Offset: 0x00000425
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, RagdollCreator.ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002227 File Offset: 0x00000427
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, RagdollCreator.ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002229 File Offset: 0x00000429
		protected static float GetScaleF(Transform t)
		{
			return 0f;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000032C4 File Offset: 0x000014C4
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002230 File Offset: 0x00000430
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000032DC File Offset: 0x000014DC
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000032F4 File Offset: 0x000014F4
		protected static Vector3 DirectionToVector3(RagdollCreator.Direction dir)
		{
			return default(Vector3);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002232 File Offset: 0x00000432
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return 0;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000330C File Offset: 0x0000150C
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002235 File Offset: 0x00000435
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002238 File Offset: 0x00000438
		protected static void CreateJoint(RagdollCreator.CreateJointParams p)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003324 File Offset: 0x00001524
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		// Token: 0x02000076 RID: 118
		[Serializable]
		public enum ColliderType
		{
			// Token: 0x040003B3 RID: 947
			Box,
			// Token: 0x040003B4 RID: 948
			Capsule
		}

		// Token: 0x02000077 RID: 119
		[Serializable]
		public enum JointType
		{
			// Token: 0x040003B6 RID: 950
			Configurable,
			// Token: 0x040003B7 RID: 951
			Character
		}

		// Token: 0x02000078 RID: 120
		[Serializable]
		public enum Direction
		{
			// Token: 0x040003B9 RID: 953
			X,
			// Token: 0x040003BA RID: 954
			Y,
			// Token: 0x040003BB RID: 955
			Z
		}

		// Token: 0x02000079 RID: 121
		public struct CreateJointParams
		{

			// Token: 0x040003BC RID: 956
			public Rigidbody rigidbody;

			// Token: 0x040003BD RID: 957
			public Rigidbody connectedBody;

			// Token: 0x040003BE RID: 958
			public Transform child;

			// Token: 0x040003BF RID: 959
			public Vector3 worldSwingAxis;

			// Token: 0x040003C0 RID: 960
			public RagdollCreator.CreateJointParams.Limits limits;

			// Token: 0x040003C1 RID: 961
			public RagdollCreator.JointType type;

			// Token: 0x020000BE RID: 190
			public struct Limits
			{

				// Token: 0x040005A2 RID: 1442
				public float minSwing;

				// Token: 0x040005A3 RID: 1443
				public float maxSwing;

				// Token: 0x040005A4 RID: 1444
				public float swing2;

				// Token: 0x040005A5 RID: 1445
				public float twist;
			}
		}
	}
}
