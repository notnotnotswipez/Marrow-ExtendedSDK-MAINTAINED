using System;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x02000073 RID: 115
	public interface ICrate
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600046E RID: 1134
		// (set) Token: 0x0600046F RID: 1135
		MarrowAsset MainAsset { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000470 RID: 1136
		Type AssetType { get; }
	}
}
