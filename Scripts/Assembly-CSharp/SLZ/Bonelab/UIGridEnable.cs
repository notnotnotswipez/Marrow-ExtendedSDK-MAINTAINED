using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.Bonelab
{
	public class UIGridEnable : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFXChange_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIGridEnable _003C_003E4__this;

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
			public _003CFXChange_003Ed__11(int _003C_003E1__state)
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

		public AnimationCurve curve_spawn;

		public Vector2 spacing_start;

		private Vector2 spacing_end;

		private float timeToSpace;

		private float cur_timeToSpace;

		private Vector2 cur_spacing;

		private Vector2 tar_spacing;

		public GridLayoutGroup grid;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void GRIDSPACER()
		{
		}

		[IteratorStateMachine(typeof(_003CFXChange_003Ed__11))]
		private IEnumerator FXChange()
		{
			return null;
		}
	}
}
