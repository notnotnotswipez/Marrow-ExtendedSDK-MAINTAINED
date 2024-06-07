using System;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Forklift
{
	// Token: 0x02000178 RID: 376
	public readonly struct Result<TOk, TErr>
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00008194 File Offset: 0x00006394
		public TOk Ok
		{
			[CompilerGenerated]
			get
			{
				return default(TOk);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00004EF7 File Offset: 0x000030F7
		public bool IsOk
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x000081AC File Offset: 0x000063AC
		public TErr Err
		{
			[CompilerGenerated]
			get
			{
				return default(TErr);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00004EFA File Offset: 0x000030FA
		public bool IsErr
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00004EFD File Offset: 0x000030FD
		public Result(TOk ok)
		{
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00004EFF File Offset: 0x000030FF
		public Result(TErr err)
		{
		}
	}
}
