using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Arena_Launcher : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoLaunchConfetti_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Arena_Launcher _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CCoLaunchConfetti_003Ed__14(int _003C_003E1__state)
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

		public Spawnable hoiPoiSpawnable;

		public Spawnable rigidbodyProjectileSpawnable;

		public Spawnable confettiSpawnable;

		[SerializeField]
		private Transform parentRotater;

		[SerializeField]
		private float fireForce;

		[SerializeField]
		private AudioClip launchClip;

		[SerializeField]
		private Transform confettiTarg;

		[SerializeField]
		private Arena_GameController gameController;

		[SerializeField]
		private GameObject turretObj;

		[SerializeField]
		private GameObject turrTarg;

		[SerializeField]
		private float projectileForce;

		private void Awake()
		{
		}

		private void OnLevelLoadGetPlayer()
		{
		}

		[ContextMenu("LaunchConfetti")]
		public void LaunchConfetti()
		{
		}

		[IteratorStateMachine(typeof(_003CCoLaunchConfetti_003Ed__14))]
		private IEnumerator CoLaunchConfetti()
		{
			return null;
		}

		public void LaunchCapsuleEnemy(Arena_GameController arenaGameController, EnemyProfile profile)
		{
		}

		[ContextMenu("ShootThatBitch")]
		public void ShootItUp()
		{
		}

		public void FixedUpdate()
		{
		}

		public void LaunchProjectile(Vector3 playerPos)
		{
		}

		public void ShootThePlayer(Vector3 playerPos)
		{
		}
	}
}
