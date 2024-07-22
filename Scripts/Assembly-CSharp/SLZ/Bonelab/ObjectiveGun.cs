using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.MLAgents;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ObjectiveGun : Gun
	{
		[CompilerGenerated]
		private sealed class _003CCoFireFlash_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ObjectiveGun _003C_003E4__this;

			private float _003Cduration_003E5__2;

			private float _003Ctime_003E5__3;

			private Color _003CstartColor_003E5__4;

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
			public _003CCoFireFlash_003Ed__17(int _003C_003E1__state)
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

		[Header("Spawn Options")]
		public LayerMask collisionLayers;

		public float effectiveRange;

		public bool wackySpinWhenUpsideDown;

		public bool isDespawnMode;

		public GameObject laserPointerGameObject;

		private InferenceAgent _selectedAgent;

		private Transform trackedTransform;

		private GameObject placeHolder;

		private bool _isOptionsActive;

		private ObjetiveModes _selectedMode;

		private RaycastHit _hitInfo;

		private Hand currentHand;

		protected override void Awake()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		private void OnSpawnHandAttached(Hand hand)
		{
		}

		private void OnSpawnHandDetached(Hand hand)
		{
		}

		public void Flash()
		{
		}

		[IteratorStateMachine(typeof(_003CCoFireFlash_003Ed__17))]
		private IEnumerator CoFireFlash()
		{
			return null;
		}

		protected void OnAgentSelected(InferenceAgent agent)
		{
		}

		protected void OnModeSelect(ObjetiveModes mode)
		{
		}

		public override void Fire()
		{
		}

		private void SetAgent()
		{
		}

		protected override void OnFire()
		{
		}

		protected override void OnTriggerGripAttached(Hand hand)
		{
		}

		protected override void OnTriggerGripDetached(Hand hand)
		{
		}
	}
}
