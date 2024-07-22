using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Button))]
	public class ScrollButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		private enum ScrollButtonDirection
		{
			UP = 0,
			DOWN = 1
		}

		[CompilerGenerated]
		private sealed class _003CSmoothScrolling_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float totalTime;

			public float maxValue;

			public float minValue;

			public ScrollButton _003C_003E4__this;

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
			public _003CSmoothScrolling_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003CRefactoredSmoothScrolling_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float totalTime;

			public ScrollButton _003C_003E4__this;

			public float CurValue;

			public float TargetValue;

			private float _003Ctime_003E5__2;

			private float _003Ctimescaler_003E5__3;

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
			public _003CRefactoredSmoothScrolling_003Ed__20(int _003C_003E1__state)
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
		private ScrollButtonDirection direction;

		[SerializeField]
		private bool incremental;

		[SerializeField]
		private float stepSize;

		[SerializeField]
		private float scrollFrequency;

		[SerializeField]
		private Scrollbar scrollbar;

		[SerializeField]
		private ScrollElementsContainer scrollElementsContainer;

		private float signedStepSize;

		private Button button;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void HandleScrollViewChanged()
		{
		}

		private void HandleScrollValueChanged(float value)
		{
		}

		private void SetButtonState(bool enabled)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void stopScrolls()
		{
		}

		private void IncrementalScrollContent()
		{
		}

		private void ScrollContent()
		{
		}

		[IteratorStateMachine(typeof(_003CSmoothScrolling_003Ed__19))]
		private IEnumerator SmoothScrolling(float minValue, float maxValue, float totalTime)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRefactoredSmoothScrolling_003Ed__20))]
		private IEnumerator RefactoredSmoothScrolling(float CurValue, float TargetValue, float totalTime)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
