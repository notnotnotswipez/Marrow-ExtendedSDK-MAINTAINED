using System;
using SLZ.Marrow.SaveData;

namespace SLZ.Marrow
{
	// Token: 0x0200001A RID: 26
	public static class ExtensionsASDF
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00002BE5 File Offset: 0x00000DE5
		public static bool TrySetLevelCompleted(this IProgression progression, string levelKey, bool completed)
		{
			return false;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public static bool TryGetLevelCompleted(this IProgression progression, string levelKey, out bool completed)
		{
			completed = default(bool);
			return false;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002BF2 File Offset: 0x00000DF2
		public static bool TrySetLevelProgress(this IProgression progression, string levelKey, int progress)
		{
			return false;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public static bool TryGetLevelProgress(this IProgression progression, string levelKey, out int progress)
		{
			progress = 0;
			return false;
		}

		// Token: 0x04000105 RID: 261
		public const string PROGRESS = "SLZ.Marrow.progress";

		// Token: 0x04000106 RID: 262
		public const string COMPLETED = "SLZ.Marrow.completed";
	}
}
