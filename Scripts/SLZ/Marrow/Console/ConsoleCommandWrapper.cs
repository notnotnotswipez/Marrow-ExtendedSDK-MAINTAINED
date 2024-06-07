using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001A5 RID: 421
	public sealed class ConsoleCommandWrapper
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00005148 File Offset: 0x00003348
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x0000514B File Offset: 0x0000334B
		public bool Installed
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x0000514D File Offset: 0x0000334D
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00005150 File Offset: 0x00003350
		public IReadOnlyList<ConsoleCommandAttribute> Attributes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00005152 File Offset: 0x00003352
		public ConsoleCommandWrapper(Type commandType)
		{
		}

		// Token: 0x04000AC2 RID: 2754
		public readonly BaseConsoleCommand Command;
	}
}
