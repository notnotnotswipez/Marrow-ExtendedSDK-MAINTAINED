using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000101 RID: 257
	public static class MarrowDebug
	{
		// Token: 0x0600099A RID: 2458 RVA: 0x00004251 File Offset: 0x00002451
		[MethodImpl(256)]
		public static MarrowDebug.LogSuppressor SuppressIf(bool condition)
		{
			return null;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00004254 File Offset: 0x00002454
		[MethodImpl(256)]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00004256 File Offset: 0x00002456
		[MethodImpl(256)]
		public static void Log(object message)
		{
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00004258 File Offset: 0x00002458
		[Conditional("UNITY_ASSERTIONS")]
		[MethodImpl(256)]
		public static void LogAssertion(object message, UnityEngine.Object context)
		{
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0000425A File Offset: 0x0000245A
		[Conditional("UNITY_ASSERTIONS")]
		[MethodImpl(256)]
		public static void LogAssertion(object message)
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0000425C File Offset: 0x0000245C
		[Conditional("UNITY_ASSERTIONS")]
		[MethodImpl(256)]
		public static void LogAssertionFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0000425E File Offset: 0x0000245E
		[Conditional("UNITY_ASSERTIONS")]
		[MethodImpl(256)]
		public static void LogAssertionFormat(string format, params object[] args)
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00004260 File Offset: 0x00002460
		[MethodImpl(256)]
		public static void LogError(object message)
		{
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00004262 File Offset: 0x00002462
		[MethodImpl(256)]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00004264 File Offset: 0x00002464
		[MethodImpl(256)]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00004266 File Offset: 0x00002466
		[MethodImpl(256)]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00004268 File Offset: 0x00002468
		[MethodImpl(256)]
		public static void LogException(Exception exception)
		{
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0000426A File Offset: 0x0000246A
		[MethodImpl(256)]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0000426C File Offset: 0x0000246C
		[MethodImpl(256)]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0000426E File Offset: 0x0000246E
		[MethodImpl(256)]
		public static void LogFormat(LogType logType, LogOption logOptions, UnityEngine.Object context, string format, params object[] args)
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00004270 File Offset: 0x00002470
		[MethodImpl(256)]
		public static void LogFormat(string format, params object[] args)
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00004272 File Offset: 0x00002472
		[MethodImpl(256)]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00004274 File Offset: 0x00002474
		[MethodImpl(256)]
		public static void LogWarning(object message)
		{
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00004276 File Offset: 0x00002476
		[MethodImpl(256)]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00004278 File Offset: 0x00002478
		[MethodImpl(256)]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0000427A File Offset: 0x0000247A
		[Conditional("UNITY_EDITOR")]
		public static void WarnIfCalledFromAwake()
		{
		}

		// Token: 0x0400061E RID: 1566
		private const bool Enable = true;

		// Token: 0x0400061F RID: 1567
		private const bool ShowTypicalLogs = false;

		// Token: 0x04000620 RID: 1568
		private const bool ShowWarnings = false;

		// Token: 0x04000621 RID: 1569
		private static readonly ThreadLocal<bool> ThreadLocalEnable;

		// Token: 0x02000260 RID: 608
		public sealed class LogSuppressor : IDisposable
		{
			// Token: 0x0600118C RID: 4492 RVA: 0x0000582E File Offset: 0x00003A2E
			private void Dispose(bool disposing)
			{
			}

			// Token: 0x0600118D RID: 4493 RVA: 0x00005830 File Offset: 0x00003A30
			public LogSuppressor()
			{
			}

			// Token: 0x0600118E RID: 4494 RVA: 0x00005838 File Offset: 0x00003A38
			public LogSuppressor(bool doNothing)
			{
			}

			// Token: 0x0600118F RID: 4495 RVA: 0x00005840 File Offset: 0x00003A40
			protected void Finalize()
			{
			}

			// Token: 0x06001190 RID: 4496 RVA: 0x00005842 File Offset: 0x00003A42
			void System.IDisposable.Dispose()
			{
			}

			// Token: 0x04000F79 RID: 3961
			private readonly bool _doNothing;

			// Token: 0x04000F7A RID: 3962
			private readonly bool _previousValue;

			// Token: 0x04000F7B RID: 3963
			private bool _disposedValue;
		}
	}
}
