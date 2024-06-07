using System;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B6 RID: 438
	public class AudioPlayer : SpawnEvents
	{
		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x000052F2 File Offset: 0x000034F2
		public static ComponentCache<AudioPlayer> Cache
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000052F5 File Offset: 0x000034F5
		protected override void Awake()
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000052F7 File Offset: 0x000034F7
		public override void OnPoolInitialize()
		{
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000052F9 File Offset: 0x000034F9
		public override void OnPoolDeInitialize()
		{
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000052FB File Offset: 0x000034FB
		private void OnDestroy()
		{
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000052FD File Offset: 0x000034FD
		private void Update()
		{
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x000052FF File Offset: 0x000034FF
		public AudioSource source
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00005302 File Offset: 0x00003502
		public void Play(AudioClip clip, AudioMixerGroup mixerGroup = null, float? volume = null, bool? isLooping = null, float? pitch = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00005304 File Offset: 0x00003504
		public void Play(AudioClip[] clips, AudioMixerGroup mixerGroup = null, float? volume = null, bool? isLooping = null, float? pitch = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00005306 File Offset: 0x00003506
		public void Attenuate(float? volume = null, float? pitch = null, float? minDistance = null)
		{
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00005308 File Offset: 0x00003508
		public void Stop()
		{
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0000530A File Offset: 0x0000350A
		public void SetSpatialBlend(float blend)
		{
		}

		// Token: 0x04000B26 RID: 2854
		private static ComponentCache<AudioPlayer> _cache;

		// Token: 0x04000B27 RID: 2855
		[SerializeField]
		private AudioSource _source;

		// Token: 0x04000B28 RID: 2856
		private bool _hasStartedPlaying;

		// Token: 0x04000B29 RID: 2857
		private AudioMixerGroup _defaultMixerGroup;

		// Token: 0x04000B2A RID: 2858
		private float _defaultVolume;

		// Token: 0x04000B2B RID: 2859
		private bool _defaultLoop;

		// Token: 0x04000B2C RID: 2860
		private float _defaultPitch;

		// Token: 0x04000B2D RID: 2861
		private float _defaultMinDistance;

		// Token: 0x04000B2E RID: 2862
		private float _defaultSpatialBlend;

		// Token: 0x04000B2F RID: 2863
		private float _defaultDopplerLevel;

		// Token: 0x04000B30 RID: 2864
		private const float _lowPitchRange = 0.88f;

		// Token: 0x04000B31 RID: 2865
		private const float _highPitchRange = 1.12f;
	}
}
