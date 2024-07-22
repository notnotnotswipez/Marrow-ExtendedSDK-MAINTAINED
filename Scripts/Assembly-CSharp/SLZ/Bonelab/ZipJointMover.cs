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
	public class ZipJointMover : MonoBehaviour
	{
		public enum ZipState
		{
			MOVING_UP = 0,
			MOVING_DOWN = 1,
			READY = 2
		}

		[CompilerGenerated]
		private sealed class _003CCoMoveJoint_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ZipJointMover _003C_003E4__this;

			public float endGoalX;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

			private Vector3 _003CendGoal_003E5__5;

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
			public _003CCoMoveJoint_003Ed__40(int _003C_003E1__state)
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
		private sealed class _003CCoMoveJointDown_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ZipJointMover _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003ClerpVal_003E5__4;

			private Vector3 _003CstartPos_003E5__5;

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
			public _003CCoMoveJointDown_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CCoCheckGrip_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ZipJointMover _003C_003E4__this;

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
			public _003CCoCheckGrip_003Ed__42(int _003C_003E1__state)
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

		private Vector3 localVel;

		public ZipState zipState;

		[SerializeField]
		private bool isDebugging;

		public ZipLinkManager zipManager;

		public LinkData maxLinkData;

		public LinkData currLinkData;

		public Grip _grip;

		public ConfigurableJoint gripJoint;

		public Collider gripCollider;

		public Rigidbody gripBody;

		[SerializeField]
		private ConfigurableJoint moverJoint;

		public Rigidbody moverBody;

		public float duration;

		public float zipLength;

		[Tooltip("Meters/ second")]
		public float speed;

		private Coroutine moveUpRoutine;

		private Coroutine moveDownRoutine;

		[SerializeField]
		private AnimationCurve animCurve;

		public GameObject[] upperWheelObjs;

		public GameObject lowerWheelObj;

		public float upperWheelSpeed;

		public float lowerWheelSpeed;

		public UnityEvent OnGripClaim;

		public UnityEvent OnGripRelease;

		public UnityEvent OnCompleteMove;

		public UnityEvent OnBreakGrip;

		private PlayerZipSetup playerZipSetup;

		private float playerLerpDistance;

		public Hand activeHand;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnGrab(Hand hand)
		{
		}

		private void OnDrop(Hand hand)
		{
		}

		public void NPCMove(LinkData data)
		{
		}

		public void NPC_MoveDown()
		{
		}

		private void SetZipState(ZipState state)
		{
		}

		private void ResetGripLocalPos()
		{
		}

		[IteratorStateMachine(typeof(_003CCoMoveJoint_003Ed__40))]
		private IEnumerator CoMoveJoint(float endGoalX)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoMoveJointDown_003Ed__41))]
		private IEnumerator CoMoveJointDown()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoCheckGrip_003Ed__42))]
		private IEnumerator CoCheckGrip()
		{
			return null;
		}

		[ContextMenu("Set Duration")]
		public void SetDuration()
		{
		}

		[ContextMenu("GetLength")]
		public void GetLength()
		{
		}
	}
}
