using System;
using System.Runtime.CompilerServices;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

namespace SLZ.Marrow.UniTaskExtensions
{
	// Token: 0x020000C4 RID: 196
	[PublicAPI]
	public static class CancellationTokenExtensions
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x00003AE7 File Offset: 0x00001CE7
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, CancellationToken token)
		{
			return null;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00003AEA File Offset: 0x00001CEA
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationToken token, CancellationTokenSource cts)
		{
			return null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00003AED File Offset: 0x00001CED
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationToken token, CancellationToken token2)
		{
			return null;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00003AF0 File Offset: 0x00001CF0
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, CancellationTokenSource cts2)
		{
			return null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00003AF3 File Offset: 0x00001CF3
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, params CancellationToken[] tokens)
		{
			return null;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00003AF6 File Offset: 0x00001CF6
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationToken token, params CancellationToken[] tokens)
		{
			return null;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00003AF9 File Offset: 0x00001CF9
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationTokenSource cts, params CancellationTokenSource[] tokenSources)
		{
			return null;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00003AFC File Offset: 0x00001CFC
		[MethodImpl(256)]
		public static CancellationTokenSource WithLinked(this CancellationToken token, params CancellationTokenSource[] tokenSources)
		{
			return null;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00003AFF File Offset: 0x00001CFF
		[MethodImpl(256)]
		public static CancellationTokenSource WithOnDestroy(this CancellationTokenSource cts, Component component)
		{
			return null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00003B02 File Offset: 0x00001D02
		[MethodImpl(256)]
		public static CancellationTokenSource WithOnDestroy(this CancellationToken token, Component component)
		{
			return null;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000070B4 File Offset: 0x000052B4
		[MethodImpl(256)]
		public static CancellationToken WithOnDestroyToken(this CancellationToken token, Component component)
		{
			return default(CancellationToken);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000070CC File Offset: 0x000052CC
		[MethodImpl(256)]
		public static CancellationToken WithOnDestroyToken(this CancellationTokenSource cts, Component component)
		{
			return default(CancellationToken);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00003B05 File Offset: 0x00001D05
		[MethodImpl(256)]
		public static void CancelAndReplace(ref CancellationTokenSource cts)
		{
		}
	}
}
