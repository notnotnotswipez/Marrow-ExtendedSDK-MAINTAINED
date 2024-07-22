using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TransformLerp : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLerpTransform_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TransformLerp _003C_003E4__this;

			public float time;

			private float _003Ctimer_003E5__2;

			private Vector3 _003CstartVect_003E5__3;

			private Quaternion _003CstartQuat_003E5__4;

			private Vector3 _003CEndVect_003E5__5;

			private Quaternion _003CEndQuat_003E5__6;

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
			public _003CLerpTransform_003Ed__4(int _003C_003E1__state)
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

		public Transform SourceTransform;

		public Transform StartingTransform;

		public Transform EndingTransform;

		public void DoLerpTransform(float time)
		{
		}

		[IteratorStateMachine(typeof(_003CLerpTransform_003Ed__4))]
		private IEnumerator LerpTransform(float time)
		{
			return null;
		}
	}
}
