using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using YieldAwaitable = Cysharp.Threading.Tasks.YieldAwaitable;

namespace SLZ.Bonelab
{
	public class TutorialShaft : MonoBehaviour
	{
		public enum ShaftState
		{
			STOPPED = 0,
			MOVING_UP = 1,
			MOVING_DOWN = 2
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CMoveShaftLoop_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public TutorialShaft _003C_003E4__this;

			public CancellationToken ct;

			private YieldAwaitable.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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

		public TutorialElevator elevator;

		public ShaftState shaftState;

		public float speed;

		public float shaftHeight;

		public float loopHeight;

		private CancellationTokenSource cts;

		[ContextMenu("StartShaftLoop")]
		public void StartShaftLoop()
		{
		}

		[ContextMenu("StopShaftLoop")]
		public void StopShaftLoop()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CMoveShaftLoop_003Ed__10))]
		private UniTaskVoid MoveShaftLoop(CancellationToken ct)
		{
			return default(UniTaskVoid);
		}
	}
}
