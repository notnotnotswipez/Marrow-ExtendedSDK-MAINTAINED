using System;
using SLZ.Marrow.Interaction;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200004D RID: 77
	[RequireComponent(typeof(ZoneLink))]
	public class ZoneLinkEvents : ZoneLinkItem
	{
		// Token: 0x0600031A RID: 794 RVA: 0x00002F9E File Offset: 0x0000119E
		protected void OnEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002FA0 File Offset: 0x000011A0
		protected void OnExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002FA2 File Offset: 0x000011A2
		protected void OnSecondaryEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002FA4 File Offset: 0x000011A4
		protected void OnSecondaryExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002FA6 File Offset: 0x000011A6
		protected void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002FA8 File Offset: 0x000011A8
		protected void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x040001F6 RID: 502
		private bool _hasZoneLinkEntered;

		// Token: 0x040001F7 RID: 503
		[Space(10f)]
		public ZoneLinkEvents.ZoneEventCallback onZoneLinkEnter;

		// Token: 0x040001F8 RID: 504
		[Space(10f)]
		public ZoneLinkEvents.ZoneEventCallback onZoneLinkEnterOneShot;

		// Token: 0x040001F9 RID: 505
		[Space(10f)]
		public ZoneLinkEvents.ZoneEventCallback onZoneLinkExit;

		// Token: 0x040001FA RID: 506
		[Space(10f)]
		public ZoneLinkEvents.ZoneEventCallback onSecondaryZoneLinkEnter;

		// Token: 0x040001FB RID: 507
		[Space(10f)]
		public ZoneLinkEvents.ZoneEventCallback onSecondaryZoneLinkExit;

		// Token: 0x040001FC RID: 508
		[Space(10f)]
		public ZoneLinkEvents.ZoneEventCallback onPrimaryZoneLinkEnter;

		// Token: 0x040001FD RID: 509
		[Space(10f)]
		public ZoneLinkEvents.ZoneEventCallback onPrimaryZoneLinkExit;

		// Token: 0x020001E8 RID: 488
		[Serializable]
		public class ZoneEventCallback : UltEvent<MarrowEntity>
		{
		}
	}
}
