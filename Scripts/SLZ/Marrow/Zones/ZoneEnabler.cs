using System;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000049 RID: 73
	public class ZoneEnabler : ZoneLinkItem
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00002F50 File Offset: 0x00001150
		private void Start()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002F52 File Offset: 0x00001152
		protected void OnEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002F54 File Offset: 0x00001154
		protected void OnExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002F56 File Offset: 0x00001156
		protected void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002F58 File Offset: 0x00001158
		protected void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002F5A File Offset: 0x0000115A
		protected void OnSecondaryEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002F5C File Offset: 0x0000115C
		protected void OnSecondaryExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002F5E File Offset: 0x0000115E
		private void SetActive(bool isActive)
		{
		}

		// Token: 0x040001E7 RID: 487
		[SerializeField]
		private GameObject[] _gameObjects;
	}
}
