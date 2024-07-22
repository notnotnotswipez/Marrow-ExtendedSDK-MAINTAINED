using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MiniDisc : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPopFXAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Spawnable effect;

			public MiniDisc _003C_003E4__this;

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

		public BoxGrip grip;

		public RadioSong clip_song;

		public AmbientSFX source;

		private string songName;

		public string unlockEventName;

		private bool used;

		[SerializeField]
		private Spawnable vfxSpawnable;

		public Transform vfxPoint;

		public Blip blip;

		public void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UNLOCKTHISSONG()
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		public void POPFX(Spawnable effect)
		{
		}

		[AsyncStateMachine(typeof(_003CPopFXAsync_003Ed__14))]
		private UniTaskVoid PopFXAsync(Spawnable effect)
		{
			return default(UniTaskVoid);
		}
	}
}
