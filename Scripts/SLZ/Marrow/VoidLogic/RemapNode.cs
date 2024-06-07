using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A6 RID: 166
	[Support(SupportFlags.Supported, null)]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/RemapNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Remap")]
	public class RemapNode : BaseNode
	{
		// Token: 0x060005D3 RID: 1491 RVA: 0x0000380E File Offset: 0x00001A0E
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00006C64 File Offset: 0x00004E64
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000305 RID: 773
		[Tooltip("Output response curve")]
		[SerializeField]
		private AnimationCurve _remapCurve;

		// Token: 0x04000306 RID: 774
		private static readonly PortMetadata _portMetadata;
	}
}
