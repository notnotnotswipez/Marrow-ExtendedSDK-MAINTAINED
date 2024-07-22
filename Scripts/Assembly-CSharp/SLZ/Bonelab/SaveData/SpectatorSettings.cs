using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class SpectatorSettings : ISpectatorSettings, IFixFieldsIfNeeded
	{
		[JsonProperty("eye_output")]
		public EyeTarget EyeOutput
		{
			[CompilerGenerated]
			get
			{
				return default(EyeTarget);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("spectator_camera_mode")]
		public SpectatorCameraMode SpectatorCameraMode
		{
			[CompilerGenerated]
			get
			{
				return default(SpectatorCameraMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("resolution_x")]
		public int ResolutionX
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

		[JsonProperty("resolution_y")]
		public int ResolutionY
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

		public void FixFieldsIfNeeded()
		{
		}
	}
}
