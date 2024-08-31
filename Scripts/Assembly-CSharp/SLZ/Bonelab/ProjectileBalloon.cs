using System;
using System.Collections;
using SLZ.Marrow;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class ProjectileBalloon : SpawnEvents, IAttackReceiver, IEventSystemHandler
	{
		protected override void Awake()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		public override void OnPoolDeInitialize()
		{
		}

		private void AttachJoint(Rigidbody connectedBody, Vector3 impactPosition)
		{
		}

		private void AttachBuoyancyJoint()
		{
		}

		private void LateUpdate()
		{
		}

		private IEnumerator CoDelayFire(Vector3 position, Vector3 forward)
		{
			return null;
		}

		private IEnumerator CoWarmupAttach()
		{
			return null;
		}

		private void TakeDamage(Vector3 attackDir)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		public void SetColor(Balloon.BalloonColor color)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		public ProjectileBalloon()
		{
		}

		[Header("Options")]
		public LayerMask collisionLayers;

		[Tooltip("Effective Range of Raycast")]
		public float effectiveRange;

		[Tooltip("Max Velocity After Impact")]
		public float maxVelocity;

		[Tooltip("Balloon's Up Force")]
		public float constantBuoyantForce;

		[Tooltip("Impact Force Before Popping")]
		public float maxImpactForce;

		[Header("References")]
		public Spawnable airPopVFXSpawnable;

		public Spawnable balloonPopVfxSpawnable;

		public GameObject[] balloonArt;

		public Transform stringStartTransform;

		public Transform forceTargetTransform;

		public AudioClip[] inflateSFX;

		private float sqrMaxVelocity;

		private float sqrMaxImpactForce;

		private MarrowJoint joint;

		private MarrowJoint _buoyancyMarrowJoint;

		private MeshRenderer[] artRenderer;

		private LineRenderer lineRenderer;

		private Rigidbody rb;

		private ImpactSFX impactSFX;

		private float _scaledBuoyantForce;

		private float defaultDrag;

		private bool hasConnectedBody;

		private bool isWarmingUp;

		public Poolee poolee;

		public Color _color;

		public LineRenderer linerenderer;

		public Transform hosttransform;
	}
}
