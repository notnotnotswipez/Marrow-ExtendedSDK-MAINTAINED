using UnityEngine;
using UnityEngine.Rendering;

namespace MK.Glow
{
	internal abstract class CameraData
	{
		internal int width;

		internal int height;

		internal bool stereoEnabled;

		internal float aspect;

		internal Matrix4x4 worldToCameraMatrix;

		internal bool overwriteDescriptor;

		internal TextureDimension overweriteDimension;

		internal int overwriteVolumeDepth;
	}
}
