using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public sealed class PatchNotesLoader : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPatchNotes_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public PatchNotesLoader _003C_003E4__this;

			private UniTask<UnityEngine.Networking.UnityWebRequest>.Awaiter _003C_003Eu__1;

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

		[SerializeField]
		private string backupPatchNotes;

		private TMP_Text tmp_PatchNotes
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

		private string PatchName
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

		private static string CachedPatchNotes
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

		private string PatchUrl => null;

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CGetPatchNotes_003Ed__16))]
		private UniTaskVoid GetPatchNotes()
		{
			return default(UniTaskVoid);
		}
	}
}
