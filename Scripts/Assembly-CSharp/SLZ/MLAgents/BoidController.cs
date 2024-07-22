using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CChargeShot_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoidController _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CChargeShot_003Ed__114(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CPostLaunchCooldown_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoidController _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CPostLaunchCooldown_003Ed__115(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CWayPointCountdown_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoidController _003C_003E4__this;

			public TriggerRefProxy trp;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CWayPointCountdown_003Ed__119(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[Header("Reward Switches")]
		public bool use_passive_penalty;

		public bool use_radius_reward;

		public bool use_movement_loss;

		public bool use_ray_loss;

		public bool use_cohesion_loss;

		public bool use_alignment_loss;

		public bool use_neighbor_loss;

		public bool use_vel_loss;

		public BehaviourBoidAgent_SlicedInference agent;

		public Transform boidBall;

		public Rigidbody _rb;

		public float max_accel;

		public float max_speed;

		public float min_speed;

		public float rotation_slerp_mod;

		public bool log_losses;

		public bool alwaysForward;

		public Vector3 avg_pos;

		public Vector3 avg_alignment;

		public Vector3[] boidPositions;

		public float agentCollisionLoss;

		public float nonAgentCollisionLoss;

		public float bulletCollisionLoss;

		public float cohesion_loss_mod;

		public float personal_space_mod;

		public float alignment_loss_mod;

		public float avgvel_loss_mod;

		public float separation_loss_mod;

		public float neighbor_reward_mod;

		public float move_loss_mod;

		public float reflect_mod;

		public float out_of_radius_mod;

		public float in_radius_mod;

		public bool use_out_penalty;

		public bool out_penalty_on_attempt;

		public bool attempt_started;

		public float rayBumperMod;

		private float previous_speed;

		[HideInInspector]
		public BoidBallManager boidBallMngr;

		public float ray_length;

		public int rayMask;

		public int agentMask;

		public float max_lim;

		public float min_lim;

		public float min_prox_radius;

		public float goal_radius;

		public BoidSensor boidSensor;

		private RaycastHit hit;

		private bool collision_lockout;

		public bool disableMove;

		public bool zeroVelOnAction;

		public bool useSpoolUp;

		private float targetAngle;

		private Vector3 targetAxis;

		private Quaternion deltaQuat;

		private bool chargeRoutine;

		public float chargeForce;

		public float chargeRotateForce;

		public float chargeSpoolForce;

		public float chargeRotateDampenFactor;

		public bool debugCharge;

		public bool charging;

		public bool launch;

		public float chargeTime;

		private float postLaunchCooldown;

		public float postLaunchTime;

		public GameObject chargeTarget;

		public BoidBumper bumpers;

		private RaycastHit[] rayLossResults;

		private float norm_dist;

		private Vector3 norm_ball;

		private Vector3 norm_boid;

		private Vector3 ball_hit_vec;

		public bool debugInput;

		public float collisionStayTimer;

		public float collisionStayCur;

		public TriggerRefProxy waypointTrp;

		private int waypointInd;

		public bool seekingWaypoint;

		[HideInInspector]
		public event Action OnAgentCollision
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
		public event Action OnNonAgentCollision
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
		public event Action OnBulletCollision
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

		public void Reactivate()
		{
		}

		private float MinMaxNorm(float val, float max, float min)
		{
			return 0f;
		}

		private void OnDrawGizmos()
		{
		}

		public float RewardLoop(Agent agent, ActionSegment<int> actions)
		{
			return 0f;
		}

		public float PassivePenalty(int MaxStep)
		{
			return 0f;
		}

		public float RadiusReward()
		{
			return 0f;
		}

		public float BoidAlgLoss()
		{
			return 0f;
		}

		public float NeighborReward()
		{
			return 0f;
		}

		public float CohesionLoss()
		{
			return 0f;
		}

		public float AlignmentLoss()
		{
			return 0f;
		}

		public float AvgVelLoss()
		{
			return 0f;
		}

		public float PersonalSpaceLoss()
		{
			return 0f;
		}

		public float ProximityLoss()
		{
			return 0f;
		}

		public float MovementLoss(int moveVal)
		{
			return 0f;
		}

		public float RayLoss()
		{
			return 0f;
		}

		public float InVolumeLoss()
		{
			return 0f;
		}

		public Vector3 ProximityDelta()
		{
			return default(Vector3);
		}

		public Vector3 BallHitProximityDelta()
		{
			return default(Vector3);
		}

		public float HandleObsRay()
		{
			return 0f;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void OnCollisionStay(Collision collision)
		{
		}

		public void MoveAgent(float[] act)
		{
		}

		internal void SlowMoveVel(int dirToGo, int pitch, int roll, int yaw)
		{
		}

		public void Move(int dirToGo, int pitch, int roll, int yaw)
		{
		}

		[IteratorStateMachine(typeof(_003CChargeShot_003Ed__114))]
		private IEnumerator ChargeShot()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPostLaunchCooldown_003Ed__115))]
		public IEnumerator PostLaunchCooldown()
		{
			return null;
		}

		public void KillLaunch()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CWayPointCountdown_003Ed__119))]
		private IEnumerator WayPointCountdown(TriggerRefProxy trp)
		{
			return null;
		}

		public void SeekWaypoint()
		{
		}

		[ContextMenu("Force Next Waypoint")]
		public void ForceNextWaypoint()
		{
		}
	}
}
