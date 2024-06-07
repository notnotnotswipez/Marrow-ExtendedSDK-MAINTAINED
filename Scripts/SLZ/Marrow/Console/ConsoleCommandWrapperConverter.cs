using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001A6 RID: 422
	public class ConsoleCommandWrapperConverter : IObjectDescriber, ITokenConverter<ConsoleCommandWrapper>
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x0000515A File Offset: 0x0000335A
		public bool CanDescribe(Type type)
		{
			return false;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0000515D File Offset: 0x0000335D
		public bool TryDescribe(object obj, TokenParseContext context, out ObjectDescription description)
		{
			description = null;
			return false;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00005163 File Offset: 0x00003363
		public bool CanConvert(Type type)
		{
			return false;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00005166 File Offset: 0x00003366
		public IEnumerable<ConsoleCommandWrapper> Convert(string token, TokenParseContext context)
		{
			return null;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00005169 File Offset: 0x00003369
		public TokenSuggestions<ConsoleCommandWrapper> SuggestConversions(string partialOrEmptyToken, TokenParseContext context)
		{
			return null;
		}
	}
}
