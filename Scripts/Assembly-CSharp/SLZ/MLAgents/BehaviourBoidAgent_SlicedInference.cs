using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BehaviourBoidAgent_SlicedInference : InferenceAgent
	{
		public BehaviourBoid behaviour;

		public float[] incomingActions;

		private InteractableHost _host;

		public int boidNumber;

		public BoidController boidController;

		public BoidSensor boidSensor;

		public Rigidbody _rb;

		private float roll;

		private float pitch;

		private float yaw;

		public bool use_cohesion;

		public bool use_alignment;

		public bool use_neighbor;

		public bool ep_rndm_start;

		public bool useHitObservations;

		private float ray_val;

		public bool log_losses;

		public bool log_cum_reward;

		private EnvironmentParameters envParams;

		public float use_alg;

		public bool override_track;

		public GameObject override_ref;

		public BehaviourBoidBall behaviourBoidBall;

		public event Action AgentInit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void UpdateTarget()
		{
		}

		public override void Setup()
		{
		}

		public void Initialize()
		{
		}

		protected override void Awake()
		{
		}

		public override void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnEpisodeBegin()
		{
		}

		public override void OnActionReceived()
		{
		}

		private void FixedUpdate()
		{
		}

		public override void CollectObservations()
		{
		}
	}
}
