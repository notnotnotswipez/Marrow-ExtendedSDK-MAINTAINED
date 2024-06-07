using System;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Forklift
{
	// Token: 0x02000179 RID: 377
	public readonly struct FetchError
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00004F01 File Offset: 0x00003101
		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00004F04 File Offset: 0x00003104
		public int ErrorCode
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00004F07 File Offset: 0x00003107
		public string ErrorDescription
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00004F0A File Offset: 0x0000310A
		public int Index
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00004F0D File Offset: 0x0000310D
		public FetchError(Exception exception, int index = -1)
		{
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00004F0F File Offset: 0x0000310F
		public FetchError(int errorCode, string errorDescription, int index = -1)
		{
		}
	}
}
