using System;
using JetBrains.Annotations;

namespace SLZ.Marrow.Forklift
{
	// Token: 0x0200017B RID: 379
	[PublicAPI]
	public readonly struct FileDownloadProgress
	{
		// Token: 0x040009FE RID: 2558
		public readonly long BytesDownloaded;

		// Token: 0x040009FF RID: 2559
		public readonly long BytesTotal;
	}
}
