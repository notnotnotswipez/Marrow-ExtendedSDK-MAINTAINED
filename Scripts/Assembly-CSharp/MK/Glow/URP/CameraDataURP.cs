using UnityEngine.Rendering.Universal;

namespace MK.Glow.URP
{
	internal class CameraDataURP : CameraData
	{
		public static implicit operator CameraDataURP(UnityEngine.Rendering.Universal.CameraData input)
		{
			return null;
		}
	}
}
