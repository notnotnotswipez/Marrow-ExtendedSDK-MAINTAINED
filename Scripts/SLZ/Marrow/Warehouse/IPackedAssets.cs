using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x0200008D RID: 141
	public interface IPackedAssets
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000538 RID: 1336
		List<PackedAsset> PackedAssets { get; }

		// Token: 0x06000539 RID: 1337
		void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets);

		// Token: 0x0600053A RID: 1338
		List<PackedAsset> ExportPackedAssets();
	}
}
