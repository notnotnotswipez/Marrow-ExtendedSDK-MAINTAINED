using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000138 RID: 312
	[MarrowPlugin("SLZ.Marrow.Interaction", "EntityManager", "0.0.1")]
	public class EntityManager : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x000046A1 File Offset: 0x000028A1
		public static EntityManager Instance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00007BC4 File Offset: 0x00005DC4
		 UniTask SLZ.Marrow.Plugins.IMarrowPluginLevelCallbacks.OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x000046A4 File Offset: 0x000028A4
		public bool TryGetEntitiesWithTag(BoneTag boneTag, out IReadOnlyList<MarrowEntity> entities)
		{
			entities = null;
			return false;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000046AA File Offset: 0x000028AA
		public bool TryGetFirstEntityWithTag(BoneTag boneTag, out MarrowEntity entity)
		{
			entity = null;
			return false;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000046B0 File Offset: 0x000028B0
		public void RegisterEntity(MarrowEntity entity)
		{
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000046B2 File Offset: 0x000028B2
		public void UnregisterEntity(MarrowEntity entity)
		{
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x000046B4 File Offset: 0x000028B4
		private void RemoveEntityFromTag(string boneTagID, MarrowEntity entity)
		{
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x000046B6 File Offset: 0x000028B6
		private void AddEntityToTag(string boneTagID, MarrowEntity entity)
		{
		}

		// Token: 0x040006D1 RID: 1745
		private static EntityManager _manager;

		// Token: 0x040006D2 RID: 1746
		private HashSet<MarrowEntity> _entities;

		// Token: 0x040006D3 RID: 1747
		private Dictionary<string, List<MarrowEntity>> _tagIDToEntity;
	}
}
