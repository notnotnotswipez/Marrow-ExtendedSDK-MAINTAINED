using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MagazineDecorator : SpawnDecorator
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Magazine magazine;

			public MagazineDecorator _003C_003E4__this;

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

		[SerializeField]
		private CartridgeData _cartridgeData;

		[SerializeField]
		private int _ammoCount;


		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__3))]
		private UniTaskVoid InitializeAsync(Magazine magazine)
		{
			return default(UniTaskVoid);
		}
	}
}
