using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Bonelab.Obsolete;
using SLZ.Marrow;
using SLZ.Marrow.VoidLogic;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	[Obsolete("Uses old Powerable system.")]
	public class CraneControlBox : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFullCraneResetCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CraneControlBox _003C_003E4__this;

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
			public _003CFullCraneResetCoroutine_003Ed__30(int _003C_003E1__state)
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
		private sealed class _003CDeactivation_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CraneControlBox _003C_003E4__this;

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
			public _003CDeactivation_003Ed__31(int _003C_003E1__state)
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

		public GameObject lineRenderers;

		public JoystickForwarder joystick;

		public SLZ.Marrow.VoidLogic.PowerSource zControls;

		public SLZ.Marrow.VoidLogic.PowerSource gravControlButtonPowerSource;

		public Powerable_Joint[] craneSegments;

		public Powerable_Joint[] craneGantry;

		public Material craneLightOn;

		public Material craneLightOff;

		public GameObject[] lightMeshes;

		public List<Renderer> lightRenderers;

		public GameObject[] craneRunningColliders;

		public Collider[] craneMainColliders;

		public PhysicMaterial zeroFriction;

		public PhysicMaterial steel;

		public Rigidbody[] rigidbodies;

		public ConfigurableJoint[] configurableJoints;

		private Vector3[] initialRBPosition;

		private Quaternion[] initialRBRotation;

		private HandJointConfiguration[] savedJointConfiguration;

		private IEnumerator craneResetCoroutine;

		private IEnumerator coroutine;

		public bool isPowered;

		private bool craneDeactivating;

		private bool blockAction;

		private bool inCraneVolume;

		public UnityEvent craneActivateEvent;

		public UnityEvent craneDeactivateEvent;

		private void Start()
		{
		}

		public void DeactivateCrane()
		{
		}

		public void FULLCRANERESET()
		{
		}

		[IteratorStateMachine(typeof(_003CFullCraneResetCoroutine_003Ed__30))]
		public IEnumerator FullCraneResetCoroutine()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDeactivation_003Ed__31))]
		private IEnumerator Deactivation()
		{
			return null;
		}

		public void ActivateCrane()
		{
		}

		private void Activation()
		{
		}

		public void ActivateCraneColliders()
		{
		}

		public void DeactivateCraneColliders()
		{
		}
	}
}
