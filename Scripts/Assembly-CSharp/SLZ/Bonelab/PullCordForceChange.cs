using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PullCordForceChange : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AvatarCrateReference avatarCrate;

			public PullCordForceChange _003C_003E4__this;

			private AvatarCrate _003Ccrate_003E5__2;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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

		public AvatarCrateReference avatarCrate;

		public int optionalPullCordStopIndex;

		public bool onlyTriggerOnce;

		private RigManager rigManager;

		private bool used;

		private int choice;

		public bool randomize;

		private List<AvatarCrateReference> defaultFavoriteAvatarsBarcodes;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void ForceChange(GameObject other)
		{
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__10))]
		private UniTaskVoid SwapAvatar(AvatarCrateReference avatarCrate)
		{
			return default(UniTaskVoid);
		}
	}
}
