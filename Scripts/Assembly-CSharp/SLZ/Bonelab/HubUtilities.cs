using SLZ.Bonelab.SaveData;

namespace SLZ.Bonelab
{
	public static class HubUtilities
	{
		public static string CalculateHubLevelKey()
		{
			return null;
		}

		public static string[] CalculatePriorLevels()
		{
			return null;
		}

		public static bool GetHubFlag(this PlayerProgression progression, string flag)
		{
			return false;
		}

		public static int GetHubInt(this PlayerProgression progression, string flag)
		{
			return 0;
		}

		public static bool TrySetHubFlag(this PlayerProgression progression, string flag, bool value)
		{
			return false;
		}

		public static bool TryGetHubFlag(this PlayerProgression progression, string flag, out bool value)
		{
			value = default(bool);
			return false;
		}

		public static bool TryGetHubInt(this PlayerProgression progression, string flag, out int value)
		{
			value = default(int);
			return false;
		}
	}
}
