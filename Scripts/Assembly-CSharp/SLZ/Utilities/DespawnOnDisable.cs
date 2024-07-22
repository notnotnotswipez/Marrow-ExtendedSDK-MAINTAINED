using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Utilities
{
	[RequireComponent(typeof(Poolee))]
	public class DespawnOnDisable : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDelayedDespawn_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public DespawnOnDisable _003C_003E4__this;

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

		[ReadOnly(false)]
		public Poolee poolee;

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayedDespawn_003Ed__2))]
		private UniTaskVoid DelayedDespawn()
		{
			return default(UniTaskVoid);
		}

		private void Reset()
		{
		}
	}
}
