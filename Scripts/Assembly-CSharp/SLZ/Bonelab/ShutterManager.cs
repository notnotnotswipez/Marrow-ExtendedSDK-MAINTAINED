using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ShutterManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoStaggerShuttersSurvival_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShutterManager _003C_003E4__this;

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
			public _003CCoStaggerShuttersSurvival_003Ed__6(int _003C_003E1__state)
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

		public ConfigurableJoint[] windowJoints;

		public ConfigurableJoint doorJointA;

		public ConfigurableJoint doorJointB;

		public ConfigurableJoint skylightJointA;

		public ConfigurableJoint skylightJointB;

		[ContextMenu("OpenShutters")]
		public void OpenShutters()
		{
		}

		[IteratorStateMachine(typeof(_003CCoStaggerShuttersSurvival_003Ed__6))]
		private IEnumerator CoStaggerShuttersSurvival()
		{
			return null;
		}
	}
}
