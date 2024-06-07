using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlayerAvatarManager : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadAvatarFromSaveDataAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PlayerAvatarManager _003C_003E4__this;

			private string _003CcurrentAvatar_003E5__2;

			private string _003CfallbackAvatar_003E5__3;

			private UniTask.Awaiter _003C_003Eu__1;

			private UniTask<bool>.Awaiter _003C_003Eu__2;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public RigManager rigManager;

		public bool loadAvatarFromSaveData;

		private bool _hasAvatarOverride;

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadAvatarFromSaveDataAsync_003Ed__4))]
		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		public void OverrideAvatar(string barcode, bool cached)
		{
		}
	}
}
