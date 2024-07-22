using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class MineCartLapBar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoCheckBar_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MineCartLapBar _003C_003E4__this;

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
			public _003CCoCheckBar_003Ed__15(int _003C_003E1__state)
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

		[Tooltip("Joint for lapbar")]
		[InspectorDisplayName("Configurable Joint")]
		public ConfigurableJoint cj;

		[InspectorDisplayName("Seat")]
		[Tooltip("Seat script goes here")]
		public Seat seat;

		[Tooltip("Servo script goes here")]
		[InspectorDisplayName("Servo Script")]
		public Servo servo;

		[InspectorDisplayName("Lock Angle")]
		[Tooltip("The amount of rotation in degrees that will lock the joint")]
		public float lockAngle;

		[Tooltip("Event to fire on player seated")]
		[Header("Events")]
		[SerializeField]
		private UnityEvent OnSeat;

		[Tooltip("Event to fire on player unseated")]
		[SerializeField]
		private UnityEvent OnUnseat;

		[SerializeField]
		[Tooltip("Event to fire on bar locked")]
		private UnityEvent OnBarLocked;

		[SerializeField]
		[Tooltip("Event to fire on bar unlocked")]
		private UnityEvent OnBarUnlocked;

		private Quaternion startRotation;

		private Coroutine _checkingBar;

		public void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnSeated()
		{
		}

		private void OnUnSeated()
		{
		}

		[IteratorStateMachine(typeof(_003CCoCheckBar_003Ed__15))]
		private IEnumerator CoCheckBar()
		{
			return null;
		}

		public bool CheckBar()
		{
			return false;
		}

		public void LockBar()
		{
		}

		public void UnlockBar()
		{
		}

		private void OnDisable()
		{
		}
	}
}
