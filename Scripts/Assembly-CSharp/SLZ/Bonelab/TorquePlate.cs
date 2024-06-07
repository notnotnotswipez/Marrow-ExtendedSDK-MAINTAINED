using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TorquePlate : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoLaunch_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TorquePlate _003C_003E4__this;

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
			public _003CCoLaunch_003Ed__10(int _003C_003E1__state)
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
		private Rigidbody rb;

		[SerializeField]
		private ConfigurableJoint jnt;

		public float launchReturnSeconds;

		private Coroutine _moveCoroutine;

		public AudioClip launchClip;

		public float rotTargetHigh;

		public float rotTargetLow;

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		public void Launch()
		{
		}

		[IteratorStateMachine(typeof(_003CCoLaunch_003Ed__10))]
		public IEnumerator CoLaunch()
		{
			return null;
		}
	}
}
