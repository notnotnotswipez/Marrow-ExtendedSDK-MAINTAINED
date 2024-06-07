using System;
using SLZ.Marrow.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200003F RID: 63
	[RequireComponent(typeof(Zone))]
	public class ZoneEventDebugger : MonoBehaviour
	{
		// Token: 0x060002AE RID: 686 RVA: 0x00002E62 File Offset: 0x00001062
		private void Reset()
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002E64 File Offset: 0x00001064
		private void Awake()
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002E66 File Offset: 0x00001066
		private void OnEnable()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002E68 File Offset: 0x00001068
		private void OnDisable()
		{
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002E6A File Offset: 0x0000106A
		private void _OnBodyTriggerEnter(MarrowBody body)
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002E6C File Offset: 0x0000106C
		private void _OnBodyTriggerExit(MarrowBody body)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002E6E File Offset: 0x0000106E
		private void _OnEntityTriggerEnter(MarrowEntity entity)
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002E70 File Offset: 0x00001070
		private void _OnEntityTriggerExit(MarrowEntity entity)
		{
		}

		// Token: 0x0400019A RID: 410
		[SerializeField]
		private Zone _zone;

		// Token: 0x0400019B RID: 411
		public EntityAggregator aggregator;

		// Token: 0x0400019C RID: 412
		public UnityEvent<MarrowBody> OnBodyTriggerEnter;

		// Token: 0x0400019D RID: 413
		public UnityEvent<MarrowBody> OnBodyTriggerExit;

		// Token: 0x0400019E RID: 414
		public UnityEvent<MarrowEntity> OnEntityTriggerEnter;

		// Token: 0x0400019F RID: 415
		public UnityEvent<MarrowEntity> OnEntityTriggerExit;
	}
}
