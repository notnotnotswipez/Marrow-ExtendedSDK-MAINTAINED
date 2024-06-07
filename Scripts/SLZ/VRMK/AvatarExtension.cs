using System;
using UnityEngine;

namespace SLZ.VRMK
{
	// Token: 0x02000013 RID: 19
	public class AvatarExtension : MonoBehaviour
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00002AE0 File Offset: 0x00000CE0
		protected virtual void Awake()
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002AE2 File Offset: 0x00000CE2
		private void OnEnable()
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002AE4 File Offset: 0x00000CE4
		private void OnDisable()
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002AE6 File Offset: 0x00000CE6
		public virtual void OnWriteTransforms()
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002AE8 File Offset: 0x00000CE8
		public virtual void OnRefreshBodyMeasurements()
		{
		}

		// Token: 0x040000ED RID: 237
		protected Avatar _avatar;
	}
}
