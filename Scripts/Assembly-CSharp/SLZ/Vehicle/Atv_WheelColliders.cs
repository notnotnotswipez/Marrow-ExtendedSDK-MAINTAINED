using System;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Vehicle
{
	public class Atv_WheelColliders : MonoBehaviour
	{
		public enum WheelType
		{
			FrontLeft = 0,
			FrontRight = 1,
			RearLeft = 2,
			RearRight = 3
		}

		public enum SpeedUnit
		{
			Imperial = 0,
			Metric = 1
		}

		[Serializable]
		private class Wheel
		{
			public WheelCollider collider;

			public GameObject mesh;

			public WheelType wheelType;
		}

		[SerializeField]
		private Wheel[] wheels;

		[SerializeField]
		private float maxTorque;

		[SerializeField]
		private float maxBrakeTorque;

		[SerializeField]
		private float maxSteerAngle;

		[SerializeField]
		private static int NoOfGears;

		[SerializeField]
		private float downForce;

		[SerializeField]
		private SpeedUnit speedUnit;

		[SerializeField]
		public float topSpeed;

		[SerializeField]
		private float topReverseSpeed;

		[SerializeField]
		private Transform centerOfMass;

		[HideInInspector]
		public bool Accelerating;

		[HideInInspector]
		public bool Deccelerating;

		[HideInInspector]
		public bool Left;

		[HideInInspector]
		public bool Right;

		[HideInInspector]
		public float HandBrake;

		private string imp;

		private string met;

		public Grip throttleGrip;

		public InteractableHost wheel;

		public ConfigurableJoint frontLf;

		public ConfigurableJoint frontRt;

		public ConfigurableJoint backLf;

		public ConfigurableJoint backRt;

		public float maxSpeed;

		public float wheelRadius;

		public Rigidbody steeringWheel;

		public Rigidbody frontAxle;

		private ConfigurableJoint _steeringHinge;

		public Seat driverSeat;

		private float _lastThrottleSet;

		private float last_steerInput;

		private float steerInput;

		public float steeringLerpScale;

		public bool use_keyboard;

		private void VisualizeWheel(Wheel wheel)
		{
		}

		private void Start()
		{
		}

		private void UpdateCar(float axis, float steerInput, float handBrake)
		{
		}

		private void Update()
		{
		}
	}
}
