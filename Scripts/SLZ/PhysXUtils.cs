using System;
using UnityEngine;

namespace SLZ
{
	// Token: 0x0200000F RID: 15
	public static class PhysXUtils
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00005E04 File Offset: 0x00004004
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005E1C File Offset: 0x0000401C
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000027D5 File Offset: 0x000009D5
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000027D7 File Offset: 0x000009D7
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005E34 File Offset: 0x00004034
		public static Vector3 GetFromToVelocity(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005E4C File Offset: 0x0000404C
		public static Vector3 GetAngularDisplacement(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005E64 File Offset: 0x00004064
		public static Vector3 GetAngularVelocity(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000027D9 File Offset: 0x000009D9
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000027DB File Offset: 0x000009DB
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000027DD File Offset: 0x000009DD
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005E7C File Offset: 0x0000407C
		public static Vector3 GetLinearDisplacement(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005E94 File Offset: 0x00004094
		public static Vector3 GetLinearVelocity(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005EAC File Offset: 0x000040AC
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005EC4 File Offset: 0x000040C4
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005EDC File Offset: 0x000040DC
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
}
