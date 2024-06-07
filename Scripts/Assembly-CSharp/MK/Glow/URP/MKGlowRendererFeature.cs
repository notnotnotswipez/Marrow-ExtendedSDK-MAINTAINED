using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace MK.Glow.URP
{
	public class MKGlowRendererFeature : ScriptableRendererFeature
	{
		public class MKGlowRenderPass : ScriptableRenderPass
		{
			private MKGlow _mKGlowVolumeComponent;

			internal Effect effect;

			internal ScriptableRenderer scriptableRenderer;

			private RenderTarget sourceRenderTarget;

			private RenderTarget destinationRenderTarget;

			private CameraDataURP _cameraData;

			private SettingsURP _settingsURP;

			private RenderTextureDescriptor _sourceDescriptor;

			private readonly int _rendererBufferID;

			private readonly string _profilerName;

			private MKGlow mKGlowVolumeComponent => null;

			public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
			{
			}

			public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
			}
		}

		private MKGlowRenderPass _mkGlowRenderPass;

		private readonly string _componentName;

		public override void Create()
		{
		}

		public void Disable()
		{
		}

		private void OnDisable()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}
	}
}
