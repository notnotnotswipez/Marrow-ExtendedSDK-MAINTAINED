using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TweenRotation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CEasetoEase_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Vector3 targetpos;

			public TweenRotation _003C_003E4__this;

			private float _003Ctimer_003E5__2;

			private Quaternion _003CtargetRotation_003E5__3;

			private Quaternion _003CorgRotation_003E5__4;

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
			public _003CEasetoEase_003Ed__2(int _003C_003E1__state)
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
		private AnimationCurve curve;

		public void LookAtRotationTween(Transform LookAtTransform)
		{
		}

		[IteratorStateMachine(typeof(_003CEasetoEase_003Ed__2))]
		private IEnumerator EasetoEase(Vector3 targetpos)
		{
			return null;
		}
	}
}
