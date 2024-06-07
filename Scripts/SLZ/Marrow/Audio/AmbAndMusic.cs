using System;
using UnityEngine;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B0 RID: 432
	[Serializable]
	public class AmbAndMusic
	{
		// Token: 0x06000F16 RID: 3862 RVA: 0x000051C8 File Offset: 0x000033C8
		public void UpdateFade()
		{
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000051CA File Offset: 0x000033CA
		public void FadeOut(float fadeOutTime)
		{
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000051CC File Offset: 0x000033CC
		public void FadeIn(AudioClip ambClip, float fadeTar, float fadeInTime)
		{
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000051CE File Offset: 0x000033CE
		public void AttenuateCurrent(float fadeTar, float fadeInTime)
		{
		}

		// Token: 0x04000AEC RID: 2796
		public AudioSource ambMus;

		// Token: 0x04000AED RID: 2797
		public AudioClip clip;

		// Token: 0x04000AEE RID: 2798
		public bool isFading;

		// Token: 0x04000AEF RID: 2799
		public float fadeTarget;

		// Token: 0x04000AF0 RID: 2800
		public float fadePerSec;
	}
}
