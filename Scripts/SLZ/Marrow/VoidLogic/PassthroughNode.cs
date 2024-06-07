using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A5 RID: 165
	[Support(SupportFlags.Supported, null)]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Passthrough")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/PassthroughNode")]
	public class PassthroughNode : BaseNode
	{
		// Token: 0x060005CC RID: 1484 RVA: 0x000037FC File Offset: 0x000019FC
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000037FE File Offset: 0x000019FE
		[MethodImpl(256)]
		public void Toggle()
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00003800 File Offset: 0x00001A00
		[MethodImpl(256)]
		public void TurnOn()
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00003802 File Offset: 0x00001A02
		[MethodImpl(256)]
		public void TurnOff()
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00006C4C File Offset: 0x00004E4C
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000303 RID: 771
		[SerializeField]
		private bool _cutoff;

		// Token: 0x04000304 RID: 772
		private static readonly PortMetadata _portMetadata;
	}
}
