using System;
using System.Diagnostics;
using JetBrains.Annotations;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001A3 RID: 419
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	[MeansImplicitUse]
	[DebuggerDisplay("ConsoleCommand({ImplicitName})")]
	public sealed class ConsoleCommandAttribute : Attribute
	{
		// Token: 0x06000EE2 RID: 3810 RVA: 0x0000512B File Offset: 0x0000332B
		public ConsoleCommandAttribute(string @namespace, string name, string description = "")
		{
		}

		// Token: 0x04000AB9 RID: 2745
		public readonly string Namespace;

		// Token: 0x04000ABA RID: 2746
		public readonly string Name;

		// Token: 0x04000ABB RID: 2747
		public readonly string Description;

		// Token: 0x04000ABC RID: 2748
		public readonly string ImplicitName;
	}
}
