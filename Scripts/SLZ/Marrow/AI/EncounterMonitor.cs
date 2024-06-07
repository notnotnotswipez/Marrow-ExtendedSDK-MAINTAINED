using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001BD RID: 445
	[RequireComponent(typeof(Encounter))]
	public class EncounterMonitor : MonoBehaviour
	{
		// Token: 0x06000FD5 RID: 4053 RVA: 0x000053BB File Offset: 0x000035BB
		[ContextMenu("GetEncounterData")]
		public void GetEncounterData()
		{
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000053BD File Offset: 0x000035BD
		private void OnEnable()
		{
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x000053BF File Offset: 0x000035BF
		public void Start()
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x000053C1 File Offset: 0x000035C1
		public void OnSpawn(GameObject go, SpawnGroup group)
		{
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x000053C3 File Offset: 0x000035C3
		private void RegisterSpawnedBrain(AIBrain brain, SpawnGroup spawnGroup)
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x000053C5 File Offset: 0x000035C5
		private void OnDeath(AIBrain brain)
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000053C7 File Offset: 0x000035C7
		private void OnDespawn(GameObject go)
		{
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000053C9 File Offset: 0x000035C9
		private void OnResurrect(AIBrain brain)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000053CB File Offset: 0x000035CB
		private void OnCompleteGroup(SpawnGroup group)
		{
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000053CD File Offset: 0x000035CD
		private void OnGroupCleanup(SpawnGroup group)
		{
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000053CF File Offset: 0x000035CF
		private void OnReset()
		{
		}

		// Token: 0x04000B7E RID: 2942
		public Encounter encounter;

		// Token: 0x04000B7F RID: 2943
		public uint maxConcurrent;

		// Token: 0x04000B80 RID: 2944
		public uint aliveTotal;

		// Token: 0x04000B81 RID: 2945
		public uint deadTotal;

		// Token: 0x04000B82 RID: 2946
		public uint totalSpawned;

		// Token: 0x04000B83 RID: 2947
		public uint totalSpawnGoal;

		// Token: 0x04000B84 RID: 2948
		public uint enemiesRemaining;

		// Token: 0x04000B85 RID: 2949
		private Action<GameObject> _onCrateDespawned;

		// Token: 0x04000B86 RID: 2950
		private Action<AIBrain> _onDeath;

		// Token: 0x04000B87 RID: 2951
		private Action<AIBrain> _onResurrect;

		// Token: 0x04000B88 RID: 2952
		public Dictionary<AIBrain, NPC_Display_Data> brainLookup;

		// Token: 0x04000B89 RID: 2953
		public Dictionary<SpawnGroup, List<NPC_Display_Data>> groupLookup;

		// Token: 0x04000B8A RID: 2954
		public NPC_Display_Data selectedNPC;

		// Token: 0x04000B8B RID: 2955
		public Texture defaultIcon;

		// Token: 0x04000B8C RID: 2956
		public Texture deadIcon;

		// Token: 0x04000B8D RID: 2957
		public Texture despawnIcon;

		// Token: 0x04000B8E RID: 2958
		private string defaultIconPath;

		// Token: 0x04000B8F RID: 2959
		private string deadIconPath;

		// Token: 0x04000B90 RID: 2960
		private string despawnIconPath;
	}
}
