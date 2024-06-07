using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	// Token: 0x020000ED RID: 237
	public class AssetSpawner : MonoBehaviour
	{
		// Token: 0x06000937 RID: 2359 RVA: 0x0000410A File Offset: 0x0000230A
		private void Awake()
		{
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0000410C File Offset: 0x0000230C
		private void OnDestroy()
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0000410E File Offset: 0x0000230E
		private static void Instantiate()
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00004110 File Offset: 0x00002310
		public static ulong GetNewID()
		{
			return (ulong)0;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00004114 File Offset: 0x00002314
		public static void Register(Spawnable spawnable)
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000075DC File Offset: 0x000057DC
		public static UniTask RegisterAsync(Barcode barcode)
		{
			return default(UniTask);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000075F4 File Offset: 0x000057F4
		public static UniTask InstantiateForWarmupAsync(Spawnable spawnable)
		{
			return default(UniTask);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00004116 File Offset: 0x00002316
		public static void Spawn(Spawnable spawnable, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null, bool ignorePolicy = false, int? groupID = null, Action<GameObject> spawnCallback = null, Action<GameObject> despawnCallback = null)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0000760C File Offset: 0x0000580C
		public static UniTask<Poolee> SpawnAsync(Spawnable spawnable, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null, bool ignorePolicy = false, int? groupID = null, Action<GameObject> spawnCallback = null, Action<GameObject> despawnCallback = null)
		{
			return default(UniTask<Poolee>);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00004118 File Offset: 0x00002318
		public static void Clear(Poolee poolee)
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0000411A File Offset: 0x0000231A
		public static void Despawn(Poolee poolee, bool skipDisable = false)
		{
		}

		// Token: 0x040005E9 RID: 1513
		private static bool _hasInstance;

		// Token: 0x040005EA RID: 1514
		private static AssetSpawner _instance;

		// Token: 0x040005EB RID: 1515
		private Dictionary<Barcode, Pool> _barcodeToPool;

		// Token: 0x040005EC RID: 1516
		private Dictionary<Poolee, SpawnPolicy> _pooleeToPolicy;

		// Token: 0x040005ED RID: 1517
		private Dictionary<int, SpawnPolicy> _policySpawns;

		// Token: 0x040005EE RID: 1518
		private List<Pool> _poolList;

		// Token: 0x040005EF RID: 1519
		private static ulong _spawnCount;
	}
}
