using UnityEngine;
using UnityEngine.Rendering;

namespace MK.Glow
{
	internal interface ICameraData
	{
		int GetCameraWidth();

		int GetCameraHeight();

		bool GetStereoEnabled();

		float GetAspect();

		Matrix4x4 GetWorldToCameraMatrix();

		bool GetOverwriteDescriptor();

		TextureDimension GetOverwriteDimension();

		int GetOverwriteVolumeDepth();

		bool GetTargetTexture();
	}
}
