using System;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	// Token: 0x020000F4 RID: 244
	public class VFXSpawnPolicy : SpawnPolicy
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x0000766C File Offset: 0x0000586C
		public override UniTask<Poolee> Spawn(Pool pool, SpawnPolicyData policyData, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null)
		{
			return default(UniTask<Poolee>);
		}

		// Token: 0x04000605 RID: 1541
		private double _timeOfLastSpawn;

		// Token: 0x04000606 RID: 1542
		private Poolee _lastSpawn;
	}
}
