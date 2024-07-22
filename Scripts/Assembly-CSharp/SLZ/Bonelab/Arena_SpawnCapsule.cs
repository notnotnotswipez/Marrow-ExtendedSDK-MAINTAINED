using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class Arena_SpawnCapsule : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public EnemyProfile enemyProfile;

			public Arena_GameController arenaGameController;

			internal void _003CCoLaunchSequenceArena_003Eb__0(GameObject go)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoLaunchSequenceArena_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EnemyProfile enemyProfile;

			public Arena_GameController arenaGameController;

			public Arena_SpawnCapsule _003C_003E4__this;

			private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

			private float _003CdurationPerCycle_003E5__2;

			private bool _003CwithinArenaBounds_003E5__3;

			private float _003CstartTime_003E5__4;

			private float _003CendTime_003E5__5;

			private float _003CexpandLerp_003E5__6;

			private int _003Ci_003E5__7;

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
			public _003CCoLaunchSequenceArena_003Ed__9(int _003C_003E1__state)
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
		private float maxDistFromCenter;

		[SerializeField]
		private SphereCollider expandCollider;

		[SerializeField]
		private TrailRenderer trailRend;

		[SerializeField]
		private AudioClip beepClip;

		[SerializeField]
		private AudioClip explodeClip;

		private float startRadius;

		[Range(0.25f, 1.5f)]
		[SerializeField]
		private float finalExpandRadius;

		public UnityEvent OnSpawn;

		public void OnLaunchedArena(Arena_GameController arenaGameController, EnemyProfile enemyProfile)
		{
		}

		[IteratorStateMachine(typeof(_003CCoLaunchSequenceArena_003Ed__9))]
		private IEnumerator CoLaunchSequenceArena(Arena_GameController arenaGameController, EnemyProfile enemyProfile)
		{
			return null;
		}
	}
}
