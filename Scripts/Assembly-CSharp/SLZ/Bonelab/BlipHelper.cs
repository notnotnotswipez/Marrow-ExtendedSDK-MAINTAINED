using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BlipHelper : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDespawnCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BlipHelper _003C_003E4__this;

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
			public _003CDespawnCoroutine_003Ed__6(int _003C_003E1__state)
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

		public float blipWaitTime;

		public Grip[] grips;

		public Blip blip;

		private bool fired;

		private void Start()
		{
		}

		public void DESTROYOBJ()
		{
		}

		[IteratorStateMachine(typeof(_003CDespawnCoroutine_003Ed__6))]
		private IEnumerator DespawnCoroutine()
		{
			return null;
		}
	}
}
