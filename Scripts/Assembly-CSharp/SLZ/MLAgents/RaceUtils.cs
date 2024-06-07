using UnityEngine;

namespace SLZ.MLAgents
{
	public class RaceUtils : MonoBehaviour
	{
		public Vector3 GetLineUpPosition(int i, float start_distance, float spacing, float offset_spacing, GameObject temp_contestant, TrackClass trackClass, float extraY = 0f)
		{
			return default(Vector3);
		}

		public void RegisterContestant(ref RaceTaskContestant temp_contestant, GameObject temp_vehicle, int c, TrackClass trackClass)
		{
		}

		public float SplitTime(TrackRaceTaskClass raceClass, int checkpointCounter, float cp_time)
		{
			return 0f;
		}
	}
}
