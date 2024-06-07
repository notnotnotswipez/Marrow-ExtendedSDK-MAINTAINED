using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgentsExamples;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidAgent_SlicedInference : InferenceAgent
	{
		private new string vector_obs_str;

		private float[] incomingActions;

		private Dictionary<string, float[]> lastActionDict;

		public int nb_updates;

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

		public override void Setup()
		{
		}

		public void Initialize()
		{
		}

		private new void Awake()
		{
		}

		public void OnEpisodeBegin()
		{
		}

		private void SetProxRadius(float prox_radius)
		{
		}

		private void SetGoalRadius(float goal_radius)
		{
		}

		private void SetSquishMode(bool squish_mode)
		{
		}

		private void SetBeingShot(bool being_shot)
		{
		}

		public override void OnActionReceived(Dictionary<string, float[]> actionBuffers)
		{
		}

		private void FixedUpdate()
		{
		}

		public override void CollectObservations()
		{
		}

		private void UpdateOrientationObjects()
		{
		}
	}
}
