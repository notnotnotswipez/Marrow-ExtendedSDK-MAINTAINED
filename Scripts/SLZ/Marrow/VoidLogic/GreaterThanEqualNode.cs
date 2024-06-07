using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x0200009D RID: 157
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/GreaterThanEqualNode")]
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Greater Than or Equal")]
	public class GreaterThanEqualNode : BaseNode
	{
		// Token: 0x060005A6 RID: 1446 RVA: 0x00003789 File Offset: 0x00001989
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00006B8C File Offset: 0x00004D8C
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002F4 RID: 756
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.\nMake sure your tolerances match for consistent results!")]
		[SerializeField]
		private float _tolerance;

		// Token: 0x040002F5 RID: 757
		private static readonly PortMetadata _portMetadata;
	}
}
