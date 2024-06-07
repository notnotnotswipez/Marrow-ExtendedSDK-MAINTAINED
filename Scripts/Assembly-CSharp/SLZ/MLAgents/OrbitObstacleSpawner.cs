using System.Collections.Generic;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class OrbitObstacleSpawner : MonoBehaviour
	{
		public BoidBallManager boidBallMngr;

		public GameObject[] obstacleArray;

		public int nb_obs_in_orbit;

		public int orbit_despawn_cooldown;

		private int cooldown_counter;

		public List<GameObject> spawnedObs;

		public float max_scale;

		private void Start()
		{
		}

		private void ResetObsCloud()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
