using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlatformDiscriminator : MonoBehaviour
	{
		private enum Platform
		{
			Android = 0,
			PC = 1
		}

		[SerializeField]
		private Platform platform;

		private void Awake()
		{
		}
	}
}
