using System;
using System.Collections.Generic;
using SLZ.Data;

namespace SLZ.Bonelab
{
	[Serializable]
	public class WaveProfile
	{
		public bool showWave;

		public bool showEnemies;

		public bool showFriendlies;

		public int maxConcurrent;

		public List<EnemyProfile> enemyProfilesList;

		public List<EnemyProfile> friendlyProfileList;

		public int hoiPoiChance;

		public bool showWaveLootItems;

		public List<ArenaLootItem> lootItems;

		public int bulletsPerEnemy;

		public int lightBulletAmount;

		public int medBulletAmount;

		public int heavyBulletAmount;

		public bool isProceduralWave;
	}
}
