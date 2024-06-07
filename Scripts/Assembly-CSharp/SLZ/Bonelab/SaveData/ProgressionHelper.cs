namespace SLZ.Bonelab.SaveData
{
	public static class ProgressionHelper
	{
		public static bool TrySetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, object value)
		{
			return false;
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, out object value)
		{
			value = null;
			return false;
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, out bool value)
		{
			value = default(bool);
			return false;
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, out int value)
		{
			value = default(int);
			return false;
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, out float value)
		{
			value = default(float);
			return false;
		}

		public static bool TryGetLevelValue(this PlayerProgression progression, string levelKey, string valueKey, out double value)
		{
			value = default(double);
			return false;
		}

		public static bool TryDeleteLevelValue(this PlayerProgression progression, string levelKey, string valueKey, Confirmation1 confirmation)
		{
			return false;
		}

		public static bool TryDeleteLevelValue(this PlayerProgression progression, string levelKey, string valueKey, out object finalValue, Confirmation1 confirmation)
		{
			finalValue = null;
			return false;
		}

		public static bool TryDeleteAllLevelData(this PlayerProgression progression, string levelKey, Confirmation1 confirmation = Confirmation1.IMadeAMistake, Confirmation2 confirmation2 = Confirmation2.OnTheSecondThoughtMaybeNot)
		{
			return false;
		}

		public static bool TryDeleteSaveableLevelData(this PlayerProgression progression, string levelKey, Confirmation1 confirmation = Confirmation1.IMadeAMistake)
		{
			return false;
		}
	}
}
