using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using SLZ.Marrow.Mechanics;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BehaviourCrablet : BehaviourGrabbableBaseNav
	{
		protected enum JumpType
		{
			Dash = 0,
			Attack = 1,
			FaceMount = 2,
			OffmeshLink = 3
		}

		[CompilerGenerated]
		private sealed class _003CSelfDespawn_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourCrablet _003C_003E4__this;

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
			public _003CSelfDespawn_003Ed__21(int _003C_003E1__state)
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

		[Header("Crab Settings")]
		public SubBehaviourIk ik;

		private LiteLoco _liteLoco;

		private int _mSecAnim;

		private int _flinchAnim;

		private int _angryAnim;

		private int _awakeAnim;

		private int _heldAnim;

		private int _jumpAttackAnim;

		private int _faceHugAnim;

		private int _standingAnim;

		private int _jumpChargeAnim;

		private int _jumpAnim;

		private int _faceHugNormalAnim;

		private int _faceMountAnim;

		private int _dismountAnim;

		private float linkJumpForce;

		private Vector3 linkTarget;

		public bool crumbleDeath;

		private bool _hasAttacked;

		private bool _jumpAttacking;

		private Collider[] _colliders;

		private int _interactableLayer;

		private int _triggerLayer;

		private ConfigurableJoint _faceJoint;

		private readonly Vector3 _testRotationOffset;

		private readonly Vector3 _testRotationOffsetNpc;

		private readonly Vector3 _testPositionOffset;

		private readonly Vector3 _crabMouthLocalOffset;

		protected JumpType jumpType;

		public float jumpCooldown;

		private float jumpCharge;

		public bool enableJumpAttack;

		public float facemountRngMult;

		public MeshRenderer visor;

		public SlotPosition slotPosition;

		private bool _chargeJump;

		private bool _headMounted;

		private float _mountDamageTickTime;

		private float _cooldownMelee;

		private TriggerRefProxy _grappleTarget;

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public override void KillStart()
		{
		}

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__21))]
		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void KillEnd()
		{
		}

		protected override void RestoreFromCrumbleDeath()
		{
		}

		protected override void DoCrumbleDeath()
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

		protected override void SetAnimatorVars()
		{
		}

		protected override void AnimRest()
		{
		}

		protected override void AnimAwake()
		{
		}

		[ContextMenu("Reset Animator")]
		protected override void ResetAnimator()
		{
		}

		public void LinkJump(Transform jumpTarg, float jumpForce = 7f)
		{
		}

		protected void Jump(JumpType jType)
		{
		}

		protected void PreJumpAttack()
		{
		}

		protected void JumpAttacking()
		{
		}

		private bool CheckMount()
		{
			return false;
		}

		private void UpdateMount(float distance)
		{
		}

		private void MountAttack(float damage)
		{
		}

		protected override void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private bool AttachToFace(Rigidbody face, TriggerRefProxy trp, bool preAttach = false, bool isPlayer = true)
		{
			return false;
		}

		private bool TransitionJointToEngaged()
		{
			return false;
		}

		public void DetachFromFace()
		{
		}

		public override void OnPoolDeInitialize()
		{
		}

		private void PlayerDeathDetachAdd()
		{
		}

		private void PlayerDeathDetachRemove()
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

		protected override void ReturnToPreAgro()
		{
		}

		protected override void SwitchLocoState(LocoState lState, float coolDown = 0f, bool forceSwitch = false)
		{
		}
	}
}
