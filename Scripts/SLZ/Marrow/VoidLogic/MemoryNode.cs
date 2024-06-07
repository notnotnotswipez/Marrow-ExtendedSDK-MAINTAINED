using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A2 RID: 162
	[Support(SupportFlags.BetaSupported, "Should be stable, but needs more usage for full confidence")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Memory")]
	public sealed class MemoryNode : BaseNode
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x000037C5 File Offset: 0x000019C5
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x000037CC File Offset: 0x000019CC
		public float Value
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000037CE File Offset: 0x000019CE
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x000037D1 File Offset: 0x000019D1
		private EdgeDetector StoreEdgeDetector
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x000037D3 File Offset: 0x000019D3
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x000037D6 File Offset: 0x000019D6
		private EdgeDetector ClearEdgeDetector
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000037D8 File Offset: 0x000019D8
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00006C04 File Offset: 0x00004E04
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000300 RID: 768
		private static readonly PortMetadata _portMetadata;
	}
}
