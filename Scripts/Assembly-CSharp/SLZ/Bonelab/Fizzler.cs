using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Bonelab
{
	internal class Fizzler : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoDelayDespawn_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Poolee poolee;

			public Fizzler _003C_003E4__this;

			public Rigidbody rb;

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
			public _003CCoDelayDespawn_003Ed__4(int _003C_003E1__state)
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

		private HashSet<Rigidbody> claimedRBs;

		[SerializeField]
		private Color m_despawnColor;

		private void Awake()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		[IteratorStateMachine(typeof(_003CCoDelayDespawn_003Ed__4))]
		private IEnumerator CoDelayDespawn(Poolee poolee, Rigidbody rb)
		{
			return null;
		}
	}
}
