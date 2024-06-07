using System;
using UnityEngine;

namespace SLZ.Marrow.Pool
{
	// Token: 0x020000F2 RID: 242
	public abstract class SpawnEvents : MonoBehaviour, IPoolable
	{
		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0000416B File Offset: 0x0000236B
		public ulong ID
		{
			get
			{
				return (ulong)0;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0000416F File Offset: 0x0000236F
		public bool IsDespawned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00004172 File Offset: 0x00002372
		protected virtual void Awake()
		{
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00004174 File Offset: 0x00002374
		protected virtual void Reset()
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00004176 File Offset: 0x00002376
		public void Despawn()
		{
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00004178 File Offset: 0x00002378
		public virtual void OnPoolInitialize()
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0000417A File Offset: 0x0000237A
		public virtual void OnPoolSpawn()
		{
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0000417C File Offset: 0x0000237C
		public virtual void OnPoolDeInitialize()
		{
		}

		// Token: 0x04000602 RID: 1538
		[SerializeField]
		protected Poolee _poolee;
	}
}
