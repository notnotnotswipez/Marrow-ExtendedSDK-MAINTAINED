using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SimpleGripJointMover : MonoBehaviour
	{
		[SerializeField]
		private enum MoveState
		{
			UP = 0,
			DOWN = 1,
			MOVING_UP = 2,
			MOVING_DOWN = 3,
			ROTATED = 4
		}

		[CompilerGenerated]
		private sealed class _003CCoMoveJointTarget_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float initialDelay;

			public SimpleGripJointMover _003C_003E4__this;

			public Vector3 startPos;

			public Vector3 endPos;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

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
			public _003CCoMoveJointTarget_003Ed__14(int _003C_003E1__state)
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
		private sealed class _003CCoCheckGrip_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimpleGripJointMover _003C_003E4__this;

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
			public _003CCoCheckGrip_003Ed__18(int _003C_003E1__state)
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
		private MoveState moveState;

		[SerializeField]
		private float duration;

		[SerializeField]
		private Grip _grip;

		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		private Transform bottomTarget;

		[SerializeField]
		private float rotDuration;

		[SerializeField]
		private float inwardVel;

		[SerializeField]
		private float outwardVel;

		private Coroutine jointMoveRoutine;

		[SerializeField]
		private ConfigurableJoint rotJoint;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[ContextMenu("ToggleMove")]
		public void ToggleMove()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMoveJointTarget_003Ed__14))]
		private IEnumerator CoMoveJointTarget(Vector3 startPos, Vector3 endPos, float initialDelay = 0f)
		{
			return null;
		}

		public void TeleportJointToStart()
		{
		}

		private void OnGrab(Hand hand)
		{
		}

		private void OnDrop(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CCoCheckGrip_003Ed__18))]
		private IEnumerator CoCheckGrip()
		{
			return null;
		}

		[ContextMenu("RotateIn")]
		public void RotateInwards()
		{
		}

		[ContextMenu("RotateOut")]
		public void RotateOutwards()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
