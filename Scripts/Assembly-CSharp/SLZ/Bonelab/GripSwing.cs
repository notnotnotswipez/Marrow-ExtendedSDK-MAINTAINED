using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GripSwing : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoCheckGrip_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GripSwing _003C_003E4__this;

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

			[DebuggerHidden]
			public _003CCoCheckGrip_003Ed__10(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[SerializeField]
		private GameObject anchorObj;

		[SerializeField]
		private ConfigurableJoint _joint;

		[SerializeField]
		private Grip _grip;

		public UnityEvent OnGripClaim;

		public UnityEvent OnDetachComplete;

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

		[IteratorStateMachine(typeof(_003CCoCheckGrip_003Ed__10))]
		private IEnumerator CoCheckGrip()
		{
			return null;
		}

		private void ResetJoint()
		{
		}
	}
}
