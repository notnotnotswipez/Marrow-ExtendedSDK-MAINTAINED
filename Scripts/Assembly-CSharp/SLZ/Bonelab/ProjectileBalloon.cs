using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Pool;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Bonelab
{
	public class ProjectileBalloon : SpawnEvents, IAttackReceiver, IEventSystemHandler
	{
		[CompilerGenerated]
		private sealed class _003CCoDelayFire_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProjectileBalloon _003C_003E4__this;

			public Vector3 forward;

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
			public _003CCoDelayFire_003Ed__33(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoWarmupAttach_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ProjectileBalloon _003C_003E4__this;

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
			public _003CCoWarmupAttach_003Ed__34(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
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

		public ParticleSystem ps;

		public Transform hosttransform;

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

		[IteratorStateMachine(typeof(_003CCoDelayFire_003Ed__33))]
		private IEnumerator CoDelayFire(Vector3 position, Vector3 forward)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoWarmupAttach_003Ed__34))]
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
	}
}
