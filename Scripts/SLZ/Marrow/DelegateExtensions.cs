using System;
using System.Collections.Generic;

namespace SLZ.Marrow
{
	// Token: 0x02000017 RID: 23
	public static class DelegateExtensions
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00002B84 File Offset: 0x00000D84
		public static void SafeInvoke(this Delegate del, params object[] args)
		{
		}

		// Token: 0x040000F9 RID: 249
		private static readonly List<Exception> _exceptions;
	}
}
