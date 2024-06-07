using System;
using Cysharp.Threading.Tasks;

namespace SLZ.Marrow.Plugins
{
	// Token: 0x020000B6 RID: 182
	public interface IMarrowPlugin
	{
		// Token: 0x0600067E RID: 1662 RVA: 0x00006DCC File Offset: 0x00004FCC
		UniTask OnMarrowPluginLoad()
		{
			return default(UniTask);
		}
	}
}
