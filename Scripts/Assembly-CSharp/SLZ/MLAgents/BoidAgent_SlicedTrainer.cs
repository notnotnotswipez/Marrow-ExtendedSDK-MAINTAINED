using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.MLAgentsExamples;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidAgent_SlicedTrainer : Agent
	{
		public int nb_updates;

		private int current_updates;

		private bool observation_ready;

		private ActionBuffers delayed_buffers;

		private OrientationCubeController orientation_cube;

		private BoidController boidController;

		private BoidSensor boidSensor;

		public BoidBallManager boidBallMngr;

		public float rotation_slerp_mod;

		public float move_mod;

		public Rigidbody _rb;

		private float roll;

		private float pitch;

		private float yaw;

		public bool use_cohesion;

		public bool use_alignment;

		public bool use_neighbor;

		public bool ep_rndm_start;

		private float ray_val;

		public bool log_losses;

		public bool log_cum_reward;

		private EnvironmentParameters envParams;

		public bool between_actions;

		private void Awake()
		{
		}


		public void MoveAgent(ActionSegment<int> act)
		{
		}

		private void FixedUpdate()
		{
		}

		private void TakeDelayedAction(ActionBuffers actionBuffers)
		{
		}

		private void AgentCollisionLoss()
		{
		}

		private void NonAgentCollisionLoss()
		{
		}

		private void UpdateOrientationObjects()
		{
		}
	}
}
