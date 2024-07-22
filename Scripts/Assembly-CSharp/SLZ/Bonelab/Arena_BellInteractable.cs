using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Arena_BellInteractable : MonoBehaviour
	{
		public enum BellState
		{
			UP = 0,
			DOWN = 1,
			MOVING = 2
		}

		[CompilerGenerated]
		private sealed class _003CMoveBell_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public Arena_BellInteractable _003C_003E4__this;

			public bool up;

			public Vector3 currentPosition;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

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
			public _003CMoveBell_003Ed__26(int _003C_003E1__state)
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
		private sealed class _003CCoResetBell_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Arena_BellInteractable _003C_003E4__this;

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
			public _003CCoResetBell_003Ed__28(int _003C_003E1__state)
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
		private Arena_GameController arenaGameController;

		public BellState bellState;

		public bool visDebug;

		public float timeToTop;

		public float timeToBottom;

		public BellBodies bellBods;

		public Rigidbody[] bellBodies;

		public CylinderGrip grip;

		public GameObject bellSwingObj;

		[HideInInspector]
		public Rigidbody hoverBody;

		private float bellPerc;

		public AnimationCurve upCurve;

		public ConfigurableJoint topJoint;

		private Vector3 bottomTargPos;

		private Vector3 topTargPos;

		private Coroutine bellMoveRoutine;

		private LineRenderer Liner;

		[SerializeField]
		public GameObject Point1;

		[SerializeField]
		public GameObject Point2;

		private void Awake()
		{
		}

		public void UpdateTargetPosition(float targetY)
		{
		}

		private void Update()
		{
		}

		[ContextMenu("MoveBellDown")]
		public void MoveBellDown()
		{
		}

		[ContextMenu("MoveBellUp")]
		public void MoveBellUp()
		{
		}

		public void MoveBell(bool moveUp)
		{
		}

		[IteratorStateMachine(typeof(_003CMoveBell_003Ed__26))]
		private IEnumerator MoveBell(bool up, float duration, Vector3 currentPosition)
		{
			return null;
		}

		public void ResetBell()
		{
		}

		[IteratorStateMachine(typeof(_003CCoResetBell_003Ed__28))]
		private IEnumerator CoResetBell()
		{
			return null;
		}

		[ContextMenu("Get All Local Positions")]
		private void GetAllReferences()
		{
		}
	}
}
