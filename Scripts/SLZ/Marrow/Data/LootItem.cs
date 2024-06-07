using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x02000191 RID: 401
	[Serializable]
	public struct LootItem
	{
		// Token: 0x04000A76 RID: 2678
		[Range(0f, 100f)]
		public float percentage;

		// Token: 0x04000A77 RID: 2679
		public Spawnable spawnable;
	}
}
