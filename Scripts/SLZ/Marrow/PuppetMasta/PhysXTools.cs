using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000E4 RID: 228
	public static class PhysXTools
	{
		// Token: 0x06000880 RID: 2176 RVA: 0x00003F31 File Offset: 0x00002131
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00003F41 File Offset: 0x00002141
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation, Vector3 gravity, float drag, float angularDrag)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00003F51 File Offset: 0x00002151
		public static void Predict(ref Vector3 position, ref Quaternion rotation, ref Vector3 velocity, ref Vector3 angularVelocity, Vector3 gravity, float drag, float angularDrag)
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000074D4 File Offset: 0x000056D4
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000074EC File Offset: 0x000056EC
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00003F53 File Offset: 0x00002153
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00003F55 File Offset: 0x00002155
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00007504 File Offset: 0x00005704
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0000751C File Offset: 0x0000571C
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00003F57 File Offset: 0x00002157
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00003F59 File Offset: 0x00002159
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00003F5B File Offset: 0x0000215B
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00007534 File Offset: 0x00005734
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0000754C File Offset: 0x0000574C
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00007564 File Offset: 0x00005764
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0000757C File Offset: 0x0000577C
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
}
