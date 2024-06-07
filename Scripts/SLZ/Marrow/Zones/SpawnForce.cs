using System;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000045 RID: 69
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnForce : SpawnDecorator
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x00002EF4 File Offset: 0x000010F4
		public override void OnSpawn(GameObject go)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00006664 File Offset: 0x00004864
		private UniTaskVoid WaitForHibernation()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002EF6 File Offset: 0x000010F6
		[ContextMenu("ApplyForce")]
		public void ApplyForce()
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002EF8 File Offset: 0x000010F8
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x040001C2 RID: 450
		[Tooltip("If true force will be applied once awakened from hibernation, or use ApplyForce() on a trigger to explicitly add forces anytime after entity is awakened")]
		public bool applyForceOnSpawn;

		// Token: 0x040001C3 RID: 451
		public Vector3 spawnVelocity;

		// Token: 0x040001C4 RID: 452
		public Vector3 spawnAngularVelocity;

		// Token: 0x040001C5 RID: 453
		public float minSpawnAngularVelocity;

		// Token: 0x040001C6 RID: 454
		public float maxSpawnAngularVelocity;

		// Token: 0x040001C7 RID: 455
		public float additionalDelay;

		// Token: 0x040001C8 RID: 456
		private bool isReady;

		// Token: 0x040001C9 RID: 457
		public bool drawVelocity;

		// Token: 0x040001CA RID: 458
		private MarrowEntity entity;
	}
}
