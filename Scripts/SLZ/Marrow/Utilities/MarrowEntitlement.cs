using System;
using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000102 RID: 258
	public static class MarrowEntitlement
	{
		// Token: 0x060009B0 RID: 2480 RVA: 0x00007744 File Offset: 0x00005944
		public static UniTask<bool> CheckEntitlementAsync(string appId)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0000427E File Offset: 0x0000247E
		public static void Close()
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0000775C File Offset: 0x0000595C
		private static UniTask<bool> CheckSteamEntitlementAsync(string appId)
		{
			return default(UniTask<bool>);
		}
	}
}
