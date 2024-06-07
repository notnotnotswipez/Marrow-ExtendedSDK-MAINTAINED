using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200019E RID: 414
	[CreateAssetMenu(fileName = "Spawn Policy Data", menuName = "StressLevelZero/Spawn Policy Data")]
	public class SpawnPolicyData : ScriptableObject
	{
		// Token: 0x04000AB1 RID: 2737
		[Tooltip("Grouping pools by crate will apply policy rules per-crate")]
		public bool groupByCrate;

		// Token: 0x04000AB2 RID: 2738
		[Tooltip("Maximum size the pool will contain")]
		public int maxSize;

		// Token: 0x04000AB3 RID: 2739
		[Tooltip("Determines what happens when a pool reaches the max size")]
		public SpawnPolicyData.PolicyRule mode;

		// Token: 0x04000AB4 RID: 2740
		[Tooltip("Skips Enable/Disable phase of the poolee in cases where it is recycled on the same frame")]
		public bool canHotPool;

		// Token: 0x020002A5 RID: 677
		public enum PolicyRule
		{
			// Token: 0x04001092 RID: 4242
			GROW,
			// Token: 0x04001093 RID: 4243
			REUSEOLDEST,
			// Token: 0x04001094 RID: 4244
			REUSENEWEST,
			// Token: 0x04001095 RID: 4245
			REUSENONE
		}
	}
}
