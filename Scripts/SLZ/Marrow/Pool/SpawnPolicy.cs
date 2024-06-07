using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	// Token: 0x020000F3 RID: 243
	public class SpawnPolicy
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x0000763C File Offset: 0x0000583C
		public virtual UniTask<Poolee> Spawn(Pool pool, SpawnPolicyData policyData, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null)
		{
			return default(UniTask<Poolee>);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00007654 File Offset: 0x00005854
		protected virtual UniTask<Poolee> SpawnFromPool(Pool pool, Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null)
		{
			return default(UniTask<Poolee>);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00004186 File Offset: 0x00002386
		public void Clear(Poolee poolee)
		{
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00004188 File Offset: 0x00002388
		public virtual bool Despawn(Pool pool, Poolee poolee, bool skipDisable = false)
		{
			return false;
		}

		// Token: 0x04000603 RID: 1539
		protected readonly List<Poolee> _poolees;

		// Token: 0x04000604 RID: 1540
		protected int _requestedSpawns;
	}
}
