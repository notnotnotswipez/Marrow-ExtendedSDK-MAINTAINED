using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class SphereVehicleUtils : BaseVehicleUtils
	{
		[Serializable]
		public class SphereWheel
		{
			[Tooltip("The joint that is responsible for driving and turning the wheel")]
			public ConfigurableJoint wheelJoint;

			[Tooltip("The art for the wheel")]
			public GameObject mesh;

			[Tooltip("Location of wheel relative to vehicle space (not used right now)")]
			public WheelType wheelType;

			[Tooltip("The sphere collider that physically represents the wheel")]
			public SphereCollider sphereCol;

			public Rigidbody rb;

			public bool grounded;

			public RaycastHit rayHit;

			public int groundLayer;

			public string groundString;

			private float rayLength;

			private RaycastHit[] rayHits;

			public int CheckGroundRays()
			{
				return 0;
			}
		}

		public enum WheelType
		{
			FrontLeft = 0,
			FrontRight = 1,
			RearLeft = 2,
			RearRight = 3
		}

		[Tooltip("Reference of config joint")]
		[Header("Sphere Vehicle Section")]
		public Rigidbody steeringWheel;

		[Tooltip("Reference of config joint")]
		public Rigidbody frontAxle;

		[Tooltip("Used for calculating target angular velocity")]
		public float wheelRadius;

		[Tooltip("Modifier for power into the wheels")]
		public float wheelForceMod;

		[Tooltip("Reference to each sphere wheel class attached to each sphere collider wheel object")]
		public SphereWheel[] sphereWheels;

		[Tooltip("Toggles the usage of wheel rays")]
		public bool checkGrounded;

		[Tooltip("Check to apply force to flip vehicle over when upsidedown")]
		public bool useFlipOver;

		private float dynamicSteerAngle;

		private float dynamicSteerLerp;

		public new event Action Fallen
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private new void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		public new void ForceRest()
		{
		}

		public override void PlaceVehicle(BaseVehicle car, Vector3 pos, Vector3 rot)
		{
		}

		private void CheckWheelsGrounded()
		{
		}

		public override void Drive(float motorInput, float steerInput, float handBrake, bool reverseEyes = false, bool discreteControl = true)
		{
		}
	}
}
