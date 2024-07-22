using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using TMPro;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class PhysVehicleInput : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoEject_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PhysVehicleInput _003C_003E4__this;

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
			public _003CCoEject_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CCoFadeInput_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PhysVehicleInput _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

			private float _003CfadeLerp_003E5__4;

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
			public _003CCoFadeInput_003Ed__45(int _003C_003E1__state)
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

		public bool isFadingInput;

		[SerializeField]
		private float fadeDuration;

		public bool leftControllerGas;

		public float steerVal;

		public float hBrakeVal;

		public BaseVehicleUtils baseVehicleUtils;

		public Seat driverSeat;

		public RigManager rigManager;

		public HingeVirtualController steerWheelVC;

		public InteractableHost steerHost;

		public ConfigurableJoint steerJoint;

		private Quaternion _steerInitialRotation;

		public ConfigurableJoint ejectJoint;

		public Grip ejectGrip;

		public InteractableHost ejectHost;

		public float ejectForce;

		public InteractableHost handBrakeHost;

		public ConfigurableJoint handBrakeJoint;

		private Quaternion _hbInitialRotation;

		private bool hbValid;

		public InferenceAgent agent;

		private float steerDeadZone;

		public float minSpringForce;

		public float maxSpringForce;

		private JointDrive steerAngDrive;

		private Coroutine fadeRoutine;

		public TMP_Text speedText;

		public TMP_Text springText;

		public TMP_Text hBrakeText;

		public TMP_Text sideStiffText;

		public bool invertSteering;

		public bool wasdOverride;

		private int horizontalInput;

		private int verticalInput;

		private bool w;

		private bool a;

		private bool s;

		private bool d;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEjectGripped(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CCoEject_003Ed__41))]
		private IEnumerator CoEject()
		{
			return null;
		}

		protected void Start()
		{
		}

		private void OnDriverSeated()
		{
		}

		private void OnDriverUnseated()
		{
		}

		[IteratorStateMachine(typeof(_003CCoFadeInput_003Ed__45))]
		private IEnumerator CoFadeInput()
		{
			return null;
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
