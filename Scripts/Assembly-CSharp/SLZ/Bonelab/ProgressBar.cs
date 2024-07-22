using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class ProgressBar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFadeFX_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProgressBar _003C_003E4__this;

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
			public _003CFadeFX_003Ed__12(int _003C_003E1__state)
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

		public RectTransform barTransform;

		public Gradient gradient;

		public Image img_percentBar;

		public Vector2 remapBar;

		private float _cur_completed;

		private float _tempCompleted;

		private bool _coroutineRunning;

		public float cur_completed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		public void DISPLAYFX()
		{
		}

		[IteratorStateMachine(typeof(_003CFadeFX_003Ed__12))]
		private IEnumerator FadeFX()
		{
			return null;
		}

		private void SendFX(float _targetVal = 0f)
		{
		}
	}
}
