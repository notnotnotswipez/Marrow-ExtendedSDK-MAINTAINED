using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using UnityEngine;

public class SpawnRecycleTester : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSpawn_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public SpawnRecycleTester _003C_003E4__this;

		public Spawnable s;

		private UniTask<Poolee>.Awaiter _003C_003Eu__1;

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

	public SpawnableCrateReference[] _testSpawnable;

	public float duration;

	private float _lastSpawnTime;

	private Poolee _poolee;

	private int _lastIdx;

	private int _spawnCount;

	private bool _isSpawning;

	private void OnEnable()
	{
	}

	[AsyncStateMachine(typeof(_003CSpawn_003Ed__8))]
	private UniTaskVoid Spawn(Spawnable s)
	{
		return default(UniTaskVoid);
	}

	private void Update()
	{
	}
}
