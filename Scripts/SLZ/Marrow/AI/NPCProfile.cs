using System;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001BF RID: 447
	[CreateAssetMenu(fileName = "NPCProfile", menuName = "StressLevelZero / NPC_Profile", order = 1)]
	public class NPCProfile : ScriptableObject
	{
		// Token: 0x04000B92 RID: 2962
		public Spawnable spawnable;

		// Token: 0x04000B93 RID: 2963
		public BaseEnemyConfig baseConfig;
	}
}
