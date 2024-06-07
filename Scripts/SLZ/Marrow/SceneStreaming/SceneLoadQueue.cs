using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000CE RID: 206
	public class SceneLoadQueue
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x000071D4 File Offset: 0x000053D4
		public SceneInstance GetInstance(string address)
		{
			return default(SceneInstance);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00003BAA File Offset: 0x00001DAA
		public void AddLoad(string address)
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00003BAC File Offset: 0x00001DAC
		public void AddUnload(string address)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00003BAE File Offset: 0x00001DAE
		public void Cancel()
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000071EC File Offset: 0x000053EC
		public UniTask LoadAll(LoadSceneMode loadMode = LoadSceneMode.Additive, bool activateOnLoad = true)
		{
			return default(UniTask);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00007204 File Offset: 0x00005404
		public UniTask UnloadAll(bool autoReleaseHandle = true)
		{
			return default(UniTask);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00003BB0 File Offset: 0x00001DB0
		protected void Finalize()
		{
		}

		// Token: 0x040003B5 RID: 949
		private Dictionary<Scene, uint> _loadedScenes;

		// Token: 0x040003B6 RID: 950
		private Dictionary<string, SceneInstance> _addressToInstance;

		// Token: 0x040003B7 RID: 951
		private HashSet<string> _loadAddressesHash;

		// Token: 0x040003B8 RID: 952
		private List<string> _loadAddresses;

		// Token: 0x040003B9 RID: 953
		private List<string> _unloadAddresses;

		// Token: 0x040003BA RID: 954
		private List<UniTask<SceneInstance>> _loadTasks;

		// Token: 0x040003BB RID: 955
		private List<UniTask> _unloadTasks;

		// Token: 0x040003BC RID: 956
		private CancellationTokenSource _loadCts;

		// Token: 0x040003BD RID: 957
		private CancellationTokenSource _unloadCts;
	}
}
