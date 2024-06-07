using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200019C RID: 412
	[Serializable]
	public struct Spawnable
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x000050EB File Offset: 0x000032EB
		public bool IsValid()
		{
			return false;
		}

		// Token: 0x04000AAD RID: 2733
		[SerializeField]
		public SpawnableCrateReference crateRef;

		// Token: 0x04000AAE RID: 2734
		[SerializeField]
		public SpawnPolicyData policyData;
	}
}
