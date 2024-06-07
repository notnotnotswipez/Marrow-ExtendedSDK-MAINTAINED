using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class PowerGlove : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFunctionDelay_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action callback;

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
			public _003CFunctionDelay_003Ed__5(int _003C_003E1__state)
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

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		public ConeCheck forceCone;

		public Grip triggerGrip;

		private bool _isTriggerDownOnGrab;

		private Rigidbody[] _playerRbs;

		private InteractableHost _host;

		[IteratorStateMachine(typeof(_003CFunctionDelay_003Ed__5))]
		private IEnumerator FunctionDelay(Action callback)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnTriggerHandAttached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		private void DisableNoClip()
		{
		}

		private void OnTriggerHandDetached(Hand hand)
		{
		}
	}
}
