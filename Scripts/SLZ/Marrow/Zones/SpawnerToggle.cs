using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000044 RID: 68
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnerToggle : SpawnDecorator
	{
		// Token: 0x060002DD RID: 733 RVA: 0x00002EE5 File Offset: 0x000010E5
		private void Awake()
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002EE7 File Offset: 0x000010E7
		private bool ShouldSpawn()
		{
			return false;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002EEA File Offset: 0x000010EA
		public void SpawnerEnabled(bool b)
		{
		}

		// Token: 0x040001C1 RID: 449
		[HideInInspector]
		public bool shouldSpawn;
	}
}
