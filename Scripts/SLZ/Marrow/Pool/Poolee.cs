using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	// Token: 0x020000F1 RID: 241
	[DefaultExecutionOrder(1000)]
	public class Poolee : MonoBehaviour
	{
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0000413C File Offset: 0x0000233C
		public static ComponentCache<Poolee> Cache
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0000413F File Offset: 0x0000233F
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x00004142 File Offset: 0x00002342
		public SpawnableCrate SpawnableCrate
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x00004146 File Offset: 0x00002346
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00004144 File Offset: 0x00002344
		public ulong ID
		{
			[CompilerGenerated]
			get
			{
				return (ulong)0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0000414A File Offset: 0x0000234A
		public bool IsInPool
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0000414D File Offset: 0x0000234D
		private void Awake()
		{
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0000414F File Offset: 0x0000234F
		private void OnEnable()
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00004151 File Offset: 0x00002351
		private void OnDestroy()
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00004153 File Offset: 0x00002353
		internal void OnInitialize()
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00004155 File Offset: 0x00002355
		internal void OnSpawnEvent()
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00004157 File Offset: 0x00002357
		internal void OnSpawn()
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00004159 File Offset: 0x00002359
		internal void OnDespawnEvent()
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0000415B File Offset: 0x0000235B
		internal void OnDeinitialize()
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0000415D File Offset: 0x0000235D
		public void Despawn()
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0000415F File Offset: 0x0000235F
		public void RegisterPoolable(IPoolable poolable)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00004161 File Offset: 0x00002361
		public void DeregisterPoolable(IPoolable poolable)
		{
		}

		// Token: 0x040005FA RID: 1530
		private static ComponentCache<Poolee> _cache;

		// Token: 0x040005FD RID: 1533
		private bool _isInPool;

		// Token: 0x040005FE RID: 1534
		private readonly List<IPoolable> _poolables;

		// Token: 0x040005FF RID: 1535
		public Action<GameObject> OnSpawnDelegate;

		// Token: 0x04000600 RID: 1536
		public Action<GameObject> OnDespawnDelegate;

		// Token: 0x04000601 RID: 1537
		private bool _hasBeenInitialized;
	}
}
