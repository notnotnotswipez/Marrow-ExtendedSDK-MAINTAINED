using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x020000F6 RID: 246
	public static class MathUtils
	{
		// Token: 0x0600097A RID: 2426 RVA: 0x000041B8 File Offset: 0x000023B8
		public static void DecomposeSwingTwist(Quaternion q, Vector3 twistAxis, out Quaternion swing, out Quaternion twist)
		{
			swing = default(Quaternion);
			twist = default(Quaternion);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000041C8 File Offset: 0x000023C8
		public static void CalculateDelta(float pos, float rot, ref float lastPos, ref float lastRot, out float posDelta, out float rotDelta)
		{
			posDelta = 0f;
			rotDelta = 0f;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000076B4 File Offset: 0x000058B4
		public static Quaternion NormalizeSafe(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000041DA File Offset: 0x000023DA
		public static bool IsQuaternionNan(in Quaternion rotation)
		{
			return false;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000076CC File Offset: 0x000058CC
		public static Vector3 FastRotateTowards(in Vector3 lhsNorm, in Vector3 rhsNorm, float targetAngle)
		{
			return default(Vector3);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000076E4 File Offset: 0x000058E4
		public static Vector3 OrthoNormalVectorFast(in Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000076FC File Offset: 0x000058FC
		public static Quaternion LimitSwingTwistRotation(in Quaternion q, in Vector3 primaryAxis, in float swingLimit, in float twistLimit)
		{
			return default(Quaternion);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00007714 File Offset: 0x00005914
		public static Quaternion SoftLimitSwingTwistRotation(in Quaternion q, in Vector3 primaryAxis, in float swingSoftLimit, in float swingHardLimit, in float twistSoftLimit, in float twistHardLimit)
		{
			return default(Quaternion);
		}

		// Token: 0x0400060D RID: 1549
		public static readonly float Epsilon;

		// Token: 0x0400060E RID: 1550
		private const float k_FloatMin = 1E-10f;

		// Token: 0x0400060F RID: 1551
		public static float _sqrt_2;
	}
}
