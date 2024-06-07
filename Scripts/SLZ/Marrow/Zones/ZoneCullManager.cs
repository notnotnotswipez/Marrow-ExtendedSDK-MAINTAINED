using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Interaction;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200003D RID: 61
	internal class ZoneCullManager
	{
		// Token: 0x0600028D RID: 653 RVA: 0x00002E0B File Offset: 0x0000100B
		public void Register(int cullerId, int priority)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002E0D File Offset: 0x0000100D
		public void Unregister(int cullerId)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002E0F File Offset: 0x0000100F
		public void Register(int cullerId, MarrowEntity entity)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002E11 File Offset: 0x00001011
		public void Unregister(int cullerId, InactiveStatus disableCallbackHandler)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002E13 File Offset: 0x00001013
		public void Cull(InactiveStatus activatorEntity, int cullerId, bool isCulled)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002E15 File Offset: 0x00001015
		public void ForceCull(int cullerId, bool isCulled)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002E17 File Offset: 0x00001017
		public bool IsCulled(int cullerId)
		{
			return false;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002E1A File Offset: 0x0000101A
		public void Clear(InactiveStatus disableCallbackHandler)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002E1C File Offset: 0x0000101C
		private void Orphan(InactiveStatus entity, int cullerId)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002E1E File Offset: 0x0000101E
		private void UnOrphan(InactiveStatus entity)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002E20 File Offset: 0x00001020
		private void SolveOrphanedCullState(InactiveStatus disableCallbackHandler)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002E22 File Offset: 0x00001022
		private void SolveCullState(InactiveStatus disableCallbackHandler)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002E24 File Offset: 0x00001024
		internal bool TryGetCullerData(int cullerId, out CullerData cullerData)
		{
			cullerData = null;
			return false;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00006604 File Offset: 0x00004804
		private UniTaskVoid WaitToSolveCullState()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0400018B RID: 395
		private readonly Dictionary<int, CullerData> _cullerDatas;

		// Token: 0x0400018C RID: 396
		private readonly Dictionary<InactiveStatus, List<int>> _entityToCullerId;

		// Token: 0x0400018D RID: 397
		private readonly Dictionary<InactiveStatus, int> _orphanEntityToLastCullerId;

		// Token: 0x0400018E RID: 398
		private List<CullerData> _changedCullers;

		// Token: 0x0400018F RID: 399
		private bool _isWaitingToSolveCullState;
	}
}
