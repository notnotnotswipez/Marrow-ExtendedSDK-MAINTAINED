using System;

namespace SLZ.Marrow.SaveData
{
	// Token: 0x0200016F RID: 367
	public static class ProgressionHelper
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x00004EAD File Offset: 0x000030AD
		public static bool TrySetLevelValue(this IProgression progression, string levelKey, string valueKey, object value)
		{
			return false;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00004EB0 File Offset: 0x000030B0
		public static bool TryGetLevelValue(this IProgression progression, string levelKey, string valueKey, out object value)
		{
			value = null;
			return false;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00004EB6 File Offset: 0x000030B6
		public static bool TryGetLevelValue(this IProgression progression, string levelKey, string valueKey, out bool value)
		{
			value = default(bool);
			return false;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00004EC0 File Offset: 0x000030C0
		public static bool TryGetLevelValue(this IProgression progression, string levelKey, string valueKey, out int value)
		{
			value = 0;
			return false;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00004ECA File Offset: 0x000030CA
		public static bool TryGetLevelValue(this IProgression progression, string levelKey, string valueKey, out float value)
		{
			value = 0f;
			return false;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00004ED4 File Offset: 0x000030D4
		public static bool TryGetLevelValue(this IProgression progression, string levelKey, string valueKey, out double value)
		{
			value = 0.0;
			return false;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00004EDE File Offset: 0x000030DE
		public static bool TryDeleteLevelValue(this IProgression progression, string levelKey, string valueKey, Confirmation1 confirmation)
		{
			return false;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00004EE1 File Offset: 0x000030E1
		public static bool TryDeleteLevelValue(this IProgression progression, string levelKey, string valueKey, out object finalValue, Confirmation1 confirmation)
		{
			finalValue = null;
			return false;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00004EE7 File Offset: 0x000030E7
		public static bool TryDeleteAllLevelData(this IProgression progression, string levelKey, Confirmation1 confirmation = Confirmation1.IMadeAMistake, Confirmation2 confirmation2 = Confirmation2.OnTheSecondThoughtMaybeNot)
		{
			return false;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00004EEA File Offset: 0x000030EA
		public static bool TryDeleteSaveableLevelData(this IProgression progression, string levelKey, Confirmation1 confirmation = Confirmation1.IMadeAMistake)
		{
			return false;
		}
	}
}
