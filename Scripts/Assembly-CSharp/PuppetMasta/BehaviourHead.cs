using RealisticEyeMovements;
using SLZ.Marrow.Combat;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;
using UnityEngine.AI;

namespace PuppetMasta
{
	public class BehaviourHead : BehaviourBase
	{
		public enum CrabState
		{
			Rest = 0,
			Meander = 1,
			Roam = 2,
			Investigate = 3,
			Agroed = 4,
			KnockedOut = 5,
			Facehug = 6,
			Headmount = 7
		}

		public enum LocoState
		{
			Idle = 0,
			Walking = 1,
			Rolling = 2,
			Jumping = 3,
			InAir = 4,
			Headmount = 5
		}

		protected enum JumpType
		{
			Dash = 0,
			Attack = 1,
			FaceMount = 2,
			OffmeshLink = 3
		}

		public SubBehaviourSensors sensors;

		public SubBehaviourHealth health;

		public SubBehaviourSfx sfx;

		public SubBehaviourFaceanim faceAnim;

		private Quaternion _lastRotation;

		private Quaternion _localAnimatedRoot;

		private NavMeshAgent _navAgent;

		private VisualDamageController _visualDamage;

		private int _emissColor;

		private EyeAndHeadAnimator _eyeBlinker;

		private float _time;

		private float _fixedTime;

		private Vector3 _animatedRoot;

		private Quaternion _locoRollRot;

		private bool _hasAttacked;

		private bool _jumpAttacking;

		private ConfigurableJoint _faceJoint;

		private readonly Vector3 _testRotationOffset;

		private readonly Vector3 _testPositionOffset;

		private readonly Vector3 _crabMouthLocalOffset;

		public CrabState crabState;

		public LocoState locoState;

		protected JumpType jumpType;

		[ColorUsage(true, true)]
		public Color eyeColor;

		[ColorUsage(true, true)]
		public Color agroColor;

		public Transform eyeTran;

		public Rigidbody targetRb;

		public float aiTickFreq;

		public float targetDistance;

		[Range(4f, 16f)]
		public float investigateRange;

		public float breakAgroTargetDistance;

		public float breakAgroHomeDistance;

		public float meanderSpeed;

		public float roamSpeed;

		public float agroedSpeed;

		public float jumpCooldown;

		public float jumpCharge;

		public bool enableJumpAttack;

		private CrabState _initialState;

		private CrabState _preAggroState;

		private Vector3 _homePosition;

		private bool _openInvestigation;

		private bool _investIsPosition;

		private bool _chargeJump;

		private bool _forceAiTick;

		private bool _blockAiTick;

		private bool _isCalculated;

		private float _dyingTime;

		private Vector3 _investigateTarget;

		private float _investigationTimer;

		private float _lastAiTickTime;

		private float _lastJumpTime;

		protected override void OnInitiate()
		{
		}

		protected override void OnActivate()
		{
		}

		public override void OnReactivate(int phase = 0)
		{
		}

		protected override void OnDeactivate()
		{
		}

		public override void Resurrect()
		{
		}

		public override void KillStart()
		{
		}

		public override void KillEnd()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnReadBehaviour()
		{
		}

		protected override void OnWriteBehaviour()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		private void ResetAnimator()
		{
		}

		protected void SetNavAgentToPhysics(float deltaTime = 0f)
		{
		}

		private void OnTriggerEnter(Collider c)
		{
		}

		public void Investigate(Vector3 target, bool isPosition = false)
		{
		}

		public void SetPath(Vector3 target)
		{
		}

		public void ClearPath()
		{
		}

		protected void Jump(JumpType jType)
		{
		}

		protected void PreJumpAttack()
		{
		}

		protected bool AttachToFace(Rigidbody face)
		{
			return false;
		}

		public void DetachFromFace()
		{
		}

		private static float PredictiveAimWildGuessAtImpactTime()
		{
			return 0f;
		}

		public static bool PredictiveAim(Vector3 muzzlePosition, float projectileSpeed, Vector3 targetPosition, Vector3 targetVelocity, float gravity, out Vector3 projectileVelocity)
		{
			projectileVelocity = default(Vector3);
			return false;
		}

		public void AiTick()
		{
		}

		private void SetupAiState(CrabState cState)
		{
		}

		private void ReturnToPreAgro()
		{
		}
	}
}
