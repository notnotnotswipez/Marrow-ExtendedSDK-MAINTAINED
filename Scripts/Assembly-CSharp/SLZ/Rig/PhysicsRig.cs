using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Data;
using SLZ.Interaction;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.Rig
{
	public class PhysicsRig : Rig
	{
		public enum BodyState
		{
			OnFoot = 0,
			Seated = 1,
			Ragdoll = 2,
			Prone = 3,
			Supine = 4,
			InAirControlled = 5,
			InAirRagdoll = 6
		}

		public enum StepState
		{
			NeutralRoll = 0,
			HoldStep = 1,
			ReturnStep = 2,
			Dangle = 3,
			Climbing = 4,
			Foothold = 5
		}

		[CompilerGenerated]
		private sealed class _003CCoResetHand_003Ed__124 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Handedness handedness;

			public PhysicsRig _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoResetHand_003Ed__124(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[Header("PhysicsRig")]
		public Hand leftHand;

		public Hand rightHand;

		public PhysTorso torso;

		public PhysLimb legLf;

		public PhysLimb legRt;

		public PhysSoftBody softbody;

		public HeadSFX headSfx;

		public ArtRig artOutput;

		public bool shutdown;

		public HashSet<Rigidbody> selfRbs;

		public int onLadder;

		public float ladderFade;

		private float _kneeCaY;

		private LadderInfo _ladderInfo;

		public bool bodyMassNaturalHold;

		private bool _bodyMassNatural;

		[SerializeField]
		private ImpactProperties[] _impactProperties;

		[SerializeField]
		private CollisionCollector[] _collisionCollectors;

		[SerializeField]
		private CollisionSfxManager _torsoSfxManager;

		[SerializeField]
		private SurfaceData _surfaceDataDefault;

		private Coroutine resetHandsCoroutine;

		private bool _ballLocoEnabled;

		private bool _legsKinematic;

		private SimpleTransform _initialPelvis;

		private SimpleTransform _initialSpine;

		private SimpleTransform _initialChest;

		private SimpleTransform _initialNeck;

		private SimpleTransform _initialHead;

		private SimpleTransform _initialJaw;

		private SimpleTransform _initialKnee;

		private SimpleTransform _initialFeet;

		private SimpleTransform _initialGhLf;

		private SimpleTransform _initialElbowLf;

		private SimpleTransform _initialHandLf;

		private SimpleTransform _initialGhRt;

		private SimpleTransform _initialElbowRt;

		private SimpleTransform _initialHandRt;

		private Quaternion _initialHipLf;

		private Quaternion _initialKneeLf;

		private Quaternion _initialFootLf;

		private Quaternion _initialHipRt;

		private Quaternion _initialKneeRt;

		private Quaternion _initialFootRt;

		private SimpleTransform _cachedPelvis;

		private SimpleTransform _cachedSpine;

		private SimpleTransform _cachedChest;

		private SimpleTransform _cachedNeck;

		private SimpleTransform _cachedHead;

		private SimpleTransform _cachedJaw;

		private SimpleTransform _cachedKnee;

		private SimpleTransform _cachedFeet;

		private SimpleTransform _cachedGhLf;

		private SimpleTransform _cachedElbowLf;

		private SimpleTransform _cachedHandLf;

		private SimpleTransform _cachedGhRt;

		private SimpleTransform _cachedElbowRt;

		private SimpleTransform _cachedHandRt;

		private Quaternion _cachedHipLf;

		private Quaternion _cachedKneeLf;

		private Quaternion _cachedFootLf;

		private Quaternion _cachedHipRt;

		private Quaternion _cachedKneeRt;

		private Quaternion _cachedFootRt;

		public BodyState bodyState;

		private float _avgDeltaTest;

		private float _skidSpeedTest;

		private float _monoRemainder;

		private float _monoVel;

		private float _doubleCooldown;

		private float _doubleLaunchWindow;

		private bool _doubleReady;

		[Header("Monofoot")]
		public GameObject knee;

		public GameObject feet;

		[SerializeField]
		private Rigidbody _kneeRb;

		[SerializeField]
		private Rigidbody _feetRb;

		[SerializeField]
		private ConfigurableJoint _kneePelJoint;

		[SerializeField]
		private ConfigurableJoint _feetKneeJoint;

		[SerializeField]
		private Servo _kneeHeadServo;

		[SerializeField]
		private Servo _kneeChestServo;

		[SerializeField]
		private Servo _kneePelServo;

		public CapsuleCollider kneePelvisCol;

		public LayerMask footballColCheckMask;

		[Range(0f, 1f)]
		public float overrideKneePelForce;

		public GameObject debugFootArt;

		[SerializeField]
		private float _pelvisForceMult;

		[SerializeField]
		private float _pelvisForceInternalMult;

		[SerializeField]
		private float _monoDamperMult;

		private float _footballRadius;

		private float _maxStepHeight;

		private Vector3 _kneeAnchorVelocity;

		[SerializeField]
		private SphereCollider _football;

		[SerializeField]
		private SphereCollider _kneeFender;

		private RaycastHit[] _footHits;

		[SerializeField]
		private PhysGrounder physG;

		private float _footballCircum;

		private const float kneeFenderMult = 1.0444444f;

		private StepState _stepState;

		private float _climbingOffset;

		private float _stepOffset;

		private float _stepOffsetVelocity;

		public bool canFall;

		private Vector2 _stepDelta;

		private Vector2 _stepDeltaOverTimeBuffer;

		private Vector2 _stepVel;

		private bool _returnStepTranslates;

		private Vector3 _stepCastBuffer;

		private Vector3 _climbingNormal;

		private Vector3 _climbingVelocity;

		private Vector3 _lastClimbingPoint;

		private Vector3 _climbingKneeJointVelocity;

		private Quaternion _lastKneeRotation;

		public Vector3 wholeBodyVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 wholeBodyAccel
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 pelvisVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 groundVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 skidVelocity
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float skidSpeed
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float groundAngVelocity
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float footSupported
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 pelvisAccel
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 spineDisplaceInWorld
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 spineDisplaceVelocityInWorld
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 grounderNormal => default(Vector3);

		public bool ungroundedThisFrame => false;

		public float pelvisHeightMult
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float physicalKneeDisplace
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool ballLocoEnabled => false;

		public Rigidbody rbKnee => null;

		public Rigidbody rbFeet => null;

		public ConfigurableJoint kneePelvisJoint => null;

		public float footballRadius => 0f;

		public StepState stepState => default(StepState);

		public Vector3 climbingVelocity => default(Vector3);

		public Vector3 climbingNormal => default(Vector3);

		public float monofootInternalMult
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void ResetHands(Handedness handedness)
		{
		}

		[IteratorStateMachine(typeof(_003CCoResetHand_003Ed__124))]
		private IEnumerator CoResetHand(Handedness handedness)
		{
			return null;
		}

		public override void Reset()
		{
		}

		public override void OnAwake()
		{
		}

		public override void OnStart()
		{
		}

		public override void OnRigEnable(bool reEnable)
		{
		}

		public override void OnRigDisable()
		{
		}

		public override void OnEarlyUpdate()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		public override void OnFixedUpdate(float deltaTime)
		{
		}

		public override void OnAfterFixedUpdate()
		{
		}

		public override void Teleport(SimpleTransform displace, bool zeroVelocity = false)
		{
		}

		public void TeleportToPose()
		{
		}

		public override void SetAvatar(SLZ.VRMK.Avatar avatar)
		{
		}

		public void SetBodySlot(SLZ.VRMK.Avatar avatar)
		{
		}

		private void ProcessSlotContainer(SLZ.VRMK.Avatar avatar, SlotContainer slotContainer)
		{
		}

		public void UpdateLadderInfo(LadderInfo info)
		{
		}

		public void LadderForce()
		{
		}

		public bool CheckDoubleJump(float newtonSecond, float cooldown = 1f)
		{
			return false;
		}

		private void DischargeMono()
		{
		}

		public void UpdateTotalDerivatives()
		{
		}

		private void CheckBodyMassDistribution()
		{
		}

		private void SetBodyMassDistribution()
		{
		}

		[ContextMenu("EnableBallLoco")]
		public void EnableBallLoco()
		{
		}

		[ContextMenu("DisableBallLoco")]
		public void DisableBallLoco()
		{
		}

		public void SetFrictionNatural()
		{
		}

		public void SetFrictionLow()
		{
		}

		public void KinematicLegs()
		{
		}

		public void PhysicalLegs()
		{
		}

		[ContextMenu("RagdollRig")]
		public void RagdollRig()
		{
		}

		[ContextMenu("UnRagdollRig")]
		public void UnRagdollRig()
		{
		}

		public void ShutdownRig()
		{
		}

		public void TurnOnRig()
		{
		}

		public void CalibrateJoints(SLZ.VRMK.Avatar avatar)
		{
		}

		public void OnMonofootUpdate()
		{
		}

		public void OnMonofootFixedUpdate()
		{
		}

		public void UpdateKnee(float feetTar, float deltaTime)
		{
		}

		public void UpdateMonofootColliders()
		{
		}

		public void ApplyFeetForce(Vector3 delta, Vector3 velocity)
		{
		}

		public void CheckStep(Rig inRig, Vector3 inputDelta, Vector3 inputVelocity)
		{
		}

		private bool CheckDangle()
		{
			return false;
		}

		private bool CheckClimb(Rig inRig, float castExtension, float mantle, out Vector3 supportPoint, out Vector3 virtuaPelvisWorld, out Vector3 castDir, out Vector3 trackPhysError, out RaycastHit hitInfo)
		{
			supportPoint = default(Vector3);
			virtuaPelvisWorld = default(Vector3);
			castDir = default(Vector3);
			trackPhysError = default(Vector3);
			hitInfo = default(RaycastHit);
			return false;
		}

		private void SwitchStepState(StepState to)
		{
		}

		private bool FootCast(Rig inRig, Vector3 inputVelocity, float forwardProject, out RaycastHit hitInfo, out float hitHeight, out float normalHitHeight)
		{
			hitInfo = default(RaycastHit);
			hitHeight = default(float);
			normalHitHeight = default(float);
			return false;
		}

		public bool SphereCastExcludeRbHashset(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, RaycastHit[] buffer, HashSet<Rigidbody> rbHashSet)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		public bool RaycastExcludeRbHashset(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, RaycastHit[] buffer, HashSet<Rigidbody> rbHashSet)
		{
			hitInfo = default(RaycastHit);
			return false;
		}

		private void HoldStep(Vector3 inputVelocity)
		{
		}

		private void StepFeet(Vector3 offsetWorld)
		{
		}

		private void ReturnStep(Vector3 inputVelocity)
		{
		}

		public void SetFootballSize(float mult)
		{
		}

		public void UpdateFootballRadius(bool runCheck = false)
		{
		}

		public void SetKneePelvisLimit(float minCrouchMeters, float maxCrouchMeters)
		{
		}
	}
}
