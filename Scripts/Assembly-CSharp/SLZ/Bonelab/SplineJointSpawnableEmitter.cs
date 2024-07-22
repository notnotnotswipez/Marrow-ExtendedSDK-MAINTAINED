using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SplineJointSpawnableEmitter : SplineEntity
	{
		public enum Mode
		{
			Manual = 0,
			Once = 1,
			Multiple = 2
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnLoop_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SplineJointSpawnableEmitter _003C_003E4__this;

			private bool _003CisLooping_003E5__2;

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

		[Header("Settings")]
		public Spawnable splineSpawnable;

		public Mode mode;

		public float delay;

		public float frequency;

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnLoop_003Ed__7))]
		private UniTaskVoid SpawnLoop()
		{
			return default(UniTaskVoid);
		}

		public void Spawn()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
