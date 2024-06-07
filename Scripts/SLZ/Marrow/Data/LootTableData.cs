using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x02000192 RID: 402
	[CreateAssetMenu(fileName = "LootTable", menuName = "Variables/LootTable", order = 10)]
	[Serializable]
	public class LootTableData : ScriptableObject
	{
		// Token: 0x06000EC2 RID: 3778 RVA: 0x0000835C File Offset: 0x0000655C
		public Spawnable GetLootItem()
		{
			return default(Spawnable);
		}

		// Token: 0x04000A78 RID: 2680
		[SerializeField]
		public LootItem[] items;
	}
}
