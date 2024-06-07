using System;
using System.Collections.Generic;

namespace SLZ.Bonelab.VoidLogic
{
	internal static class DictionaryCountedSetFunctions
	{
		public static bool AddOne<T>(this Dictionary<T, int> dict, T obj, out int count, Func<T, bool> onFirstAdded = null) where T : class
		{
			count = default(int);
			return false;
		}

		public static bool TryRemoveOne<T>(this Dictionary<T, int> dict, T obj, out int count, Action<T, int> onLastRemoved = null) where T : class
		{
			count = default(int);
			return false;
		}

		public static bool Clear<T>(this Dictionary<T, int> dict, T obj, out int count, Action<T, int> onRemoved = null) where T : class
		{
			count = default(int);
			return false;
		}
	}
}
