using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x020000A7 RID: 167
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/SequencerNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Sequencer")]
	[Support(SupportFlags.AlphaSupported, "This needs to be updated to use sensors and actuators.")]
	public class SequencerNode : BaseNode
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0000381A File Offset: 0x00001A1A
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x0000381D File Offset: 0x00001A1D
		private AnimationCurve Sequence
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0000381F File Offset: 0x00001A1F
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00003822 File Offset: 0x00001A22
		public bool RealTime
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00003824 File Offset: 0x00001A24
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x0000382B File Offset: 0x00001A2B
		public float TimeScale
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0000382D File Offset: 0x00001A2D
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00003830 File Offset: 0x00001A30
		public bool Loop
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00003832 File Offset: 0x00001A32
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00003835 File Offset: 0x00001A35
		public bool ResetTimeOnSequenceCompletion
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00003837 File Offset: 0x00001A37
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x0000383A File Offset: 0x00001A3A
		private EdgeDetector StartEdgeDetector
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0000383C File Offset: 0x00001A3C
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0000383F File Offset: 0x00001A3F
		private EdgeDetector ResetEdgeDetector
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003841 File Offset: 0x00001A41
		private void Start()
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00003843 File Offset: 0x00001A43
		private void Update()
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00003845 File Offset: 0x00001A45
		public override void Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00006C7C File Offset: 0x00004E7C
		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x0400030E RID: 782
		private bool _isRunning;

		// Token: 0x0400030F RID: 783
		private float _time;

		// Token: 0x04000310 RID: 784
		private float _cachedEndKeyTime;

		// Token: 0x04000311 RID: 785
		private float _cachedValue;

		// Token: 0x04000312 RID: 786
		private static readonly PortMetadata _portMetadata;
	}
}
