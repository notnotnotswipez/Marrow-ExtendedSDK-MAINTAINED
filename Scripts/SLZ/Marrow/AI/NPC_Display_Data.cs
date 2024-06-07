using System;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001BC RID: 444
	[Serializable]
	public class NPC_Display_Data
	{
		// Token: 0x04000B78 RID: 2936
		public AIBrain brain;

		// Token: 0x04000B79 RID: 2937
		public SpawnGroup spawnGroup;

		// Token: 0x04000B7A RID: 2938
		public BehaviourBaseNav baseNav;

		// Token: 0x04000B7B RID: 2939
		public PuppetMaster puppet;

		// Token: 0x04000B7C RID: 2940
		public Texture iconImage;

		// Token: 0x04000B7D RID: 2941
		public NPC_Display_Data.NPC_State npcState;

		// Token: 0x020002C8 RID: 712
		public enum NPC_State
		{
			// Token: 0x04001139 RID: 4409
			ALIVE,
			// Token: 0x0400113A RID: 4410
			DEAD,
			// Token: 0x0400113B RID: 4411
			DESPAWNED
		}
	}
}
