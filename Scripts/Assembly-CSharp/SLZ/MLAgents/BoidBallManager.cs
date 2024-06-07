using System;
using System.Runtime.CompilerServices;
using Unity.MLAgents;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidBallManager : MonoBehaviour
	{
		public delegate void OnProxChangeDelegate(float newVal);

		public delegate void OnGoalChangeDelegate(float newVal);

		public delegate void OnShotChangeDelegate(bool newVal);

		public delegate void OnSquishChangeDelegate(bool newVal);

		public bool debug_gizmos;

		private float prox_radius;

		public float prox_radius_min;

		public float prox_radius_max;

		private float goal_radius;

		public float goal_radius_min;

		public int rndm_freq;

		private int freq_counter;

		public bool rndm_prox_radius;

		public SphereCollider col;

		public bool rndm_move;

		public float max_speed;

		public float min_speed;

		public BoidBallMove ballMove;

		public bool strict_proximity;

		public float max_health;

		public float health;

		public float bullet_dmg;

		public bool use_projectiles;

		private bool being_shot;

		public Vector3 shot_normal;

		public float being_shot_cooldown;

		public float being_shot_interval;

		public float ball_hit_penalty;

		public SimpleMultiAgentGroup boidGroup;

		public int maxProjectileSteps;

		public int projectileEpisodeSteps;

		public bool use_group_reward;

		public bool env_params_set;

		public bool squish_mode;

		public float min_squish_distance;

		public bool assign_listeners;

		public float Prox_radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Goal_radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Being_shot
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Squish_mode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event OnProxChangeDelegate OnProxChange
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

		public event OnGoalChangeDelegate OnGoalChange
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

		public event OnShotChangeDelegate OnShotChange
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

		public event OnShotChangeDelegate OnSquishChange
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

		[HideInInspector]
		public event Action SetProxRadius
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

		public event Action SetGoalRadius
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

		private void OnDrawGizmos()
		{
		}

		public void RandomizeProxRadius()
		{
		}

		public void RandomizeGoalRadius()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void ProjectileHit()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
