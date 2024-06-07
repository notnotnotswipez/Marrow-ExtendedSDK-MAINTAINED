using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Player
{
	public class Haptor : MonoBehaviour
	{
		private enum HapStack
		{
			hap_Add = 0,
			hap_Override = 1,
			hap_Ignore = 2,
			hap_Duck = 3
		}

		[CompilerGenerated]
		private sealed class _003Cco_HapHit_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Haptor _003C_003E4__this;

			public float amp;

			private float _003Chap_hit_clock_003E5__2;

			private float _003Chap_loop_t_003E5__3;

			private float _003Chap_hit_dur_003E5__4;

			private float _003Camp_drop_003E5__5;

			private float _003Cfreq_drop_003E5__6;

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
			public _003Cco_HapHit_003Ed__60(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003Cco_HapticSine_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Haptor _003C_003E4__this;

			public float length;

			public float min_amplitude;

			public float max_amplitude;

			public float frequency;

			public int gate;

			private float _003Chap_loop_t_003E5__2;

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
			public _003Cco_HapticSine_003Ed__61(int _003C_003E1__state)
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

		[Header("Required")]
		public bool hapticsAllowed;

		public BaseController device_Controller;

		public Haptor otherHaptor;

		private bool usingRumbleHap;

		[HideInInspector]
		public float mod_globalPer;

		private float mod_viveWand;

		[Range(1f, 200f)]
		[Header("Defaults")]
		public float low_thr_freq;

		[Range(0.03f, 3f)]
		public float hap_duration;

		[Range(0f, 1000f)]
		public float hap_frequency;

		[Range(0f, 1f)]
		public float hap_amplitude;

		private float hap_delay;

		[Range(0.03f, 0.5f)]
		public float hap_calc_t;

		[Space(10f)]
		[Header("Subtle")]
		private float hap_subtle_t;

		private float hap_subtle_frequency;

		private float hap_subtle_amplitude;

		[Header("Click")]
		public float hap_click_down_t;

		public float hap_click_down_frequency;

		public float hap_click_down_amplitude;

		public float hap_click_up_t;

		public float hap_click_up_frequency;

		public float hap_click_up_amplitude;

		[Range(0f, 0.1f)]
		[Header("Tap")]
		public float hap_tap_duration;

		[Range(20f, 300f)]
		public float hap_tap_frequency;

		[Range(0f, 1f)]
		public float hap_tap_amplitude;

		[Range(0f, 1f)]
		[Header("Knock")]
		public float hap_knock_duration;

		[Range(0f, 200f)]
		public float hap_knock_frequency;

		[Range(0f, 1f)]
		public float hap_knock_amplitude;

		[Range(0.1f, 1f)]
		[Header("Hit")]
		public float hap_hit_mod;

		[Range(0f, 320f)]
		public float hap_hit_frequency;

		[Space(10f)]
		[Header("Sine")]
		[Header("Slide Friction")]
		[Header("Slide")]
		public int sin_gateCount;

		private int cur_sin_gateCount;

		private float cur_sin_length;

		private float cur_sin_amp;

		[Range(0f, 10f)]
		[Header("Soft Sine")]
		public float hap_softSin_length;

		[Range(120f, 1000f)]
		public float hap_softSin_freq;

		[Range(0f, 1f)]
		public float hap_max_softSin_amp;

		[Range(0f, 1f)]
		public float hap_min_softSin_amp;

		[Header("Hard Sine")]
		[Range(0f, 10f)]
		public float hap_hardSin_length;

		[Range(100f, 400f)]
		public float hap_hardSin_freq;

		[Range(0f, 1f)]
		public float hap_max_hardSin_amp;

		[Range(0f, 1f)]
		public float hap_min_hardSin_amp;

		private bool hapticking;

		private bool noDoubleHaptic;

		private void Start()
		{
		}

		public void DELAYEDCHECK()
		{
		}

		public void Haptic_Subtle()
		{
		}

		public void Haptic_Click(bool down = true)
		{
		}

		public void Haptic_Tap()
		{
		}

		public void Haptic_Knock()
		{
		}

		public void Haptic_Hit(float amp)
		{
		}

		public void Haptic_Tutorial(bool down = true)
		{
		}

		public void Haptic_Sliding()
		{
		}

		public void Haptic_SlideFriction()
		{
		}

		public void Haptic_SoftSin(int gateCount = 0, float length = 0f)
		{
		}

		public void Haptic_HardSin(int gateCount = 0, float length = 0f)
		{
		}

		public void Haptic_WepClang()
		{
		}

		public void Haptic_WepMagInsert()
		{
		}

		public void Haptic_WepChargeHandle()
		{
		}

		public void Haptic_WepFire(float kickForce)
		{
		}

		[IteratorStateMachine(typeof(_003Cco_HapHit_003Ed__60))]
		private IEnumerator co_HapHit(float amp = 0f)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003Cco_HapticSine_003Ed__61))]
		private IEnumerator co_HapticSine(int gate = 0, float length = 0f, float frequency = 0f, float max_amplitude = 0f, float min_amplitude = 0f)
		{
			return null;
		}

		public void SENDHAPTIC(float delay, float duration, float frequency, float amplitude)
		{
		}

		private void VIVEBANDAID()
		{
		}
	}
}
