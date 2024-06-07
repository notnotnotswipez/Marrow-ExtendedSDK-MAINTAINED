using System;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow.Combat
{
	// Token: 0x020001AC RID: 428
	[Serializable]
	public struct Attack
	{
		// Token: 0x04000ACD RID: 2765
		public float damage;

		// Token: 0x04000ACE RID: 2766
		public Vector3 normal;

		// Token: 0x04000ACF RID: 2767
		public Vector3 origin;

		// Token: 0x04000AD0 RID: 2768
		public Vector3 direction;

		// Token: 0x04000AD1 RID: 2769
		public bool backFacing;

		// Token: 0x04000AD2 RID: 2770
		public int OrderInPool;

		// Token: 0x04000AD3 RID: 2771
		public Collider collider;

		// Token: 0x04000AD4 RID: 2772
		public AttackType attackType;

		// Token: 0x04000AD5 RID: 2773
		public TriggerRefProxy proxy;
	}
}
