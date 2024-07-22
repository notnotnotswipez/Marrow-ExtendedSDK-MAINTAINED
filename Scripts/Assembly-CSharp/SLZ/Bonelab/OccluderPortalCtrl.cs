using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class OccluderPortalCtrl : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CcheckPortal_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OccluderPortalCtrl _003C_003E4__this;

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
			public _003CcheckPortal_003Ed__10(int _003C_003E1__state)
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

		public OcclusionPortal occlusionPortal;

		public Transform checkTransform;

		public Transform closeTarget;

		private bool _portalOpen;

		private Coroutine _portalDoorCheck;

		private float _closeTolerance;

		private float _waitTime;

		private void Start()
		{
		}

		public void OpenPortal()
		{
		}

		public void ClosePortal()
		{
		}

		[IteratorStateMachine(typeof(_003CcheckPortal_003Ed__10))]
		private IEnumerator checkPortal()
		{
			return null;
		}
	}
}
