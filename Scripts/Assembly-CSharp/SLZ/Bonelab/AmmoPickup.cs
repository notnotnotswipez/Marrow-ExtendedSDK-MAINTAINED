using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class AmmoPickup : SpawnEvents
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDelayDespawnAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AmmoPickup _003C_003E4__this;

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

		public AmmoGroup ammoGroup;

		public int ammoCount;

		public AudioClip collectAudioClip;

		public UnityEvent OnAmmoCollect;

		public Spawnable animeCollectVFXSpawnable;

		public Spawnable bulletBlastVFXSpawnable;

		public Spawnable smokerVFXSpawnable;

		private bool _isCollected;

		private Vector3 scale;

		protected override void Awake()
		{
		}

		public override void OnPoolInitialize()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		public void ForcePickup()
		{
		}
	}
}
