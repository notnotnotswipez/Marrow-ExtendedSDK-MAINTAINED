using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace SLZ.Marrow.SaveData
{
	// Token: 0x0200016E RID: 366
	public abstract class MarrowDataManager<TDataManager, TSave, TSettings, TProgression, TUnlocks> where TDataManager : MarrowDataManager<TDataManager, TSave, TSettings, TProgression, TUnlocks> where TSave : class, ISave<TProgression, TUnlocks>, new() where TSettings : class, ISettings, new() where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new()
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00004E6C File Offset: 0x0000306C
		[PublicAPI]
		public static string SettingsPath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00004E6F File Offset: 0x0000306F
		[PublicAPI]
		public static string SettingsBackupPath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00004E72 File Offset: 0x00003072
		[PublicAPI]
		public static string SettingsTempPath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00004E75 File Offset: 0x00003075
		[PublicAPI]
		public static string SavePath
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00004E78 File Offset: 0x00003078
		private bool _tryReadAndParseSettings(out TSettings settings)
		{
			settings = default(TSettings);
			return false;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00004E82 File Offset: 0x00003082
		protected static bool TryWriteSettings(ref TSettings settings)
		{
			return false;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00004E85 File Offset: 0x00003085
		protected internal bool TryAutosaveAndSetActive(TSave save, SaveFlags flags, out string saveFilename)
		{
			saveFilename = null;
			return false;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00004E8B File Offset: 0x0000308B
		protected bool TryWriteSave(TSave save, string saveFilename, SaveFlags flags)
		{
			return false;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00004E8E File Offset: 0x0000308E
		protected bool DoesSaveFileExist(string filename)
		{
			return false;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00004E91 File Offset: 0x00003091
		protected bool TryReadSave(ref TSave save, string filename, SaveFlags flags = SaveFlags.Progression)
		{
			return false;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00004E94 File Offset: 0x00003094
		private void _cleanupOldestSaves()
		{
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00008164 File Offset: 0x00006364
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00004E96 File Offset: 0x00003096
		protected internal DateTime LastWriteTime
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00004E98 File Offset: 0x00003098
		protected MarrowDataManager(int settingsVersion, int saveVersion)
		{
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00004EA0 File Offset: 0x000030A0
		private static string _generateSaveFilename()
		{
			return null;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00004EA3 File Offset: 0x000030A3
		[PublicAPI]
		public static bool TryParseDate(string dateString, out DateTime date)
		{
			date = default(DateTime);
			return false;
		}

		// Token: 0x040009E5 RID: 2533
		protected internal static TDataManager _instance;

		// Token: 0x040009E6 RID: 2534
		protected readonly int SettingsVersion;

		// Token: 0x040009E7 RID: 2535
		protected TSettings _settings;

		// Token: 0x040009E8 RID: 2536
		protected readonly int SaveVersion;

		// Token: 0x040009E9 RID: 2537
		protected internal TSave _activeSave;
	}
}
