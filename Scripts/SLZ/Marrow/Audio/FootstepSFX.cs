using System;
using SLZ.Data;
using UnityEngine;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B7 RID: 439
	public class FootstepSFX : MonoBehaviour
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x00005314 File Offset: 0x00003514
		private void Awake()
		{
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00005316 File Offset: 0x00003516
		public void PlayStep(float velocitySqr)
		{
		}

		// Token: 0x04000B32 RID: 2866
		public float volumeMult;

		// Token: 0x04000B33 RID: 2867
		public AudioClip[] walkConcrete;

		// Token: 0x04000B34 RID: 2868
		public AudioClip[] runConcrete;

		// Token: 0x04000B35 RID: 2869
		public AudioVarianceData walkOverride;

		// Token: 0x04000B36 RID: 2870
		public AudioVarianceData runOverride;

		// Token: 0x04000B37 RID: 2871
		private AudioSource source;
	}
}
