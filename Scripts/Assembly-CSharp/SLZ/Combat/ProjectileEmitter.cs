using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.AI;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Combat
{
	public static class ProjectileEmitter
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ProjectileData projectileData;

			public Transform parentT;

			public Vector3 position;

			public Quaternion rotation;

			public TriggerRefProxy proxy;

			private UniTask<SLZ.Marrow.Pool.Poolee>.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public static void Register(ProjectileData projectileData)
		{
		}

		public static void Emit(ProjectileData projectileData, Transform EmittingTransform, TriggerRefProxy proxy = null)
		{
		}

		[AsyncStateMachine(typeof(_003CSpawnAsync_003Ed__2))]
		private static UniTaskVoid SpawnAsync(ProjectileData projectileData, Vector3 position, Quaternion rotation, Transform parentT, TriggerRefProxy proxy = null)
		{
			return default(UniTaskVoid);
		}
	}
}
