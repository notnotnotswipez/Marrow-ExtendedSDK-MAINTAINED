using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidBallMove : MonoBehaviour
	{
		public float moveSpeed;

		public float spawnRadius;

		private Vector3 randomPos;

		public float height_min;

		public float height_max;

		public Vector3 newTargetPos;

		private float destThresh;

		public bool readyForDest;

		public bool active;

		public bool rndm_speed;

		public float min_speed;

		public float max_speed;

		public bool block_random_pos;

		public bool behaviour_mode;

		public GameObject phys_ref;

		public BallThrustPointManager thrustMngr;

		private void OnDrawGizmos()
		{
		}

		private void Start()
		{
		}

		public void MoveTargetToRandomPosition()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
