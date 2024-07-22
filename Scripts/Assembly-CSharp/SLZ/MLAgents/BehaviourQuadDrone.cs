using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Navigation;
using PuppetMasta;
using SLZ.Bonelab;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;
using AsyncUniTaskVoidMethodBuilder = Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder;

namespace SLZ.MLAgents
{
	public class BehaviourQuadDrone : BehaviourGrabbableBaseNav
	{
		[CompilerGenerated]
		private sealed class _003CSelfDespawn_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourQuadDrone _003C_003E4__this;

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
			public _003CSelfDespawn_003Ed__48(int _003C_003E1__state)
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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTravelAlongPath_003Ed__104 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public BehaviourQuadDrone _003C_003E4__this;

			public CancellationToken cancellationToken;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		public GameObject rootParent;

		public Grip droneBodyGrip;

		public Grip droneJoyGrip;

		public bool joyHeld;

		public bool bodyHeld;

		public int ballGripCount;

		public int joyGripCount;

		public GameObject killEndVFX;

		public Spawnable despawnVFX;

		public Spawnable takeDmgVFX;

		private Vector3 _tempRotation;

		private Quaternion _cachedTurretRot;

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

		public BallThrustPointManager thrustMngr;

		public bool trackGrippedMass;

		public BoidBallMassChanger massChanger;

		public QuadDroneJoystick joyController;

		public bool useHeightCost;

		public bool useTerminalHeight;

		public bool useMinHeight;

		public float terminalHeight;

		public float minHeight;

		private Vector3 _tempPos;

		public bool drawGizmos;

		public float restHeight;

		public float roamHeight;

		public float roam_speed;

		public float roamLowerVelThresh;

		public float investigateHeight;

		public float investigateSpeed;

		public float agroHeight;

		public float agroSpeed;

		public float agroAwayPerc;

		public float agroTowardsPadding;

		public float agroAwayPadding;

		private float _currentAgroDistance;

		private Vector2 _toAgroTargetVector;

		public Vector3 spawnPos;

		public float yDistTeleportThresh;

		public Spawnable teleportVFX;

		public DoneTurretController turretController;

		private Vector3 _moveTargetPos;

		private SvoAgent _svoAgent;

		private HeightRangeCost _heightCost;

		public GameObject tempDebugObject;

		public float pathPointThreshold;

		private Vector3 _currentPathPoint;

		private bool _pathLocoStarted;

		private CancellationTokenSource _pathCancelToken;

		private RoamArea _currentRoamArea;

		private Vector3 _roamPos;

		private float _cachedHoverHeight;

		public float agroTickRate;

		public bool trackPlayerHeight;

		public bool trackHoverDistance;

		public float hoverDist;

		private Vector3 pathPointDir;

		public float orbitDistance;

		public RoamArea RoamArea
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Init()
		{
		}

		private void Start()
		{
		}

		private void AliveFuncs()
		{
		}

		protected override void OnInitiate()
		{
		}

		private void OnEnable()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		[ContextMenu("Force Kill")]
		public new void PuppetMasterKill()
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		private void DeadFuncs()
		{
		}

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__48))]
		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
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

		[ContextMenu("Force Roam")]
		public void ForceRoam()
		{
		}

		[ContextMenu("Force Path")]
		public void ForcePath()
		{
		}

		[ContextMenu("Force Sphere Hover")]
		public void ForceSphereHover()
		{
		}

		[ContextMenu("Get New Path")]
		public void GetNewPath()
		{
		}

		public void GetNewPath(Vector3 startPos, Vector3 endPos, bool replaceEndpoint = false)
		{
		}

		public void GoToNextPoint()
		{
		}

		[ContextMenu("Force Cancel Path Coroutine")]
		public void CancelPath()
		{
		}

		[AsyncStateMachine(typeof(_003CTravelAlongPath_003Ed__104))]
		private UniTaskVoid TravelAlongPath(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		private void SetTarget(Vector3 pos, Quaternion rot)
		{
		}

		private void SetPathPointDirection(Vector3 pos, Quaternion rot)
		{
		}

		protected override void AiUpdate()
		{
		}

		private Vector3 QueryRoamArea()
		{
			return default(Vector3);
		}

		public void DoRoam(Vector3 heightReference)
		{
		}

		protected override void AiTick()
		{
		}

		[ContextMenu("go to home")]
		private void GoToHome()
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

		private new void OnDrawGizmos()
		{
		}

		private void TeleportToClosestVoxel()
		{
		}

		private void TooLowTeleportCheck()
		{
		}

		private void TerminalHeightCheck()
		{
		}

		private void MinHeight()
		{
		}

		private void BufferDistanceCheck()
		{
		}

		private void OnBallGripAttached(Hand hand)
		{
		}

		private void OnBallGripDetached(Hand hand)
		{
		}

		private void OnJoyGripAttached(Hand hand)
		{
		}

		private void OnJoyGripDetached(Hand hand)
		{
		}

		public void DetatchGrip()
		{
		}

		[ContextMenu("Fix Spawn Rotation")]
		private void FixSpawnRotation()
		{
		}

		[ContextMenu("Force Buffer Distance")]
		private void ForceBuffer()
		{
		}
	}
}
