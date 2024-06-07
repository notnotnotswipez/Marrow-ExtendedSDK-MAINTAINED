using System;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200004C RID: 76
	public class ZoneLight : ZoneLinkItem
	{
		// Token: 0x06000312 RID: 786 RVA: 0x00002F88 File Offset: 0x00001188
		protected void OnEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002F8A File Offset: 0x0000118A
		protected void OnExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002F8C File Offset: 0x0000118C
		protected void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002F8E File Offset: 0x0000118E
		protected void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002F90 File Offset: 0x00001190
		private void DisableLight()
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002F92 File Offset: 0x00001192
		private void EnableLight()
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002F94 File Offset: 0x00001194
		private void ChangeLightSettings()
		{
		}

		// Token: 0x040001EE RID: 494
		[SerializeField]
		private bool PrimeZoneOnly;

		// Token: 0x040001EF RID: 495
		[Range(0f, 180f)]
		[SerializeField]
		[Space(5f)]
		[Header("Light properties")]
		private float SpotLightAngle;

		// Token: 0x040001F0 RID: 496
		[SerializeField]
		private float LightRange;

		// Token: 0x040001F1 RID: 497
		[SerializeField]
		private float LightIntensity;

		// Token: 0x040001F2 RID: 498
		[SerializeField]
		private Color LightColor;

		// Token: 0x040001F3 RID: 499
		[SerializeField]
		private bool EnableShadows;

		// Token: 0x040001F4 RID: 500
		[HideInInspector]
		[SerializeField]
		private GameObject LightObject;

		// Token: 0x040001F5 RID: 501
		[SerializeField]
		[HideInInspector]
		private Light SourceLight;
	}
}
