using UnityEngine;

namespace SLZ.MLAgents
{
	public class PhysVehicleAIInput : MonoBehaviour
	{
		[Tooltip("Value referenced by ai for steering input and this script for deadzone")]
		public float steerVal;

		[Tooltip("Used for getting vehicles current and top speed and using it for damping")]
		public BaseVehicleUtils baseVehicleUtils;

		[Tooltip("The joint whos target rotation will be set for steering value to steering column (front axel)")]
		public ConfigurableJoint steerJoint;

		[Tooltip("Used in getting steering wheel un-rotated for respawning")]
		public Quaternion _steerInitialRotation;

		[Tooltip("Normalized value representing the handbrake twist input val")]
		public float hBrakeVal;

		[Tooltip("The joint whos target rotation will be set for hand breaking")]
		public ConfigurableJoint handBrakeJoint;

		[Tooltip("Used in getting hand brake joint un-rotated for respawning")]
		public Quaternion _hbInitialRotation;

		[Tooltip("Spring ranges used for normalization/remapping")]
		public float minSpringForce;

		[Tooltip("Spring ranges used for normalization/remapping")]
		public float maxSpringForce;

		[Tooltip("Damper ranges used for normalization/remapping")]
		public float minDamperForce;

		[Tooltip("Damper ranges used for normalization/remapping")]
		public float maxDamperForce;

		private JointDrive steerAngDrive;

		private float fadeDuration;

		[Tooltip("Rigidbody of wheel")]
		public Rigidbody steerRb;

		private float steerDeadZone;

		[Tooltip("Used in setting target rotation of wheel joint")]
		public float maxSteerVelX;

		[Tooltip("Used in setting target rotation of hb joint")]
		public float maxHBVelX;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		public float ValueRemapper(float fromValue, float fromLow, float fromHigh, float toLow, float toHigh)
		{
			return 0f;
		}

		public float GetTwistInDegrees(ConfigurableJoint joint, Quaternion startLocalRotation)
		{
			return 0f;
		}
	}
}
