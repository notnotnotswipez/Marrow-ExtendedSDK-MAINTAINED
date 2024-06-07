using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000041 RID: 65
	public class CrateSpawnSequencer : ZoneLinkItem, ISpawnListenable
	{
		// Token: 0x060002C3 RID: 707 RVA: 0x00002EA1 File Offset: 0x000010A1
		protected void OnEnable()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002EA3 File Offset: 0x000010A3
		protected void OnDisable()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002EA5 File Offset: 0x000010A5
		private void OnDestroy()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002EA7 File Offset: 0x000010A7
		private void Start()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002EA9 File Offset: 0x000010A9
		protected void OnEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002EAB File Offset: 0x000010AB
		protected void OnExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002EAD File Offset: 0x000010AD
		public void StartSpawning()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002EAF File Offset: 0x000010AF
		public void StopSpawning()
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002EB1 File Offset: 0x000010B1
		public void OnSpawn(GameObject go)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002EB3 File Offset: 0x000010B3
		public void OnDespawn(GameObject go)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002EB5 File Offset: 0x000010B5
		private void DespawnOldest()
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00006634 File Offset: 0x00004834
		private UniTaskVoid SpawnLoop(CancellationToken ct)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x040001AB RID: 427
		[SerializeField]
		private float initialDelay;

		// Token: 0x040001AC RID: 428
		[SerializeField]
		private float spawnInterval;

		// Token: 0x040001AD RID: 429
		[Tooltip("Max amount that can be spawned")]
		[SerializeField]
		private float maxConcurrent;

		// Token: 0x040001AE RID: 430
		[Tooltip("Randomize which spawner is used")]
		[SerializeField]
		private bool randomizeSpawner;

		// Token: 0x040001AF RID: 431
		[SerializeField]
		private CrateSpawner[] crateSpawners;

		// Token: 0x040001B0 RID: 432
		private int _spawnerIndex;

		// Token: 0x040001B1 RID: 433
		private bool isActive;

		// Token: 0x040001B2 RID: 434
		private CancellationTokenSource _spawnCTS;

		// Token: 0x040001B3 RID: 435
		private Dictionary<CrateSpawner, RandomizeCrate> _crateRandLookup;

		// Token: 0x040001B4 RID: 436
		private HashSet<Poolee> spawnedObjs;

		// Token: 0x040001B5 RID: 437
		public List<Poolee> spawnedPoolees;

		// Token: 0x040001B6 RID: 438
		public bool despawnAndReuseOldest;

		// Token: 0x040001B7 RID: 439
		[Tooltip("How many items should get despawned each time limits are hit")]
		public int despawnCount;
	}
}
