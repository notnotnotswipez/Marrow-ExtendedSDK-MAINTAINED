using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SpawnableCrateWarmup : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CWarmupSpreadAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Dictionary<Barcode, int> compiledManifest;

			public SpawnableCrateWarmup _003C_003E4__this;

			private Dictionary<Barcode, int>.KeyCollection.Enumerator _003C_003E7__wrap1;

			private Barcode _003Cbarcode_003E5__3;

			private Spawnable _003Cspawnable_003E5__4;

			private int _003Ci_003E5__5;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CWarmupAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SpawnableCrateWarmup _003C_003E4__this;

			public Spawnable spawnable;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		[SerializeField]
		private PoolWarmupProfile[] _warmupProfiles;

		private Queue<(Spawnable, int)> _spawnQueue;

		private int _maxBatch;

		private int _currentBatch;

		private bool _isDraining;

		private Func<bool> _isDrainingFunc;

		private void Awake()
		{
		}

		private void OnWillLoadPersistent()
		{
		}

		[AsyncStateMachine(typeof(_003CWarmupSpreadAsync_003Ed__8))]
		private UniTaskVoid WarmupSpreadAsync(Dictionary<Barcode, int> compiledManifest)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CWarmupAsync_003Ed__9))]
		private UniTaskVoid WarmupAsync(Spawnable spawnable)
		{
			return default(UniTaskVoid);
		}
	}
}
