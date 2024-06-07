using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001AA RID: 426
	public interface ITokenConverter<out T>
	{
		// Token: 0x06000EFF RID: 3839
		bool CanConvert(Type type);

		// Token: 0x06000F00 RID: 3840
		IEnumerable<T> Convert(string token, TokenParseContext context);
	}
}
