using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200019F RID: 415
	[CreateAssetMenu(fileName = "VFX Spawn Policy Data", menuName = "StressLevelZero/VFX Spawn Policy Data")]
	public class VFXSpawnPolicyData : SpawnPolicyData
	{
		// Token: 0x04000AB5 RID: 2741
		[Tooltip("Time in seconds between each spawn setting 0 will disable this feature")]
		public float spawnFrequency;

		// Token: 0x04000AB6 RID: 2742
		[Tooltip("Allowable distance between each active spawn setting 0 will disable this feature")]
		public float spawnDistance;

		// Token: 0x04000AB7 RID: 2743
		[Tooltip("Proximity to consider as stack")]
		public float spawnStackDistance;

		// Token: 0x04000AB8 RID: 2744
		[Tooltip("Allowable spawns in a stack setting 0 will disable this feature")]
		public int spawnStackCount;
	}
}
