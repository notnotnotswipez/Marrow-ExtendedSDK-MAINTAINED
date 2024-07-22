using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class ClockBPM : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCountClock_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ClockBPM _003C_003E4__this;

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
			public _003CCountClock_003Ed__26(int _003C_003E1__state)
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

		[Header("SETTINGS")]
		public bool playOnStart;

		[Header("TIMING")]
		public float BPM;

		[Range(1f, 8f)]
		public int stepsPerMeasure;

		[Range(1f, 8f)]
		public int steps;

		[Header("DISPLAY")]
		public int cur_measure;

		public int tot_steps;

		public int cur_step;

		public int cur_2step;

		public int cur_4step;

		public int cur_8step;

		public int scoreMultiplier;

		[Header("EVENTS")]
		public UnityEvent OnNewMeasure;

		public UnityEvent OnDownBeat;

		public UnityEvent HalfNote;

		public UnityEvent QuarterNote;

		public UnityEvent EighthNote;

		public UnityEvent[] Event_BeatDivisions;

		public UnityEvent[] Event_Steps;

		private float defaultBPM;

		private float interval;

		private float nextTime;

		private int cur_division;

		private bool paused;

		private WaitForSecondsRealtime time_eighthhNote;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CCountClock_003Ed__26))]
		private IEnumerator CountClock()
		{
			return null;
		}

		public void CLOCK_PLAY()
		{
		}

		public void CLOCK_STOP()
		{
		}

		public void CLOCK_RESET(bool play = false)
		{
		}
	}
}
