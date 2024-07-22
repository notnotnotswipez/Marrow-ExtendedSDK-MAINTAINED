using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class TimedJointEvents : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoTimerRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimedJointEvents _003C_003E4__this;

			private float _003CtimeStarted_003E5__2;

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
			public _003CCoTimerRoutine_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CCoSecondaryAudio_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public AudioClip[] clips;

			public TimedJointEvents _003C_003E4__this;

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
			public _003CCoSecondaryAudio_003Ed__30(int _003C_003E1__state)
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

		public ConfigurableJoint joint;

		public ConfigurableJoint secJoint;

		[SerializeField]
		private AudioClip[] initClips;

		[SerializeField]
		private float audioDelay;

		[SerializeField]
		private bool initialIsTriggered;

		[SerializeField]
		private float initThreshold;

		public UnityEvent initEvent;

		[SerializeField]
		private AudioClip[] secondaryClips;

		[SerializeField]
		private bool secondaryIsTriggered;

		[SerializeField]
		private float secondaryThreshold;

		public UnityEvent secondaryEvent;

		[SerializeField]
		private AudioClip[] finalClips;

		[SerializeField]
		private bool finalIsTriggered;

		[SerializeField]
		private float finalThreshold;

		public UnityEvent finalEvent;

		[SerializeField]
		private float elapsedTime;

		private Coroutine timerRoutine;

		public void StartTimer()
		{
		}

		public void ResetStates()
		{
		}

		public void StopTimer()
		{
		}

		[IteratorStateMachine(typeof(_003CCoTimerRoutine_003Ed__20))]
		private IEnumerator CoTimerRoutine()
		{
			return null;
		}

		[ContextMenu("Trigger1stEvent")]
		public void TriggerInitialEvent()
		{
		}

		[ContextMenu("Trigger2ndEvent")]
		public void TriggerSecondaryEvent()
		{
		}

		[ContextMenu("Trigger3rdEvent")]
		public void TriggerFinalEvent()
		{
		}

		public void LimitJoint()
		{
		}

		[ContextMenu("TestLimitUpdate")]
		public void TestLimitUpdate()
		{
		}

		public void UpdateLimits(float limitVal)
		{
		}

		public void UnlockJoint()
		{
		}

		public void DestroyJoint()
		{
		}

		public void FireOffAudio(AudioClip[] clips)
		{
		}

		[IteratorStateMachine(typeof(_003CCoSecondaryAudio_003Ed__30))]
		private IEnumerator CoSecondaryAudio(AudioClip[] clips, float delay)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public void CompletelyFreeJoint()
		{
		}
	}
}
