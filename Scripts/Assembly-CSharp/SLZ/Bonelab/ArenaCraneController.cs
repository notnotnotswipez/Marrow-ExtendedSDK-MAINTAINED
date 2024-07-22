using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ArenaCraneController : MonoBehaviour
	{
		public enum MoveState
		{
			MOVING = 0,
			AT_TARGET = 1,
			IDLE = 2
		}

		public enum GrabState
		{
			GRAB = 0,
			DUMP = 1,
			RETRACT = 2,
			NONE = 3
		}

		[CompilerGenerated]
		private sealed class _003CCoGrab_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArenaCraneController _003C_003E4__this;

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
			public _003CCoGrab_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CCoDump_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArenaCraneController _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003CdumpLerp_003E5__4;

			private float _003CstartSpring_003E5__5;

			private JointDrive _003CdropDrive_003E5__6;

			private float _003CspringGoal_003E5__7;

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
			public _003CCoDump_003Ed__29(int _003C_003E1__state)
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
		private ConfigurableJoint xJoint;

		[SerializeField]
		private ConfigurableJoint zJoint;

		[SerializeField]
		private ConfigurableJoint dropJoint;

		[SerializeField]
		private ConfigurableJoint grabJoint;

		[SerializeField]
		private Transform target;

		[SerializeField]
		private float sqrDistToBody;

		private float dropDuration;

		[SerializeField]
		private float sqrDist;

		[SerializeField]
		private float targetThresh;

		[SerializeField]
		private float speed;

		[SerializeField]
		private float attachThresh;

		private Coroutine dumpRoutine;

		[SerializeField]
		private Vector3 xTarget;

		[SerializeField]
		private Vector3 zTarget;

		public MoveState moveState;

		public GrabState grabState;

		[SerializeField]
		private bool isEmpty;

		[SerializeField]
		private Rigidbody containerBody;

		[SerializeField]
		private CargoData activeCargo;

		[SerializeField]
		private CargoData[] cargoData;

		[ContextMenu("StartMoveState")]
		public void StartMoveState()
		{
		}

		public void UpdateMoveState(MoveState state)
		{
		}

		public void UpdateGrabState(GrabState state)
		{
		}

		private void FixedUpdate()
		{
		}

		public void Grab()
		{
		}

		[IteratorStateMachine(typeof(_003CCoGrab_003Ed__27))]
		private IEnumerator CoGrab()
		{
			return null;
		}

		public void Dump()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDump_003Ed__29))]
		private IEnumerator CoDump()
		{
			return null;
		}

		[ContextMenu("PickupCargoOne")]
		public void PickupCargoOne()
		{
		}

		[ContextMenu("PickupCargoTwo")]
		public void PickupCargoTwo()
		{
		}

		public void PickupCargo(int idX)
		{
		}
	}
}
