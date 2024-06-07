using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x020000F8 RID: 248
	public class ComponentCache<T> where T : MonoBehaviour
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x0000772C File Offset: 0x0000592C
		public T Get(GameObject go)
		{
			return default(T);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000041EE File Offset: 0x000023EE
		public bool TryGet(GameObject go, out T component)
		{
			component = default(T);
			return false;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000041F8 File Offset: 0x000023F8
		public void Remove(GameObject go, T component)
		{
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000041FA File Offset: 0x000023FA
		public void Add(GameObject go, T component)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000041FC File Offset: 0x000023FC
		public bool IsEmpty()
		{
			return false;
		}

		// Token: 0x0400061B RID: 1563
		private readonly Dictionary<GameObject, List<T>> _cache;
	}
}
