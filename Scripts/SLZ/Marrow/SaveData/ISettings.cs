using System;
using Newtonsoft.Json;

namespace SLZ.Marrow.SaveData
{
	// Token: 0x02000175 RID: 373
	public interface ISettings
	{
		// Token: 0x06000E30 RID: 3632
		void FixFieldsIfNeeded();

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000E31 RID: 3633
		// (set) Token: 0x06000E32 RID: 3634
		[JsonProperty("version")]
		int Version { get; set; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000E33 RID: 3635
		// (set) Token: 0x06000E34 RID: 3636
		[JsonProperty("active_save_game")]
		string ActiveSave { get; set; }
	}
}
