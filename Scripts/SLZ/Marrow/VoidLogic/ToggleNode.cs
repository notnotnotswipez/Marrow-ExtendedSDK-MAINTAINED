using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000AB RID: 171
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Toggle")]
	public class ToggleNode : BaseNode
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0000386F File Offset: 0x00001A6F
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00003872 File Offset: 0x00001A72
		public bool Value
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00003874 File Offset: 0x00001A74
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00003877 File Offset: 0x00001A77
		private EdgeDetector SetEdgeDetector
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00003879 File Offset: 0x00001A79
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x0000387C File Offset: 0x00001A7C
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

		// Token: 0x060005FB RID: 1531 RVA: 0x0000387E File Offset: 0x00001A7E
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x00006CC4 File Offset: 0x00004EC4
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000319 RID: 793
		private static readonly PortMetadata _portMetadata;
	}
}
