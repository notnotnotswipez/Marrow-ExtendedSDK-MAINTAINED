using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Data;
using SLZ.Marrow.AI;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class ProfileSpawner : SpawnDecorator
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CExplicitArenaSpawn_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ProfileSpawner _003C_003E4__this;

			public EnemyProfile enemyProfile;

			public bool isFriendly;

			private UniTask<SLZ.Marrow.Pool.Poolee>.Awaiter _003C_003Eu__1;

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

		public Zone zone;

		public bool forceManualSpawns;

		public bool enableAgentLinking;

		[HideInInspector]
		public EnemyProfile currProfile;

		[HideInInspector]
		public bool isFriend;

		public bool LogSpawns;

		private TriggerRefProxy playerProxy;

		public Action<ProfileSpawner, AIBrain, EnemyProfile, bool> onSpawnNPCDelegate;

		public CrateSpawner CrateSpawner => null;

		private void Awake()
		{
		}

		public void SetPlayerProxy(TriggerRefProxy proxy)
		{
		}

		[AsyncStateMachine(typeof(_003CExplicitArenaSpawn_003Ed__12))]
		public UniTask ExplicitArenaSpawn(EnemyProfile enemyProfile, bool isFriendly = false)
		{
			return default(UniTask);
		}


		public void PostReactivate(BehaviourBaseNav baseNav)
		{
		}

		public void OnDeath(AIBrain aiBrain)
		{
		}
	}
}
