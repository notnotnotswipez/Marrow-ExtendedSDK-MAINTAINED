using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000C6 RID: 198
	public class ChunkLoader
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00003B0F File Offset: 0x00001D0F
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00003B12 File Offset: 0x00001D12
		public List<ChunkTrigger> Triggers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00003B14 File Offset: 0x00001D14
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00003B17 File Offset: 0x00001D17
		public List<ChunkTracker> Trackers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00003B21 File Offset: 0x00001D21
		public void SetOccupiedChunk(Chunk chunk)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00003B23 File Offset: 0x00001D23
		public void RemoveOccupiedChunk(Chunk chunk)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00003B25 File Offset: 0x00001D25
		public void RegisterTrigger(ChunkTrigger trigger)
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00003B27 File Offset: 0x00001D27
		public void UnregisterTrigger(ChunkTrigger trigger)
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00003B29 File Offset: 0x00001D29
		public void RegisterTracker(ChunkTracker tracker)
		{
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00003B2B File Offset: 0x00001D2B
		public void UnregisterTracker(ChunkTracker tracker)
		{
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00003B2D File Offset: 0x00001D2D
		private void SolveChunks(Chunk chunk)
		{
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000070E4 File Offset: 0x000052E4
		public UniTask SetActive(Chunk chunk)
		{
			return default(UniTask);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000070FC File Offset: 0x000052FC
		private UniTask Load(Chunk chunk)
		{
			return default(UniTask);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00007114 File Offset: 0x00005314
		private UniTask UnloadChunks()
		{
			return default(UniTask);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0000712C File Offset: 0x0000532C
		private UniTask LoadChunks()
		{
			return default(UniTask);
		}

		// Token: 0x0400038D RID: 909
		private SceneLoadQueue _sceneQueue;

		// Token: 0x0400038E RID: 910
		private List<Chunk> _activeChunks;

		// Token: 0x0400038F RID: 911
		private List<Chunk> _chunksToLoad;

		// Token: 0x04000390 RID: 912
		private List<Chunk> _chunksToUnload;

		// Token: 0x04000391 RID: 913
		private List<Chunk> _occupiedChunks;

		// Token: 0x04000392 RID: 914
		private HashSet<string> _wasLoadedOnce;

		// Token: 0x04000393 RID: 915
		private static Dictionary<string, List<ChunkTrigger>> _chunkToTrigger;

		// Token: 0x04000396 RID: 918
		private Chunk _bufferedChunk;

		// Token: 0x04000397 RID: 919
		private bool _isLoading;
	}
}
