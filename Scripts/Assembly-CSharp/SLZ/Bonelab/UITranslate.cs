using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UITranslate : MonoBehaviour
	{
		public enum posBehavior
		{
			pingPong = 0,
			loop = 1,
			stop = 2
		}

		[CompilerGenerated]
		private sealed class _003CTranslateTransform_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UITranslate _003C_003E4__this;

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
			public _003CTranslateTransform_003Ed__15(int _003C_003E1__state)
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

		public AnimationCurve curve_translate;

		public Vector3 pos_start;

		public Vector3 pos_end;

		public bool playOnEnable;

		public bool endHere;

		public float timeToTranslate;

		public posBehavior m_behavior;

		private float cur_timeToTranslate;

		private Vector3 cur_position;

		private Vector3 tar_position;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void PLAYTRANSLATE()
		{
		}

		[IteratorStateMachine(typeof(_003CTranslateTransform_003Ed__15))]
		private IEnumerator TranslateTransform()
		{
			return null;
		}
	}
}
