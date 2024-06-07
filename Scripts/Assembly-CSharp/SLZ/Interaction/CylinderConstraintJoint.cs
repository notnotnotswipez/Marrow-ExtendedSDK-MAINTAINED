using UnityEngine;

namespace SLZ.Interaction
{
	public class CylinderConstraintJoint
	{
		private const float MAX_DRIVE_SPRING_DISTANCE = 1E+10f;

		private const float MAX_DRIVE_DAMPEN_DISTANCE = 100000000f;

		private const float POSITION_THRESHOLD = 0.005f;

		private const float POSITION_THRESHOLD_SQR = 2.5E-05f;

		private const float ROTATION_MIN_THRESHOLD_DOT = 0.9999999f;

		private const float ROTATION_MAX_THRESHOLD_DOT = 0.9999985f;

		private const float ROTATION_5DEG_THRESHOLD_DOT = 0.9961947f;

		public bool hasXFriction;

		public bool hasYFriction;

		public bool hasZFriction;

		public bool hasAngularXFriction;

		public bool hasAngularYZFriction;

		private float _normalForce;

		private bool _isNormalForceDirty;

		private float _staticCoefficient;

		private bool _isStaticCoefficientDirty;

		private float _kineticCoefficient;

		private bool _isKineticCoefficientDirty;

		private bool _isBodyTranslating;

		private bool _isBodyRotating;

		private ConfigurableJoint _joint;

		private Rigidbody _rigidbody;

		private Rigidbody _connectedRigidbody;

		private bool _hasConnectedBody;

		private Quaternion _connBodyRot;

		private Vector3 _connBodyPos;

		private Quaternion _startRotation;

		private Quaternion _worldToJointSpace;

		private bool _isActive;

		public bool IsFrictionKinetic => false;

		public void Create(Rigidbody body, Rigidbody connectedBody = null, bool swapBodies = false, Vector3 axis = default(Vector3), Vector3 secondaryAxis = default(Vector3), float linearLimit = 0f, float xAngLimit = 0f, float yzAngLimit = 0f)
		{
		}

		public void SetNormalForce(float normalForce)
		{
		}

		public void SetBreakForce(float breakForce)
		{
		}

		public void SetStaticCoefficient(float coefficient)
		{
		}

		public void SetKineticCoefficient(float coefficient)
		{
		}

		public void SetAnchor(Vector3 anchor)
		{
		}

		public void SetConnectedAnchor(Vector3 connectedAnchor)
		{
		}

		public void UpdateBeforeSolve()
		{
		}

		public void Draw()
		{
		}

		public void SetTargetRotation(Quaternion targetRotation)
		{
		}

		public void SetTargetPosition(Vector3 targetPosition)
		{
		}

		public void Destroy()
		{
		}

		private void UpdateDrives()
		{
		}

		private void SetupJointConfig(bool swapBodies, Vector3 axis, Vector3 secondaryAxis, float linearLimit, float xAngLimit, float yzAngLimit)
		{
		}
	}
}
