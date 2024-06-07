using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000164 RID: 356
	public class XRHMD : XRDevice
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00004DCB File Offset: 0x00002FCB
		public override bool IsConnected
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00004DCE File Offset: 0x00002FCE
		public bool IsUserPresent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00004DD1 File Offset: 0x00002FD1
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public float LeftGazeConfidence
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000080D4 File Offset: 0x000062D4
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00004DDA File Offset: 0x00002FDA
		public Vector3 LeftGazePosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000080EC File Offset: 0x000062EC
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00004DDC File Offset: 0x00002FDC
		public Quaternion LeftGazeRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00004DDE File Offset: 0x00002FDE
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00004DE5 File Offset: 0x00002FE5
		public float RightGazeConfidence
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00008104 File Offset: 0x00006304
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00004DE7 File Offset: 0x00002FE7
		public Vector3 RightGazePosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0000811C File Offset: 0x0000631C
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00004DE9 File Offset: 0x00002FE9
		public Quaternion RightGazeRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}
	}
}
