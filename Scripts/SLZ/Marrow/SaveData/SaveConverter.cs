using System;
using Newtonsoft.Json;

namespace SLZ.Marrow.SaveData
{
	// Token: 0x02000172 RID: 370
	public class SaveConverter<TSave, TProgression, TUnlocks> : JsonConverter<TSave> where TSave : class, ISave<TProgression, TUnlocks>, new() where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new()
	{
		// Token: 0x06000E1E RID: 3614 RVA: 0x00004EED File Offset: 0x000030ED
		public SaveConverter(SaveFlags flags)
		{
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00004EF5 File Offset: 0x000030F5
		public override void WriteJson(JsonWriter writer, TSave save, JsonSerializer serializer)
		{
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0000817C File Offset: 0x0000637C
		public override TSave ReadJson(JsonReader reader, Type objectType, TSave existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return default(TSave);
		}

		// Token: 0x040009F2 RID: 2546
		private readonly SaveFlags _flags;
	}
}
