using System;
using System.Collections;
using System.Collections.Generic;
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
		private void Start()
		{
		}

		public void DeactivateCrane()
		{
		}

		public void FULLCRANERESET()
		{
		}

		public IEnumerator FullCraneResetCoroutine()
		{
			return null;
		}

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

		public CraneControlBox()
		{
		}

		public GameObject lineRenderers;

		public JoystickForwarder joystick;

		public SLZ.Marrow.VoidLogic.PowerSource zControls;

		public SLZ.Marrow.VoidLogic.PowerSource gravControlButtonPowerSource;

		public PassthroughNode gravControlButtonPowerCutOff;

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
	}
}
