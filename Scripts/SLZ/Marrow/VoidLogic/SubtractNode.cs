using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A9 RID: 169
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/SubtractNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Subtract")]
	[Support(SupportFlags.Supported, null)]
	public class SubtractNode : BaseNode
	{
		// Token: 0x060005ED RID: 1517 RVA: 0x00003857 File Offset: 0x00001A57
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00006C94 File Offset: 0x00004E94
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000313 RID: 787
		private static readonly PortMetadata _portMetadata;
	}
}
