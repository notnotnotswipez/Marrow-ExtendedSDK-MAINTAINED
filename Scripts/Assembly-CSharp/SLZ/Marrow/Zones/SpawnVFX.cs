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

			public Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SpawnVFX _003C_003E4__this;

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

		private MarrowEntity entity;

		private Blip blip;


		[AsyncStateMachine(typeof(_003CWaitForHibernation_003Ed__3))]
		private UniTaskVoid WaitForHibernation()
		{
			return default(UniTaskVoid);
		}
	}
}
