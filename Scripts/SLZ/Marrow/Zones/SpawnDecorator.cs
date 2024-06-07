using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000038 RID: 56
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnDecorator : MonoBehaviour, ISpawnListenable
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00002D7E File Offset: 0x00000F7E
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002D80 File Offset: 0x00000F80
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002D82 File Offset: 0x00000F82
		public virtual void OnSpawn(GameObject go)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002D84 File Offset: 0x00000F84
		public virtual void OnDespawn(GameObject go)
		{
		}

		// Token: 0x0400016D RID: 365
		[SerializeField]
		protected CrateSpawner _crateSpawner;
	}
}
