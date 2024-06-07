using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000E3 RID: 227
	public class MuscleCollisionBroadcasterSensor : MuscleCollisionBroadcaster
	{
		// Token: 0x06000879 RID: 2169 RVA: 0x00003EE3 File Offset: 0x000020E3
		private void Start()
		{
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00003EE5 File Offset: 0x000020E5
		public override void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00003EE7 File Offset: 0x000020E7
		private void OnCollisionStay(Collision collision)
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00003EE9 File Offset: 0x000020E9
		private void ProcessCollision(Collision c)
		{
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00003EEB File Offset: 0x000020EB
		public void ReadData(out Vector3 deltaPosition, out Vector3 impulse, out bool asleep)
		{
			deltaPosition = default(Vector3);
			impulse = default(Vector3);
			asleep = default(bool);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00003F02 File Offset: 0x00002102
		public void ReadData(out Vector3 deltaPosition, out Vector3 impulse, out bool asleep, out Vector3 groundVelocity, out float groundAngVel)
		{
			deltaPosition = default(Vector3);
			impulse = default(Vector3);
			asleep = default(bool);
			groundVelocity = default(Vector3);
			groundAngVel = 0f;
		}

		// Token: 0x04000553 RID: 1363
		public bool isGrounded;

		// Token: 0x04000554 RID: 1364
		public Vector3 groundNormal;

		// Token: 0x04000555 RID: 1365
		public Vector3 _totalImpulse;

		// Token: 0x04000556 RID: 1366
		public float totalMass;

		// Token: 0x04000557 RID: 1367
		public float additionalMass;

		// Token: 0x04000558 RID: 1368
		private Vector3 _deltaVel;

		// Token: 0x04000559 RID: 1369
		private Vector3 _groundVel;

		// Token: 0x0400055A RID: 1370
		private Vector3 _lastGroundVel;

		// Token: 0x0400055B RID: 1371
		private float _groundMultSum;

		// Token: 0x0400055C RID: 1372
		private float _groundAngVel;

		// Token: 0x0400055D RID: 1373
		private int _count;

		// Token: 0x0400055E RID: 1374
		private Rigidbody _rb;

		// Token: 0x0400055F RID: 1375
		private int collisionLayer;
	}
}
