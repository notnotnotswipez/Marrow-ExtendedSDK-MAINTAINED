using System.Collections.Generic;

namespace SLZ.Bonelab
{
	public static class HeadsetDetection
	{
		public enum Device
		{
			Uninitialized = -1,
			Unknown = 0,
			Quest1 = 1000,
			Quest2 = 1001,
			QuestPro = 1002,
			Quest3 = 1003
		}

		private static string s_deviceName;

		private static Device s_device;

		private static Dictionary<string, Device> modelName2device;

		public static string deviceName => null;

		public static Device device => default(Device);

		private static Device GetDevice()
		{
			return default(Device);
		}
	}
}
