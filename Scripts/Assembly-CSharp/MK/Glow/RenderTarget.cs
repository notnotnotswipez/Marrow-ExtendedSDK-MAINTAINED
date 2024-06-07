using UnityEngine;
using UnityEngine.Rendering;

namespace MK.Glow
{
	internal struct RenderTarget
	{
		internal RenderTexture renderTexture;

		internal RenderTargetIdentifier renderTargetIdentifier;

		internal int identifier;
	}
}
