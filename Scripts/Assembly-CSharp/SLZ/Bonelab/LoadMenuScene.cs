using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LoadMenuScene : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoad_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public LoadMenuScene _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public LevelCrateReference MenuHollowCrateRef;

		public LevelCrateReference VoidG114CrateRef;

		public LevelCrateReference LevelLoaderCrateRef;

		private static PlayerProgression p => null;

		[AsyncStateMachine(typeof(_003CLoad_003Ed__5))]
		public UniTaskVoid Load()
		{
			return default(UniTaskVoid);
		}
	}
}
