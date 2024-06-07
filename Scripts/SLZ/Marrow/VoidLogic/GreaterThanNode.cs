using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x0200009E RID: 158
	[Support(SupportFlags.Supported, null)]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/GreaterThanNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Greater Than")]
	public class GreaterThanNode : BaseNode
	{
		// Token: 0x060005AA RID: 1450 RVA: 0x00003795 File Offset: 0x00001995
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00006BA4 File Offset: 0x00004DA4
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002F6 RID: 758
		[SerializeField]
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.\nMake sure your tolerances match for consistent results!")]
		private float _tolerance;

		// Token: 0x040002F7 RID: 759
		private static readonly PortMetadata _portMetadata;
	}
}
