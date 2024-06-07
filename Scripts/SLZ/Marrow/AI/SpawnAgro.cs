using System;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001C2 RID: 450
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnAgro : ZoneLinkItem, ISpawnListenable
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x00005407 File Offset: 0x00003607
		public void OnEnable()
		{
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00005409 File Offset: 0x00003609
		public void OnDisable()
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0000540B File Offset: 0x0000360B
		public void OnDespawn(GameObject go)
		{
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0000540D File Offset: 0x0000360D
		public void OnSpawn(GameObject go)
		{
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0000540F File Offset: 0x0000360F
		public void OnDeath(AIBrain brain)
		{
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00005411 File Offset: 0x00003611
		public void PostReactivate(BehaviourBaseNav baseNav)
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00005415 File Offset: 0x00003615
		public void MentalOnEnter(MarrowEntity entity)
		{
		}

		// Token: 0x04000B9F RID: 2975
		public CrateSpawner _crateSpawner;

		// Token: 0x04000BA0 RID: 2976
		private AIBrain brain;

		// Token: 0x04000BA1 RID: 2977
		private MarrowEntity activatorEntity;

		// Token: 0x04000BA2 RID: 2978
		[Tooltip("Agro mental state: agro on player proxy, Investigate mental state: increase bubble and move to player position")]
		public SpawnAgro.MentalMode mentalMode;

		// Token: 0x04000BA3 RID: 2979
		[Tooltip("Duration in seconds npc spends investigating player position")]
		public float investigateTimeout;

		// Token: 0x020002C9 RID: 713
		public enum MentalMode
		{
			// Token: 0x0400113D RID: 4413
			INVESTIGATE,
			// Token: 0x0400113E RID: 4414
			AGRO,
			// Token: 0x0400113F RID: 4415
			NONE
		}
	}
}
