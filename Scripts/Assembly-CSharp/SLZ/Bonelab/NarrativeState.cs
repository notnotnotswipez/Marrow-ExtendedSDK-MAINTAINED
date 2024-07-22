using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace SLZ.Bonelab
{
	public class NarrativeState : MonoBehaviour
	{
		public enum HoldState
		{
			INACTIVE = 0,
			INTRO = 1,
			HOLD = 2,
			PROMPT = 3,
			EXIT = 4,
			INTERRUPTED = 5
		}

		[CompilerGenerated]
		private sealed class _003CCoHold_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NarrativeState _003C_003E4__this;

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
			public _003CCoHold_003Ed__31(int _003C_003E1__state)
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

		public HoldState currHoldState;

		public HoldState prevHoldState;

		[Space(10f)]
		public bool playIntroOnStart;

		public bool ExitAfterIntro;

		[HideInInspector]
		public int _stateIndex;

		public NarrativeState nextState;

		[SerializeField]
		private float initTimerValue;

		[SerializeField]
		private float timerValue;

		[SerializeField]
		private int currPrompt;

		private Coroutine holdRoutine;

		[SerializeField]
		private bool intertupedTimerRoutine;

		[Header("Playable Directors")]
		[SerializeField]
		private PlayableDirector introDirector;

		[SerializeField]
		private PlayableDirector holdDirector;

		[SerializeField]
		private PlayableDirector[] promptDirectors;

		private List<TrackData> promptDirectorDataList;

		[SerializeField]
		[Header("Events")]
		private UnityEvent OnIntro;

		[SerializeField]
		private UnityEvent OnEnterHold;

		[SerializeField]
		private UnityEvent OnTimeOut;

		[SerializeField]
		private UnityEvent OnExit;

		public static Action<NarrativeState, PlayableDirector> OnStateChange;

		[SerializeField]
		[Header("Debug State Directors")]
		private PlayableDirector activeDirector;

		[SerializeField]
		private PlayableDirector prevDirector;

		public void Start()
		{
		}

		[ContextMenu("PlayIntro")]
		public void PlayIntro()
		{
		}

		public void HoldForInput()
		{
		}

		public void HoldWithTimeoutPrompt(float time = -1f)
		{
		}

		private void TimeoutState()
		{
		}

		public void InteruptState()
		{
		}

		public void ResumeState()
		{
		}

		[ContextMenu("ExitState")]
		public void ExitState()
		{
		}

		[IteratorStateMachine(typeof(_003CCoHold_003Ed__31))]
		private IEnumerator CoHold()
		{
			return null;
		}

		private void StopHoldRoutine()
		{
		}

		public void UpdateState(HoldState state, PlayableDirector director)
		{
		}

		public void SetCheckPoint()
		{
		}

		public void SwapDirectorPlayable(PlayableDirector director, PlayableAsset asset)
		{
		}

		public void GetBindings(PlayableDirector director)
		{
		}

		public void SetBindings(PlayableDirector director)
		{
		}

		public static void Bind(PlayableDirector director, string trackName, UnityEngine.Object sourceObj)
		{
		}
	}
}
