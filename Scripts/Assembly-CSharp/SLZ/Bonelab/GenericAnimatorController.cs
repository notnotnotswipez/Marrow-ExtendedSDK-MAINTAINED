using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RealisticEyeMovements;
using SLZ.Marrow.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GenericAnimatorController : MonoBehaviour
	{
		[Serializable]
		public class AnimationAudioPair
		{
			public AnimationClip animationClip;

			public AudioClip audioClip;

			public int animationIndex;
		}

		[Serializable]
		public class AnimatorStateMachineGroup
		{
			public List<AnimationAudioPair> animationAudioPairList;

			public string triggerName;

			public string triggerIndexName;
		}

		[Serializable]
		public class AnimatorSequence
		{
			public string description;

			public int stateMachineIndex;

			public int[] animationIndex;

			public float startBufferTime;

			public float endBufferTime;

			public bool autoProgress;

			public bool lookAtPlayer;

			public TriggerActionGroup[] TriggerActions;
		}

		[Serializable]
		public class TriggerActionGroup
		{
			public float triggerActionDelay;

			public UnityEvent onAnimationTriggerAction;
		}

		[CompilerGenerated]
		private sealed class _003CCancelAnimationCoroutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GenericAnimatorController _003C_003E4__this;

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
			public _003CCancelAnimationCoroutine_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CSetSequencePosition_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimatorSequence sequence;

			public GenericAnimatorController _003C_003E4__this;

			public int stateMachine;

			public int animation;

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
			public _003CSetSequencePosition_003Ed__23(int _003C_003E1__state)
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
		private sealed class _003CTriggerAction_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public UnityEvent action;

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
			public _003CTriggerAction_003Ed__24(int _003C_003E1__state)
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
		private sealed class _003CSetSpecificIndex_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GenericAnimatorController _003C_003E4__this;

			public int stateMachine;

			public int animation;

			public bool lookAtPlayer;

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
			public _003CSetSpecificIndex_003Ed__26(int _003C_003E1__state)
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

		public Animator animator;

		public Transform audioTransform;

		public LookTargetController lookTargetController;

		public float audioSourceMinDist;

		public List<AnimatorStateMachineGroup> StateMachineGroups;

		public List<AnimatorSequence> animationSequence;

		public bool updateTimeScale;

		private static readonly int Cancel;

		private IEnumerator sequencePosition;

		private int currentSequenceIndex;

		private int nextSequenceIndex;

		private static readonly int TimeScale;

		private float _lastTimeScale;

		private ManagedAudioPlayer audioSource;

		private void Start()
		{
		}

		public void CANCELANIMATION()
		{
		}

		[IteratorStateMachine(typeof(_003CCancelAnimationCoroutine_003Ed__20))]
		private IEnumerator CancelAnimationCoroutine()
		{
			return null;
		}

		public void ADVANCESEQUENCE()
		{
		}

		public void GOTOSEQUENCEINDEX(int sequence)
		{
		}

		[IteratorStateMachine(typeof(_003CSetSequencePosition_003Ed__23))]
		private IEnumerator SetSequencePosition(int stateMachine, int animation, AnimatorSequence sequence)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTriggerAction_003Ed__24))]
		private IEnumerator TriggerAction(UnityEvent action, float delay)
		{
			return null;
		}

		public void GOTOSPECIFICINDEX(int stateMachine, int animation, bool lookAtPlayer)
		{
		}

		[IteratorStateMachine(typeof(_003CSetSpecificIndex_003Ed__26))]
		private IEnumerator SetSpecificIndex(int stateMachine, int animation, bool lookAtPlayer)
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
