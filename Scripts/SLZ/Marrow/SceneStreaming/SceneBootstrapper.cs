using System;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000CB RID: 203
	public class SceneBootstrapper : MonoBehaviour
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x0000715C File Offset: 0x0000535C
		private UniTaskVoid Start()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x040003AA RID: 938
		public LevelCrateReference levelCrateRef;

		// Token: 0x040003AB RID: 939
		public LevelCrateReference loadLevelCrateRef;
	}
}
