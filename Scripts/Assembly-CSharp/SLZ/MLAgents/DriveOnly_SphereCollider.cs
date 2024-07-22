using System;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.MLAgents
{
	public class DriveOnly_SphereCollider : MonoBehaviour
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
			public ConfigurableJoint cvJoint;

			public GameObject mesh;

			public WheelType wheelType;
		}

		public GameObject orientation_cube;

		[HideInInspector]
		[SerializeField]
		public Rigidbody _rb;

		[SerializeField]
		private Wheel[] wheels;

		[SerializeField]
		private float maxTorque;

		[SerializeField]
		private float maxBrakeTorque;

		[SerializeField]
		private float maxSteerAngle;

		[SerializeField]
		private float maxAngVel;

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

		[SerializeField]
		private Text speedText;

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

		private Vector3 nan_rot;

		public Collider spawnArea;

		public float spawn_rotation;

		public float rotation_clamp;

		private float last_steerInput;

		private float last_motorInput;

		private float speed_ratio;

		private float[] wheelsGrounded;

		public bool lerpSteering;

		public float steeringLerpScale;

		public float wheelRadius;

		public float maxSpeed;

		public Rigidbody steeringWheel;

		public Rigidbody frontAxle;

		private ConfigurableJoint _steeringHinge;

		public float CurrentSpeed => 0f;

		public void PlaceVehicle(Vector3 pos, Vector3 rot)
		{
		}

		private void StickToTheGround()
		{
		}

		private void ManageSpeed()
		{
		}

		private void VisualizeWheel(Wheel wheel)
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private void OnCollisionStay(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}

		public void OnActionReceived()
		{
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Start()
		{
		}
	}
}
