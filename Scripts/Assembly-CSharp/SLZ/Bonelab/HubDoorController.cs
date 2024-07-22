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
	public class HubDoorController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCloseCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HubDoorController _003C_003E4__this;

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
			public _003CCloseCoroutine_003Ed__18(int _003C_003E1__state)
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

		public ConfigurableJoint jnt;

		public Rigidbody rb;

		public Servo servo;

		public float latchThreshhold;

		public Vector3 positiveDrive;

		public Vector3 negativeDrive;

		public float positiveRot;

		public float negativeRot;

		private SoftJointLimit lowLimit;

		private SoftJointLimit highLimit;

		private SoftJointLimit zeroLimit;

		private JointDrive openDrive;

		private JointDrive closeDrive;

		[SerializeField]
		private UnityEvent DoorCloseEvent;

		[SerializeField]
		private UnityEvent DoorOpenEvent;

		private void Awake()
		{
		}

		public void OPENDOOR()
		{
		}

		public void CLOSEDOOR()
		{
		}

		[IteratorStateMachine(typeof(_003CCloseCoroutine_003Ed__18))]
		private IEnumerator CloseCoroutine()
		{
			return null;
		}
	}
}
