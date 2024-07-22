using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab;
using UnityEngine;

public class LaserCursorJockey : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CTOGGLEUI_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public SLZ.Bonelab.AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public bool active;

		public LaserCursorJockey _003C_003E4__this;

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

	public LaserCursor laserCursor;

	public GameObject uiGameObj;

	[AsyncStateMachine(typeof(_003CTOGGLEUI_003Ed__2))]
	public UniTaskVoid TOGGLEUI(bool active = true)
	{
		return default(UniTaskVoid);
	}
}
