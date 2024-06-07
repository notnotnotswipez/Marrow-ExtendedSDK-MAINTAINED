using System;
using UnityEngine;
using UnityEngine.UI;

namespace SLZ.MLAgents
{
	public class LPPV_CarController : MonoBehaviour
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
		private float topSpeed;

		[SerializeField]
		private Transform centerOfMass;

		[SerializeField]
		private Text speedText;

		[HideInInspector]
		public bool Accelerating;

		[HideInInspector]
		public bool Deccelerating;

		[HideInInspector]
		public bool HandBrake;

		private Rigidbody _rgbd;

		private string imp;

		private string met;

		public float CurrentSpeed => 0f;

		private void VisualizeWheel(Wheel wheel)
		{
		}

		private void Start()
		{
		}

		private void Move(float motorInput, float steerInput, bool handBrake)
		{
		}

		private void StickToTheGround()
		{
		}

		private void ManageSpeed()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
