using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000142 RID: 322
	public class RigidbodySettings : MonoBehaviour
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000477D File Offset: 0x0000297D
		private void Awake()
		{
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0000477F File Offset: 0x0000297F
		private void OnEnable()
		{
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00004781 File Offset: 0x00002981
		private void Start()
		{
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00004783 File Offset: 0x00002983
		public void SetCenter()
		{
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00004785 File Offset: 0x00002985
		public void IgnoreHierarchy()
		{
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00004787 File Offset: 0x00002987
		public void IgnoreColliders(bool ignore = true)
		{
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00004789 File Offset: 0x00002989
		public void SetVelocity(Vector3 velocity)
		{
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0000478B File Offset: 0x0000298B
		public void SetVelocity(float minSpeed, float maxSpeed)
		{
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0000478D File Offset: 0x0000298D
		public void SetAngularVelocity(Vector3 angularVelocity)
		{
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0000478F File Offset: 0x0000298F
		public void SetAngularVelocity(float minAngularSpeed, float maxAngularSpeed)
		{
		}

		// Token: 0x04000715 RID: 1813
		public bool disableITCalc;

		// Token: 0x04000716 RID: 1814
		public bool scaleMass;

		// Token: 0x04000717 RID: 1815
		public Transform comOverride;

		// Token: 0x04000718 RID: 1816
		public float maxAv;

		// Token: 0x04000719 RID: 1817
		public float iTensorMult;

		// Token: 0x0400071A RID: 1818
		private Rigidbody rb;

		// Token: 0x0400071B RID: 1819
		public bool ignoreHierarchy;

		// Token: 0x0400071C RID: 1820
		public bool drawCom;

		// Token: 0x0400071D RID: 1821
		public bool resetOnEnable;

		// Token: 0x0400071E RID: 1822
		public Collider[] localColliders;

		// Token: 0x0400071F RID: 1823
		public Collider[] collidersToIgnore;

		// Token: 0x04000720 RID: 1824
		private float _nativeMass;

		// Token: 0x04000721 RID: 1825
		private Vector3 _initialPos;

		// Token: 0x04000722 RID: 1826
		private Quaternion _initialRot;
	}
}
