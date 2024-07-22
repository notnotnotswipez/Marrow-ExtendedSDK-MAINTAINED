using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Utilities
{
	public class TimedPrefabSpawner : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnLoop_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public TimedPrefabSpawner _003C_003E4__this;

			public CancellationTokenSource cancelToken;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[Tooltip("Spawnable")]
		[SerializeField]
		private Spawnable spawnable;

		[Tooltip("Spawn Points")]
		[SerializeField]
		private Transform[] spawnPoints;

		[SerializeField]
		[Tooltip("Spawn Interval")]
		private float spawnInterval;

		[SerializeField]
		[Tooltip("Ignore Colliders")]
		private Collider[] ignoreColliders;

		private CancellationTokenSource cts;

		private bool doSpawnLoop;

		private int spawnIndex;

		private void Start()
		{
		}

		public void ACTIVATESPAWNER()
		{
		}

		public void DEACTIVATESPAWNER()
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnLoop_003Ed__10))]
		private UniTaskVoid SpawnLoop(CancellationTokenSource cancelToken)
		{
			return default(UniTaskVoid);
		}

		public void SpawnPrefab()
		{
		}
	}
}
