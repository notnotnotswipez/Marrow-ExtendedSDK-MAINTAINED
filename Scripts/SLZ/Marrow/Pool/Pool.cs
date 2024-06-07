using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	// Token: 0x020000F0 RID: 240
	public class Pool
	{
		// Token: 0x06000949 RID: 2377 RVA: 0x00004130 File Offset: 0x00002330
		public Pool(SpawnableCrate sc, Transform rootTransform = null)
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00007624 File Offset: 0x00005824
		internal UniTask<Poolee> Spawn(Vector3 position = default(Vector3), Quaternion rotation = default(Quaternion), Vector3? scale = null, bool forceInstantiation = false)
		{
			return default(UniTask<Poolee>);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00004138 File Offset: 0x00002338
		public void Clear(Poolee poolee)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0000413A File Offset: 0x0000233A
		public void Despawn(Poolee poolee, bool skipDisable = false)
		{
		}

		// Token: 0x040005F3 RID: 1523
		private readonly SpawnableCrate _crate;

		// Token: 0x040005F4 RID: 1524
		private GameObject _templateObject;

		// Token: 0x040005F5 RID: 1525
		private readonly Transform _parentTransform;

		// Token: 0x040005F6 RID: 1526
		private string _prefabName;

		// Token: 0x040005F7 RID: 1527
		private readonly List<Poolee> _objects;

		// Token: 0x040005F8 RID: 1528
		private readonly List<Poolee> _despawned;

		// Token: 0x040005F9 RID: 1529
		private readonly List<Poolee> _spawned;
	}
}
