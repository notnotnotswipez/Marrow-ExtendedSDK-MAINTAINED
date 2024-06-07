using System;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x0200008B RID: 139
	public interface IReadOnlyScannable
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000531 RID: 1329
		Barcode Barcode { get; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000532 RID: 1330
		string Title { get; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000533 RID: 1331
		string Description { get; }
	}
}
