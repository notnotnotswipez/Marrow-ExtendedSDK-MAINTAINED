using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LinkZipStick : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoCheckGrip_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float initialWait;

			public LinkZipStick _003C_003E4__this;

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
			public _003CCoCheckGrip_003Ed__20(int _003C_003E1__state)
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

		public Rigidbody rb;

		[SerializeField]
		private Grip grip;

		[SerializeField]
		private ConfigurableJoint joint;

		private Vector3 startPos;

		private Quaternion startRot;

		private float initBreakForce;

		public int activeStick;

		[SerializeField]
		private GameObject[] sticks;

		public float[] conAnchor;

		[SerializeField]
		private GameObject shortStick;

		[SerializeField]
		private GameObject medStick;

		[SerializeField]
		private GameObject longStick;

		[SerializeField]
		private Grip shortGrip;

		[SerializeField]
		private Grip medGrip;

		[SerializeField]
		private Grip longGrip;

		private void OnEnable()
		{
		}

		private void OnAttach(Hand hand)
		{
		}

		private void OnDetach(Hand hand)
		{
		}

		private void ResetJoint()
		{
		}

		private void CreateJoint()
		{
		}

		[IteratorStateMachine(typeof(_003CCoCheckGrip_003Ed__20))]
		private IEnumerator CoCheckGrip(float initialWait = 0.15f)
		{
			return null;
		}

		private void OnJointBreak(float breakForce)
		{
		}

		public void SetZipLengthObject(int currStick)
		{
		}
	}
}
