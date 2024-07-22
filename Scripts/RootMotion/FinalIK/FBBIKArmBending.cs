using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000037 RID: 55
	public class FBBIKArmBending : MonoBehaviour
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x00002561 File Offset: 0x00000761
		private void LateUpdate()
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002563 File Offset: 0x00000763
		private void OnPostFBBIK()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002565 File Offset: 0x00000765
		private void OnDestroy()
		{
		}

		// Token: 0x04000158 RID: 344
		public FullBodyBipedIK ik;

		// Token: 0x04000159 RID: 345
		public Vector3 bendDirectionOffsetLeft;

		// Token: 0x0400015A RID: 346
		public Vector3 bendDirectionOffsetRight;

		// Token: 0x0400015B RID: 347
		public Vector3 characterSpaceBendOffsetLeft;

		// Token: 0x0400015C RID: 348
		public Vector3 characterSpaceBendOffsetRight;

		// Token: 0x0400015D RID: 349
		private Quaternion leftHandTargetRotation;

		// Token: 0x0400015E RID: 350
		private Quaternion rightHandTargetRotation;

		// Token: 0x0400015F RID: 351
		private bool initiated;
	}
}
