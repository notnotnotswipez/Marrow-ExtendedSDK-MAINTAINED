using System;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000051 RID: 81
	public class ZoneOcclusion : ZoneLinkItem
	{
		// Token: 0x0600033B RID: 827 RVA: 0x00002FF4 File Offset: 0x000011F4
		private void Awake()
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002FF6 File Offset: 0x000011F6
		protected void OnEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002FF8 File Offset: 0x000011F8
		protected void OnExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x04000213 RID: 531
		[SerializeField]
		private OcclusionPortal _occlusion;
	}
}
