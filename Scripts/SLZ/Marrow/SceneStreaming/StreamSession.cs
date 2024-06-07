using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Warehouse;
using UnityEngine.SceneManagement;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000D1 RID: 209
	public class StreamSession
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00007264 File Offset: 0x00005464
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00003BDA File Offset: 0x00001DDA
		public StreamStatus Status
		{
			[CompilerGenerated]
			get
			{
				return StreamStatus.NONE;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00003BDE File Offset: 0x00001DDE
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x00003BDC File Offset: 0x00001DDC
		public SceneLoader SceneLoader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public StreamSession(LevelCrateReference level, LevelCrateReference loadLevel = null)
		{
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00003BE9 File Offset: 0x00001DE9
		public void RegisterLoadDependency()
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00003BEB File Offset: 0x00001DEB
		public void UnregisterLoadDependency()
		{
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00003BED File Offset: 0x00001DED
		public void AddDoPersistentLoadCallback(Action cb)
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00003BEF File Offset: 0x00001DEF
		public void AddWillPersistentLoadCallback(Action cb)
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00003BF1 File Offset: 0x00001DF1
		public void AddDoLevelLoadCallback(Action cb)
		{
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00003BF3 File Offset: 0x00001DF3
		public void AddDoLevelUnloadCallback(Action cb)
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0000727C File Offset: 0x0000547C
		internal UniTask Load()
		{
			return default(UniTask);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00003BF5 File Offset: 0x00001DF5
		public void End()
		{
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00003BF7 File Offset: 0x00001DF7
		public StreamSession Refresh()
		{
			return null;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00003BFA File Offset: 0x00001DFA
		public void RegisterPlayerMarker(PlayerMarker playerMarker)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00007294 File Offset: 0x00005494
		private UniTask<Scene> LoadPersistentScenes()
		{
			return default(UniTask<Scene>);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000072AC File Offset: 0x000054AC
		private UniTask UnloadAllOtherScenes(Scene loadingScene)
		{
			return default(UniTask);
		}

		// Token: 0x040003C5 RID: 965
		private readonly LevelCrateReference _level;

		// Token: 0x040003C6 RID: 966
		public readonly LevelCrate Level;

		// Token: 0x040003C7 RID: 967
		private readonly LevelCrateReference _loadLevel;

		// Token: 0x040003C8 RID: 968
		public readonly LevelCrate LoadLevel;

		// Token: 0x040003C9 RID: 969
		private readonly SceneLoadQueue _persistentQueue;

		// Token: 0x040003CA RID: 970
		private Action _doLevelLoad;

		// Token: 0x040003CB RID: 971
		private Action _doLevelUnload;

		// Token: 0x040003CC RID: 972
		private bool _willPersistentSceneLoadHappened;

		// Token: 0x040003CD RID: 973
		private Action _willPersistentSceneLoad;

		// Token: 0x040003CE RID: 974
		private bool _doPersistentSceneLoadHappened;

		// Token: 0x040003CF RID: 975
		private Action _doPersistentSceneLoad;

		// Token: 0x040003D0 RID: 976
		private List<PlayerMarker> _playerMarkers;

		// Token: 0x040003D1 RID: 977
		private int _loadDependencyCount;
	}
}
