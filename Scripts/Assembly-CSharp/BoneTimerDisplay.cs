using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class BoneTimerDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoUpdateDisplay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoneTimerDisplay _003C_003E4__this;

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
		public _003CCoUpdateDisplay_003Ed__9(int _003C_003E1__state)
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

	public BoneTimer boneTimer;

	[SerializeField]
	protected TimeSpan tsTimerValue;

	[SerializeField]
	private bool showMilliseconds;

	private string tsTimerString;

	private float lastDisplayTime;

	private float minDisplayTime;

	public List<TMP_Text> timerTexts;

	private Coroutine updateRoutine;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCoUpdateDisplay_003Ed__9))]
	private IEnumerator CoUpdateDisplay()
	{
		return null;
	}

	private void UpdateTimeDisplay(float timerValue)
	{
	}
}
