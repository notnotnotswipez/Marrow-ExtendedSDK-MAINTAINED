using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace MK.Glow.URP
{
	[VolumeComponentMenu("Post-processing/MK/MKGlow")]
	[ExecuteInEditMode]
	public class MKGlow : VolumeComponent, IPostProcessComponent, ISettings
	{
		[Serializable]
		public sealed class RenderPriorityParameter : VolumeParameter<RenderPriority>
		{
			public override void Interp(RenderPriority from, RenderPriority to, float t)
			{
			}

			public RenderPriorityParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class Texture2DParameter : VolumeParameter<Texture2D>
		{
			public override void Interp(Texture2D from, Texture2D to, float t)
			{
			}

			public Texture2DParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class DebugViewParameter : VolumeParameter<DebugView>
		{
			public override void Interp(DebugView from, DebugView to, float t)
			{
			}

			public DebugViewParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class QualityParameter : VolumeParameter<Quality>
		{
			public override void Interp(Quality from, Quality to, float t)
			{
			}

			public QualityParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class AntiFlickerModeParameter : VolumeParameter<AntiFlickerMode>
		{
			public override void Interp(AntiFlickerMode from, AntiFlickerMode to, float t)
			{
			}

			public AntiFlickerModeParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class WorkflowParameter : VolumeParameter<Workflow>
		{
			public override void Interp(Workflow from, Workflow to, float t)
			{
			}

			public WorkflowParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class LayerMaskParameter : VolumeParameter<LayerMask>
		{
			public override void Interp(LayerMask from, LayerMask to, float t)
			{
			}

			public LayerMaskParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class MinMaxRangeParameter : VolumeParameter<MinMaxRange>
		{
			public override void Interp(MinMaxRange from, MinMaxRange to, float t)
			{
			}

			public MinMaxRangeParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class GlareStyleParameter : VolumeParameter<GlareStyle>
		{
			public override void Interp(GlareStyle from, GlareStyle to, float t)
			{
			}

			public GlareStyleParameter()
			{
				
			}
		}

		[Serializable]
		public sealed class LensFlareStyleParameter : VolumeParameter<LensFlareStyle>
		{
			public override void Interp(LensFlareStyle from, LensFlareStyle to, float t)
			{
			}

			public LensFlareStyleParameter()
			{
				
			}
		}

		public BoolParameter allowGeometryShaders;

		public BoolParameter allowComputeShaders;

		public RenderPriorityParameter renderPriority;

		public DebugViewParameter debugView;

		public QualityParameter quality;

		public AntiFlickerModeParameter antiFlickerMode;

		public WorkflowParameter workflow;

		public LayerMaskParameter selectiveRenderLayerMask;

		[Range(-1f, 1f)]
		public ClampedFloatParameter anamorphicRatio;

		[Range(0f, 1f)]
		public ClampedFloatParameter lumaScale;

		[Range(0f, 1f)]
		public ClampedFloatParameter blooming;

		[MinMaxRange(0f, 10f)]
		public MinMaxRangeParameter bloomThreshold;

		[Range(1f, 10f)]
		public ClampedFloatParameter bloomScattering;

		public FloatParameter bloomIntensity;

		public BoolParameter allowLensSurface;

		public Texture2DParameter lensSurfaceDirtTexture;

		public FloatParameter lensSurfaceDirtIntensity;

		public Texture2DParameter lensSurfaceDiffractionTexture;

		public FloatParameter lensSurfaceDiffractionIntensity;

		public BoolParameter allowLensFlare;

		public LensFlareStyleParameter lensFlareStyle;

		[Range(0f, 25f)]
		public ClampedFloatParameter lensFlareGhostFade;

		public FloatParameter lensFlareGhostIntensity;

		[MinMaxRange(0f, 10f)]
		public MinMaxRangeParameter lensFlareThreshold;

		[Range(0f, 8f)]
		public ClampedFloatParameter lensFlareScattering;

		public Texture2DParameter lensFlareColorRamp;

		[Range(-100f, 100f)]
		public ClampedFloatParameter lensFlareChromaticAberration;

		[Range(0f, 5f)]
		public ClampedIntParameter lensFlareGhostCount;

		[Range(-1f, 1f)]
		public ClampedFloatParameter lensFlareGhostDispersal;

		[Range(0f, 25f)]
		public ClampedFloatParameter lensFlareHaloFade;

		public FloatParameter lensFlareHaloIntensity;

		[Range(0f, 1f)]
		public ClampedFloatParameter lensFlareHaloSize;

		public BoolParameter allowGlare;

		[Range(0f, 1f)]
		public ClampedFloatParameter glareBlend;

		public FloatParameter glareIntensity;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareAngle;

		[MinMaxRange(0f, 10f)]
		public MinMaxRangeParameter glareThreshold;

		[Range(1f, 4f)]
		public ClampedIntParameter glareStreaks;

		[Range(0f, 4f)]
		public ClampedFloatParameter glareScattering;

		public GlareStyleParameter glareStyle;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample0Scattering;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareSample0Angle;

		public FloatParameter glareSample0Intensity;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample0Offset;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample1Scattering;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareSample1Angle;

		public FloatParameter glareSample1Intensity;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample1Offset;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample2Scattering;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareSample2Angle;

		public FloatParameter glareSample2Intensity;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample2Offset;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample3Scattering;

		[Range(0f, 360f)]
		public ClampedFloatParameter glareSample3Angle;

		public FloatParameter glareSample3Intensity;

		[Range(0f, 10f)]
		public ClampedFloatParameter glareSample3Offset;

		public bool IsActive()
		{
			return false;
		}

		public bool IsTileCompatible()
		{
			return false;
		}

		public bool GetAllowGeometryShaders()
		{
			return false;
		}

		public bool GetAllowComputeShaders()
		{
			return false;
		}

		public RenderPriority GetRenderPriority()
		{
			return default(RenderPriority);
		}

		public RenderPriority SetRenderPriority(RenderPriority TargetParameter)
		{
			return default(RenderPriority);
		}

		public DebugView GetDebugView()
		{
			return default(DebugView);
		}

		public Quality SetQuality(Quality InputQuality)
		{
			return default(Quality);
		}

		public Quality GetQuality()
		{
			return default(Quality);
		}

		public AntiFlickerMode GetAntiFlickerMode()
		{
			return default(AntiFlickerMode);
		}

		public Workflow GetWorkflow()
		{
			return default(Workflow);
		}

		public LayerMask GetSelectiveRenderLayerMask()
		{
			return default(LayerMask);
		}

		public float GetAnamorphicRatio()
		{
			return 0f;
		}

		public float GetLumaScale()
		{
			return 0f;
		}

		public float GetBlooming()
		{
			return 0f;
		}

		public MinMaxRange GetBloomThreshold()
		{
			return default(MinMaxRange);
		}

		public float GetBloomScattering()
		{
			return 0f;
		}

		public float GetBloomIntensity()
		{
			return 0f;
		}

		public bool GetAllowLensSurface()
		{
			return false;
		}

		public Texture2D GetLensSurfaceDirtTexture()
		{
			return null;
		}

		public float GetLensSurfaceDirtIntensity()
		{
			return 0f;
		}

		public Texture2D GetLensSurfaceDiffractionTexture()
		{
			return null;
		}

		public float GetLensSurfaceDiffractionIntensity()
		{
			return 0f;
		}

		public bool GetAllowLensFlare()
		{
			return false;
		}

		public LensFlareStyle GetLensFlareStyle()
		{
			return default(LensFlareStyle);
		}

		public float GetLensFlareGhostFade()
		{
			return 0f;
		}

		public float GetLensFlareGhostIntensity()
		{
			return 0f;
		}

		public MinMaxRange GetLensFlareThreshold()
		{
			return default(MinMaxRange);
		}

		public float GetLensFlareScattering()
		{
			return 0f;
		}

		public Texture2D GetLensFlareColorRamp()
		{
			return null;
		}

		public float GetLensFlareChromaticAberration()
		{
			return 0f;
		}

		public int GetLensFlareGhostCount()
		{
			return 0;
		}

		public float GetLensFlareGhostDispersal()
		{
			return 0f;
		}

		public float GetLensFlareHaloFade()
		{
			return 0f;
		}

		public float GetLensFlareHaloIntensity()
		{
			return 0f;
		}

		public float GetLensFlareHaloSize()
		{
			return 0f;
		}

		public void SetLensFlareGhostFade(float fade)
		{
		}

		public void SetLensFlareGhostCount(int count)
		{
		}

		public void SetLensFlareGhostDispersal(float dispersal)
		{
		}

		public void SetLensFlareHaloFade(float fade)
		{
		}

		public void SetLensFlareHaloSize(float size)
		{
		}

		public bool GetAllowGlare()
		{
			return false;
		}

		public float GetGlareBlend()
		{
			return 0f;
		}

		public float GetGlareIntensity()
		{
			return 0f;
		}

		public float GetGlareAngle()
		{
			return 0f;
		}

		public MinMaxRange GetGlareThreshold()
		{
			return default(MinMaxRange);
		}

		public int GetGlareStreaks()
		{
			return 0;
		}

		public void SetGlareStreaks(int count)
		{
		}

		public float GetGlareScattering()
		{
			return 0f;
		}

		public GlareStyle GetGlareStyle()
		{
			return default(GlareStyle);
		}

		public float GetGlareSample0Scattering()
		{
			return 0f;
		}

		public float GetGlareSample0Angle()
		{
			return 0f;
		}

		public float GetGlareSample0Intensity()
		{
			return 0f;
		}

		public float GetGlareSample0Offset()
		{
			return 0f;
		}

		public void SetGlareSample0Scattering(float scattering)
		{
		}

		public void SetGlareSample0Angle(float angle)
		{
		}

		public void SetGlareSample0Intensity(float intensity)
		{
		}

		public void SetGlareSample0Offset(float offset)
		{
		}

		public float GetGlareSample1Scattering()
		{
			return 0f;
		}

		public float GetGlareSample1Angle()
		{
			return 0f;
		}

		public float GetGlareSample1Intensity()
		{
			return 0f;
		}

		public float GetGlareSample1Offset()
		{
			return 0f;
		}

		public void SetGlareSample1Scattering(float scattering)
		{
		}

		public void SetGlareSample1Angle(float angle)
		{
		}

		public void SetGlareSample1Intensity(float intensity)
		{
		}

		public void SetGlareSample1Offset(float offset)
		{
		}

		public float GetGlareSample2Scattering()
		{
			return 0f;
		}

		public float GetGlareSample2Angle()
		{
			return 0f;
		}

		public float GetGlareSample2Intensity()
		{
			return 0f;
		}

		public float GetGlareSample2Offset()
		{
			return 0f;
		}

		public void SetGlareSample2Scattering(float scattering)
		{
		}

		public void SetGlareSample2Angle(float angle)
		{
		}

		public void SetGlareSample2Intensity(float intensity)
		{
		}

		public void SetGlareSample2Offset(float offset)
		{
		}

		public float GetGlareSample3Scattering()
		{
			return 0f;
		}

		public float GetGlareSample3Angle()
		{
			return 0f;
		}

		public float GetGlareSample3Intensity()
		{
			return 0f;
		}

		public float GetGlareSample3Offset()
		{
			return 0f;
		}

		public void SetGlareSample3Scattering(float scattering)
		{
		}

		public void SetGlareSample3Angle(float angle)
		{
		}

		public void SetGlareSample3Intensity(float intensity)
		{
		}

		public void SetGlareSample3Offset(float offset)
		{
		}
	}
}
