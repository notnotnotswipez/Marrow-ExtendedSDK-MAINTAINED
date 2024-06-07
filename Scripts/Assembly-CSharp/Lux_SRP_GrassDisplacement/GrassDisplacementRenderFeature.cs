using System;
using UnityEngine.Rendering.Universal;

namespace Lux_SRP_GrassDisplacement
{
	public class GrassDisplacementRenderFeature : ScriptableRendererFeature
	{
		[Serializable]
		public enum RTDisplacementSize
		{
			_128 = 0x80,
			_256 = 0x100,
			_512 = 0x200,
			_1024 = 0x400
		}

		[Serializable]
		public class GrassDisplacementSettings
		{
			public RTDisplacementSize Resolution;

			public float Size;

			public bool ShiftRenderTex;
		}

		public GrassDisplacementSettings settings;

		private GrassDisplacementPass m_GrassDisplacementPass;

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}
	}
}
