using SLZ.Bonelab.Obsolete;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BehaviourHovercraft : BehaviourBase
	{
		public SubBehaviourSensors sensors;

		public SubBehaviourHealth health;

		public SubBehaviourSfx sfx;

		public bool isDespawnOnDeath;

		[Range(0f, 720f)]
		public float turnRate;

		[Range(0f, 60f)]
		public float maxBankAngle;

		[Range(0.1f, 4f)]
		public float bankResponsiveness;

		private Quaternion _lastRotation;

		private Quaternion _localAnimatedRoot;

		private Powerable_Vehicle _powerVehicle;

		private float _blockCollisionsUntil;

		private bool _debugDrawHierarchy;

		private bool _engineOn;

		private Quaternion _bodyAccelQuat;

		public AudioSource skidSource;

		public MeshRenderer stallMesh;

		public bool bypassBatteries;

		public bool resetHack;

		public Control_PowerLever throttle;

		public Rigidbody wingLf;

		public Rigidbody wingRt;

		public Rigidbody[] rebarRope;

		private Quaternion[] _rebarInitRot;

		private float _time;

		private float _fixedTime;

		private float _currentRotVel;

		private float _currentRotDelta;

		private Vector3 _animatedRoot;

		private Quaternion _propellerLocalRot;

		private Vector3 _joyWorldV3;

		private float _throttleMult;

		private int _batteries;

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

		protected override void OnFixedUpdate()
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

		private float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return 0f;
		}

		private void SetNavAgentToPhysics(float deltaTime = 0f)
		{
		}

		private void UpdateStun()
		{
		}

		private void ResetAnimator()
		{
		}

		protected void ProcessInputs()
		{
		}
	}
}
