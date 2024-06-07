using System;
using SLZ.Serialize;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x0200008C RID: 140
	public interface IScannable : IReadOnlyScannable, IPackable, IPackedAssets
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000534 RID: 1332
		bool Unlockable { get; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000535 RID: 1333
		bool Redacted { get; }

		// Token: 0x06000536 RID: 1334
		void GenerateBarcode(bool forceGeneration = false);

		// Token: 0x06000537 RID: 1335
		void GenerateBarcodeInternal(bool forceGeneration = false);
	}
}
