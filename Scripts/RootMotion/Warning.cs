using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000012 RID: 18
	public static class Warning
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000021F5 File Offset: 0x000003F5
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}

		// Token: 0x0400004F RID: 79
		public static bool logged;

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000441 RID: 1089
		public delegate void Logger(string message);
	}
}
