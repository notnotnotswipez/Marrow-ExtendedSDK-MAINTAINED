using System;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000CF RID: 207
	public static class SceneStreamer
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00003BBA File Offset: 0x00001DBA
		public static StreamSession Session
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00003BBD File Offset: 0x00001DBD
		public static void Load(string levelBarcode, string loadLevelBarcode = "")
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00003BBF File Offset: 0x00001DBF
		public static void Load(LevelCrateReference level, LevelCrateReference loadLevel)
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0000721C File Offset: 0x0000541C
		public static UniTask LoadAsync(LevelCrateReference level, LevelCrateReference loadLevel)
		{
			return default(UniTask);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00003BC1 File Offset: 0x00001DC1
		public static void Reload()
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00007234 File Offset: 0x00005434
		public static UniTask ReloadAsync()
		{
			return default(UniTask);
		}

		// Token: 0x040003BE RID: 958
		private static StreamSession _session;

		// Token: 0x040003BF RID: 959
		public static Action doAnyLevelLoad;

		// Token: 0x040003C0 RID: 960
		public static Action doAnyLevelUnload;
	}
}
