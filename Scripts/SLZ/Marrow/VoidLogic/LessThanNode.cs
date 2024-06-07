using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A0 RID: 160
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/LessThanNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Less Than")]
	[Support(SupportFlags.Supported, null)]
	public class LessThanNode : BaseNode
	{
		// Token: 0x060005B2 RID: 1458 RVA: 0x000037AD File Offset: 0x000019AD
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x040002FA RID: 762
		[SerializeField]
		[Tooltip("Amount of approximation allowed in the equality check.\n0 will use Mathf.Approximately/Mathf.Epsilon to approximate.\nMake sure your tolerances match for consistent results!")]
		private float _tolerance;

		// Token: 0x040002FB RID: 763
		private static readonly PortMetadata _portMetadata;
	}
}
