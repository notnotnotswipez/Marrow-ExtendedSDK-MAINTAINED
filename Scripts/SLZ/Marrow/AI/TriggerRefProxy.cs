using System;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001C5 RID: 453
	public class TriggerRefProxy : MonoBehaviour
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00005481 File Offset: 0x00003681
		public AIBrain aiManager
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00005484 File Offset: 0x00003684
		public void Start()
		{
		}

		// Token: 0x04000BDF RID: 3039
		private AIBrain _aiManager;

		// Token: 0x04000BE0 RID: 3040
		public TriggerRefProxy.TriggerType triggerType;

		// Token: 0x04000BE1 RID: 3041
		public TriggerRefProxy.NpcType npcType;

		// Token: 0x04000BE2 RID: 3042
		public int teamNumber;

		// Token: 0x04000BE3 RID: 3043
		public GameObject root;

		// Token: 0x04000BE4 RID: 3044
		public Rigidbody targetHead;

		// Token: 0x04000BE5 RID: 3045
		public Rigidbody lfHandRb;

		// Token: 0x04000BE6 RID: 3046
		public Rigidbody rtHandRb;

		// Token: 0x04000BE7 RID: 3047
		public Transform chestTran;

		// Token: 0x04000BE8 RID: 3048
		public Transform feetTran;

		// Token: 0x04000BE9 RID: 3049
		public Transform legacyProxy;

		// Token: 0x020002D1 RID: 721
		public enum TriggerType
		{
			// Token: 0x04001162 RID: 4450
			Player,
			// Token: 0x04001163 RID: 4451
			Proxy,
			// Token: 0x04001164 RID: 4452
			Npc
		}

		// Token: 0x020002D2 RID: 722
		[Flags]
		public enum NpcType
		{
			// Token: 0x04001166 RID: 4454
			FordHair = 1,
			// Token: 0x04001167 RID: 4455
			FordShortHair = 2,
			// Token: 0x04001168 RID: 4456
			EarlyExit = 4,
			// Token: 0x04001169 RID: 4457
			NullBody = 8,
			// Token: 0x0400116A RID: 4458
			Fordlet = 16,
			// Token: 0x0400116B RID: 4459
			Crablet = 32,
			// Token: 0x0400116C RID: 4460
			OmniProjector = 64,
			// Token: 0x0400116D RID: 4461
			OmniWrecker = 128,
			// Token: 0x0400116E RID: 4462
			OmniTurret = 256,
			// Token: 0x0400116F RID: 4463
			Turret = 512,
			// Token: 0x04001170 RID: 4464
			NullRat = 1024,
			// Token: 0x04001171 RID: 4465
			Voidman = 2048
		}
	}
}
