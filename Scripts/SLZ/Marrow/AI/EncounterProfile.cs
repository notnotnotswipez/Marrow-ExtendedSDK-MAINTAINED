using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001BE RID: 446
	[CreateAssetMenu(fileName = "EncounterProfile", menuName = "StressLevelZero / EncounterProfile", order = 1)]
	public class EncounterProfile : ScriptableObject
	{
		// Token: 0x04000B91 RID: 2961
		public List<NPCProfile> npcProfileList;
	}
}
