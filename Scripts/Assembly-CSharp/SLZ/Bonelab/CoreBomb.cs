using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Audio;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CoreBomb : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoHitColor_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoreBomb _003C_003E4__this;

			private float _003CstartH_003E5__2;

			private float _003CstartS_003E5__3;

			private float _003CstartV_003E5__4;

			private float _003CendH_003E5__5;

			private float _003CendS_003E5__6;

			private float _003CendV_003E5__7;

			private float _003Cduration_003E5__8;

			private float _003Ctime_003E5__9;

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
			public _003CCoHitColor_003Ed__35(int _003C_003E1__state)
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
		private sealed class _003CCoAntigravColor_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoreBomb _003C_003E4__this;

			private float _003CstartH_003E5__2;

			private float _003CstartS_003E5__3;

			private float _003CstartV_003E5__4;

			private float _003CendH_003E5__5;

			private float _003CendS_003E5__6;

			private float _003CendV_003E5__7;

			private float _003Cduration_003E5__8;

			private float _003Ctime_003E5__9;

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
			public _003CCoAntigravColor_003Ed__36(int _003C_003E1__state)
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

		private static MaterialPropertyBlock _propertyBlock;

		private static int _colorID;

		[ColorUsage(true, true)]
		public Color defaultColor;

		[ColorUsage(true, true)]
		public Color hotColor;

		public AudioClip strongHitClip;

		public AudioClip unstableLoopClip;

		public float duration;

		public float cooldown;

		public Action OnCriticalHitOneTime;

		public Action OnDeactivateCore;

		[Header("References")]
		public MeshRenderer meshRenderer;

		public Grip grip;

		public Rigidbody rb;

		public GravityManipulatorJob gravityManipulator;

		private List<Collider> _colliders;

		private float _lastTimeHitActive;

		private float _lastCooldownTime;

		private float _lastSFXHit;

		private bool _canBeActive;

		private ManagedAudioPlayer _mapLoop;

		private Coroutine _hitCoroutine;

		private Coroutine _antigravCoroutine;

		public bool IsActive
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnGripAttached(Hand hand)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void FixedUpdate()
		{
		}

		private void ActivateAntigrav(InteractableHostManager manager)
		{
		}

		private void DeactivateAntigrav()
		{
		}

		public void DeactivateCore()
		{
		}

		public void ActivateCore()
		{
		}

		[IteratorStateMachine(typeof(_003CCoHitColor_003Ed__35))]
		private IEnumerator CoHitColor()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoAntigravColor_003Ed__36))]
		private IEnumerator CoAntigravColor()
		{
			return null;
		}
	}
}
