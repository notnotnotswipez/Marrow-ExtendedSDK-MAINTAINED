using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TunnelTipper_Chunker : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CForceUnloadStartChunk_async_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public TunnelTipper_Chunker _003C_003E4__this;

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

		public SceneChunk mainRoomChunk;

		public float delay;

		[ContextMenu("ForceUnloadStartChunk")]
		public void ForceUnloadStartChunk()
		{
		}

		[AsyncStateMachine(typeof(_003CForceUnloadStartChunk_async_003Ed__3))]
		private UniTaskVoid ForceUnloadStartChunk_async()
		{
			return default(UniTaskVoid);
		}

		private void UnloadChunk()
		{
		}
	}
}
