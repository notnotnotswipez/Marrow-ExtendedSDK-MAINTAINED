using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SnapToInteractionVolume : InteractionVolume
	{
		[CompilerGenerated]
		private sealed class _003CCoDetatchGrab_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SnapToInteractionVolume _003C_003E4__this;

			private float _003Cduration_003E5__2;

			private float _003Ctime_003E5__3;

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
			public _003CCoDetatchGrab_003Ed__12(int _003C_003E1__state)
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

		private Transform targetTransform;

		public Transform exitTransform;

		private InteractableHost attachedHost;

		private bool isAttached;

		private Coroutine detachGrabCoroutine;

		protected override void OnHoverEnd(InteractableHost host)
		{
		}

		protected override void OnHoverStart(InteractableHost host)
		{
		}

		protected override void OnHoverUpdate(InteractableHost host)
		{
		}

		private void AttachInteractable(InteractableHost host)
		{
		}

		private void DetachInteractable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void DetachGrab()
		{
		}

		[IteratorStateMachine(typeof(_003CCoDetatchGrab_003Ed__12))]
		private IEnumerator CoDetatchGrab()
		{
			return null;
		}
	}
}
