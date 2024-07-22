using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class PlayerSettings : IPlayerSettings
	{
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

		[JsonProperty("inventory_hud_enabled")]
		public bool InventoryHudEnabled
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

		[JsonProperty("tooltips_enabled")]
		public bool TooltipsEnabled
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

		[JsonProperty("haptics")]
		public float Haptics
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("right_handed")]
		public bool RightHanded
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

		[JsonProperty("locomotion_curve")]
		public int LocomotionCurve
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

		[JsonProperty("locomotion_degrees_per_snap")]
		public float LocomotionDegreesPerSnap
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("locomotion_direction")]
		public int LocomotionDirection
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

		[JsonProperty("locomotion_snap_degrees_per_frame")]
		public int LocomotionSnapDegreesPerFrame
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

		[JsonProperty("player_height")]
		public float PlayerHeight
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("measurement_presets")]
		public BodyVitals.MeasurementState MeasurementPresets
		{
			[CompilerGenerated]
			get
			{
				return default(BodyVitals.MeasurementState);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("chest_circumference")]
		public float ChestCircumference
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("underbust_circumference")]
		public float UnderbustCircumference
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("waist_circumference")]
		public float WaistCircumference
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("hips_circumference")]
		public float HipsCircumference
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("wingspan_length")]
		public float WingspanLength
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("inseam_length")]
		public float InseamLength
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("offset_sitting")]
		public float OffsetSitting
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("offset_floor")]
		public float OffsetFloor
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("standing")]
		public bool Standing
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

		[JsonProperty("belt_location_right")]
		public bool BeltLocationRight
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

		[JsonProperty("body_log_location_right")]
		public bool BodyLogLocationRight
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

		[JsonProperty("volume_global")]
		public float VolumeGlobal
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("volume_music")]
		public float VolumeMusic
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("volume_sfx")]
		public float VolumeSFX
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("fallback_avatar")]
		public string FallbackAvatar
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

		[JsonProperty("current_avatar")]
		public string CurrentAvatar
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

		[JsonProperty("favorite_avatars")]
		public List<string> FavoriteAvatars
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

		[JsonProperty("favorite_spawnables")]
		public List<string> FavoriteSpawnables
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
