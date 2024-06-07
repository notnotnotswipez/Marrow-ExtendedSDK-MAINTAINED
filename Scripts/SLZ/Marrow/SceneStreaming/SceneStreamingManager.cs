using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000D0 RID: 208
	[MarrowPlugin("SLZ.Marrow.SceneStreaming", "Scene Streaming Plugin", "0.0.1")]
	public class SceneStreamingManager : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00003BC5 File Offset: 0x00001DC5
		public static SceneStreamingManager Instance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public void RegisterSceneZone(GameObject gameObject, SceneChunk sceneChunk)
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00003BD2 File Offset: 0x00001DD2
		public void UnregisterSceneZone(GameObject gameObject)
		{
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00003BD4 File Offset: 0x00001DD4
		internal bool TryGetScenesFromCollider(GameObject gameObject, out SceneChunk sceneChunk)
		{
			sceneChunk = null;
			return false;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0000724C File Offset: 0x0000544C
		public UniTask OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		// Token: 0x040003C1 RID: 961
		private static SceneStreamingManager _manager;

		// Token: 0x040003C2 RID: 962
		private Dictionary<GameObject, SceneChunk> _gameObjectToScenes;
	}
}
