using SLZ.Combat;
using SLZ.Marrow.AI;
using SLZ.Marrow.Audio;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.SFX
{
	public class HeadSFX : MonoBehaviour
	{
		[Header("Jump Effort")]
		public AudioClip[] jumpEffort;

		public AudioClip[] doubleJump;

		[Header("Take Damage")]
		public AudioClip[] smallDamage;

		public AudioClip[] bigDamage;

		public AudioClip[] dying;

		public AudioClip[] dead;

		public AudioClip[] recovery;

		public AudioSource mouthSrc;

		public AudioLowPassFilter mouthLowPass;

		[Header("Headbutt")]
		public LayerMask meleeAttackMask;

		public AudioClip[] headbuttClips;

		public AudioClip[] headbuttClipsSlowmo;

		public TriggerRefProxy proxy;

		private float _speachEnd;

		private float _lastJumpEffort;

		private float _lastImpactTime;

		private Rigidbody _rbHead;

		[SerializeField]
		private PhysicsRig _physRig;

		[SerializeField]
		private CollisionCollector _collisionCollector;

		private float _nextImpactTime;

		private float _lastImpulse;

		private float _nextSlideTime;

		private float _lastAccelSqMg;

		private Vector3 _lastRelVelPlane;

		private ManagedAudioPlayer _mapImpact;

		private bool _fixedRan;

		private float _lastHeadChestAngVelSqMg;

		public bool isSpeaking => false;

		public void Speak(AudioClip clip, bool playDelayed = false, bool overwrite = true)
		{
		}

		public void SmallDamageVocal(float damage)
		{
		}

		public void BigDamageVocal()
		{
		}

		public void DyingVocal()
		{
		}

		public void DeathVocal()
		{
		}

		public void RecoveryVocal()
		{
		}

		public void JumpEffort()
		{
		}

		public void DoubleJump()
		{
		}

		private void OnSignificantCollisionEnter(CollisionCollector.RelevantCollision c)
		{
		}

		private bool BluntAttack(CollisionCollector.RelevantCollision c, float impulseNormed)
		{
			return false;
		}

		private void OnSignificantCollisionStay(CollisionCollector.RelevantCollision c)
		{
		}

		private void UpdateLowPass()
		{
		}

		private float ProcessImpulse(Collision c, Rigidbody thisRb)
		{
			return 0f;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
