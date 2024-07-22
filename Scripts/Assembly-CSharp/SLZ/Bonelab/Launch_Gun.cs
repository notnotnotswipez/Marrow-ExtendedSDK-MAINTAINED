using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Launch_Gun : MonoBehaviour
	{
		public enum LaunchMode
		{
			PUSH = 0,
			PULL = 1
		}

		[CompilerGenerated]
		private sealed class _003CCoCoolDown_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Launch_Gun _003C_003E4__this;

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
			public _003CCoCoolDown_003Ed__29(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CCoDisableAimAssist_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Launch_Gun _003C_003E4__this;

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
			public _003CCoDisableAimAssist_003Ed__32(int _003C_003E1__state)
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

		public LaunchMode launchMode;

		public Grip triggerGrip;

		public Transform firePoint;

		public Hand oppositeHand;

		public Hand leftHand;

		public Hand rightHand;

		public float maxFireDist;

		public float playerLaunchForce;

		public float objectLaunchForce;

		public bool isDisplayingFX;

		[SerializeField]
		private bool isReadyToFire;

		public float rechargeTime;

		public GravGunSFX sfx;

		[SerializeField]
		private Rigidbody playerPelvisRB;

		private Rigidbody[] _playerRbs;

		private InteractableHost _host;

		private bool _isTriggerDownOnGrab;

		[SerializeField]
		private GameObject aimAssistParentObj;

		[SerializeField]
		private GameObject aimAssistScalerObj;

		[SerializeField]
		private GameObject aimAssistHitObj;

		[SerializeField]
		private GameObject aimAssistMissObj;

		[SerializeField]
		private GameObject readyIndicatorObj;

		[SerializeField]
		private GameObject directionDecalObj;

		private float aimAssistScale;

		private void Awake()
		{
		}

		private void OnTriggerHandAttached(Hand hand)
		{
		}

		private void OnTriggerHandDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CCoCoolDown_003Ed__29))]
		private IEnumerator CoCoolDown()
		{
			return null;
		}

		private void FireLaunchRay()
		{
		}

		private void FireFX(bool isHitting)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDisableAimAssist_003Ed__32))]
		private IEnumerator CoDisableAimAssist()
		{
			return null;
		}

		private void DisableAimAssist()
		{
		}

		private void ApplyForceToTarget(Rigidbody targetRB, Vector3 hitPosition)
		{
		}

		private void ApplyForceToPlayer(Vector3 hitPosition)
		{
		}

		public void ToggleLaunchMode()
		{
		}
	}
}
