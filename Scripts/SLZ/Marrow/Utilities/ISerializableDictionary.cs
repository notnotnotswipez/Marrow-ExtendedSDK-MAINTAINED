using System;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x0200011A RID: 282
	public interface ISerializableDictionary
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060009FE RID: 2558
		SerializableType KeyType { get; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060009FF RID: 2559
		SerializableType ValueType { get; }
	}
}
