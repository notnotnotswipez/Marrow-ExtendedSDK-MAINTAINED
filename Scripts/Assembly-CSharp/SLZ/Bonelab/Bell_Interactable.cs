using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Bell_Interactable : MonoBehaviour
	{
		[SerializeField]
		private enum MoveState
		{
			UP = 0,
			DOWN = 1,
			MOVING_UP = 2,
			MOVING_DOWN = 3
		}

		[CompilerGenerated]
		private sealed class _003CCoMoveJointTarget_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Bell_Interactable _003C_003E4__this;

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
			public _003CCoMoveJointTarget_003Ed__26(int _003C_003E1__state)
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

			public Bell_Interactable _003C_003E4__this;

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
		private bool isVisDebug;

		public bool isReady;

		[SerializeField]
		private MoveState moveState;

		[SerializeField]
		private float duration;

		[SerializeField]
		private InteractableHost host;

		[SerializeField]
		private Grip _grip;

		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		private Transform topTarget;

		[SerializeField]
		private Transform bottomTarget;

		[SerializeField]
		private GameObject anchorObj;

		private Coroutine jointMoveRoutine;

		public UnityEvent OnRing;

		public UnityEvent OnBellReset;

		[SerializeField]
		private Rigidbody[] jointChainRBs;

		public Quaternion[] localBodyRotations;

		public Vector3[] localBodyPositions;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private GameObject CreateAnchorObject(ConfigurableJoint joint)
		{
			return null;
		}

		private void OnGrab(Hand hand)
		{
		}

		private void OnDrop(Hand hand)
		{
		}

		public void RingTheBell()
		{
		}

		public void TeleportToUpState()
		{
		}

		[ContextMenu("ToggleMove")]
		public void ToggleMove()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMoveJointTarget_003Ed__26))]
		private IEnumerator CoMoveJointTarget(Vector3 startPos, Vector3 endPos)
		{
			return null;
		}

		[ContextMenu("Reset Bell")]
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

		public void OnDrawGizmos()
		{
		}

		[ContextMenu("ForceDetach")]
		public void ForceDetachFromBell()
		{
		}
	}
}
