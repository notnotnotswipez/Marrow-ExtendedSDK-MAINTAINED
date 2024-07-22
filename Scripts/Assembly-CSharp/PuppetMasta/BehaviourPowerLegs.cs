using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ;
using SLZ.Marrow.Data;
using SLZ.Marrow.Mechanics;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourPowerLegs : BehaviourGrabbableBaseNav
	{
		[Flags]
		public enum CombatType
		{
			WildPunch = 1,
			FistFight = 2
		}

		public enum GestureAnim
		{
			ChestBeat = 0,
			DeathThreat1 = 1,
			DeathThreat2 = 2,
			GroinTaunt = 3,
			ChickenTaunt = 4,
			MrUniverse = 5,
			Robot = 6,
			FacePalm = 7,
			HatTip = 8,
			Salute = 9,
			RaiseTheRoof = 10,
			Wave = 11
		}

		public enum EngagedMode
		{
			Mirror = 0,
			Follow = 1,
			Stay = 2,
			Hide = 3
		}

		[CompilerGenerated]
		private sealed class _003CSelfDespawn_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourPowerLegs _003C_003E4__this;

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
			public _003CSelfDespawn_003Ed__36(int _003C_003E1__state)
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
		private sealed class _003CTargetableUpdateRoutine_003Ed__95 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BehaviourPowerLegs _003C_003E4__this;

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
			public _003CTargetableUpdateRoutine_003Ed__95(int _003C_003E1__state)
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

		[Header("Biped Settings")]
		public SubBehaviourIk ik;

		public SubBehaviourFaceanim faceAnim;

		public SubBehaviourHandPose handPoser;

		public float scaleFactor;

		public GameObject throwVfx;

		public bool crumbleDeath;

		private LiteLoco _liteLoco;

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

		private int _neutral;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		private bool _footIkWasOn;

		private bool _debugDrawHierarchy;

		[Header("Agro State")]
		[EnumFlags]
		public CombatType combatProficiency;

		public CombatType agroState;

		public float meleeRange;

		public float desiredMeleeDistance;

		public float meleeCooldown;

		public TargetableAnimatorEvent WildPunchBigL;

		public TargetableAnimatorEvent WildPunchBigR;

		public TargetableAnimatorEvent WildPunchJabL;

		public TargetableAnimatorEvent WildPunchJabR;

		public TargetableAnimatorEvent Fist1PunchL;

		public TargetableAnimatorEvent Fist1PunchR;

		public TargetableAnimatorEvent Fist1MidUppercutL;

		public TargetableAnimatorEvent Fist1MidUppercutR;

		public TargetableAnimatorEvent Block;

		private float _cooldownMelee;

		private float _meleeActiveUntilTime;

		private float _throwReleaseTime;

		private TargetableAnimatorEvent _activeTargetableEvent;

		private bool _blockActive;

		private bool _throwActive;

		private Collider[] _colliders;

		private int _interactableLayer;

		public Spawnable spawnable;

		public float throwSpeed;

		public float throwGap;

		public EnemyPoseData standingIdle;

		[Range(0f, 16f)]
		public float restingActivateRange;

		public float jumpCooldown;

		public float jumpCharge;

		public bool getUpWhileResting;

		private Vector3 _lookDirectionWorld;

		private bool _blockAiTick;

		private bool _isCalculated;

		private float _dyingTime;

		private float _unbalancedTimer;

		private int _getUpCount;

		private int _lifetimeGetups;

		[Tooltip("Called when the character starts getting up from a prone pose (facing down).")]
		public AnimatorEvent[] onGetUpProne;

		[Tooltip("Called when the character starts getting up from a supine pose (facing up).")]
		public AnimatorEvent[] onGetUpSupine;

		public GameObject IKPunchGameObject;

		public bool isOverrideOn;

		public LocoController aiLocoController;

		public bool useAiLocoController;

		[Header("Engaged State")]
		public EngagedMode engagedMode;

		public float desiredDistance;

		public bool followPlayer;

		public float engagedSpeed;

		public float breakEngagedTargetDistance;

		public float breakEngagedHomeDistance;

		[Range(0f, 1f)]
		public float mirrorSkill;

		private Vector3 _mirrorLeftDir;

		private Vector3 _mirrorRightDir;

		private Vector3 _lastMirrorLeftDir;

		private Vector3 _lastMirrorRightDir;

		private Vector3 _lastMirrorLeftTrainer;

		private Vector3 _lastMirrorRightTrainer;

		private Quaternion _mirrorLfQuat;

		private Quaternion _mirrorRtQuat;

		private Quaternion _lastMirrorLfQuat;

		private Quaternion _lastMirrorRtQuat;

		private float _t;

		private float _gestureCooldown;

		public bool BlockActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnInitiate()
		{
		}

		public new void BlockCollisions(float blockTime)
		{
		}

		public void SwitchLocoStateForLinking(LocoState lState, float coolDown = 0f, bool forceSwitch = false)
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
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

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__36))]
		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void Freeze()
		{
		}

		public override void Unfreeze()
		{
		}

		protected override void Awake()
		{
		}

		private void SwitchAgroState()
		{
		}

		private void TriggerAttack()
		{
		}

		private void UpdateTargetableEvent()
		{
		}

		private void ProcessTargetRelativePathing(float idealDistance, float nearBuffer, float farBuffer)
		{
		}

		public void Throw()
		{
		}

		[ContextMenu("ContextBlockAnim")]
		private void ContextBlockAnim()
		{
		}

		[ContextMenu("ContextAttack")]
		private void ContextAttack()
		{
		}

		[ContextMenu("StopContextAttack")]
		private void StopContextAttack()
		{
		}

		[IteratorStateMachine(typeof(_003CTargetableUpdateRoutine_003Ed__95))]
		private IEnumerator TargetableUpdateRoutine()
		{
			return null;
		}

		[ContextMenu("ContextBlock")]
		private void ContextBlock()
		{
		}

		protected override void AiUpdate()
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

		public void UpdateUprightUsage()
		{
		}

		public void IkFootToggle(bool ikOn)
		{
		}

		protected override void ReturnToPreAgro()
		{
		}

		private void SwitchEngagedState(EngagedMode newEngagedMode, bool enteringEngaged = false)
		{
		}

		public void UpdateEngagedFrame()
		{
		}

		public void UpdateEngagedTick()
		{
		}

		public void UpdateMirrorTick()
		{
		}

		public void TriggerGesture(int index)
		{
		}

		public void TriggerGesture(GestureAnim gestureAnim)
		{
		}

		private void UpdateMirrorFrame()
		{
		}

		public void SetGestureCooldown(float time)
		{
		}
	}
}
