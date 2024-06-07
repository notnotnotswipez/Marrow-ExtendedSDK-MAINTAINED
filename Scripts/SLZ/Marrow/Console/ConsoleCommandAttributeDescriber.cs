using System;
using JetBrains.Annotations;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001A2 RID: 418
	[UsedImplicitly]
	internal class ConsoleCommandAttributeDescriber : IObjectDescriber
	{
		// Token: 0x06000EDF RID: 3807 RVA: 0x0000511A File Offset: 0x0000331A
		public bool CanDescribe(Type type)
		{
			return false;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0000511D File Offset: 0x0000331D
		public bool TryDescribe(object obj, TokenParseContext context, out ObjectDescription description)
		{
			description = null;
			return false;
		}
	}
}
