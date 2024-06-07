using System;
using SLZ.Marrow.Utilities;
using SLZ.VRMK;
using UnityEngine;
using UnityEngine.AI;

namespace SLZ.Rig
{
	public class RemapRig : HeptaRig
	{
		public enum TraversalState
		{
			Walk = 0,
			Jog = 1,
			Run = 2,
			Jump = 3,
			Leap = 4,
			Airborne = 5,
			HandClimb = 6,
			QuadClimb = 7,
			FootClimb = 8
		}

		public enum VertState
		{
			Stand = 0,
			Crouch = 1,
			Kneel = 2,
			Prone = 3,
			Supine = 4,
			SitChair = 5,
			SitFloor = 6
		}

		[Header("RemapHeptaRig")]
		public Transform testGazeTarget;

		public bool physicalTwistAlignEnabled;

		private float _lfCurlLerp;

		private float _rtCurlLerp;

		private float _velocitySanGravMagRetainer;

		private float _accelSanGravMagRetainer;

		private float _accelDuckRetainer;

		private float _accelDuckVelocity;

		private float _lastSwingOff;

		private float _platformAngularVel;

		private float _platformAngularAccel;

		[SerializeField]
		private AnimationCurve _dirVel;

		private BodyPose _inBasePose;

		public Rig testAdditiveRig;

		private BodyPose _addSubtractivePose;

		private BodyPose _basePose;

		private RigWeights _baseWeights;

		private BodyPose _inAdditivePose;

		public RigWeights _inWeights;

		private BodyPose _addAdditivePose;

		public RigWeights _addWeights;

		[Range(0f, 1f)]
		public float inWeight;

		[Range(0f, 1f)]
		public float addWeight;

		public NavMeshAgent _navAgent;

		[Header("Movement")]
		public float maxVelocity;

		public float maxAcceleration;

		public float jumpVelocity;

		public float dragPerSec;

		public float brakingMult;

		public float doubleJumpPower;

		public TraversalState travState;

		public VertState vertState;

		private Vector2 _currentVelocity;

		private Vector2 _currentAcceleration;

		private Vector2 _effectiveAcceleration;

		private Vector3 _vcLocoDeltaLf;

		private Vector3 _vcLocoDeltaRt;

		private Vector3 _vcLocoNormalLf;

		private Vector3 _vcLocoNormalRt;

		private int _vcLocoDofLf;

		private int _vcLocoDofRt;

		private bool _vcActive;

		private float _lastPelvisHeight;

		private float _smoothTwist;

		protected float currentMaxVelocity;

		public AnimationCurve JumpCurve;

		public AnimationCurve SwingCounterCurve;

		private float _crouchTarget;

		private float _crouchVelocity;

		private float _feetOffset;

		private float _crouchSpeedLimit;

		private bool _jumping;

		private int _jumpStage;

		private float _jumpCycle;

		private float _timeOfFlight;

		private float _spineCrouchOff;

		private Vector2 _trackedDebt;

		private Vector2 _locoDebt;

		private Vector2 _physDebt;

		private Vector2 _trackedApplied;

		private Vector2 _locoApplied;

		private Vector2 _physApplied;

		private Vector2 _artificialDelta;

		protected Vector3 _lastTrackedHead;

		protected SimpleTransform _lastHmdLocal;

		protected SimpleTransform _lastContLfLocal;

		protected SimpleTransform _lastContRtLocal;

		private Vector3 _trackedHeadDelta;

		public bool jumpEnabled;

		public bool doubleJump;

		public Action onPlayerJump;

		private Quaternion _rotationOffset;

		private bool _rotationOffsetDirty;

		private bool _rotationOffsetWasDirty;

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public override void OnAfterFixedUpdate()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void Teleport(SimpleTransform displace, bool zeroVelocity = false)
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		protected virtual void ApplyMovement(Vector2 axis, bool inputPressed, float deltaTime)
		{
		}

		private void ApplyRotation(float deltaTime, float smoothTwist)
		{
		}

		public void SetTwist(float degrees)
		{
		}

		public void SetRotate(Quaternion offset)
		{
		}

		private void JumpCharge(float deltaTime, ref bool feetOverride, bool chargeInput = true)
		{
		}

		public void Jump()
		{
		}

		private void Jumping(float deltaTime, ref bool feetOverride)
		{
		}

		private void JumpEnd()
		{
		}

		protected virtual void CrouchHold(float deltaTime, ref bool feetOverride, float crouchRate = -1f, bool crouchInput = true)
		{
		}

		protected void MoveSpineCrouchOffTowards(float target, float deltaTime, float rate = 6.5f)
		{
		}

		private bool MantleGesture(out float mantle)
		{
			mantle = default(float);
			return false;
		}

		public Vector2 GetVelocity()
		{
			return default(Vector2);
		}

		public Vector2 GetAcceleration()
		{
			return default(Vector2);
		}

		public void SetVcLocomotionLf(Vector3 deltaLf, Vector3 normalLf, int positionalDof = 0)
		{
		}

		public void SetVcLocomotionRt(Vector3 deltaRt, Vector3 normalRt, int positionalDof = 0)
		{
		}
	}
}
