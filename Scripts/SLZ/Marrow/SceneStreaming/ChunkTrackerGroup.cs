using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000C8 RID: 200
	public class ChunkTrackerGroup : MonoBehaviour
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00003B47 File Offset: 0x00001D47
		public void Add(ChunkTracker tracker)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00003B49 File Offset: 0x00001D49
		public void Remove(ChunkTracker tracker)
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00003B4B File Offset: 0x00001D4B
		public void Freeze(ChunkTracker tracker)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00003B4D File Offset: 0x00001D4D
		public void Unfreeze(ChunkTracker tracker)
		{
		}

		// Token: 0x0400039B RID: 923
		private List<ChunkTracker> _trackers;

		// Token: 0x0400039C RID: 924
		public HashSet<ChunkTracker> _frozenTrackers;
	}
}
