using UnityEngine;

namespace MK.Glow
{
	internal abstract class Settings
	{
		protected bool _allowGeometryShaders;

		protected bool _allowComputeShaders;

		protected RenderPriority _renderPriority;

		protected DebugView _debugView;

		protected Quality _quality;

		protected AntiFlickerMode _antiFlickerMode;

		protected Workflow _workflow;

		protected LayerMask _selectiveRenderLayerMask;

		protected float _anamorphicRatio;

		protected float _lumaScale;

		protected float _blooming;

		protected MinMaxRange _bloomThreshold;

		protected float _bloomScattering;

		protected float _bloomIntensity;

		protected bool _allowLensSurface;

		protected Texture2D _lensSurfaceDirtTexture;

		protected float _lensSurfaceDirtIntensity;

		protected Texture2D _lensSurfaceDirtDistortionTexture;

		protected float _lensSurfaceDirtDistortion;

		protected Texture2D _lensSurfaceDiffractionTexture;

		protected float _lensSurfaceDiffractionIntensity;

		protected bool _allowLensFlare;

		protected LensFlareStyle _lensFlareStyle;

		protected float _lensFlareGhostFade;

		protected float _lensFlareGhostIntensity;

		protected MinMaxRange _lensFlareThreshold;

		protected float _lensFlareScattering;

		protected Texture2D _lensFlareColorRamp;

		protected float _lensFlareChromaticAberration;

		protected int _lensFlareGhostCount;

		protected float _lensFlareGhostDispersal;

		protected float _lensFlareHaloFade;

		protected float _lensFlareHaloIntensity;

		protected float _lensFlareHaloSize;

		protected bool _allowGlare;

		protected float _glareBlend;

		protected float _glareIntensity;

		protected float _glareAngle;

		protected MinMaxRange _glareThreshold;

		protected int _glareStreaks;

		protected float _glareScattering;

		protected GlareStyle _glareStyle;

		protected float _glareSample0Scattering;

		protected float _glareSample0Angle;

		protected float _glareSample0Intensity;

		protected float _glareSample0Offset;

		protected float _glareSample1Scattering;

		protected float _glareSample1Angle;

		protected float _glareSample1Intensity;

		protected float _glareSample1Offset;

		protected float _glareSample2Scattering;

		protected float _glareSample2Angle;

		protected float _glareSample2Intensity;

		protected float _glareSample2Offset;

		protected float _glareSample3Scattering;

		protected float _glareSample3Angle;

		protected float _glareSample3Intensity;

		protected float _glareSample3Offset;

		internal bool allowGeometryShaders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool allowComputeShaders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal RenderPriority renderPriority
		{
			get
			{
				return default(RenderPriority);
			}
			set
			{
			}
		}

		internal DebugView debugView
		{
			get
			{
				return default(DebugView);
			}
			set
			{
			}
		}

		internal Quality quality
		{
			get
			{
				return default(Quality);
			}
			set
			{
			}
		}

		internal AntiFlickerMode antiFlickerMode
		{
			get
			{
				return default(AntiFlickerMode);
			}
			set
			{
			}
		}

		internal Workflow workflow
		{
			get
			{
				return default(Workflow);
			}
			set
			{
			}
		}

		internal LayerMask selectiveRenderLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		internal float anamorphicRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float lumaScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float blooming
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal MinMaxRange bloomThreshold
		{
			get
			{
				return default(MinMaxRange);
			}
			set
			{
			}
		}

		internal float bloomScattering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float bloomIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal bool allowLensSurface
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal Texture2D lensSurfaceDirtTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float lensSurfaceDirtIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal Texture2D lensSurfaceDirtDistortionTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float lensSurfaceDirtDistortion
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal Texture2D lensSurfaceDiffractionTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float lensSurfaceDiffractionIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal bool allowLensFlare
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal LensFlareStyle lensFlareStyle
		{
			get
			{
				return default(LensFlareStyle);
			}
			set
			{
			}
		}

		internal float lensFlareGhostFade
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float lensFlareGhostIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal MinMaxRange lensFlareThreshold
		{
			get
			{
				return default(MinMaxRange);
			}
			set
			{
			}
		}

		internal float lensFlareScattering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal Texture2D lensFlareColorRamp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal float lensFlareChromaticAberration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal int lensFlareGhostCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal float lensFlareGhostDispersal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float lensFlareHaloFade
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float lensFlareHaloIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float lensFlareHaloSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal bool allowGlare
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal float glareBlend
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal MinMaxRange glareThreshold
		{
			get
			{
				return default(MinMaxRange);
			}
			set
			{
			}
		}

		internal int glareStreaks
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal float glareScattering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal GlareStyle glareStyle
		{
			get
			{
				return default(GlareStyle);
			}
			set
			{
			}
		}

		internal float glareSample0Scattering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample0Angle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample0Intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample0Offset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample1Scattering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample1Angle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample1Intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample1Offset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample2Scattering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample2Angle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample2Intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample2Offset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample3Scattering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample3Angle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample3Intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float glareSample3Offset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal void SetLensFlarePreset(LensFlareStyle lensFlareStyle)
		{
		}

		internal void SetGlarePreset(GlareStyle glareStyle)
		{
		}
	}
}
