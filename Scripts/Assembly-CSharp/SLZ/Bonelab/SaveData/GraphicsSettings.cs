using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class GraphicsSettings : IGraphicsSettings, IFixFieldsIfNeeded
	{
		[JsonProperty("graphics_quality")]
		public GraphicsQuality GraphicsQuality
		{
			[CompilerGenerated]
			get
			{
				return default(GraphicsQuality);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("adaptive_resolution")]
		public bool AdaptiveResolution
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("texture_resolution")]
		public int TextureResolution
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("msaa")]
		public int MSAA
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("smaa")]
		public SettingLevel SMAA
		{
			[CompilerGenerated]
			get
			{
				return default(SettingLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("hbao")]
		public SettingLevel HBAO
		{
			[CompilerGenerated]
			get
			{
				return default(SettingLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("ssr")]
		public SettingLevel SSR
		{
			[CompilerGenerated]
			get
			{
				return default(SettingLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("shadow_cascade")]
		public int ShadowCascade
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("render_scale")]
		public int RenderScale
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("shadows")]
		public SettingLevel Shadows
		{
			[CompilerGenerated]
			get
			{
				return default(SettingLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("bloom")]
		public SettingLevel Bloom
		{
			[CompilerGenerated]
			get
			{
				return default(SettingLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("volumetrics")]
		public SettingLevel Volumetrics
		{
			[CompilerGenerated]
			get
			{
				return default(SettingLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("LOD_Bias")]
		public int LODBias
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("FoveatedRenderingMode")]
		public FoveatedRenderingMode FoveatedRenderingModeSetting
		{
			[CompilerGenerated]
			get
			{
				return default(FoveatedRenderingMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("FoveatedPreset")]
		public FoveatedPresets FoveatedPresetSetting
		{
			[CompilerGenerated]
			get
			{
				return default(FoveatedPresets);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("FoveatedOuterRadius")]
		public int FoveatedOuterRadius
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("FoveatedInnerRatio")]
		public int FoveatedInnerRatio
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("FoveatedSamplingAnisotropy")]
		public int FoveatedSamplingAnisotropy
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("EnableFoveatedRenderingMenu")]
		public bool EnableFoveatedRenderingMenu
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void FixFieldsIfNeeded()
		{
		}
	}
}
