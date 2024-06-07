using System;
using SLZ.Marrow.AI;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Combat
{
	public class RigidbodyProjectile : MonoBehaviour, IAttackReceiver, IEventSystemHandler
	{
		[SerializeField]
		private Rigidbody _rb;

		private float _initialTime;

		private Collider[] m_OverlappingColliders;

		public LayerMask attackLayerMask;

		public LayerMask blockLayerMask;

		public AttackType attackType;

		public AudioClip[] throwClips;

		public AudioClip[] hitClips;

		public TriggerRefProxy throwerProxy;

		[SerializeField]
		private Spawnable blastSpawnable;

		public float BlastRadius;

		public float BlastDamage;

		private Vector3 Vec3EffectScale;

		public Collider col;

		public static Action OnProjectileShot;

		public Rigidbody Rb => null;

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		private void BlowUp(Attack attack)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}
	}
}
