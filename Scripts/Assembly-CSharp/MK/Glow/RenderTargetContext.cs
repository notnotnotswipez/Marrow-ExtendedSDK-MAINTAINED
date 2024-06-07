using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace MK.Glow
{
	internal static class RenderTargetContext
	{
		private static int _renderTargetCount;

		private static RenderTargetSetup[] _mrtBindingsLegacy;

		private static RenderTargetBinding[] _mrtBindingsSRP;

		internal static void SetRenderTargetContext(this CommandBuffer cmd, List<RenderTarget> renderTargets)
		{
		}

		internal static void SetRenderTargetContext(List<RenderTarget> renderTargets)
		{
		}
	}
}
