using System;

namespace SLZ.Marrow.Pool
{
	// Token: 0x020000EF RID: 239
	public interface IPoolable
	{
		// Token: 0x06000946 RID: 2374
		void OnPoolInitialize();

		// Token: 0x06000947 RID: 2375
		void OnPoolSpawn();

		// Token: 0x06000948 RID: 2376
		void OnPoolDeInitialize();
	}
}
