using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

public static class ThrottlerExt
{
	private class Throttler : IDisposable
	{
		private readonly SemaphoreSlim _throttler;

		public Throttler(SemaphoreSlim throttler)
		{
		}

		public void Dispose()
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CThrottle_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<IDisposable> _003C_003Et__builder;

		public SemaphoreSlim throttler;

		private TaskAwaiter _003C_003Eu__1;

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

	[AsyncStateMachine(typeof(_003CThrottle_003Ed__0))]
	public static UniTask<IDisposable> Throttle(this SemaphoreSlim throttler)
	{
		return default(UniTask<IDisposable>);
	}
}
