using System;
using System.Collections;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000046 RID: 70
	public class Zone3dSound : ZoneLinkItem
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00002F02 File Offset: 0x00001102
		public AudioPlayer audioPlayer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002F05 File Offset: 0x00001105
		public void SetSecondaryVolume(float volume)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002F07 File Offset: 0x00001107
		protected void OnSecondaryEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002F09 File Offset: 0x00001109
		protected void OnPrimaryEnter(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002F0B File Offset: 0x0000110B
		protected void OnPrimaryExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002F0D File Offset: 0x0000110D
		protected void OnExit(MarrowEntity activatorEntity)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002F0F File Offset: 0x0000110F
		private void PlayNew(Action callback = null)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002F11 File Offset: 0x00001111
		private IEnumerator Fade(float fadeTarget, float fadeTime)
		{
			return null;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002F14 File Offset: 0x00001114
		private float randomizeFloat(float max, float minMultiplier)
		{
			return 0f;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002F1B File Offset: 0x0000111B
		public void StopSound()
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002F1D File Offset: 0x0000111D
		public void PlaySound()
		{
		}

		// Token: 0x040001CB RID: 459
		public Zone3dSound.SoundMode soundMode;

		// Token: 0x040001CC RID: 460
		public Transform[] targetTran;

		// Token: 0x040001CD RID: 461
		[HideInInspector]
		public AudioClip clip;

		// Token: 0x040001CE RID: 462
		[Tooltip("More than one clip will randomize for PLAY_ON_ENTER mode")]
		public AudioClip[] clips;

		// Token: 0x040001CF RID: 463
		[Range(0f, 1f)]
		public float primaryVolume;

		// Token: 0x040001D0 RID: 464
		[Range(0f, 1f)]
		public float secondaryVolume;

		// Token: 0x040001D1 RID: 465
		public float pitch;

		// Token: 0x040001D2 RID: 466
		[Range(0.1f, 4f)]
		[Tooltip("Higher number fades faster")]
		public float fadeSpeed;

		// Token: 0x040001D3 RID: 467
		[Range(0.1f, 10f)]
		[Tooltip("Radius of min sphere")]
		public float sourceRadius;

		// Token: 0x040001D4 RID: 468
		private bool loop;

		// Token: 0x040001D5 RID: 469
		private bool hasPlayed;

		// Token: 0x040001D6 RID: 470
		private bool _fadeActive;

		// Token: 0x040001D7 RID: 471
		private bool _inPrimary;

		// Token: 0x040001D8 RID: 472
		private AudioPlayer _ap;

		// Token: 0x040001D9 RID: 473
		private float _curVol;

		// Token: 0x040001DA RID: 474
		[Tooltip("0 = no delays, any other value, will cause wait to happen randomly between value and 50% of value")]
		public float waitTime;

		// Token: 0x040001DB RID: 475
		private float _nextFirable;

		// Token: 0x040001DC RID: 476
		private bool _useRandomClip;

		// Token: 0x040001DD RID: 477
		private int _randomClipIndex;

		// Token: 0x040001DE RID: 478
		private int _randomTransformIndex;

		// Token: 0x020001E3 RID: 483
		public enum SoundMode
		{
			// Token: 0x04000CEB RID: 3307
			CONTINUOUS,
			// Token: 0x04000CEC RID: 3308
			ONE_SHOT,
			// Token: 0x04000CED RID: 3309
			PLAY_ON_ENTER
		}
	}
}
