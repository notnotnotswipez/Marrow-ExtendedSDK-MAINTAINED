using SLZ.Combat;
using SLZ.Marrow.Audio;
using SLZ.VRMK;
using UnityEngine;

namespace SLZ.SFX
{
	public class HandSFX : MonoBehaviour
	{
		public AudioClip[] grab;

		public AudioClip[] grabBig;

		public AudioClip[] drop;

		public AudioClip[] bodySlot;

		public AudioClip[] fallbackImpact;

		public AudioClip[] slide;

		public AudioClip[] punch;

		public AudioClip[] slap;

		public AudioClip[] backhand;

		public AudioClip[] punchSlowMo;

		public AudioClip[] slapSlowMo;

		public AudioClip[] backhandSlowMo;

		public AudioClip whoosh;

		public AudioClip forceGrab;

		public AudioClip forceGrabLong;

		public LayerMask meleeAttackMask;

		public float minSpeed;

		public float maxSpeed;

		public float volumeMulti;

		public AnimationCurve VelocityPitchCurve;

		public float realtimeWhooshUpdateFrequency;

		[SerializeField]
		private PhysHand _physHand;

		private ManagedAudioPlayer _mapImpact;

		private ManagedAudioPlayer _mapSlide;

		private Rigidbody _rb;

		private float _nextImpactTime;

		private float _lastImpulse;

		private float _nextSlideTime;

		private float _lastAccelSqMg;

		private Vector3 _lastRelVelPlane;

		private int _enemyLayer;

		[SerializeField]
		private CollisionCollector _collisionCollector;

		private bool _fixedRan;

		private float _lastHandChestVelSqMg;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void Grab(float volumeMult)
		{
		}

		public void BodySlot()
		{
		}

		public void Drop()
		{
		}

		public void ForcePull(float massDistance)
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void OnSignificantCollisionEnter(CollisionCollector.RelevantCollision c)
		{
		}

		private void OnSignificantCollisionStay(CollisionCollector.RelevantCollision c)
		{
		}

		private void Slide(float speed, float impulse, float relAccelSqMg)
		{
		}

		private bool PunchAttack(CollisionCollector.RelevantCollision c, float impulse, float relVelSqr)
		{
			return false;
		}

		private void OnCollisionStay(Collision c)
		{
		}
	}
}
