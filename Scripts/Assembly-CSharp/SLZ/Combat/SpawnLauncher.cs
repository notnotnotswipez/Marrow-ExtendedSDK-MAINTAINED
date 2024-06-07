using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Combat
{
	public class SpawnLauncher : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawn_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SpawnLauncher _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public Spawnable spawnable;

		public Transform firePoint;

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CSpawn_003Ed__3))]
		public UniTaskVoid Spawn()
		{
			return default(UniTaskVoid);
		}
	}
}
