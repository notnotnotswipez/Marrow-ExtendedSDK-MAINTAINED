using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x0200009C RID: 156
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Equal")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/EqualNode")]
	public class EqualNode : BaseNode
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x0000377D File Offset: 0x0000197D
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00006B74 File Offset: 0x00004D74
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002F2 RID: 754
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.\nMake sure your tolerances match for consistent results!")]
		[SerializeField]
		private float _tolerance;

		// Token: 0x040002F3 RID: 755
		private static readonly PortMetadata _portMetadata;
	}
}
