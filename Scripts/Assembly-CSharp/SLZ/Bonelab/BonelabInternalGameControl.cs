using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;

namespace SLZ.Bonelab
{
	public abstract class BonelabInternalGameControl : BonelabGameControl
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLevelCompleteWithDelayAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public TimeSpan timeSpan;

			public BonelabInternalGameControl _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		private Dictionary<string, int> storyLevelBarcodeKeyPair;

		protected LevelCrateReference NextCampaignLevel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected List<GenericCrateReference> Unlocks
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected double LevelLoadBufferTime
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public void SetHubSpawnLocation(int hubSpawnLocation)
		{
		}

		public void JustJumpToLevel(LevelCrateReference level)
		{
		}

		public void LevelComplete()
		{
		}

		[AsyncStateMachine(typeof(_003CLevelCompleteWithDelayAsync_003Ed__17))]
		public UniTaskVoid LevelCompleteWithDelayAsync(TimeSpan timeSpan)
		{
			return default(UniTaskVoid);
		}

		public virtual void DoLevelComplete()
		{
		}
	}
}
