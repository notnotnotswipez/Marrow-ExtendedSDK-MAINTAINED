using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B3 RID: 435
	public class Audio3dManager : MonoBehaviour
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0000521E File Offset: 0x0000341E
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00005221 File Offset: 0x00003421
		public static AudioMixerGroup softInteraction
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00005223 File Offset: 0x00003423
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00005226 File Offset: 0x00003426
		public static AudioMixerGroup ambience
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00005228 File Offset: 0x00003428
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x0000522B File Offset: 0x0000342B
		public static AudioMixerGroup inHead
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0000522D File Offset: 0x0000342D
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00005230 File Offset: 0x00003430
		public static AudioMixerGroup ui
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00005232 File Offset: 0x00003432
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00005235 File Offset: 0x00003435
		public static AudioMixerGroup gunShot
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00005237 File Offset: 0x00003437
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x0000523A File Offset: 0x0000343A
		public static AudioMixerGroup impact
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0000523C File Offset: 0x0000343C
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x0000523F File Offset: 0x0000343F
		public static AudioMixerGroup bulletImpact
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00005241 File Offset: 0x00003441
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x00005244 File Offset: 0x00003444
		public static AudioMixerGroup diegeticMusic
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00005246 File Offset: 0x00003446
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00005249 File Offset: 0x00003449
		public static AudioMixerGroup footsteps
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x0000524B File Offset: 0x0000344B
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x0000524E File Offset: 0x0000344E
		public static AudioMixerGroup hardInteraction
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00005250 File Offset: 0x00003450
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00005253 File Offset: 0x00003453
		public static AudioMixerGroup shells
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00005255 File Offset: 0x00003455
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00005258 File Offset: 0x00003458
		public static AudioMixerGroup npcVocals
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x0000525A File Offset: 0x0000345A
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x0000525D File Offset: 0x0000345D
		public static AudioMixerGroup nonDiegeticMusic
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0000525F File Offset: 0x0000345F
		private void Awake()
		{
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0000847C File Offset: 0x0000667C
		private UniTaskVoid LoadMixers()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00005261 File Offset: 0x00003461
		public static void PlayAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00005263 File Offset: 0x00003463
		public static void PlayAtPoint(AudioClip[] clips, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00005265 File Offset: 0x00003465
		public static void PlayAtPoint(AudioClip clip, AudioClip clipHalfMo, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00005267 File Offset: 0x00003467
		public static void PlayAtPoint(AudioClip[] clips, AudioClip[] clipsHalfMo, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00005269 File Offset: 0x00003469
		public static void PlayAtLocalPoint(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0000526B File Offset: 0x0000346B
		public static void PlayAtLocalPoint(AudioClip[] clips, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0000526D File Offset: 0x0000346D
		public static void PlayAtLocalPoint(AudioClip clip, AudioClip clipHalfMo, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0000526F File Offset: 0x0000346F
		public static void PlayAtLocalPoint(AudioClip[] clips, AudioClip[] clipsHalfMo, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float? minDistance = null, float? spatialBlend = null)
		{
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00005271 File Offset: 0x00003471
		public static void Play2dOneShot(AudioClip clip, AudioMixerGroup mixerGroup, float? volume = null, float? pitch = null)
		{
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00005273 File Offset: 0x00003473
		public static void Play2dOneShot(AudioClip[] clips, AudioMixerGroup mixerGroup, float? volume = null, float? pitch = null)
		{
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00008494 File Offset: 0x00006694
		private static UniTask<AudioPlayer> PlayAtPointAsync(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float? volume = null, float? pitch = null, float? minDistance = null, float? spatialBlend = null)
		{
			return default(UniTask<AudioPlayer>);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000084AC File Offset: 0x000066AC
		private static UniTask<AudioPlayer> PlayAtLocalPointAsync(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float? volume = null, float? pitch = null, float? minDistance = null, float? spatialBlend = null)
		{
			return default(UniTask<AudioPlayer>);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000084C4 File Offset: 0x000066C4
		private static UniTask<AudioPlayer> Play2dOneShotAsync(AudioClip clip, AudioMixerGroup mixerGroup, float? volume = null, float? pitch = null)
		{
			return default(UniTask<AudioPlayer>);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00005275 File Offset: 0x00003475
		public static void SpawnAudioPlayer(Vector3 position = default(Vector3), Action<GameObject> callback = null)
		{
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00005277 File Offset: 0x00003477
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x0000527E File Offset: 0x0000347E
		public static float audio_Master
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00005280 File Offset: 0x00003480
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x00005287 File Offset: 0x00003487
		public static float audio_Music
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00005289 File Offset: 0x00003489
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00005290 File Offset: 0x00003490
		public static float audio_SFX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00005292 File Offset: 0x00003492
		public void SetLowPassFilter(float lpf)
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00005294 File Offset: 0x00003494
		private static void SETMIXERS()
		{
		}

		// Token: 0x04000B15 RID: 2837
		private static float audio_GlobalVolume;

		// Token: 0x04000B16 RID: 2838
		private static float audio_MusicVolume;

		// Token: 0x04000B17 RID: 2839
		private static float audio_SFXVolume;
	}
}
