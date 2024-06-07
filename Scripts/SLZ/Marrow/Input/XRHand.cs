using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000163 RID: 355
	public class XRHand : XRDevice
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00004D85 File Offset: 0x00002F85
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x00004D83 File Offset: 0x00002F83
		public Quaternion[] Rotations
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

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00004D8A File Offset: 0x00002F8A
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x00004D88 File Offset: 0x00002F88
		public Vector3[] Positions
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

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00004D8F File Offset: 0x00002F8F
		// (set) Token: 0x06000DC8 RID: 3528 RVA: 0x00004D8D File Offset: 0x00002F8D
		public float[] Radii
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

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00004D94 File Offset: 0x00002F94
		// (set) Token: 0x06000DCA RID: 3530 RVA: 0x00004D92 File Offset: 0x00002F92
		public float ThumbCurl
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

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00004D9D File Offset: 0x00002F9D
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00004D9B File Offset: 0x00002F9B
		public float IndexCurl
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

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00004DA6 File Offset: 0x00002FA6
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00004DA4 File Offset: 0x00002FA4
		public float MiddleCurl
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

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00004DAF File Offset: 0x00002FAF
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00004DAD File Offset: 0x00002FAD
		public float RingCurl
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

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00004DB8 File Offset: 0x00002FB8
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00004DB6 File Offset: 0x00002FB6
		public float PinkyCurl
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

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00004DBF File Offset: 0x00002FBF
		public void StopFullUpdate()
		{
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00004DC1 File Offset: 0x00002FC1
		public void StartFullUpdate()
		{
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000080BC File Offset: 0x000062BC
		public SimpleTransform GetHandBone(XRHand hand, HandBone bone)
		{
			return default(SimpleTransform);
		}

		// Token: 0x040009CB RID: 2507
		protected bool _isFullUpdate;
	}
}
