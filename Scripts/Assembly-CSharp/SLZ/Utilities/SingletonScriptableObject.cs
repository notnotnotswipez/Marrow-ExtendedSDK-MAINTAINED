using UnityEngine;

namespace SLZ.Utilities
{
	public class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
	{
		private static T s_Instance;

		public static T Instance => null;
	}
}
