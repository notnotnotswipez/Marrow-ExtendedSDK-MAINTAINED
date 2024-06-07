using System;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000030 RID: 48
	public interface ISpawnListenable
	{
		// Token: 0x06000246 RID: 582
		void OnSpawn(GameObject go);

		// Token: 0x06000247 RID: 583
		void OnDespawn(GameObject go);
	}
}
