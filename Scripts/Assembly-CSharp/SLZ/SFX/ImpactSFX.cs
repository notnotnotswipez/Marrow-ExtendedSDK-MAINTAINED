using System;
using SLZ.Interaction;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.SFX
{
	public class ImpactSFX : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		public AudioClip[] impactSoft;

		public AudioClip[] impactHard;

		public AudioClip[] destruction;

		public AudioClip[] jointBreak;

		public Collider[] altImpactColliders;

		public AudioClip[] altImpact;

		public float pitchMod;

		public bool bluntAttack;

		public float bluntDamageMult;

		public float minVelocity;

		public float velocityClipSplit;

		public float jointBreakVolume;

		[HideInInspector]
		public ImpactSfxManager manager;

		private InteractableHost _host;

		private float _minVelSquared;

		private float _mass;

		private Rigidbody _rb;

		private ManagedAudioPlayer _mapImpact;

		private float _nextImpactTime;

		private float _lastImpactImpulse;

		private float _pitchMod;

		private MarrowBody _marrowBody;

		private bool _altColliders;

		public Action<Collision, float> OnSignificantCollision;

		private void Awake()
		{
		}

		public void SetPitchMultiplier(float value)
		{
		}

		private void Initialize()
		{
		}

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		public void ImpactSound(Collision c)
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}

		public void JointBreakFx(AudioClip[] breakClips)
		{
		}

		public void DestructionEvent(float volume = 1f)
		{
		}

		private bool AltColliderCheck(Collider hitCol)
		{
			return false;
		}

		private bool CheckImpact(float impulse)
		{
			return false;
		}

		public void ReceiveAttack(Attack attack)
		{
		}
	}
}
