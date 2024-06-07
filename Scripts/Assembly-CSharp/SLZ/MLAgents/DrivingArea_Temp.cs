using System.Collections.Generic;
using TMPro;
using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class DrivingArea_Temp : MonoBehaviour
	{
		public bool useObs;

		public GameObject obstical;

		public bool useJumps;

		public GameObject[] checkpointArray;

		public GameObject jump;

		private GameObject[] jumpArray;

		private List<GameObject> obsList;

		public GameObject spawn;

		public GameObject spawnArea;

		[Tooltip("The agent inside the area")]
		private EnvironmentParameters envParams;

		private float nb_obs;

		private float nb_zones;

		public float carRotation;

		public TextMeshPro cumulativeRewardText;

		public void ObsSpawner(GameObject cur_zone, GameObject next_zone)
		{
		}

		public void PlaceObstacles()
		{
		}

		private void BuildJumps()
		{
		}

		private void RotateJumps()
		{
		}

		private void RemoveAllObs()
		{
		}

		public void ResetArea()
		{
		}

		private void Start()
		{
		}
	}
}
