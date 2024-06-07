using System;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Plugins
{
	// Token: 0x020000B9 RID: 185
	public interface IMarrowPluginLevelCallbacks : IMarrowPlugin
	{
		// Token: 0x06000689 RID: 1673 RVA: 0x00006ED4 File Offset: 0x000050D4
		UniTask OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00006EEC File Offset: 0x000050EC
		UniTask OnAfterLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00006F04 File Offset: 0x00005104
		UniTask OnBeforeLevelUnload()
		{
			return default(UniTask);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00006F1C File Offset: 0x0000511C
		UniTask OnAfterLevelUnload()
		{
			return default(UniTask);
		}
	}
}
