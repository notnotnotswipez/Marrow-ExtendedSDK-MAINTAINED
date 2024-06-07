using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x02000199 RID: 409
	[Serializable]
	public class RigidbodyInfo
	{
		// Token: 0x06000ECA RID: 3786 RVA: 0x000050D6 File Offset: 0x000032D6
		public void CopyFrom(Rigidbody rb)
		{
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000050D8 File Offset: 0x000032D8
		public void CopyTo(Rigidbody rb)
		{
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000050DA File Offset: 0x000032DA
		public void Destroy(Rigidbody rb)
		{
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000050DC File Offset: 0x000032DC
		public Rigidbody Create(GameObject go)
		{
			return null;
		}

		// Token: 0x04000A9A RID: 2714
		[SerializeField]
		public float mass;

		// Token: 0x04000A9B RID: 2715
		[SerializeField]
		public float drag;

		// Token: 0x04000A9C RID: 2716
		[SerializeField]
		public float angularDrag;

		// Token: 0x04000A9D RID: 2717
		[SerializeField]
		public bool useGravity;

		// Token: 0x04000A9E RID: 2718
		[SerializeField]
		public bool isKinematic;

		// Token: 0x04000A9F RID: 2719
		[SerializeField]
		public bool detectCollisions;

		// Token: 0x04000AA0 RID: 2720
		[SerializeField]
		public RigidbodyInterpolation interpolate;

		// Token: 0x04000AA1 RID: 2721
		[SerializeField]
		public CollisionDetectionMode collisionDetection;

		// Token: 0x04000AA2 RID: 2722
		[SerializeField]
		public RigidbodyConstraints constraints;

		// Token: 0x04000AA3 RID: 2723
		[SerializeField]
		public Vector3 centerOfMass;

		// Token: 0x04000AA4 RID: 2724
		[SerializeField]
		public Vector3 inertiaTensor;

		// Token: 0x04000AA5 RID: 2725
		[SerializeField]
		public Quaternion inertiaTensorRotation;

		// Token: 0x04000AA6 RID: 2726
		[SerializeField]
		public Vector3 initalVelocity;

		// Token: 0x04000AA7 RID: 2727
		[SerializeField]
		public Vector3 initialAngularVelocity;
	}
}
