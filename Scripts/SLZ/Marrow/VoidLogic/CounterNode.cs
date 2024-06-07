using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x0200009A RID: 154
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Counter")]
	[Support(SupportFlags.BetaSupported, "Should be stable, but needs more usage for full confidence")]
	public sealed class CounterNode : BaseNode
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00003747 File Offset: 0x00001947
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0000374A File Offset: 0x0000194A
		public int Value
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000374C File Offset: 0x0000194C
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0000374F File Offset: 0x0000194F
		public int Min
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00003751 File Offset: 0x00001951
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00003754 File Offset: 0x00001954
		public int Max
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00003756 File Offset: 0x00001956
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00003759 File Offset: 0x00001959
		private EdgeDetector DecrementEdgeDetector
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0000375B File Offset: 0x0000195B
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x0000375E File Offset: 0x0000195E
		private EdgeDetector IncrementEdgeDetector
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00003760 File Offset: 0x00001960
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00003763 File Offset: 0x00001963
		private EdgeDetector ResetEdgeDetector
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

		// Token: 0x0600059A RID: 1434 RVA: 0x00003765 File Offset: 0x00001965
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00006B44 File Offset: 0x00004D44
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002F0 RID: 752
		private static readonly PortMetadata _portMetadata;
	}
}
