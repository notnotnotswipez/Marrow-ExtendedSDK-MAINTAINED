using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200019D RID: 413
	[Serializable]
	public struct VFXSpawnable
	{
		// Token: 0x06000ED4 RID: 3796 RVA: 0x000050EE File Offset: 0x000032EE
		public bool IsValid()
		{
			return false;
		}

		// Token: 0x04000AAF RID: 2735
		[SerializeField]
		public VFXCrateReference crateRef;

		// Token: 0x04000AB0 RID: 2736
		[SerializeField]
		public VFXSpawnPolicyData policyData;
	}
}
