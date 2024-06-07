using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.Marrow.SaveData
{
	// Token: 0x02000173 RID: 371
	public interface IProgression
	{
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000E21 RID: 3617
		// (set) Token: 0x06000E22 RID: 3618
		[JsonProperty("level_state")]
		Dictionary<string, Dictionary<string, object>> LevelState { get; set; }
	}
}
