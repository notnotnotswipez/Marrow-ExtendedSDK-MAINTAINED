using System;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x0200005F RID: 95
	public interface ICrateReference
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003BA RID: 954
		// (set) Token: 0x060003BB RID: 955
		Barcode Barcode { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003BC RID: 956
		Crate Crate { get; }

		// Token: 0x060003BD RID: 957
		bool TryGetCrate(out Crate crate);
	}
}
