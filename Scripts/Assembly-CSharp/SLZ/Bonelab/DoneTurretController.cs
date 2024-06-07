using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DoneTurretController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CTurretUpdateLoop_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DoneTurretController _003C_003E4__this;

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
			public _003CTurretUpdateLoop_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CFireTurret_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DoneTurretController _003C_003E4__this;

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
			public _003CFireTurret_003Ed__34(int _003C_003E1__state)
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

		[Header("References")]
		public Rigidbody turretRb;

		public TurretHeadController turret;

		public Transform targetTransform;

		public Transform firePointTransform;

		public SphereCollider playerTrigger;

		[Header("Turret Behavior")]
		public float agroRange;

		public float chargeTime;

		public float burstLength;

		public float fireRate;

		public float burstCoolDown;

		public bool clampAimRotation;

		public float minAimRotation;

		public float maxAimRotation;

		[Range(0f, 10f)]
		public float maxBulletSpread;

		[Range(0f, 10f)]
		public float minBulletSpread;

		[Header("Audio")]
		public AudioClip[] turretCharge;

		private float lastFireTime;

		private float burstLengthTime;

		private float coolDownLengthTime;

		private IEnumerator turretLoop;

		private IEnumerator fireSequence;

		private bool killMode;

		private Quaternion aimingQuat;

		private Vector3 aimingAxis;

		private float wrappedRotation;

		private Quaternion parentTiltRot;

		private float parentTiltAngle;

		private Vector3 parentTiltAxis;

		private float parentTiltDir;

		private float adjustedRotation;

		public void Start()
		{
		}

		[ContextMenu("Found Player")]
		public void FoundPlayer()
		{
		}

		public void LostPlayer()
		{
		}

		[IteratorStateMachine(typeof(_003CTurretUpdateLoop_003Ed__33))]
		private IEnumerator TurretUpdateLoop()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFireTurret_003Ed__34))]
		private IEnumerator FireTurret()
		{
			return null;
		}

		public void KILLMODE(bool killOn)
		{
		}
	}
}
