using System;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	public class RegisteredSaveableInfo
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002BFF File Offset: 0x00000DFF
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002C02 File Offset: 0x00000E02
		public Saveable Saveable
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002C04 File Offset: 0x00000E04
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002C07 File Offset: 0x00000E07
		public string UniqueId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002C09 File Offset: 0x00000E09
		public RegisteredSaveableInfo(Saveable saveable, string uniqueId)
		{
		}
	}
}
