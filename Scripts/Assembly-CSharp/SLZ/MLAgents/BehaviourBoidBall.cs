using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Zones;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.MLAgents
{
	public class BehaviourBoidBall : BehaviourGrabbableBaseNav
	{
		public delegate void OnSquishChangeDelegate(bool newVal);

		public delegate void OnProxChangeDelegate(float newVal);

		public delegate void OnGoalChangeDelegate(float newVal);

		public delegate void OnShotChangeDelegate(bool newVal);

		[CompilerGenerated]
		private sealed class _003CSelfDespawn_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourBoidBall _003C_003E4__this;

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
			public _003CSelfDespawn_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CBallRadiusStateController_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourBoidBall _003C_003E4__this;

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
			public _003CBallRadiusStateController_003Ed__133(int _003C_003E1__state)
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

		[Header("----BoidBall Section Start----")]
		[Tooltip("Shows the debug graphics for the radii and thrusters")]
		public bool debug_gizmos;

		[Tooltip("Config file containing radii and height/speed for ball for each mental state")]
		public BehaviourBoidBallConfig ballConfig;

		[Header("----BoidBall Spawn and Teleport Section----")]
		[Tooltip("Reference to script that is utilizing thrusters to move ball to desired positition")]
		public BoidBallMove ballMover;

		[Tooltip("Use teleport ball to if it goes to low")]
		public bool useTeleport;

		[Tooltip("Position to teleport ball to if it goes to low")]
		public Vector3 teleportToPos;

		[Tooltip("How low till teleport is initiated")]
		public float yDistTeleportThresh;

		[Tooltip("VFX to use when teleport happens")]
		public Spawnable teleportVFX;

		[Tooltip("Used when ball is aggro and moving away from player")]
		private Vector3 moveTargetPos;

		[Tooltip("Move the ball when the player gets within this range")]
		public float distFromPlayerMove;

		[Header("----BoidBall Despawn Section----")]
		public bool useVFX;

		public Spawnable despawnVFX;

		private Poolee _despawnPoolee;

		public Spawnable boidSpawnVFX;

		public Spawnable takeDmgVFX;

		public Action behaviourDead;

		private int _armsLayer;

		private int _mSecAnim;

		private int _locoCycleAnim;

		private int _flinchAnim;

		private int _angryAnim;

		private int _awakeAnim;

		private int _unGroundedAnim;

		private int _emissColor;

		private int _attackAnim;

		private int _clipIntAnim;

		private int _gestureAnim;

		private int _deathAnim;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		[Header("----BoidBall Deal Damage Section----")]
		[Tooltip("This allows the radii to lerp between min and max values")]
		public RigidBodyDamageDealer[] dmgDealers;

		[Header("----Mental State Section----")]
		[Tooltip("Rate is multiplied by current health")]
		public float agroTickRate;

		public float waypointAgroTime;

		[Tooltip("Current Outer Radius Value")]
		private float prox_radius;

		[Tooltip("Outer Radius Min")]
		public float prox_radius_min;

		[Tooltip("Outer Radius Max")]
		public float prox_radius_max;

		[Tooltip("Current Inner Radius Value")]
		private float goal_radius;

		[Tooltip("Inner Radius Min")]
		public float goal_radius_min;

		[Tooltip("Inner Radius Max")]
		public float goal_radius_max;

		[Tooltip("Min speed of radius min/max transition")]
		public float state_lerp_rate_min;

		[Tooltip("Max speed of radius min/max transition")]
		public float state_lerp_rate_max;

		[Tooltip("This allows the radii to lerp between min and max values")]
		public bool useRadiusController;

		public float rest_goal_min;

		public float rest_goal_max;

		public float rest_prox_min;

		public float rest_prox_max;

		public float rest_lerp_speed_min;

		public float rest_lerp_speed_max;

		public float rest_height;

		public float roam_goal_min;

		public float roam_goal_max;

		public float roam_prox_min;

		public float roam_prox_max;

		public float roam_lerp_speed_min;

		public float roam_lerp_speed_max;

		public float roam_height;

		public float investigate_goal_min;

		public float investigate_goal_max;

		public float investigate_prox_min;

		public float investigate_prox_max;

		public float investigate_lerp_speed_min;

		public float investigate_lerp_speed_max;

		public float investigate_height;

		public float agro_goal_min;

		public float agro_goal_max;

		public float agro_prox_min;

		public float agro_prox_max;

		public float agro_lerp_speed_min;

		public float agro_lerp_speed_max;

		public float agro_height;

		private bool prox_decreasing;

		private bool goal_decreasing;

		private bool decreasing;

		private float lerp_scale;

		private bool squish_mode;

		[Header("----Boid Specific Section----")]
		public MobileEncounter boidEncounter;

		public int nbTotalBoids;

		public int nbBoidsRest;

		public int nbBoidsRoam;

		public int nbBoidsInvestigate;

		public int nbBoidsAgro;

		[Tooltip("Make boids listen for ball update events")]
		public bool assign_listeners;

		public List<BehaviourBoid> boidList;

		public List<BehaviourBoid> dispatchedList;

		[Range(0f, 1f)]
		[Tooltip("The probability of a boid being selected during dispatch (each agro tick)")]
		public float dispatchRate;

		[Tooltip("Percentage of dispatched boids to call back each tick")]
		public float recallPercentage;

		[Header("----BoidBall Take Damage Section----")]
		public float being_shot_cooldown;

		public float being_shot_interval;

		private bool being_shot;

		public Vector3 shot_normal;

		public SkinnedMeshRenderer meshRenderer;

		public SphereCollider ballCollider;

		public SphereGrip sphereGrip;

		public float maxColliderRad;

		public float minColliderRad;

		private int nbBoidsSpawned;

		public UnityEvent KillBoidsSignal;

		public MentalState MState
		{
			get
			{
				return default(MentalState);
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

		public event Action Death
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

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		private void AliveFuncs()
		{
		}

		[ContextMenu("PuppetMasterKill")]
		protected override void PuppetMasterKill()
		{
		}

		private void DeathEffects(GameObject go)
		{
		}

		public override void KillStart()
		{
		}

		private void DeadFuncs()
		{
		}

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__41))]
		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void KillEnd()
		{
		}

		private void FixedUpdate()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		protected override void ResetAnimator()
		{
		}

		public override void Freeze()
		{
		}

		public override void Unfreeze()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		public override void OnPoolSpawn()
		{
		}

		public override void OnPoolDeInitialize()
		{
		}

		private new void OnDrawGizmos()
		{
		}

		private void Start()
		{
		}

		protected override void AiUpdate()
		{
		}

		[ContextMenu("Manual Investigate")]
		public void ManualInvestigate()
		{
		}

		private void SetTarget(Vector3 pos, Quaternion rot)
		{
		}

		private new void RoamByMode()
		{
		}

		protected override void AiTick()
		{
		}

		protected override void SwitchMentalState(MentalState mState)
		{
		}

		protected override void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false)
		{
		}

		protected override void ReturnToPreAgro()
		{
		}

		[IteratorStateMachine(typeof(_003CBallRadiusStateController_003Ed__133))]
		public IEnumerator BallRadiusStateController()
		{
			return null;
		}

		private void InitEncounter()
		{
		}

		[ContextMenu("KillBallAndBoids")]
		private void KillBallAndBoids()
		{
		}

		private void StopEncounter()
		{
		}

		private void SetNbBoids(int nbBoids)
		{
		}

		private void ProcessGroupSpawn(GameObject go, SpawnGroup group)
		{
		}

		private void BoidSpawnBallRescale()
		{
		}

		private void ProcessBoidSpawn(BehaviourBoid boid)
		{
		}

		private void DispatchHandler(TriggerRefProxy triggerRef)
		{
		}

		private void RecallBoids()
		{
		}

		public void ProcessDespawn()
		{
		}

		private void HandleBeingShot()
		{
		}
	}
}
