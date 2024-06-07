using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A1 RID: 161
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Max")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/MaxNode")]
	[Support(SupportFlags.Supported, null)]
	public class MaxNode : BaseNode
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x000037B9 File Offset: 0x000019B9
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00006BEC File Offset: 0x00004DEC
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002FC RID: 764
		private static readonly PortMetadata _portMetadata;
	}
}
