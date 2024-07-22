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
	public class RopeSwing : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoCheckGrip_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RopeSwing _003C_003E4__this;

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
			public _003CCoCheckGrip_003Ed__17(int _003C_003E1__state)
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
		private bool isReady;

		[SerializeField]
		private Rigidbody anchorRB;

		[SerializeField]
		private Rigidbody gripRB;

		[SerializeField]
		private ConfigurableJoint swingJoint;

		[SerializeField]
		private Grip _grip;

		[SerializeField]
		private LineRenderer lineRend;

		[SerializeField]
		private DrawLine2Points drawLine;

		[SerializeField]
		private GameObject lineRendGripTarg;

		[SerializeField]
		private float jointLimitValue;

		[SerializeField]
		private GameObject gripPrefab;

		[SerializeField]
		private Vector3 startGripPos;

		[SerializeField]
		private Quaternion startGripRot;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		public void OnGrab(Hand hand)
		{
		}

		public void OnDrop(Hand hand)
		{
		}

		[IteratorStateMachine(typeof(_003CCoCheckGrip_003Ed__17))]
		private IEnumerator CoCheckGrip()
		{
			return null;
		}

		private void ResetRopeSwing()
		{
		}

		public void OnDrawGizmos()
		{
		}
	}
}
