using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UIWobble : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWobble_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIWobble _003C_003E4__this;

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
			public _003CWobble_003Ed__17(int _003C_003E1__state)
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

		public float wobbleFrequency;

		public Vector3 wobbleAmplitude;

		public float rotWobbleAmplitude;

		public float smoothTime;

		public float rotSmoothTime;

		public AnimationCurve amplitudeCurve;

		public AnimationCurve smoothCurve;

		public float curveLength;

		private float wobbleTime;

		private float amplitudeProgress;

		private float smoothProgress;

		private Vector3 startPos;

		private Vector3 startRot;

		private Vector3 vectorVelocity;

		private float floatVelocity;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CWobble_003Ed__17))]
		private IEnumerator Wobble()
		{
			return null;
		}

		private void Update()
		{
		}

		private Vector3 GetRandomPos(Vector3 starVar, Vector3 n)
		{
			return default(Vector3);
		}

		private float GetRandomFloat(float n)
		{
			return 0f;
		}
	}
}
