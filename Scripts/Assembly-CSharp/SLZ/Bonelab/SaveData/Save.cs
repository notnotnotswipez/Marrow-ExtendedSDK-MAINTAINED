using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class Save : ISave<PlayerSettings, PlayerProgression, PlayerUnlocks>, IFixFieldsIfNeeded
	{
		[JsonProperty("version")]
		public int Version
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

		[JsonProperty("modified")]
		public string Modified
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("name")]
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("player_settings")]
		public PlayerSettings PlayerSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonIgnore]
		public PlayerUnlocks Unlocks
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("unlocks")]
		public string SerializedUnlocks
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonIgnore]
		public PlayerProgression Progression
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("progression")]
		public string SerializedProgression
		{
			[CompilerGenerated]
			get
			{
				return null;
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
