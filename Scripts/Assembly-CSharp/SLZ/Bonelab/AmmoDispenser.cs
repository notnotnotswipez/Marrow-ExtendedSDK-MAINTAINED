using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AmmoDispenser : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRAINAMMO_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AmmoDispenser _003C_003E4__this;

			public int type;

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
			public _003CRAINAMMO_003Ed__14(int _003C_003E1__state)
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

		public TextMeshPro[] txt_ammoDisplay;

		public bool[] count_infinite;

		public int[] count_ammo;

		public CrateSpawner[] spawn_ammo;

		public CrateSpawner[] inf_spawn_ammo;

		public SimpleParticleSpawner[] spawn_fx;

		public bool makeItRain;

		public TextMeshPro txt_makeItRain;

		public AudioClip[] clip_spawn;

		public AudioClip[] clip_deny;

		private Coroutine[] rainingAmmo;

		public void Start()
		{
		}

		public void Setup()
		{
		}

		public void SPAWN_AMMO(int type)
		{
		}

		[IteratorStateMachine(typeof(_003CRAINAMMO_003Ed__14))]
		public IEnumerator RAINAMMO(int type)
		{
			return null;
		}

		public void TOGGLERAIN()
		{
		}

		public void STOPRAININGAMMO(int type)
		{
		}

		public void TEXTDISPLAY()
		{
		}

		public void AUDIOALERT(bool positive = false, int type = 0)
		{
		}
	}
}
