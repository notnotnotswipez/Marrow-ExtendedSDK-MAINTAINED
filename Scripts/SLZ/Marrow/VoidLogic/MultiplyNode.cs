using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A4 RID: 164
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Multiply")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MultiplyNode")]
	[Support(SupportFlags.Supported, null)]
	public class MultiplyNode : BaseNode
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x000037F0 File Offset: 0x000019F0
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00006C34 File Offset: 0x00004E34
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000302 RID: 770
		private static readonly PortMetadata _portMetadata;
	}
}
