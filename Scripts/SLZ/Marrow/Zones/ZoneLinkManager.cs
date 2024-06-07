using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000053 RID: 83
	public class ZoneLinkManager<TZoneActivator, TZoneLink> where TZoneActivator : class where TZoneLink : class, IZoneLinkable<TZoneActivator>, IZonePrioritizable
	{
		// Token: 0x06000354 RID: 852 RVA: 0x00003033 File Offset: 0x00001233
		public void RegisterZoneLink(TZoneLink zoneLinkA)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003035 File Offset: 0x00001235
		public void RegisterZoneLink(TZoneLink zoneLinkA, TZoneLink zoneLinkB)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003037 File Offset: 0x00001237
		public void UnregisterZoneLinkEdge(TZoneLink zoneLinkA, TZoneLink zoneLinkB)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003039 File Offset: 0x00001239
		public void UnregisterZoneLinkVert(TZoneLink zoneLink)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000303B File Offset: 0x0000123B
		private bool RegisterActivator(TZoneActivator activator)
		{
			return false;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000303E File Offset: 0x0000123E
		private void UnregisterActivator(TZoneActivator activator)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003040 File Offset: 0x00001240
		public void Activate(TZoneActivator activator, TZoneLink zoneLink)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00003042 File Offset: 0x00001242
		public void Deactivate(TZoneActivator activator, TZoneLink zoneLink, bool allowOrphan = true)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003044 File Offset: 0x00001244
		private void ClearLink(TZoneLink zoneLink)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003046 File Offset: 0x00001246
		private void RefreshZoneStates()
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003048 File Offset: 0x00001248
		private void SolveZoneStates(ZoneLinkManager<TZoneActivator, TZoneLink>.ActivatorStates states, TZoneActivator activator, TZoneLink zoneLink, TZoneLink curActiveZoneLink)
		{
		}

		// Token: 0x0400021C RID: 540
		private readonly ZoneGraph<TZoneLink> _graph;

		// Token: 0x0400021D RID: 541
		private readonly List<TZoneLink> _linkBuffer;

		// Token: 0x0400021E RID: 542
		private readonly Dictionary<TZoneActivator, ZoneLinkManager<TZoneActivator, TZoneLink>.ActivatorStates> _activatorStates;

		// Token: 0x020001EC RID: 492
		public class ActivatorStates
		{
			// Token: 0x06001073 RID: 4211 RVA: 0x00005578 File Offset: 0x00003778
			public ActiveZoneState GetZoneState(TZoneLink zoneLink)
			{
				return null;
			}

			// Token: 0x06001074 RID: 4212 RVA: 0x0000557B File Offset: 0x0000377B
			public void ClearState(TZoneLink zoneLink)
			{
			}

			// Token: 0x06001075 RID: 4213 RVA: 0x0000557D File Offset: 0x0000377D
			public bool WillOrphan(TZoneLink zoneLink)
			{
				return false;
			}

			// Token: 0x06001076 RID: 4214 RVA: 0x00005580 File Offset: 0x00003780
			public void ClearOrphan()
			{
			}

			// Token: 0x04000D0A RID: 3338
			public readonly ActiveZoneStack<TZoneLink> zoneStack;

			// Token: 0x04000D0B RID: 3339
			public readonly Dictionary<TZoneLink, ActiveZoneState> states;

			// Token: 0x04000D0C RID: 3340
			public bool isOrphaned;

			// Token: 0x04000D0D RID: 3341
			public TZoneLink orphanActiveLink;
		}
	}
}
