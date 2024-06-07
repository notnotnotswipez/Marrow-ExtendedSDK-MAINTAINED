using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001AB RID: 427
	public class TokenParseContext
	{
		// Token: 0x06000F01 RID: 3841 RVA: 0x0000518D File Offset: 0x0000338D
		public TokenParseContext(int softSuggestionLimit = 20, params Type[] expectedTypes)
		{
		}

		// Token: 0x04000ACA RID: 2762
		public readonly HashSet<ConsoleCommandWrapper> EligibleCommands;

		// Token: 0x04000ACB RID: 2763
		public readonly Type[] ExpectedTypes;

		// Token: 0x04000ACC RID: 2764
		public readonly int SoftSuggestionLimit;
	}
}
