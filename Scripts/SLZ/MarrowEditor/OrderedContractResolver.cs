using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SLZ.MarrowEditor
{
	// Token: 0x02000010 RID: 16
	public class OrderedContractResolver : DefaultContractResolver
	{
		// Token: 0x06000081 RID: 129 RVA: 0x000027DF File Offset: 0x000009DF
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		// Token: 0x04000022 RID: 34
		public static readonly JsonSerializerSettings Settings;
	}
}
