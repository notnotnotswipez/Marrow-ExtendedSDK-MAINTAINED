using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000D3 RID: 211
	public class UniTaskQueue<T>
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00003C02 File Offset: 0x00001E02
		public void Add(UniTask<T> task)
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000072C4 File Offset: 0x000054C4
		public UniTask<T[]> WhenAll()
		{
			return default(UniTask<T[]>);
		}

		// Token: 0x040003D6 RID: 982
		private List<UniTask<T>> _taskQueue;
	}
}
