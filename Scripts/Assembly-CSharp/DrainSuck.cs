using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class DrainSuck : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSuckLoop_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public CancellationToken cancelToken;

		public DrainSuck _003C_003E4__this;

		private float _003Ctime_003E5__2;

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

	[SerializeField]
	private LayerMask layerFilter;

	[SerializeField]
	private float impulseTune;

	[SerializeField]
	private float impulseClamp;

	[SerializeField]
	private float suckRange;

	[SerializeField]
	private AnimationCurve suckCurve;

	private List<Rigidbody> filteredRBs;

	private CancellationTokenSource suckCancelToken;

	public void STARTSUCK()
	{
	}

	public void STOPSUCK()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	[AsyncStateMachine(typeof(_003CSuckLoop_003Ed__11))]
	private UniTaskVoid SuckLoop(CancellationToken cancelToken)
	{
		return default(UniTaskVoid);
	}
}
