using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourBaseTurret : BehaviourGrabbableBaseNav
	{
		[CompilerGenerated]
		private sealed class _003CSelfDespawn_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public BehaviourBaseTurret _003C_003E4__this;

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

			[DebuggerHidden]
			public _003CSelfDespawn_003Ed__22(int _003C_003E1__state)
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

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		public Transform target;

		public Action behaviourDead;

		public bool actionReady;

		public float[] incomingActions;

		private int _deathAnim;

		private float _animationBlendWeight;

		private float _animationBlendWeightV;

		private float _blendToAnimationTime;

		public SubBehaviourIk ik;

		public GameObject throwVfx;

		public float artSlerpDrive;

		private JointDrive old;

		private bool damagedJoint;

		public MentalState[] start_state_list;

		public int start_state_ind;

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

		protected override void ResetAnimator()
		{
		}

		protected override void OnInitiate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		public override void Freeze()
		{
		}

		public override void Unfreeze()
		{
		}

		protected override void OnUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CSelfDespawn_003Ed__22))]
		private IEnumerator SelfDespawn(float duration)
		{
			return null;
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		public new void SetAgro(TriggerRefProxy agroTarget)
		{
		}

		private void TakeDelayedAction()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		private new void Awake()
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

		protected override void ReturnToPreAgro()
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
