using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TimeBender : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoLimitSlowMo_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeBender _003C_003E4__this;

			public float step;

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
			public _003CCoLimitSlowMo_003Ed__18(int _003C_003E1__state)
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
		private sealed class _003CCoRegenSlowMo_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public TimeBender _003C_003E4__this;

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
			public _003CCoRegenSlowMo_003Ed__19(int _003C_003E1__state)
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

		[SerializeField]
		[Header("SLOW-MOTION-FOR-ME")]
		private bool limitedSlowMo;

		[SerializeField]
		private bool isSlowTime;

		[SerializeField]
		private bool showVisuals;

		[SerializeField]
		private GameObject visObj;

		private Coroutine limitedSlowMoRoutine;

		private Coroutine regenSlowMoRoutine;

		[SerializeField]
		private float maxSlowMoJuice;

		[SerializeField]
		private float slowMoJuice;

		[SerializeField]
		private GameObject[] timeBips;

		[SerializeField]
		private GameObject slowMoSlider;

		[SerializeField]
		private AudioClip slowMoCoolClip;

		[SerializeField]
		private AudioClip slowMoJuicedClip;

		private float currStep;

		private float sliderScaleMax;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void ToggleSlowLimits(bool isLimited)
		{
		}

		public void SlowTimeToggle(float step)
		{
		}

		[IteratorStateMachine(typeof(_003CCoLimitSlowMo_003Ed__18))]
		private IEnumerator CoLimitSlowMo(float step = 1f)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoRegenSlowMo_003Ed__19))]
		private IEnumerator CoRegenSlowMo(float delay = 0f)
		{
			return null;
		}
	}
}
