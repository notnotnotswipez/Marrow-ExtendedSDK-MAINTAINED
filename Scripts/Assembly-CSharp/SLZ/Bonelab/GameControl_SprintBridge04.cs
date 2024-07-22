using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GameControl_SprintBridge04 : BonelabAvatarLevelGameControl
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CKillPlayerAndReset_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GameControl_SprintBridge04 _003C_003E4__this;

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

		private RigManager rM;

		private Player_Health playerHealth;

		public UnityEvent onDeathEvent;

		private bool playerDeathActive;

		private float cashedDeathTimeAmount;

		private float cashedInstaDeathTimeAmount;

		public override void Start()
		{
		}

		public override void DoLevelComplete()
		{
		}

		public void OnDisable()
		{
		}

		public void PlayerDeath()
		{
		}

		private void Initialize()
		{
		}

		public void KillPlayerFast()
		{
		}

		[AsyncStateMachine(typeof(_003CKillPlayerAndReset_003Ed__12))]
		private UniTaskVoid KillPlayerAndReset()
		{
			return default(UniTaskVoid);
		}
	}
}
