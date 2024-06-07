using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace SLZ.Marrow.VoidLogic
{
	// Token: 0x02000096 RID: 150
	[Serializable]
	public sealed class EdgeDetector
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x000036D1 File Offset: 0x000018D1
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x000036D8 File Offset: 0x000018D8
		public float HighThreshold
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000036DA File Offset: 0x000018DA
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000036E1 File Offset: 0x000018E1
		public float LowThreshold
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00006ACC File Offset: 0x00004CCC
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000036E3 File Offset: 0x000018E3
		public TriggerBehavior TriggerBehavior
		{
			[CompilerGenerated]
			get
			{
				return TriggerBehavior.DontTrigger;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x000036E5 File Offset: 0x000018E5
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x000036EC File Offset: 0x000018EC
		public float MaximumRepeatRate
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000036EE File Offset: 0x000018EE
		public EdgeDetector(float lowThreshold = 0.05f, float highThreshold = 0.95f, TriggerBehavior triggerBehavior = TriggerBehavior.OnRisingEdge, float maximumRepeatRate = 60f)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00006AE4 File Offset: 0x00004CE4
		private EdgeType Tick(float nextInput)
		{
			return EdgeType.NotAnEdge;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00006AFC File Offset: 0x00004CFC
		private ValueType TestValue(float value)
		{
			return ValueType.IndeterminateValue;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000036F6 File Offset: 0x000018F6
		[PublicAPI]
		public bool TickAndTest(float value)
		{
			return false;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000036F9 File Offset: 0x000018F9
		[PublicAPI]
		public bool TickAndTest(float value, out EdgeType edgeType)
		{
			edgeType = EdgeType.NotAnEdge;
			return false;
		}

		// Token: 0x040002D7 RID: 727
		private bool _inputWasNotLow;

		// Token: 0x040002D8 RID: 728
		private bool _inputWasNotHigh;

		// Token: 0x040002D9 RID: 729
		private float _nextAvailableTick;
	}
}
