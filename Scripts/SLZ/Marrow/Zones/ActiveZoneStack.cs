using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000026 RID: 38
	public class ActiveZoneStack<TZoneLink> : UnityEngine.Object where TZoneLink : class, IZonePrioritizable
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00002CFB File Offset: 0x00000EFB
		public List<TZoneLink> ActiveZones
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002CFE File Offset: 0x00000EFE
		public IReadOnlyList<TZoneLink> GetZoneStack(TZoneLink zoneLink)
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002D01 File Offset: 0x00000F01
		public bool Activate(TZoneLink previous, TZoneLink next)
		{
			return false;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002D04 File Offset: 0x00000F04
		public bool Activate(TZoneLink zoneLink)
		{
			return false;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002D07 File Offset: 0x00000F07
		public bool Deactivate(TZoneLink zoneLink)
		{
			return false;
		}

		// Token: 0x0400013A RID: 314
		private Dictionary<TZoneLink, List<TZoneLink>> _stackLookup;

		// Token: 0x0400013B RID: 315
		private List<TZoneLink> _activeZones;
	}
}
