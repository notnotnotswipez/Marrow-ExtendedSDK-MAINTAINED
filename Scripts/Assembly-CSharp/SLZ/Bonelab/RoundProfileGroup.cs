using System.Collections.Generic;
using SLZ.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RoundProfileGroup : ScriptableObject
	{
		public enum ArenaGameMode
		{
			SURVIVAL = 0,
			CHALLENGE = 1,
			CUSTOM = 2,
			PROTECT = 3,
			WEAPON = 4,
			INSTA_DEATH = 5,
			KING_OF_THE_HILL = 6
		}

		public List<RoundProfile> roundProfileList;

		public ArenaGameMode arenaGameMode;

		public bool isObjectiveMode;

		public bool isStacked;

		public bool clearAmmoOnModeEnd;

		public bool isCustomEnemyCount;

		public int increaseEnemyRate;

		public int maxConcGoal;

		public int killLimit;

		public bool limitReached;

		public bool awardAmmoOnDeath;

		public int lightAward;

		public int medAward;

		public int heavyAward;

		public float teleportTick;

		public float teleportDist;

		public string displayTitle;

		public string descriptionText;

		public int friendlyCount;

		public int enemySpawnDelay;

		public int friendlySpawnDelay;

		public int objectiveRespawnDelay;

		public bool sublimateOnDeath;

		public Arena_TrialsProfile trialProfile;

		public bool showGroupInfo;

		public bool showGroupGraph;

		public int totalGroupLightCount;

		public int totalGroupMedCount;

		public int totalGroupHeavyCount;

		public int totalGroupBulletCount;

		public int totalGroupEnemyCount;

		public int totalGroupBulletsPerEnemy;

		public RoundProfile currRound;

		public WaveProfile currWave;

		public EnemyProfile currEnemy;

		public BoneLeaderData boneLeaderData;

		public static EnemyProfile RandomFromWave(List<EnemyProfile> waveProfileList)
		{
			return null;
		}

		public static EnemyProfile RandomFromWaveWeighted(List<EnemyProfile> waveProfileList)
		{
			return null;
		}

		public static EnemyProfile RandomCrabOrNull()
		{
			return null;
		}

		public static EnemyProfile RandomEnemyProfile()
		{
			return null;
		}

		public static EnemyProfile RandomEasyEnemyProfile()
		{
			return null;
		}

		public static EnemyProfile RandomMedEnemyProfile()
		{
			return null;
		}

		public static EnemyProfile RandomHardEnemyProfile()
		{
			return null;
		}

		public static ArenaLootItem RandomBladeLootWeapon()
		{
			return null;
		}

		public static ArenaLootItem RandomBluntLootWeapon()
		{
			return null;
		}

		public static ArenaLootItem RandomPistolLootWeapon()
		{
			return null;
		}

		public static ArenaLootItem RandomSMGLootWeapon()
		{
			return null;
		}

		public static ArenaLootItem RandomRifleLootWeapon()
		{
			return null;
		}

		public static ArenaLootItem RandomShotgunLootWeapon()
		{
			return null;
		}

		public static WaveProfile CopyWaveProfile(WaveProfile ogWaveProfile, bool randLoot = false)
		{
			return null;
		}

		public static RoundProfile CopyRoundProfile(RoundProfile ogRoundProfile, bool randLoot = false)
		{
			return null;
		}

		public static RoundProfileGroup CopyGroupProfile(RoundProfileGroup ogGroup)
		{
			return null;
		}

		public static RoundProfile CreateDefaultRound(bool addRandomLoot = false)
		{
			return null;
		}

		public static RoundProfileGroup UpdateCustomGroup(RoundProfileGroup customRoundGroup, ArenaMenuController menu, List<EnemyProfile> enemyList)
		{
			return null;
		}

		public static RoundProfileGroup CreateCustomRound(int waveCount, int lightBulletCount, int medBulletCount, int enemyCount, int maxConcurrent, List<EnemyProfile> enemyList)
		{
			return null;
		}

		public static int CalcWaveBPE(WaveProfile wave)
		{
			return 0;
		}

		public static int CalcRoundBPE(RoundProfile round)
		{
			return 0;
		}

		public static WaveProfile IncreaseWaveDifficulty(WaveProfile wave, int difficulty, int maxConcurrentLimit, int round = 1, bool randomEnemyType = false)
		{
			return null;
		}

		public static WaveProfile IncreaseWaveDifficultyAtCustomRate(RoundProfileGroup group, WaveProfile wave)
		{
			return null;
		}

		public static RoundProfile IncreaseRoundDifficulty(RoundProfile roundProfile, int difficulty, int maxConcurrentLimit, int round = 1)
		{
			return null;
		}

		public static RoundProfileGroup IncreaseGroupDifficulty(RoundProfileGroup group, int difficulty, int maxConcurrentLimit)
		{
			return null;
		}

		public static RoundProfileGroup IncreaseConcurrentEnemyCount(RoundProfileGroup group, int maxConcurrent, bool updateEnemyProfiles)
		{
			return null;
		}

		public static RoundProfileGroup IncreaseProfilesToMatchConcurrent(RoundProfileGroup group)
		{
			return null;
		}

		public static void CreateSurvivalProfileAtRound(RoundProfileGroup OGsurivalProfile, RoundProfileGroup surivalProfileProjected, int round, int maxEnemy, int difficulty)
		{
		}
	}
}
