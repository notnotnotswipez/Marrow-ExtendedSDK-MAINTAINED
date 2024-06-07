using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x0200009F RID: 159
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/LessThanEqualNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Less Than or Equal")]
	[Support(SupportFlags.Supported, null)]
	public class LessThanEqualNode : BaseNode
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x000037A1 File Offset: 0x000019A1
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00006BBC File Offset: 0x00004DBC
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002F8 RID: 760
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.\nMake sure your tolerances match for consistent results!")]
		[SerializeField]
		private float _tolerance;

		// Token: 0x040002F9 RID: 761
		private static readonly PortMetadata _portMetadata;
	}
}
