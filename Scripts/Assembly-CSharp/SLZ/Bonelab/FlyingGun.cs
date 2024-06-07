using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class FlyingGun : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFunctionDelay_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action callback;

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
			public _003CFunctionDelay_003Ed__22(int _003C_003E1__state)
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

		public bool canNoClip;

		public float maxSpeed;

		public Grip triggerGrip;

		public Transform firePoint;

		[Range(1f, 3f)]
		[Tooltip("Highter exponential makes a small trigger pull slower. 1 = linear")]
		public float speedCurveExponential;

		[Header("References")]
		public GravGunSFX sfx;

		public Transform ringA;

		public Transform ringB;

		public Transform ringC;

		private float _targetAcceleration;

		private Vector3 _smoothedDirection;

		private Vector3 _directionVel;

		private float _targetSpeed;

		private float _ringAngularDisplacement;

		private bool _noClipping;

		private float _lastFixedTime;

		private Rigidbody[] _playerRbs;

		private InteractableHost _host;

		public static Action OnFlyEnabled;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CFunctionDelay_003Ed__22))]
		private IEnumerator FunctionDelay(Action callback)
		{
			return null;
		}

		private void OnTriggerHandAttached(Hand hand)
		{
		}

		private void EnableNoClip()
		{
		}

		private void DisableNoClip(Hand hand)
		{
		}

		private void OnTriggerHandDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}
	}
}
