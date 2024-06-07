using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UltEvents;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001C4 RID: 452
	[Serializable]
	public class SpawnGroup : ISpawnListenable
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x00005440 File Offset: 0x00003640
		public int DeadCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00005443 File Offset: 0x00003643
		public int SpawnCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00005446 File Offset: 0x00003646
		public void GetAISettings()
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00005448 File Offset: 0x00003648
		public void GetCrateRandomizers()
		{
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0000544A File Offset: 0x0000364A
		public void KillAll()
		{
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0000544C File Offset: 0x0000364C
		public void MentalAllGroup(TriggerRefProxy proxy)
		{
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0000544E File Offset: 0x0000364E
		public void Setup()
		{
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00005450 File Offset: 0x00003650
		public void ResetVariables()
		{
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00005452 File Offset: 0x00003652
		public void Cleanup()
		{
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00005454 File Offset: 0x00003654
		private void HandleBrainRegistration(AIBrain brain, bool val)
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00005456 File Offset: 0x00003656
		public void OnSpawn(GameObject go)
		{
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00005458 File Offset: 0x00003658
		private void PostReactivate(BehaviourBaseNav baseNav)
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0000545A File Offset: 0x0000365A
		public void OnDespawn(GameObject gameObject)
		{
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0000545C File Offset: 0x0000365C
		private void OnResurrect(AIBrain aiBrain)
		{
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0000545E File Offset: 0x0000365E
		private void OnDeath(AIBrain aiBrain)
		{
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00005460 File Offset: 0x00003660
		private void AddEncounter(AIBrain aiBrain)
		{
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00005462 File Offset: 0x00003662
		private void RemoveEncounter(AIBrain aiBrain)
		{
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00005464 File Offset: 0x00003664
		public bool IsAllDead()
		{
			return false;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00005467 File Offset: 0x00003667
		public bool IsUnderTotalSpawned()
		{
			return false;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0000546A File Offset: 0x0000366A
		public bool IsUnderMaxAlive()
		{
			return false;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0000546D File Offset: 0x0000366D
		public bool IsOverMaxDead()
		{
			return false;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00005470 File Offset: 0x00003670
		public bool IsOverMaxAlive()
		{
			return false;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000085E4 File Offset: 0x000067E4
		public UniTask SpawnAsync()
		{
			return default(UniTask);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000085FC File Offset: 0x000067FC
		public UniTask SpawnProfileAsync()
		{
			return default(UniTask);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00005473 File Offset: 0x00003673
		public void KillAlive()
		{
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00005475 File Offset: 0x00003675
		public void Despawn()
		{
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00008614 File Offset: 0x00006814
		public UniTask DespawnBrain(AIBrain brain)
		{
			return default(UniTask);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0000862C File Offset: 0x0000682C
		public UniTask WaitAndDespawnAllDead()
		{
			return default(UniTask);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00008644 File Offset: 0x00006844
		public UniTask DespawnAllBrains(bool useGroupDelay)
		{
			return default(UniTask);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00005477 File Offset: 0x00003677
		public void CompleteGroup()
		{
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0000865C File Offset: 0x0000685C
		public UniTask DespawnToMaxDeadCount()
		{
			return default(UniTask);
		}

		// Token: 0x04000BBE RID: 3006
		[HideInInspector]
		public EncounterProfile encounterProfile;

		// Token: 0x04000BBF RID: 3007
		[FormerlySerializedAs("concurrent")]
		[Tooltip("Maximum alive AI active at a time for this group before spawn")]
		public uint maxAlive;

		// Token: 0x04000BC0 RID: 3008
		[Tooltip("Maximum dead AI active at a time for this group before despawn")]
		public uint maxDead;

		// Token: 0x04000BC1 RID: 3009
		[Tooltip("Total AI that will be spawned for this group, locked by encounter profile")]
		[FormerlySerializedAs("maxSpawn")]
		public uint totalSpawn;

		// Token: 0x04000BC2 RID: 3010
		[Tooltip("Initial delay for the group.")]
		public float initialGroupDelay;

		// Token: 0x04000BC3 RID: 3011
		[Tooltip("Time between each spawn")]
		public float spawnInterval;

		// Token: 0x04000BC4 RID: 3012
		[Tooltip("Delay in seconds after death before despawn")]
		public float despawnInterval;

		// Token: 0x04000BC5 RID: 3013
		[Tooltip("If parallel spawn order, ensure spawners are unique to each spawn group")]
		public CrateSpawner[] spawners;

		// Token: 0x04000BC6 RID: 3014
		private SpawnAISettings[] aiSettings;

		// Token: 0x04000BC7 RID: 3015
		[HideInInspector]
		public List<SpawnerToggle> spawnerToggles;

		// Token: 0x04000BC8 RID: 3016
		public bool hostileGroup;

		// Token: 0x04000BC9 RID: 3017
		private int _deadCount;

		// Token: 0x04000BCA RID: 3018
		private int _spawnCount;

		// Token: 0x04000BCB RID: 3019
		private HashSet<AIBrain> _aliveBrains;

		// Token: 0x04000BCC RID: 3020
		private HashSet<AIBrain> _deadBrains;

		// Token: 0x04000BCD RID: 3021
		private HashSet<AIBrain> _spawnedBrains;

		// Token: 0x04000BCE RID: 3022
		private HashSet<AIBrain> _ignoredBrains;

		// Token: 0x04000BCF RID: 3023
		private int _spawnerIndex;

		// Token: 0x04000BD0 RID: 3024
		private Action<GameObject> _onCrateDespawned;

		// Token: 0x04000BD1 RID: 3025
		private Action<AIBrain> _onDeath;

		// Token: 0x04000BD2 RID: 3026
		private Action<AIBrain> _onResurrect;

		// Token: 0x04000BD3 RID: 3027
		public Action<GameObject, SpawnGroup> OnGroupSpawned;

		// Token: 0x04000BD4 RID: 3028
		public Action<SpawnGroup> OnGroupComplete;

		// Token: 0x04000BD5 RID: 3029
		public Action<SpawnGroup> OnCleanup;

		// Token: 0x04000BD6 RID: 3030
		[HideInInspector]
		public bool isComplete;

		// Token: 0x04000BD7 RID: 3031
		[Tooltip("None:Mental state will not change when spawned, Agro: agro on player proxy, Investigate: increase bubble and move to player position")]
		public SpawnGroup.MentalMode mentalMode;

		// Token: 0x04000BD8 RID: 3032
		[Tooltip("Duration in seconds npc spends investigating player position")]
		public float investigateTimeout;

		// Token: 0x04000BD9 RID: 3033
		public bool useSpawnerToggle;

		// Token: 0x04000BDA RID: 3034
		private Dictionary<CrateSpawner, RandomizeCrate> _crateRandLookup;

		// Token: 0x04000BDB RID: 3035
		private TriggerRefProxy playerProxy;

		// Token: 0x04000BDC RID: 3036
		public UltEvent onComplete;

		// Token: 0x04000BDD RID: 3037
		public UltEvent<AIBrain> OnDeathEvent;

		// Token: 0x04000BDE RID: 3038
		private bool isSetup;

		// Token: 0x020002CA RID: 714
		public enum MentalMode
		{
			// Token: 0x04001141 RID: 4417
			NONE,
			// Token: 0x04001142 RID: 4418
			INVESTIGATE,
			// Token: 0x04001143 RID: 4419
			AGRO
		}
	}
}
