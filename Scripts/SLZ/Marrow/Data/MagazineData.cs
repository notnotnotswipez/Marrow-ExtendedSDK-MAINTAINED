using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x02000193 RID: 403
	[CreateAssetMenu(fileName = "New Magazine Value", menuName = "Variables/Magazine Item", order = 2)]
	public class MagazineData : ScriptableObject
	{
		// Token: 0x04000A79 RID: 2681
		public Spawnable spawnable;

		// Token: 0x04000A7A RID: 2682
		public string platform;

		// Token: 0x04000A7B RID: 2683
		public int rounds;
	}
}
