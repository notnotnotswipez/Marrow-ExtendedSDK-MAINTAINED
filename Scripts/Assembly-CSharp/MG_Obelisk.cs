using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class MG_Obelisk : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CLaserLoop_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public MG_Obelisk _003C_003E4__this;

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
	private struct _003CSliderLoop_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public MG_Obelisk _003C_003E4__this;

		public bool up;

		public CancellationToken ct;

		private float _003ClerpVal_003E5__2;

		private float _003CstartTime_003E5__3;

		private float _003CendTime_003E5__4;

		private System.Runtime.CompilerServices.YieldAwaitable _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private GameObject laserObj;

	[SerializeField]
	private GameObject obeliskMoverObj;

	[SerializeField]
	private GameObject[] railTargetObjs;

	[SerializeField]
	private GameObject[] railGuardObjs;

	[SerializeField]
	private float distToRailTarg;

	[SerializeField]
	private int currRailTarg;

	private int currGuard;

	private bool targetReached;

	[SerializeField]
	private GameObject[] damageObjs;

	private int currDamage;

	[SerializeField]
	private GameObject[] sliderObjs;

	[SerializeField]
	private GameObject[] sliderStartObjs;

	[SerializeField]
	private GameObject[] sliderEndObjs;

	private float slideDuration;

	private CancellationTokenSource sliderCTS;

	private CancellationTokenSource laserCTS;

	private void Update()
	{
	}

	private void GoalTargetReached()
	{
	}

	private void SwapGuards()
	{
	}

	private void Obelisk_TakeDamage()
	{
	}

	private void Explode()
	{
	}

	private void FireTheLasers()
	{
	}

	private void StopTheLasers()
	{
	}

	[ContextMenu("MoveSlidersUp")]
	public void MoveSlidersUp()
	{
	}

	[ContextMenu("MoveSlidersDown")]
	public void MoveSlidersDown()
	{
	}

	[ContextMenu("CancelSliderLoop")]
	public void CancelSliderLoop()
	{
	}

	public void MoveSliders(bool up)
	{
	}

	[AsyncStateMachine(typeof(_003CLaserLoop_003Ed__27))]
	private UniTaskVoid LaserLoop(CancellationToken ct)
	{
		return default(UniTaskVoid);
	}

	[AsyncStateMachine(typeof(_003CSliderLoop_003Ed__28))]
	private UniTaskVoid SliderLoop(bool up, CancellationToken ct)
	{
		return default(UniTaskVoid);
	}
}
