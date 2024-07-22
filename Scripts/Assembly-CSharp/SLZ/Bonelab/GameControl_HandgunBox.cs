using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_HandgunBox : BonelabInternalGameControl
	{
		[CompilerGenerated]
		private sealed class _003CTimer_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_HandgunBox _003C_003E4__this;

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
			public _003CTimer_003Ed__22(int _003C_003E1__state)
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

		public TextMeshProUGUI txt_Clock;

		public TextMeshProUGUI txt_Meridiem;

		private int sys_minutes;

		private DateTime time;

		public TextMeshProUGUI[] txt_Timer;

		public TextMeshProUGUI[] txt_Count;

		private bool startedTime;

		private float timeElapsed;

		private float timeSpeed;

		public TextMeshProUGUI[] txt_Timer_BEST;

		public TextMeshProUGUI[] txt_Timer_PREV;

		private float time_Best;

		private float time_Prev;

		public GameObject victoryBanner;

		private WaitForSecondsRealtime timecount;

		public GameObject obj_jumpToTimeTrial;

		public override void Awake()
		{
		}

		private new void Start()
		{
		}

		public void STARTTIMER()
		{
		}

		public void STOPTIMER()
		{
		}

		public void COMPLETETRIAL()
		{
		}

		private void FixedUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CTimer_003Ed__22))]
		private IEnumerator Timer()
		{
			return null;
		}

		public void ACHIEVEMENT_TIME_TEST()
		{
		}

		private int UpdateDeathCount()
		{
			return 0;
		}

		private void UpdateText()
		{
		}

		private void UpdateTimer()
		{
		}

		private void DisplayBestPrev()
		{
		}
	}
}
