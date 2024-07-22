using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidBullet : MonoBehaviour
	{
		public delegate void OnDespawnDelegate(BehaviourBoidAgent_SlicedInference boid);

		[CompilerGenerated]
		private sealed class _003CDespawnCounter_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BoidBullet _003C_003E4__this;

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
			public _003CDespawnCounter_003Ed__8(int _003C_003E1__state)
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

		public float maxTimeAlive;

		public float currentTimeAlive;

		public BehaviourBoidAgent_SlicedInference boidAgent;

		private TriggerRefProxy temp_trp;

		public event OnDespawnDelegate OnDespawn
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[IteratorStateMachine(typeof(_003CDespawnCounter_003Ed__8))]
		public IEnumerator DespawnCounter()
		{
			return null;
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
