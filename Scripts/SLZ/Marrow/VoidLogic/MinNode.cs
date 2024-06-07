using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A3 RID: 163
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MinNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Min")]
	[Support(SupportFlags.Supported, null)]
	public class MinNode : BaseNode
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x000037E4 File Offset: 0x000019E4
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00006C1C File Offset: 0x00004E1C
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000301 RID: 769
		private static readonly PortMetadata _portMetadata;
	}
}
