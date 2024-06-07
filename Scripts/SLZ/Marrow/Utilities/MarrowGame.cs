using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Input;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000103 RID: 259
	public static class MarrowGame
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00004280 File Offset: 0x00002480
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00004283 File Offset: 0x00002483
		public static bool IsInitialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00004285 File Offset: 0x00002485
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void RuntimeInitializeAfterAssembliesLoaded()
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00004287 File Offset: 0x00002487
		public static void RegisterOnReadyAction(Action action)
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00007774 File Offset: 0x00005974
		public static UniTask Initialize(string appId)
		{
			return default(UniTask);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0000778C File Offset: 0x0000598C
		private static UniTask TryInitializeXRApi()
		{
			return default(UniTask);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00004289 File Offset: 0x00002489
		private static void OnApplicationQuit()
		{
		}

		// Token: 0x04000623 RID: 1571
		public static MarrowPlayerLoop playerLoop;

		// Token: 0x04000624 RID: 1572
		public static XRApi xr;

		// Token: 0x04000625 RID: 1573
		public static AssetWarehouse assetWarehouse;

		// Token: 0x04000626 RID: 1574
		public static MarrowSettings marrowSettings;

		// Token: 0x04000627 RID: 1575
		public static Action<string> OnLogUpdate;

		// Token: 0x04000628 RID: 1576
		private static Action _onReady;
	}
}
