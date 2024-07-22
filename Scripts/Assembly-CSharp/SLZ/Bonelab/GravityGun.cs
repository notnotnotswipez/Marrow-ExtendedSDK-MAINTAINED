using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GravityGun : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoBlastConfirm_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BaseController controller;

			public GravityGun _003C_003E4__this;

			public float duration;

			private float _003Ctime_003E5__2;

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

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CCoBlastConfirm_003Ed__16(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		public Grip triggerGrip;

		private Rigidbody m_GrabbedRigidbody;

		private Animator animator;

		private GravGunSFX sfx;

		private bool m_IsPulling;

		private bool m_IsGrabbed;

		[Header("References")]
		public Transform firePoint;

		public GravityManipulatorJob gravityManipulator;

		public QuadLine quadline;

		public GameObject blastVFXObject;

		private Coroutine blastConfirmCoroutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void StopBlastConfirm()
		{
		}

		private void StartBlastConfirm(BaseController controller, float duration = 0.25f)
		{
		}

		[IteratorStateMachine(typeof(_003CCoBlastConfirm_003Ed__16))]
		private IEnumerator CoBlastConfirm(BaseController controller, float duration = 0.25f)
		{
			return null;
		}

		private void Blast()
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}
	}
}
