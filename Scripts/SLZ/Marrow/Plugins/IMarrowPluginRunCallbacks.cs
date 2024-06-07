using System;
using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.Plugins
{
	// Token: 0x020000B7 RID: 183
	public interface IMarrowPluginRunCallbacks : IMarrowPlugin
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x00006DE4 File Offset: 0x00004FE4
		UniTask OnMarrowPluginStart()
		{
			return default(UniTask);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00006DFC File Offset: 0x00004FFC
		UniTask OnMarrowPluginStop()
		{
			return default(UniTask);
		}
	}
}
