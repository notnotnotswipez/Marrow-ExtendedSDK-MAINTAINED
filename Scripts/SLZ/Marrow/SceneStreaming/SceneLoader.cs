using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Zones;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000CD RID: 205
	public class SceneLoader
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x00003BA6 File Offset: 0x00001DA6
		public void Add(SceneChunk sceneChunk)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00007174 File Offset: 0x00005374
		public UniTask LoadAsync()
		{
			return default(UniTask);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0000718C File Offset: 0x0000538C
		private UniTask LoadChunkBatch(ChunkBatch chunkBatch)
		{
			return default(UniTask);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00003BA8 File Offset: 0x00001DA8
		private void Solve(ChunkBatch cb)
		{
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000071A4 File Offset: 0x000053A4
		private UniTask UnloadScenes(ChunkBatch cb)
		{
			return default(UniTask);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000071BC File Offset: 0x000053BC
		private UniTask LoadScenes(ChunkBatch cb)
		{
			return default(UniTask);
		}

		// Token: 0x040003AD RID: 941
		private bool _isLoading;

		// Token: 0x040003AE RID: 942
		private SceneLoadQueue _sceneQueue;

		// Token: 0x040003AF RID: 943
		private List<SceneChunk> _activeChunks;

		// Token: 0x040003B0 RID: 944
		private List<SceneChunk> _chunksToLoad;

		// Token: 0x040003B1 RID: 945
		private List<SceneChunk> _chunksToUnload;

		// Token: 0x040003B2 RID: 946
		private HashSet<string> _wasLoadedOnce;

		// Token: 0x040003B3 RID: 947
		private Queue<ChunkBatch> _chunkQueue;

		// Token: 0x040003B4 RID: 948
		private ChunkBatch _nextChunkBatch;
	}
}
