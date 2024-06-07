using UnityEngine;

namespace SLZ.Data
{
	[CreateAssetMenu(fileName = "BoneLeaderData", menuName = "StressLevelZero / BoneLeader_Data", order = 1)]
	public class BoneLeaderData : ScriptableObject
	{
		public enum ScoreType
		{
			POINT = 0,
			TIME_IN_SECONDS = 1,
			TIME = 2,
			DISTANCE_IN_FOOT = 3,
			DISTANCE_IN_METER = 4,
			PERCENTAGE = 5
		}

		public string leaderboardTitle;

		public string apiTitle;

		public ScoreType scoreType;
	}
}
