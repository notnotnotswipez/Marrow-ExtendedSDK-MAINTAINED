using System;
using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.Plugins
{
	// Token: 0x020000B8 RID: 184
	public interface IMarrowPluginEditorCallbacks : IMarrowPlugin
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x00006E14 File Offset: 0x00005014
		UniTask OnMarrowPluginEditorPaused()
		{
			return default(UniTask);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00006E2C File Offset: 0x0000502C
		UniTask OnMarrowPluginEditorUnpaused()
		{
			return default(UniTask);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00006E44 File Offset: 0x00005044
		UniTask OnMarrowPluginEditorEnteredEditMode()
		{
			return default(UniTask);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00006E5C File Offset: 0x0000505C
		UniTask OnMarrowPluginEditorExitingEditMode()
		{
			return default(UniTask);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00006E74 File Offset: 0x00005074
		UniTask OnMarrowPluginEditorEnteredPlayMode()
		{
			return default(UniTask);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00006E8C File Offset: 0x0000508C
		UniTask OnMarrowPluginEditorExitingPlayMode()
		{
			return default(UniTask);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00006EA4 File Offset: 0x000050A4
		UniTask OnMarrowPluginEditorBeforeAssemblyReload()
		{
			return default(UniTask);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00006EBC File Offset: 0x000050BC
		UniTask OnMarrowPluginEditorAfterAssemblyReload()
		{
			return default(UniTask);
		}
	}
}
