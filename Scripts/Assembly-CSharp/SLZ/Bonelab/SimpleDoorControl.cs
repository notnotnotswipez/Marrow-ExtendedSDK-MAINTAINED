using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class SimpleDoorControl : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoCloseDoor_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimpleDoorControl _003C_003E4__this;

			private WaitForFixedUpdate _003Cwait_003E5__2;

			private float _003CstartDot_003E5__3;

			private float[] _003CvelocityHistory_003E5__4;

			private int _003CvelIndex_003E5__5;

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
			public _003CCoCloseDoor_003Ed__34(int _003C_003E1__state)
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
		private sealed class _003CCoOpenDoor_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimpleDoorControl _003C_003E4__this;

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
			public _003CCoOpenDoor_003Ed__35(int _003C_003E1__state)
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

		[Header("Options")]
		public bool isLocked;

		[Header("Audio Clips")]
		public AudioClip[] closeClip;

		public AudioClip[] slamClip;

		public AudioClip[] openClip;

		public AudioClip[] audioClip;

		public AudioClip[] lockClip;

		[Header("References")]
		public ConfigurableJoint joint;

		public Rigidbody doorRigidbody;

		public Transform hingeBack;

		public Transform hingeForward;

		public Transform connectedHingeBack;

		public Transform connectedHingeForward;

		public Transform hingeArtTransform;

		public Collider[] ignoreColliders;

		[Header("Events")]
		public UnityEvent onLocked;

		public UnityEvent onUnlocked;

		public UnityEvent onClose;

		private float _neutralDriveSpring;

		private float _neutralDriveDamper;

		private float _neutralDriveMaxForce;

		private float _neutralHighLimit;

		private float _neutralLowLimit;

		private Collider[] _colliders;

		public bool allowAutoConfigureDoorJoint;

		private Coroutine _overrideDoorCoroutine;

		private bool _isHingeForward;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public void FixedUpdate()
		{
		}

		public void Lock()
		{
		}

		public void Unlock()
		{
		}

		public void Relax()
		{
		}

		public void Open(bool isPositiveDirection)
		{
		}

		public void Close()
		{
		}

		private void SetNeutralDrive()
		{
		}

		[IteratorStateMachine(typeof(_003CCoCloseDoor_003Ed__34))]
		private IEnumerator CoCloseDoor()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoOpenDoor_003Ed__35))]
		private IEnumerator CoOpenDoor(bool isPositiveDirection)
		{
			return null;
		}

		public void CalculateHinge()
		{
		}
	}
}
