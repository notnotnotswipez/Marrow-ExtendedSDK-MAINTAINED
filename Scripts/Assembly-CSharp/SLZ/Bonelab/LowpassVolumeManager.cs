using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LowpassVolumeManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLerpBlend_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LowpassVolumeManager _003C_003E4__this;

			public float fromCutoff;

			public float toCutoff;

			public float fromVol;

			public float toVol;

			private float _003Ctime_003E5__2;

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
			public _003CLerpBlend_003Ed__16(int _003C_003E1__state)
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

		public AudioLowPassFilter lpf;

		public AudioSource audioSource;

		[Range(10f, 22000f)]
		public float cutoffFreqLow;

		[Range(10f, 22000f)]
		public float cutoffFreqHigh;

		[Range(0f, 1f)]
		public float minVolume;

		[Range(0f, 1f)]
		public float maxVolume;

		public float lerpTime;

		public bool[] volumes;

		private bool isInVolume;

		private IEnumerator lerpEnumerator;

		private float currentLerpVal;

		private float currentVolumeVal;

		private void Start()
		{
		}

		public void EnterVolume(int i)
		{
		}

		public void ExitVolume(int i)
		{
		}

		private void CheckConfig()
		{
		}

		[IteratorStateMachine(typeof(_003CLerpBlend_003Ed__16))]
		private IEnumerator LerpBlend(float fromCutoff, float toCutoff, float fromVol, float toVol)
		{
			return null;
		}
	}
}
