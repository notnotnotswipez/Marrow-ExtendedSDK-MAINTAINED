using System;
using UnityEngine;

namespace SLZ.Bonelab
{
	public static class SLZQuestNative
	{
		private static int CheckIfInitialized()
		{
			return 0;
		}

		private static void GetDeviceName(IntPtr str, int len)
		{
		}

		public static int IsVkPSOCacheValid()
		{
			return 0;
		}

		public static string AndroidDeviceName()
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void Test()
		{
		}
	}
}
