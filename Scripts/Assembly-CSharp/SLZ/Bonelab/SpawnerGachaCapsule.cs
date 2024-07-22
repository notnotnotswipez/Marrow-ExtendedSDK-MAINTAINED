using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;
using YieldAwaitable = Cysharp.Threading.Tasks.YieldAwaitable;

namespace SLZ.Bonelab
{
	public class SpawnerGachaCapsule : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAsyncSpawnProcedure_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SpawnerGachaCapsule _003C_003E4__this;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

			private UniTask<Poolee>.Awaiter _003C_003Eu__2;

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

		public Rigidbody rb;

		public Spawnable spawnable;

		public SpawnFragmentArray[] spawnFragments;

		public float explosiveForceOnDestruct;

		public ChopperSequenceController_LongRun optionalChopperContoller;

		public Transform optionalSpawnDirection;

		private bool despawning;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		[AsyncStateMachine(typeof(_003CAsyncSpawnProcedure_003Ed__11))]
		private UniTaskVoid AsyncSpawnProcedure()
		{
			return default(UniTaskVoid);
		}
	}
}
