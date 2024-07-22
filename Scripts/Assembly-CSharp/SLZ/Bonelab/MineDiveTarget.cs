using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class MineDiveTarget : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoWaitForTarget_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MineDiveTarget _003C_003E4__this;

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
			public _003CCoWaitForTarget_003Ed__12(int _003C_003E1__state)
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

		[SerializeField]
		private ConfigurableJoint joint;

		[SerializeField]
		private Quaternion goalRot;

		private JointDrive jointDrive;

		[SerializeField]
		private float delayTime;

		[SerializeField]
		private bool isLocked;

		[SerializeField]
		private float jointSpringForce;

		public bool isPractice;

		public int isWorth;

		public UnityEvent OnGoDown;

		public UnityEvent OnGoUp;

		public static Action<MineDiveTarget> hitAction;

		public void AttackTarget()
		{
		}

		[IteratorStateMachine(typeof(_003CCoWaitForTarget_003Ed__12))]
		private IEnumerator CoWaitForTarget()
		{
			return null;
		}

		private void UnlockJoint()
		{
		}

		[ContextMenu("GetJoint")]
		public void GetJoint()
		{
		}
	}
}
