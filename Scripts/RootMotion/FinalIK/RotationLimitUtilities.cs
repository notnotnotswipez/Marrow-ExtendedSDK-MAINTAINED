using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000035 RID: 53
	public static class RotationLimitUtilities
	{
		// Token: 0x060001BB RID: 443 RVA: 0x000034EC File Offset: 0x000016EC
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00003504 File Offset: 0x00001704
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000351C File Offset: 0x0000171C
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00003534 File Offset: 0x00001734
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000354C File Offset: 0x0000174C
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
}
