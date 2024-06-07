using UnityEngine;

namespace MK.Glow
{
	internal sealed class RenderContext : IDimension
	{
		private RenderTextureDescriptor _descriptor;

		public RenderTextureDescriptor descriptor => default(RenderTextureDescriptor);

		public RenderDimension renderDimension => default(RenderDimension);

		public bool enableRandomWrite => false;

		public int width => 0;

		public int height => 0;

		internal RenderContext()
		{
		}

		internal void SinglePassStereoAdjustWidth(bool stereoEnabled)
		{
		}

		internal void UpdateRenderContext(CameraData cameraData, RenderTextureFormat format, int depthBufferBits, bool enableRandomWrite, RenderDimension dimension)
		{
		}
	}
}
