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
	// Token: 0x02000056 RID: 86
	public class ZoneTriggerNode : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00003086 File Offset: 0x00001286
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00003089 File Offset: 0x00001289
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000308B File Offset: 0x0000128B
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000308E File Offset: 0x0000128E
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

		// Token: 0x06000376 RID: 886 RVA: 0x00003090 File Offset: 0x00001290
		private void Reset()
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003092 File Offset: 0x00001292
		private void Awake()
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003094 File Offset: 0x00001294
		private void OnEnable()
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003096 File Offset: 0x00001296
		private void OnDisable()
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003098 File Offset: 0x00001298
		private void OnDestroy()
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000309A File Offset: 0x0000129A
		private void _OnBodyTriggerEnter(MarrowBody body)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000309C File Offset: 0x0000129C
		private void _OnBodyTriggerExit(MarrowBody body)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000309E File Offset: 0x0000129E
		private void _OnEntityTriggerEnter(MarrowEntity entity)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000030A0 File Offset: 0x000012A0
		private void _OnEntityTriggerExit(MarrowEntity entity)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000030A2 File Offset: 0x000012A2
		 void SLZ.Marrow.VoidLogic.IVoidLogicSource.Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000380 RID: 896 RVA: 0x000030A4 File Offset: 0x000012A4
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000030A7 File Offset: 0x000012A7
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000030AD File Offset: 0x000012AD
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000066DC File Offset: 0x000048DC
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000224 RID: 548
		[SerializeField]
		private Zone _zone;

		// Token: 0x04000225 RID: 549
		public EntityAggregator aggregator;

		// Token: 0x04000227 RID: 551
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		[Tooltip("Previous node(s) in the chain")]
		protected MonoBehaviour[] _previous;

		// Token: 0x04000228 RID: 552
		public UltEvent<MarrowBody> OnBodyTriggerEnter;

		// Token: 0x04000229 RID: 553
		public UltEvent<MarrowBody> OnBodyTriggerExit;

		// Token: 0x0400022A RID: 554
		public UltEvent<MarrowEntity> OnEntityTriggerEnter;

		// Token: 0x0400022B RID: 555
		public UltEvent<MarrowEntity> OnEntityTriggerExit;

		// Token: 0x0400022C RID: 556
		[ReadOnly(false)]
		[SerializeField]
		private float logicMultiplier;

		// Token: 0x0400022E RID: 558
		protected internal float _cachedValue;

		// Token: 0x0400022F RID: 559
		private static readonly PortMetadata _portMetadata;
	}
}
