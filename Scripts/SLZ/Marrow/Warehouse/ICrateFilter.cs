using System;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x02000058 RID: 88
	public interface ICrateFilter<in T> where T : Crate
	{
		// Token: 0x06000388 RID: 904
		bool Filter(T crate);
	}
}
