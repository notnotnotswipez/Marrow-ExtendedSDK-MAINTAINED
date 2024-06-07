using System;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000AA RID: 170
	[AddComponentMenu(null)]
	[Obsolete("Use Button + Toggle instead", true)]
	[Support(SupportFlags.Unsupported, null)]
	[Support(SupportFlags.Deprecated, "Use Button + Toggle instead")]
	public class ToggleButtonNode : ButtonNode
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00003863 File Offset: 0x00001A63
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00006CAC File Offset: 0x00004EAC
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000314 RID: 788
		private float _multiplier;

		// Token: 0x04000315 RID: 789
		private static readonly PortMetadata _portMetadata;
	}
}
