using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

public class CureBattery : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoBatteryIndicator_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CureBattery _003C_003E4__this;

		private float _003Clerp_003E5__2;

		private float _003CstartTime_003E5__3;

		private float _003CendTime_003E5__4;

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
		public _003CCoBatteryIndicator_003Ed__8(int _003C_003E1__state)
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

	[SerializeField]
	private Grip[] _grips;

	[SerializeField]
	private bool wasGrabbed;

	public GameObject lightBeam;

	public CureMachinePowerable cureMachine;

	public float delayTime;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CCoBatteryIndicator_003Ed__8))]
	private IEnumerator CoBatteryIndicator()
	{
		return null;
	}

	private void OnGrab(Hand hand)
	{
	}
}
