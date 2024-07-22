using SLZ.Marrow.SaveData;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace SLZ.Bonelab.SaveData
{
	public class GraphicsManager
	{
		public enum FoveatedRadii
		{
			VRSOuterRadius = 0,
			VRSAnisotropy = 1,
			VRSInnerRatio = 2,
			RDMOuterRadius = 3,
			RDMInnerRatio = 4
		}

		[SerializeField]
		public static UniversalRendererData CustomRendererData;

		[SerializeField]
		public static UniversalRenderPipelineAsset CustomPipelineAsset;

		[SerializeField]
		public static VolumetricData CustomVolumetricRenderingSettings;

		[SerializeField]
		public static VolumetricData QuestVolumetricRenderingSettings;

		[SerializeField]
		public static VolumetricData PCVolumetricRenderingSettings;

		[SerializeField]
		public static Volume MainSceneVolume;

		[SerializeField]
		public static VolumeProfile MainVolumeProfile;

		[SerializeField]
		public static VolumeProfile CustomVolumeProfile;

		private static int SSAOFeature;

		private static int BloomFeature;

		private static int HBAOFeature;

		private static int AutoExposureFeature;

		private static int VRSRenderFeature;

		private static float PercentToFloat;

		private static GraphicsSettings graphicsSettings;

		public static void DecreaseQualityLevel()
		{
		}

		public static void IncreaseQualityLevel()
		{
		}

		public static void SaveQualityLevel()
		{
		}

		public static void SaveQualityLevel(GraphicsQuality graphicsQuality)
		{
		}

		private static void RefreshQualitySettings()
		{
		}

		private static void CustomSet()
		{
		}

		private static void CustomFoveatedSet()
		{
		}

		public static void SetQualityFromPreset(GraphicsQuality quality)
		{
		}

		public static void InitializeCustomSettings()
		{
		}

		private static void CheckRenderfeatures()
		{
		}

		public static void SetFoveatedSettings()
		{
		}

		public static bool ToggleFoveatedVisualization()
		{
			return false;
		}

		public static void DisableFoveatedVisualization()
		{
		}

		public static void SetCurrentRenderer(UniversalRenderPipelineAsset pipelineAsset)
		{
		}

		public static void IncreaseShadowQuality()
		{
		}

		public static void DecreaseShadowQuality()
		{
		}

		private static void SetShadowVariables(SettingLevel currentLevel)
		{
		}

		public static void IncreaseShadowCascade()
		{
		}

		public static void DecreaseShadowCascade()
		{
		}

		public static void SetShadowCascades(int count)
		{
		}

		public static void IncreaseMSAA()
		{
		}

		public static void DecreaseMSAA()
		{
		}

		public static void SetMSAAVariables(int TargetAA)
		{
		}

		public static void SetDepthPrepass(bool hasDepthPrepass)
		{
		}

		public static void SetOpaqueBlit(bool hasOpaqueTexture)
		{
		}

		public static void SetHDR(bool enable)
		{
		}

		public static void SetAdditionalLights(bool perPixel, int maxLights)
		{
		}

		public static void SetMainLightShadows(bool enableShadows)
		{
		}

		public static void SetAutoExposure(bool enabled)
		{
		}

		public static void SetProbeProjectionBlend(bool boxProjection, bool probeBlending)
		{
		}

		public static void IncreaseRenderScale()
		{
		}

		public static void DecreaseRenderScale()
		{
		}

		public static void SetRenderscale(int scale)
		{
		}

		public static void IncreaseLODBias()
		{
		}

		public static void DecreaseLODBias()
		{
		}

		public static void SetLODBias()
		{
		}

		public static void SetAnisotropic(bool forceOn)
		{
		}

		public static void SetTexStreamingMemory(float megabytes)
		{
		}

		public static void SetLODBias(int biasUnscaled)
		{
		}

		public static void SetLODBias(float bias)
		{
		}

		public static float ComputeXRLODBias(float InputBias)
		{
			return 0f;
		}

		private static float LODQualityFromLevel(GraphicsQuality graphicsQuality)
		{
			return 0f;
		}

		public static void IncreaseBloom()
		{
		}

		public static void DecreaseBloom()
		{
		}

		public static void IncreaseHBAO()
		{
		}

		public static void DecreaseHBAO()
		{
		}

		public static void IncreaseSSR()
		{
		}

		public static void DecreaseSSR()
		{
		}

		public static void IncreaseSMAA()
		{
		}

		public static void DecreaseSMAA()
		{
		}

		public static void SetPostAAVariables(SettingLevel antialiasingQuality)
		{
		}

		public static void IncreaseVolumetrics()
		{
		}

		public static void DecreaseVolumetrics()
		{
		}

		public static void IncreaseFoveatedRenderingMode()
		{
		}

		public static void DecreaseFoveatedRenderingMode()
		{
		}

		public static void IncreaseFoveatedPreset()
		{
		}

		public static void DecreaseFoveatedPreset()
		{
		}

		public static void IncreaseFoveatedRadius(FoveatedRadii radius)
		{
		}

		public static void DecreaseFoveatedRadius(FoveatedRadii radius)
		{
		}

		public static void SetFoveatedRenderingMode(FoveatedRenderingMode currentlevel)
		{
		}

		public static void SetFoveatedPreset(FoveatedPresets currentlevel)
		{
		}

		public static void SetFoveatedCustomRadii(FoveatedRadii radius, int value)
		{
		}

		public static void SetVolumetricVariables(SettingLevel currentlevel)
		{
		}

		public static void ReintializeVolumetricRenderer(VolumetricRendering VolumetricRender)
		{
		}

		public static void GetDefaultVolumeticValues()
		{
		}

		public static void SetVolumeticValuesFromSettings(SettingLevel level)
		{
		}

		public static void SetSSRVariables(SettingLevel SSRSettings)
		{
		}

		public static void SetHBAOVariables(SettingLevel SSRSettings)
		{
		}

		public static void SetBloomVariables(SettingLevel GlowSettings)
		{
		}
	}
}
