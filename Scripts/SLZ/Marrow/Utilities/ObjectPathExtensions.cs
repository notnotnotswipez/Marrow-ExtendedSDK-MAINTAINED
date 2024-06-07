using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000115 RID: 277
	public static class ObjectPathExtensions
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00004310 File Offset: 0x00002510
		private static IEnumerable<string> ObjectPathComponents(this Transform tf)
		{
			return null;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00004313 File Offset: 0x00002513
		[PublicAPI]
		public static string ObjectPath(this Transform tf)
		{
			return null;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00004316 File Offset: 0x00002516
		[PublicAPI]
		public static string ObjectPath(this Component c)
		{
			return null;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00004319 File Offset: 0x00002519
		[PublicAPI]
		public static string ObjectPath(this GameObject go)
		{
			return null;
		}
	}
}
