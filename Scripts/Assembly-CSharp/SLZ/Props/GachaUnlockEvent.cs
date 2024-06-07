using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Props
{
	public class GachaUnlockEvent : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public Crate crate;

			internal void _003CPopFXAsync_003Eb__0(GameObject go)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPopFXAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public GachaUnlockEvent _003C_003E4__this;

			private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

			public Spawnable effect;

			private UniTask<Crate>.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public GenericCrateReference selectedCrate;

		[SerializeField]
		private Spawnable vfxSpawnable;

		public Transform vfxPoint;

		public UnityEvent gachaPopEvent;

		private bool used;

		private static PlayerUnlocks u => null;

		public void Awake()
		{
		}

		public void UNLOCKITEM()
		{
		}

		public void POPFX(Spawnable effect)
		{
		}

		[AsyncStateMachine(typeof(_003CPopFXAsync_003Ed__10))]
		private UniTaskVoid PopFXAsync(Spawnable effect)
		{
			return default(UniTaskVoid);
		}
	}
}
