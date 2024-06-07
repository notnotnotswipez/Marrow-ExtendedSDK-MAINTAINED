using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.Bonelab
{
	[Serializable]
	public class Arena_DataPlayer
	{
		[JsonProperty("is_new_save_file")]
		public bool isNewSaveFile;

		[JsonProperty("player_stats")]
		public Arena_Player_Stats playerStats;

		[JsonProperty("challenge_profile_list")]
		public List<Arena_TrialsProfile> challengeProfileList;
	}
}
