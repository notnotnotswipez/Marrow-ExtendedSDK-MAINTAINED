using System.Collections.Generic;
using SLZ.Marrow;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GripThruster : MonoBehaviour
	{
		public GravGunSFX sfx;

		public Grip triggerGrip;

		public Vector3 forward;

		private float _triggerStartTime;

		private float _cooldownStartTime;

		public float launchForce;

		public Rigidbody rb;

		public float cooldownTime;

		public AudioClip noCoolClip;

		public Color _color;

		public LayerMask enemyLayermask;

		public float explosionRadius;

		public float minExplosionForce;

		public float maxExplosionForce;

		public HashSet<AIBrain> brainHash;

		private bool isExploding;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnAttachedUpdate(Hand hand)
		{
		}

		public void ApplyThrust()
		{
		}

		[ContextMenu("GetNearbyEnemies")]
		public void GetNearbyEnemies()
		{
		}

		[ContextMenu("Explode")]
		public void ExplodeFromHere()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
