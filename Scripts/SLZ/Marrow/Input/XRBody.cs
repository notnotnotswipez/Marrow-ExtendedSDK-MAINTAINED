using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	// Token: 0x0200015E RID: 350
	public class XRBody : XRDevice
	{
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00004C35 File Offset: 0x00002E35
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00004C33 File Offset: 0x00002E33
		public virtual Vector3[] BonePositions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00004C3A File Offset: 0x00002E3A
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00004C38 File Offset: 0x00002E38
		public virtual Quaternion[] BoneRotations
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00004C3F File Offset: 0x00002E3F
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00004C3D File Offset: 0x00002E3D
		public bool HasPermission
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00004C44 File Offset: 0x00002E44
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00004C42 File Offset: 0x00002E42
		public float Confidence
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00004C4D File Offset: 0x00002E4D
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00004C4B File Offset: 0x00002E4B
		public int SkeletonChangedCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00004C50 File Offset: 0x00002E50
		public virtual bool SuggestCalibrationHeight(float height)
		{
			return false;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00004C53 File Offset: 0x00002E53
		public virtual bool ResetBodyTrackingCalibration()
		{
			return false;
		}
	}
}
