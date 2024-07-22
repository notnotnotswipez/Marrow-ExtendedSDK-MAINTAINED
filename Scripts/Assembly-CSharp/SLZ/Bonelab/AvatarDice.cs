using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class AvatarDice : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CActiveRoll_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AvatarDice _003C_003E4__this;

			public int result;

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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDiceResult_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AvatarDice _003C_003E4__this;

			public int result;

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

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CChangeAvatar_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public AvatarDice _003C_003E4__this;

			public int result;

			private AvatarCrateReference _003CnewAvatar_003E5__2;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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

		public Dice dice;

		public List<AvatarCrateReference> avatars;

		public bool useOverrideFirstAvatar;

		public AvatarCrateReference firstAvatar;

		private RigManager rigManager;

		private InteractableHost interactableHost;

		private bool handAttachEventSetup;

		private bool firstRoll;

		public UnityEvent OnHandAttach;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		[AsyncStateMachine(typeof(_003CActiveRoll_003Ed__12))]
		private UniTaskVoid ActiveRoll(int result)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CDiceResult_003Ed__13))]
		private UniTaskVoid DiceResult(int result)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CChangeAvatar_003Ed__14))]
		private UniTask ChangeAvatar(int result, bool isResultRoll = false)
		{
			return default(UniTask);
		}

		private void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		[MethodImpl(256)]
		private void _listenForHandAttach()
		{
		}

		[MethodImpl(256)]
		private void _unlistenForHandAttach()
		{
		}

		private void _simulateRoll(int result)
		{
		}

		[ContextMenu("Simulate Roll 1")]
		private void _simulateRoll1()
		{
		}

		[ContextMenu("Simulate Roll 2")]
		private void _simulateRoll2()
		{
		}

		[ContextMenu("Simulate Roll 3")]
		private void _simulateRoll3()
		{
		}

		[ContextMenu("Simulate Roll 4")]
		private void _simulateRoll4()
		{
		}

		[ContextMenu("Simulate Roll 5")]
		private void _simulateRoll5()
		{
		}

		[ContextMenu("Simulate Roll 6")]
		private void _simulateRoll6()
		{
		}
	}
}
