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
	// Token: 0x0200003E RID: 62
	public class ZoneEntityTrigger : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00002E32 File Offset: 0x00001032
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00002E35 File Offset: 0x00001035
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00002E37 File Offset: 0x00001037
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00002E3A File Offset: 0x0000103A
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

		// Token: 0x060002A0 RID: 672 RVA: 0x00002E3C File Offset: 0x0000103C
		private void Reset()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002E3E File Offset: 0x0000103E
		private void Awake()
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002E40 File Offset: 0x00001040
		private void OnEnable()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002E42 File Offset: 0x00001042
		private void OnDisable()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002E44 File Offset: 0x00001044
		private void OnDestroy()
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002E46 File Offset: 0x00001046
		private void _OnEntityTriggerEnter(MarrowEntity entity)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002E48 File Offset: 0x00001048
		private void _OnEntityTriggerExit(MarrowEntity entity)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002E4A File Offset: 0x0000104A
		 void SLZ.Marrow.VoidLogic.IVoidLogicSource.Calculate(ref NodeState nodeState)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00002E4C File Offset: 0x0000104C
		public int InputCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002E4F File Offset: 0x0000104F
		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002E55 File Offset: 0x00001055
		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000661C File Offset: 0x0000481C
		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		// Token: 0x04000190 RID: 400
		[SerializeField]
		private Zone _zone;

		// Token: 0x04000191 RID: 401
		public EntityAggregator aggregator;

		// Token: 0x04000193 RID: 403
		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		protected internal MonoBehaviour[] _previous;

		// Token: 0x04000194 RID: 404
		public UltEvent<MarrowEntity> OnEntityTriggerEnter;

		// Token: 0x04000195 RID: 405
		public UltEvent<MarrowEntity> OnEntityTriggerExit;

		// Token: 0x04000196 RID: 406
		[SerializeField]
		[ReadOnly(false)]
		private float logicMultiplier;

		// Token: 0x04000198 RID: 408
		protected internal float _cachedValue;

		// Token: 0x04000199 RID: 409
		private static readonly PortMetadata _portMetadata;
	}
}
