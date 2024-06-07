using System;

namespace SLZ.Marrow.Forklift
{
	// Token: 0x0200017E RID: 382
	public class PalletCollisionException : Exception
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x00004F5C File Offset: 0x0000315C
		public PalletCollisionException()
		{
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00004F64 File Offset: 0x00003164
		public PalletCollisionException(string message)
		{
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00004F6C File Offset: 0x0000316C
		public PalletCollisionException(string message, Exception inner)
		{
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00004F74 File Offset: 0x00003174
		public PalletCollisionException(string message, string palletBarcode, string installedModName, long installedModID, string downloadedModName, long downloadedModID)
		{
		}

		// Token: 0x04000A05 RID: 2565
		public string palletBarcode;

		// Token: 0x04000A06 RID: 2566
		public string installedModName;

		// Token: 0x04000A07 RID: 2567
		public long installedModID;

		// Token: 0x04000A08 RID: 2568
		public string downloadedModName;

		// Token: 0x04000A09 RID: 2569
		public long downloadedModID;
	}
}
