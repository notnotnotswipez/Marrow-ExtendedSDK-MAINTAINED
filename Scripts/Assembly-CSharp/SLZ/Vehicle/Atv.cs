using SLZ.Marrow.Audio;
using SLZ.SFX;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Vehicle
{
	public class Atv : MonoBehaviour
	{
		public ConfigurableJoint frontLf;

		public ConfigurableJoint frontRt;

		public ConfigurableJoint backLf;

		public ConfigurableJoint backRt;

		public float maxSpeed;

		public float wheelRadius;

		public Rigidbody steeringWheel;

		public Rigidbody frontAxle;

		public Rigidbody mainBody;

		private ConfigurableJoint _steeringHinge;

		public Seat driverSeat;

		public MotorSFX motorSfx;

		public PhysicMaterial inSeatMaterial;

		public PhysicMaterial outOfSeatMaterial;

		public Collider colliderToMaterialSwap;

		public CollisionStaySensor frontLfStaySensor;

		public CollisionStaySensor frontRtStaySensor;

		public CollisionStaySensor backLfStaySensor;

		public CollisionStaySensor backRtStaySensor;

		private float _lastThrottleSet;

		private float _lastNormedSpeed;

		private bool _motorRunning;

		private ManagedAudioPlayer _mapSkid;

		public AudioClip skidPavement;

		private Rigidbody _frontLfRb;

		private Rigidbody _frontRtRb;

		private Rigidbody _backLfRb;

		private Rigidbody _backRtRb;

		private float _lastFrontLfPressure;

		private float _lastFrontRtPressure;

		private float _lastBackLfPressure;

		private float _lastBackRtPressure;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateSkid(float skidSpeed, float pressure, Vector3 localPosition)
		{
		}
	}
}
