using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x02000097 RID: 151
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Add")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/AddNode")]
	public class AddNode : BaseNode
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00003703 File Offset: 0x00001903
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00006B14 File Offset: 0x00004D14
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002DA RID: 730
		private static readonly PortMetadata _portMetadata;
	}
}
