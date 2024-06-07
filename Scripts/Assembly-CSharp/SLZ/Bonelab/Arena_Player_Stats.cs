using System;
using Newtonsoft.Json;

namespace SLZ.Bonelab
{
	[Serializable]
	public class Arena_Player_Stats
	{
		[JsonProperty("survival_round_reached")]
		public int survivalRoundReached;

		[JsonProperty("survival_time_reached")]
		public float survivalTimeReached;

		[JsonProperty("total_bullets_fired_from_all_maps")]
		public int totalBulletsFiredFromAllWeps;

		[JsonProperty("total_enemy_kills")]
		public int totalEnemyKills;

		[JsonProperty("total_player_deaths")]
		public int totalPlayerDeaths;

		[JsonProperty("imminent_deaths")]
		public int imminentDeaths;

		[JsonProperty("imminent_death_saves")]
		public int imminentDeathSaves;

		[JsonProperty("damage_taken")]
		public float damageTaken;

		[JsonProperty("damage_dealt")]
		public float damageDealt;

		[JsonProperty("total_alive_hits")]
		public int totalAliveHits;

		[JsonProperty("favorite_ranged_weapon")]
		public string favoriteRangedWeapon;

		[JsonProperty("challenge_points")]
		public int challengePoints;

		[JsonProperty("is_low_enemy_count")]
		public bool isLowEnemyCount;

		[JsonProperty("total_headshots")]
		public int totalHeadshots;
	}
}
