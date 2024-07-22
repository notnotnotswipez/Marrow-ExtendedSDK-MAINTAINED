using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BehaviourBoid : BehaviourGrabbableBaseNav
	{
		[CompilerGenerated]
		private sealed class _003CBluntAttackStun_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourBoid _003C_003E4__this;

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
			public _003CBluntAttackStun_003Ed__54(int _003C_003E1__state)
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
		private sealed class _003CSelfDespawn_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourBoid _003C_003E4__this;

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
			public _003CSelfDespawn_003Ed__63(int _003C_003E1__state)
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
		private sealed class _003CSpoolCounter_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourBoid _003C_003E4__this;

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
			public _003CSpoolCounter_003Ed__88(int _003C_003E1__state)
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

		public Transform target;

		public Action emitForRecycle;

		public bool actionReady;

		public BehaviourBoidAgent_SlicedInference boidAgent;

		private int _armsLayer;

		private int _mSecAnim;

		private int _locoCycleAnim;

		private int _flinchAnim;

		private int _spinAttackAnim;

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

		public RigidBodyDamageDealer[] dmgDealers;

		public SubBehaviourIk ik;

		public bool useVFX;

		public GameObject throwVfx;

		public Spawnable despawnVFX;

		public bool findBehaviourBall;

		public float impulseDmgThresh;

		public float wayPointTime;

		public float wayPointCounter;

		public float bluntAttackTime;

		public float bluntAttackCounter;

		private BehaviourBoidBall behaviourBall;

		public InteractableHost intHost;

		public Grip grip;

		public Action DeInit;

		public InferenceAgent agent;

		public MentalState[] start_state_list;

		public int start_state_ind;

		private int trigger_layer;

		[Tooltip("Number bettween 0 and 1 for whether boid will attack each attack (behaviour) tick")]
		[Range(0f, 1f)]
		public float attackProbability;

		[Tooltip("Maximum amount of time the boid spools up during attack")]
		public float maxSpoolTime;

		[Tooltip("Min amount of time the boid spools up during attack")]
		public float minSpoolTime;

		private float attackDecision;

		private float desiredSpoolTime;

		private float currentSpoolTime;

		public float agroTickRate;

		public float agroAttackDistanceThresh;

		public float maxNoLocoTime;

		public float curNoLocoTime;

		public float minSpeedPercent;

		public bool spawnedFromBall;

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

		public event Action OnNewTarget
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

		public static BehaviourBoidBall FindBall(GameObject childObject)
		{
			return null;
		}

		private void Start()
		{
		}

		public void MlZoneCallbackResponse()
		{
		}

		protected override void OnInitiate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnReactivate(int phase = 0)
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

		protected override void OnUpdate()
		{
		}

		private void TakeDelayedAction()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		[IteratorStateMachine(typeof(_003CBluntAttackStun_003Ed__54))]
		private IEnumerator BluntAttackStun(float damage)
		{
			return null;
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		public void DetatchGrip()
		{
		}

		[ContextMenu("PuppetMasterKill")]
		protected override void PuppetMasterKill()
		{
		}

		public void RemovalFunctions()
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		protected override void ResetAnimator()
		{
		}

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__63))]
		public IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void Freeze()
		{
		}

		public override void Unfreeze()
		{
		}

		private void SetAgentActive()
		{
		}

		private void SetAgentInactive()
		{
		}

		protected override void AiUpdate()
		{
		}

		protected override void AiTick()
		{
		}

		[IteratorStateMachine(typeof(_003CSpoolCounter_003Ed__88))]
		private IEnumerator SpoolCounter()
		{
			return null;
		}

		protected override void SwitchMentalState(MentalState mState)
		{
		}

		protected override void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false)
		{
		}

		private new void RoamByMode()
		{
		}

		public void ForcePreAgro()
		{
		}

		protected override void ReturnToPreAgro()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public void ConnectToBoidBall(BehaviourBoidBall boidBall)
		{
		}

		private void ProcessDespawn()
		{
		}
	}
}
