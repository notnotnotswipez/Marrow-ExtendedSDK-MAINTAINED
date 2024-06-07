using System;
using System.Collections.Generic;

namespace SLZ.Bonelab
{
	[Serializable]
	public class RoundProfile
	{
		public enum RoundMode
		{
			UNLIMITED = 0,
			LIMITED = 1
		}

		public bool showRound;

		public int waveDelayTime;

		public int roundDelayTime;

		public List<WaveProfile> waveGroupList;

		public RoundMode roundMode;

		public bool showRoundInfo;

		public int totalRoundLightCount;

		public int totalRoundMedCount;

		public int totalRoundHeavyCount;

		public int totalRoundEnemyCount;

		public int totalRoundBulletsPerEnemy;

		public bool isSlowHealthRegen;

		public float customHealthRegenDuration;

		public bool isProceduralRound;
	}
}
