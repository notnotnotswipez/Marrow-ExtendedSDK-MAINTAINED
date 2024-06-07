using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class PlatformEvent : MonoBehaviour
	{
		private enum Platform
		{
			Android = 0,
			PC = 1
		}

		public UnityEvent PCEvent;

		public UnityEvent AndroidEvent;

		[SerializeField]
		private Platform platform;

		private void Awake()
		{
		}
	}
}
