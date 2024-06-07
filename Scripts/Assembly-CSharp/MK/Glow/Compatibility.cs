using UnityEngine;

namespace MK.Glow
{
	public static class Compatibility
	{
		private static readonly bool _defaultHDRFormatSupported;

		private static readonly bool _11R11G10BFormatSupported;

		private static readonly bool _2A10R10G10BFormatSupported;

		public static readonly bool IsSupported;

		public static bool CheckGeometryShaderSupport()
		{
			return false;
		}

		public static bool CheckComputeShaderSupport()
		{
			return false;
		}

		public static bool CheckLensFlareFeatureSupport()
		{
			return false;
		}

		public static bool CheckGlareFeatureSupport()
		{
			return false;
		}

		internal static RenderTextureFormat CheckSupportedRenderTextureFormat()
		{
			return default(RenderTextureFormat);
		}
	}
}
