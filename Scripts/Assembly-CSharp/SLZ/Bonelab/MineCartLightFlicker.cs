using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MineCartLightFlicker : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFlicker_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool isTurningOn;

			public MineCartLightFlicker _003C_003E4__this;

			public float curIntensity;

			public float targetIntesity;

			public AnimationCurve curve;

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
			public _003CFlicker_003Ed__15(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public Light cartLight;

		public AnimationCurve OnCurve;

		public AnimationCurve OffCurve;

		public float flickerLength;

		private float _curTime;

		private float _endTime;

		private float _cachedOnIntensity;

		private Coroutine _flickerCo;

		public bool offOnStart;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[ContextMenu("Flicker On")]
		public void FlickerOn()
		{
		}

		[ContextMenu("Flicker Off")]
		public void FlickerOff()
		{
		}

		public void QuickOn()
		{
		}

		public void QuickOff()
		{
		}

		[IteratorStateMachine(typeof(_003CFlicker_003Ed__15))]
		private IEnumerator Flicker(AnimationCurve curve, float curIntensity, float targetIntesity, bool isTurningOn)
		{
			return null;
		}
	}
}
