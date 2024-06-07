using System;
using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	public class EntityAggregator
	{
		// Token: 0x06000226 RID: 550 RVA: 0x00002D3B File Offset: 0x00000F3B
		public void OnBodyEnter(MarrowBody body)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002D3D File Offset: 0x00000F3D
		public void OnBodyExit(MarrowBody body)
		{
		}

		// Token: 0x04000152 RID: 338
		public MarrowQuery tags;

		// Token: 0x04000153 RID: 339
		public Action<MarrowBody> onBodyEnterAction;

		// Token: 0x04000154 RID: 340
		public Action<MarrowBody> onBodyExitAction;

		// Token: 0x04000155 RID: 341
		public Action<MarrowEntity> onEntityEnterAction;

		// Token: 0x04000156 RID: 342
		public Action<MarrowEntity> onEntityExitAction;

		// Token: 0x04000157 RID: 343
		private readonly Dictionary<MarrowEntity, int> _entityOverlapCounts;
	}
}
