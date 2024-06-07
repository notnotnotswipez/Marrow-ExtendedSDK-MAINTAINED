using System;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x020000F7 RID: 247
	public class RigidbodyData
	{
		// Token: 0x06000983 RID: 2435 RVA: 0x000041DF File Offset: 0x000023DF
		public void Snapshot(Rigidbody rb)
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000041E1 File Offset: 0x000023E1
		public void Apply(Rigidbody rb)
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000041E3 File Offset: 0x000023E3
		public Rigidbody Create(GameObject go)
		{
			return null;
		}

		// Token: 0x04000610 RID: 1552
		private float _mass;

		// Token: 0x04000611 RID: 1553
		private float _drag;

		// Token: 0x04000612 RID: 1554
		private float _angularDrag;

		// Token: 0x04000613 RID: 1555
		private bool _useGravity;

		// Token: 0x04000614 RID: 1556
		private bool _isKinematic;

		// Token: 0x04000615 RID: 1557
		private RigidbodyInterpolation _interpolate;

		// Token: 0x04000616 RID: 1558
		private CollisionDetectionMode _collisionDetection;

		// Token: 0x04000617 RID: 1559
		private RigidbodyConstraints _constraints;

		// Token: 0x04000618 RID: 1560
		private Vector3 _centerOfMass;

		// Token: 0x04000619 RID: 1561
		private float _maxAngularVelocity;

		// Token: 0x0400061A RID: 1562
		private Vector3 _inertiaTensor;
	}
}
