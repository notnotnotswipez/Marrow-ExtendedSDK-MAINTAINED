using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Forklift
{
	// Token: 0x0200017A RID: 378
	public static class DownloadUtils
	{
		// Token: 0x06000E41 RID: 3649 RVA: 0x00004F11 File Offset: 0x00003111
		public static void ParseIntoUrls(List<string> strings, out List<Uri> parsedUrls, out List<FetchError> errors)
		{
			parsedUrls = null;
			errors = null;
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00004F19 File Offset: 0x00003119
		public static void GroupUrlsByHost(List<Uri> urls, out Dictionary<string, List<Uri>> groupedUrls, out List<FetchError> errors)
		{
			groupedUrls = null;
			errors = null;
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00004F21 File Offset: 0x00003121
		public static Queue<TItem> LinearizeRoundRobin<TGroupKey, TItem>(Dictionary<TGroupKey, List<TItem>> groupedRequests)
		{
			return null;
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00004F24 File Offset: 0x00003124
		public static void FillItems<TItem>(ref Queue<TItem> from, List<TItem> into, int limit, List<int> filledIndices, Func<TItem, List<TItem>, bool> shouldAddItemToList)
		{
		}
	}
}
