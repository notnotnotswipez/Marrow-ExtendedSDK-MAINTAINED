using System;
using System.Runtime.CompilerServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200003A RID: 58
	public class ZoneBodyTrigger : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002DB0 File Offset: 0x00000FB0
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002DB3 File Offset: 0x00000FB3
		public VoidLogicSubgraph Subgraph
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002DB5 File Offset: 0x00000FB5
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002DB8 File Offset: 0x00000FB8
		private protected bool IsCachedInternal
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

		// Token: 0x06000270 RID: 624 RVA: 0x00002DBA File Offset: 0x00000FBA
		private void Reset()
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002DBC File Offset: 0x00000FBC
		private void Awake()
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002DBE File Offset: 0x00000FBE
		private void OnEnable()
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002DC0 File Offset: 0x00000FC0
		private void OnDisable()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002DC2 File Offset: 0x00000FC2
		private void OnDestroy()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002DC4 File Offset: 0x00000FC4
		private void _OnBodyTriggerEnter(MarrowBody body)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002DC6 File Offset: 0x00000FC6
		private void _OnBodyTriggerExit(MarrowBody body)
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002DC8 File Offset: 0x00000FC8
		void SLZ.Marrow.VoidLogic.IVoidLogicSource.Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002DCA File Offset: 0x00000FCA
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002DCD File Offset: 0x00000FCD
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002DD3 File Offset: 0x00000FD3
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000065EC File Offset: 0x000047EC
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000175 RID: 373
		[SerializeField]
		private Zone _zone;

		// Token: 0x04000176 RID: 374
		public EntityAggregator aggregator;

		// Token: 0x04000178 RID: 376
		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		protected internal MonoBehaviour[] _previous;

		// Token: 0x04000179 RID: 377
		public UltEvent<MarrowBody> OnBodyTriggerEnter;

		// Token: 0x0400017A RID: 378
		public UltEvent<MarrowBody> OnBodyTriggerExit;

		// Token: 0x0400017B RID: 379
		[ReadOnly(false)]
		[SerializeField]
		private float logicMultiplier;

		// Token: 0x0400017D RID: 381
		protected internal float _cachedValue;

		// Token: 0x0400017E RID: 382
		private static readonly PortMetadata _portMetadata;
	}
}
