using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000AC RID: 172
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/XorNode")]
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Xor")]
	public class XorNode : BaseNode
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x0000388A File Offset: 0x00001A8A
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00006CDC File Offset: 0x00004EDC
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x0400031A RID: 794
		private static readonly PortMetadata _portMetadata;
	}
}
