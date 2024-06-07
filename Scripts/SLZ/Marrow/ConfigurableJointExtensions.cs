using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow
{
	// Token: 0x02000016 RID: 22
	public static class ConfigurableJointExtensions
	{
		// Token: 0x0600016F RID: 367 RVA: 0x000064E4 File Offset: 0x000046E4
		public static Quaternion GetJointSpace(this ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002B02 File Offset: 0x00000D02
		public static void SetTargetPositionLocal(this ConfigurableJoint joint, Vector3 targetLocalPosition, Quaternion targetLocalRotation, Quaternion startLocalRotation)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002B04 File Offset: 0x00000D04
		public static void SetTargetPositionLocal(this ConfigurableJoint joint, Vector3 targetLocalPosition, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002B06 File Offset: 0x00000D06
		public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation)
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002B08 File Offset: 0x00000D08
		public static void SetTargetRotationLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002B0A File Offset: 0x00000D0A
		public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002B0C File Offset: 0x00000D0C
		public static void SetTargetRotation(this ConfigurableJoint joint, Quaternion targetWorldRotation, Quaternion startWorldRotation, Quaternion worldToJointSpace)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002B0E File Offset: 0x00000D0E
		private static void SetTargetPositionInternal(ConfigurableJoint joint, Vector3 targetPosition, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002B10 File Offset: 0x00000D10
		private static void SetTargetRotationInternal(ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002B12 File Offset: 0x00000D12
		public static void SetTargetRotationAndAngVelocityLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, float deltaTime)
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002B14 File Offset: 0x00000D14
		public static void SetTargetRotationAndAngVelocityLocal(this ConfigurableJoint joint, Quaternion targetLocalRotation, Quaternion startLocalRotation, Quaternion worldToJointSpace, float deltaTime)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002B16 File Offset: 0x00000D16
		private static void SetTargetRotationAndAngVelocityInternal(ConfigurableJoint joint, Quaternion targetRotation, Quaternion startRotation, Quaternion worldToJointSpace, Space space, float deltaTime)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000064FC File Offset: 0x000046FC
		public static Vector3 CalculateAngVelocity(Quaternion startRotation, Quaternion endRotation, float deltaTime)
		{
			return default(Vector3);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002B18 File Offset: 0x00000D18
		public static void SetupAsCharacterJoint(this ConfigurableJoint joint)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00006514 File Offset: 0x00004714
		public static Vector3 GetAxisInWorld(this ConfigurableJoint joint)
		{
			return default(Vector3);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000652C File Offset: 0x0000472C
		public static Vector3 GetSecondaryAxisInWorld(this ConfigurableJoint joint)
		{
			return default(Vector3);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00006544 File Offset: 0x00004744
		public static Vector3 GetConnectedAnchorInWorld(this ConfigurableJoint joint)
		{
			return default(Vector3);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002B1A File Offset: 0x00000D1A
		[MethodImpl(256)]
		public static float GetTwistInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation)
		{
			return 0f;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002B21 File Offset: 0x00000D21
		[MethodImpl(256)]
		public static float GetTwistInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest)
		{
			return 0f;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002B28 File Offset: 0x00000D28
		private static float GetTwistInDegreesInternal(ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest)
		{
			return 0f;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002B2F File Offset: 0x00000D2F
		public static float GetTwistInLimitPercent(this ConfigurableJoint joint, Quaternion startLocalRotation)
		{
			return 0f;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002B36 File Offset: 0x00000D36
		public static float GetSwingInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, out float yDegrees, out float zDegrees)
		{
			yDegrees = 0f;
			zDegrees = 0f;
			return 0f;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002B4B File Offset: 0x00000D4B
		public static float GetSwingInDegrees(this ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest, out float yDegrees, out float zDegrees)
		{
			yDegrees = 0f;
			zDegrees = 0f;
			return 0f;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002B61 File Offset: 0x00000D61
		public static float GetSwingInLimitPercent(this ConfigurableJoint joint, Quaternion startLocalRotation, out float yPercent, out float zPercent)
		{
			yPercent = 0f;
			zPercent = 0f;
			return 0f;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002B76 File Offset: 0x00000D76
		private static float GetSwingCosineInternal(ConfigurableJoint joint, Quaternion startLocalRotation, Quaternion rotationToTest, out Vector2 direction)
		{
			direction = default(Vector2);
			return 0f;
		}
	}
}
