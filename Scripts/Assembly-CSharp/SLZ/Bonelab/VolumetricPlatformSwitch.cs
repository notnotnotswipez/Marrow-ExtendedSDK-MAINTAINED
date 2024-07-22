using UnityEngine;

namespace SLZ.Bonelab
{
	public class VolumetricPlatformSwitch : MonoBehaviour
	{
		[Header("Per Platform settings")]
		public VolumetricData VolumetricSettingsAndroid;

		public VolumetricData VolumetricSettingsPC;

		private void Awake()
		{
		}

		private void OnloadEvent()
		{
		}
	}
}
