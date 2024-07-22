using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Lux_SRP_GrassDisplacement
{
	public class GrassDisplacementPass : ScriptableRenderPass
	{
		private const string ProfilerTag = "Render Lux Grass Displacement FX";

		private static ProfilingSampler m_ProfilingSampler;

		private ShaderTagId m_GrassDisplacementFXShaderTag;

		private SinglePassStereoMode m_StereoRenderingMode;

		private Color m_ClearColor;

		private RenderTargetHandle m_GrassDisplacementFX;

		private Matrix4x4 projectionMatrix;

		private Matrix4x4 worldToCameraMatrix;

		public float m_Size;

		public int m_Resolution;

		public bool m_ShiftRenderTex;

		private float stepSize;

		private float oneOverStepSize;

		private Vector4 posSize;

		private static int DisplacementTexPosSizePID;

		private FilteringSettings transparentFilterSettings
		{
			[CompilerGenerated]
			get
			{
				return default(FilteringSettings);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
