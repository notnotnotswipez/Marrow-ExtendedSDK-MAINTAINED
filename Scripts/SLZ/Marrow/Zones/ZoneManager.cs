using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000054 RID: 84
	public class ZoneManager
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00003052 File Offset: 0x00001252
		public int RegisteredZoneCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00003055 File Offset: 0x00001255
		public Zone[] RegisteredZones
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003058 File Offset: 0x00001258
		public void RegisterZone(Zone zone)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000305A File Offset: 0x0000125A
		public void UnregisterZone(Zone zone)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000305C File Offset: 0x0000125C
		public void RegisterZoneLink(ZoneLink zoneA, ZoneLink zoneB)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000305E File Offset: 0x0000125E
		public void UnregisterZoneLink(ZoneLink zoneA, ZoneLink zoneB)
		{
		}

		// Token: 0x0400021F RID: 543
		private readonly HashSet<Zone> _zones;
	}
}
