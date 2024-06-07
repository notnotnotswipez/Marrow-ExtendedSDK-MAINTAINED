using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000042 RID: 66
	public class RandomizeCrate : SpawnDecorator
	{
		// Token: 0x060002D0 RID: 720 RVA: 0x00002EBF File Offset: 0x000010BF
		private void Start()
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002EC1 File Offset: 0x000010C1
		public SpawnableCrateReference SelectRandomCrate()
		{
			return null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002EC4 File Offset: 0x000010C4
		public void SelectAndSpawnRandomCrate()
		{
		}

		// Token: 0x040001B8 RID: 440
		public SpawnableCrateReference[] crates;

		// Token: 0x040001B9 RID: 441
		[Tooltip("If this is part of a CrateSpawnSequencer set this to false")]
		public bool spawnOnStart;
	}
}
