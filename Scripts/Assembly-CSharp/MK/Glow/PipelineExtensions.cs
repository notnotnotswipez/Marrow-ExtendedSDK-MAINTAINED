using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace MK.Glow
{
	internal static class PipelineExtensions
	{
		private static Mesh _screenMesh;

		private static Mesh screenMesh => null;

		internal static void SetKeyword(this CommandBuffer cmd, string keyword, bool enable)
		{
		}

		internal static void SetKeyword(string keyword, bool enable)
		{
		}

		internal static void Draw(this CommandBuffer cmd, List<RenderTarget> destinations, Material material, bool useGeometryShader, int pass, Rect viewport)
		{
		}

		internal static void Draw(List<RenderTarget> destinations, Material material, bool useGeometryShader, int pass)
		{
		}

		internal static void Draw(this CommandBuffer cmd, List<RenderTarget> destinations, ComputeShader computeShader, int kernelIndex, RenderDimension computeThreadGroups)
		{
		}

		internal static void Draw(List<RenderTarget> destinations, ComputeShader computeShader, int kernelIndex, RenderDimension computeThreadGroups)
		{
		}

		private static int SinglePassStereoDownscale(bool cameraIsStereo, int size, int scale)
		{
			return 0;
		}

		internal static void UpdateMipRenderContext(this CameraData cameraData, RenderContext[] renderContexts, RenderDimension rawDimension, int levels, RenderTextureFormat format, int depthBufferBits, bool enableRandomWrite)
		{
		}

		internal static RenderTexture GetTemporary(RenderContext renderContext, RenderTextureFormat format)
		{
			return null;
		}
	}
}
