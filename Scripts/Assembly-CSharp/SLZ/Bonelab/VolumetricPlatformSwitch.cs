using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(VolumetricRendering))]
	public class VolumetricPlatformSwitch : MonoBehaviour
	{
		[Header("Per Platform settings")]
		public VolumetricData VolumetricSettingsAndroid;

		public VolumetricData VolumetricSettingsPC;

		[Header("Per Rig setting")]
		public Camera targetCamera;

		[Header("Target scrpit")]
		public VolumetricRendering volumetricRendering;

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnloadEvent()
		{
		}
	}
}
