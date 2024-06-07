using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.VRMK
{
	public class PhysHand : MonoBehaviour
	{
		public enum HandPhysState
		{
			Empty = 0,
			RbOneHand = 1,
			RbTwoHand = 2,
			StaticOneHand = 3,
			StaticTwoHand = 4
		}

		[SerializeField]
		private Rigidbody _handRb;

		[SerializeField]
		private Rigidbody _upperArmRb;

		[SerializeField]
		private Rigidbody _lowerArmRb;

		[SerializeField]
		private Servo _handChestServo;

		[SerializeField]
		private Servo _shoulderServo;

		[SerializeField]
		private Servo _elbowServo;

		[SerializeField]
		private Servo _wristServo;

		[SerializeField]
		private Servo _supportHandServo;

		public PhysicsRig physBody;

		public Hand hand;

		public PhysHand otherHand;

		public float dampening;

		public float newtonDamp;

		public float additionalMass;

		public bool shutdown;

		[SerializeField]
		private float _forceMultiplier;

		[SerializeField]
		private float _armInternalMult;

		[Header("Shoulder Muscles")]
		public float xPosForce;

		public float xNegForce;

		public float yPosForce;

		public float yNegForce;

		public float zPosForce;

		public float zNegForce;

		[Header("Wrist Muscles")]
		public float maxTorque;

		public float angDampening;

		public float gripMult;

		private float _jerkedMult;

		private float _angJerkMult;

		private float _shock;

		private float _xPos;

		private float _xNeg;

		private float _yPos;

		private float _yNeg;

		private float _zPos;

		private float _zNeg;

		private Quaternion _muscleSpace;

		public CapsuleCollider inventoryPlug;

		public MeshCollider cUpper;

		public MeshCollider cLower;

		public BoxCollider handCol;

		public BoxCollider fingersCol;

		public CylinderGrip gShoulder;

		public CylinderGrip gElbow;

		private Vector3 _lastTargetLocalPos;

		private Quaternion _lastTargetRotation;

		private float _lastForceMult;

		private Vector3 _lastForce;

		private Vector3 _lastVel;

		private float _lastTorqueSqMg;

		private bool _colliding;

		private Vector3 _collisionImpulse;

		public Vector3 currentCollision;

		private float _handSupported;

		private float _armMantle;

		private float _curlLerp;

		private bool _isHighFriction;

		private bool _fingerEnableFlag;

		[SerializeField]
		private PhysicMaterial _highFriction;

		[SerializeField]
		private PhysicMaterial _naturalFriction;

		[SerializeField]
		private PhysicMaterial _lowFriction;

		public LayerMask fingerColCheckMask;

		public bool drawMaxForceDebug;

		public bool drawAccuracyDebug;

		public bool forceViaJoint;

		public HandPhysState handPhysState;

		private const float _staticCheatMult = 0.3f;

		public Rigidbody rbHand => null;

		public Rigidbody rbUpper => null;

		public Rigidbody rbLower => null;

		public float handSupported
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float armMantle => 0f;

		public float armInternalMult
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 lastForce => default(Vector3);

		private void Awake()
		{
		}

		public void IgnorePhysHand(PhysHand physHand, bool ignore = true)
		{
		}

		public void IgnoreHandRbColliders(Collider col, bool ignore = true)
		{
		}

		public void IgnoreWholeArmColliders(Collider col, bool ignore = true)
		{
		}

		public void IgnoreWholeArmColliders(Collider[] col, bool ignore = true)
		{
		}

		public void CalibrateArmColliders(Avatar avatar, bool isRight = false)
		{
		}

		public void CalibrateArmJoints(Avatar avatar, bool isRight = false)
		{
		}

		public void CalibrateLimbGrips(Avatar avatar, bool isRight = false)
		{
		}

		public void UpdateArmTargets(SimpleTransform chest, Transform shoulder, Transform elbow, Transform hand, Transform support, Vector3 kinematicSupportVelocity, float maxLength, float deltaTime, bool monofootEnabled)
		{
		}

		public void SetArmMass(float mass, bool isRight, Vector2 handSize)
		{
		}

		public void CalibrateJoints(float avatarArmMult, float gripMult, bool monofootEnabled)
		{
		}

		public void UpdateColliders(float curl, Vector2 handSize, bool isRight = false)
		{
		}

		public void DisableFingerCollider()
		{
		}

		public void EnableFingerCollider()
		{
		}

		private void CheckFingerEnable()
		{
		}

		public Vector3 GetArmMomentum(out float totalMass)
		{
			totalMass = default(float);
			return default(Vector3);
		}

		public void EarlyUpdateArm()
		{
		}

		public void UpdateArmDrives(float slerpForceMult, float slerpSpringMult, float slerpDampMult)
		{
		}

		public void UpdateArmSupportDrives(float slerpForceMult, float slerpSpringMult, float slerpDampMult, bool monofootEnabled)
		{
		}

		public void ZeroTargets()
		{
		}

		public void SwitchSupportToMono(Quaternion handRot, Quaternion supportRot)
		{
		}

		public void SwitchSupportToChest(Quaternion handRot, Quaternion chestRot)
		{
		}

		public void FixedUpdateArm(Vector3 targetLocalPos, Quaternion targetRotation, ConfigurableJoint joint, float gripInput, bool secondToSolveAndStatic, bool monofootEnabled)
		{
		}

		private void ApplyForce(Vector3 targetLocalPos, float forceMult, ConfigurableJoint joint, bool secondToSolveAndStatic)
		{
		}

		private void PrepShoulderMuscle(Vector3 handVelocity, float forceMult, Vector3 newtonsDamped)
		{
		}

		private Vector3 MuscleClamp(Vector3 desiredForce)
		{
			return default(Vector3);
		}

		private Vector3 MuscleMax(Vector3 direction)
		{
			return default(Vector3);
		}

		private void SetFriction(float grip)
		{
		}

		public void SetFrictionNatural()
		{
		}

		public void SetFrictionLow()
		{
		}

		public void SetRangeOfMotionNatural()
		{
		}

		public void SetRangeOfMotionActive()
		{
		}

		private float RelaxTorqueMult(float grip)
		{
			return 0f;
		}

		private void ApplyTorque(Quaternion targetRotation, float maxTor, ConfigurableJoint joint, bool monofootEnabled)
		{
		}

		private void ApplyTorque2(Quaternion targetRotation, float maxTor, ConfigurableJoint joint, bool monofootEnabled)
		{
		}

		public bool RefreshHandStates(ConfigurableJoint thisJ, ConfigurableJoint otherJ, out bool otherHandStatic)
		{
			otherHandStatic = default(bool);
			return false;
		}

		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}

		private bool IsNanV3(Vector3 v)
		{
			return false;
		}

		private Vector3 AbsV3(Vector3 v)
		{
			return default(Vector3);
		}

		public void SetHand(Vector3 worldPosition, Quaternion worldRotation, bool zeroVelocity = true)
		{
		}

		public void ClearJerk(float newJerk = 0f)
		{
		}

		public void CollisionRelay(Collision c)
		{
		}

		public void ReadSensors(ConfigurableJoint joint, ref float divByNewtons)
		{
		}

		private float ArmMantle()
		{
			return 0f;
		}

		public bool ResetHand()
		{
			return false;
		}

		public bool ResetHand(Transform elbow, Vector3 elbowFwd)
		{
			return false;
		}
	}
}
