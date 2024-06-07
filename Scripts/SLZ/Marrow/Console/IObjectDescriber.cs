using System;

namespace SLZ.Marrow.Console
{
	// Token: 0x020001A8 RID: 424
	public interface IObjectDescriber
	{
		// Token: 0x06000EFC RID: 3836
		bool CanDescribe(Type type);

		// Token: 0x06000EFD RID: 3837
		bool TryDescribe(object obj, TokenParseContext context, out ObjectDescription description);
	}
}
