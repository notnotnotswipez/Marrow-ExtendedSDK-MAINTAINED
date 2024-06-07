using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnVFX : SpawnDecorator
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CWaitForHibernation_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SpawnVFX _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private MarrowEntity entity;

		private Blip blip;

		public override void OnSpawn(GameObject go)
		{
		}

		[AsyncStateMachine(typeof(_003CWaitForHibernation_003Ed__3))]
		private UniTaskVoid WaitForHibernation()
		{
			return default(UniTaskVoid);
		}
	}
}
