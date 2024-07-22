using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000069 RID: 105
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00002BA7 File Offset: 0x00000DA7
		protected float deltaTime
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600041A RID: 1050
		protected abstract void OnModifyOffset();

		// Token: 0x0600041B RID: 1051 RVA: 0x00002BAE File Offset: 0x00000DAE
		protected virtual void Start()
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002BB0 File Offset: 0x00000DB0
		private IEnumerator Initiate()
		{
			return null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002BB3 File Offset: 0x00000DB3
		private void ModifyOffset()
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002BB5 File Offset: 0x00000DB5
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x04000370 RID: 880
		[Tooltip("The master weight")]
		public float weight;

		// Token: 0x04000371 RID: 881
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		// Token: 0x04000372 RID: 882
		private float lastTime;
	}
}
