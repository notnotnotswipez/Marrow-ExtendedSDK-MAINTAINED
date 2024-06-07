using System;
using Newtonsoft.Json;

namespace SLZ.Marrow.SaveData
{
	// Token: 0x02000174 RID: 372
	public interface ISave<TProgression, TUnlocks> where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new()
	{
		// Token: 0x06000E23 RID: 3619
		void FixFieldsIfNeeded();

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000E24 RID: 3620
		// (set) Token: 0x06000E25 RID: 3621
		[JsonProperty("version")]
		int Version { get; set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000E26 RID: 3622
		// (set) Token: 0x06000E27 RID: 3623
		[JsonProperty("modified")]
		string Modified { get; set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000E28 RID: 3624
		// (set) Token: 0x06000E29 RID: 3625
		[JsonIgnore]
		TUnlocks Unlocks { get; set; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000E2A RID: 3626
		// (set) Token: 0x06000E2B RID: 3627
		[JsonProperty("unlocks")]
		string SerializedUnlocks { get; set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000E2C RID: 3628
		// (set) Token: 0x06000E2D RID: 3629
		[JsonIgnore]
		TProgression Progression { get; set; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000E2E RID: 3630
		// (set) Token: 0x06000E2F RID: 3631
		[JsonProperty("progression")]
		string SerializedProgression { get; set; }
	}
}
