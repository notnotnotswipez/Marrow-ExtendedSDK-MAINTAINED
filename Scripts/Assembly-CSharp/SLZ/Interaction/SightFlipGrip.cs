using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Interaction
{
	public class SightFlipGrip : TargetGrip
	{
		[CompilerGenerated]
		private sealed class _003CCoFlipSight_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SightFlipGrip _003C_003E4__this;

			public Transform target;

			private float _003Ctime_003E5__2;

			private float _003Cduration_003E5__3;

			private Quaternion _003Cstart_003E5__4;

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
			public _003CCoFlipSight_003Ed__5(int _003C_003E1__state)
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

		public Transform sight;

		public Transform openSight;

		public Transform closedSight;

		private bool isUp;

		public override void OnHandHoverUpdate(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CCoFlipSight_003Ed__5))]
		private IEnumerator CoFlipSight(Transform target)
		{
			return null;
		}
	}
}
