using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x0200009B RID: 155
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/DivideNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Divide")]
	[Support(SupportFlags.Supported, null)]
	public class DivideNode : BaseNode
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x00003771 File Offset: 0x00001971
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00006B5C File Offset: 0x00004D5C
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002F1 RID: 753
		private static readonly PortMetadata _portMetadata;
	}
}
