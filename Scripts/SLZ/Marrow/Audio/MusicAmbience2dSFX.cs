using System;
using System.Collections;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B8 RID: 440
	[Obsolete("MusicAmbience2dSFX has been replaced by Audio2dPlugin.Audio2dManager use that instead", true)]
	public class MusicAmbience2dSFX : MonoBehaviour
	{
		// Token: 0x06000F99 RID: 3993 RVA: 0x00005320 File Offset: 0x00003520
		private void Awake()
		{
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00005322 File Offset: 0x00003522
		public void CueOverrideMusic(AudioClip musicClip, float targetVol, float fadeInTime, float fadeOutTime, bool loop = true, bool timedRelease = true)
		{
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00005324 File Offset: 0x00003524
		public void StopOverrideMusic(AudioClip musicClip, float fadeOutTime)
		{
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00005326 File Offset: 0x00003526
		private IEnumerator OverrideCallback(float releaseTime)
		{
			return null;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00005329 File Offset: 0x00003529
		public void CueAmbience(AudioClip ambienceClip, float targetVol, float fadeInTime, float fadeOutTime)
		{
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0000532B File Offset: 0x0000352B
		public void CueMusic(AudioClip musicClip, float targetVol, float fadeInTime, float fadeOutTime, bool loop = true)
		{
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0000532D File Offset: 0x0000352D
		public void CueMusicLoopWithIntro(AudioClip musicIntro, AudioClip musicLoop, float targetVol, float fadeInTime, float fadeOutTime, float loopTransitionFade)
		{
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0000532F File Offset: 0x0000352F
		public void StopMusic(AudioClip musicClip, float fadeOutTime)
		{
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00005331 File Offset: 0x00003531
		private void Update()
		{
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00005333 File Offset: 0x00003533
		private IEnumerator LoopCue(AudioClip loop, float introLength, float tranFade)
		{
			return null;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00005336 File Offset: 0x00003536
		public float GetParamVal(string name, float value)
		{
			return 0f;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0000533D File Offset: 0x0000353D
		public void FadeToNewReverb(AudioReverbData reverbData)
		{
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0000533F File Offset: 0x0000353F
		private IEnumerator CoFadeReverbData(float fadeTime)
		{
			return null;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00005342 File Offset: 0x00003542
		private void StopFadeRoutine()
		{
		}

		// Token: 0x04000B38 RID: 2872
		public MusicAmbience2dSFX.AmbAndMusic[] ambAndMusics;

		// Token: 0x04000B39 RID: 2873
		public AudioMixerGroup AmbientMixerGroup;

		// Token: 0x04000B3A RID: 2874
		public AudioMixerGroup MusicMixerGroup;

		// Token: 0x04000B3B RID: 2875
		private int _curAmb;

		// Token: 0x04000B3C RID: 2876
		private int _curMus;

		// Token: 0x04000B3D RID: 2877
		private Coroutine _loopPending;

		// Token: 0x04000B3E RID: 2878
		private bool _isOverride;

		// Token: 0x04000B3F RID: 2879
		private bool _overridenHasIntro;

		// Token: 0x04000B40 RID: 2880
		private AudioClip _overridenMusicClip;

		// Token: 0x04000B41 RID: 2881
		private float _overridenTargetVol;

		// Token: 0x04000B42 RID: 2882
		private float _overridenFadeInTime;

		// Token: 0x04000B43 RID: 2883
		private float _overridenFadeOutTime;

		// Token: 0x04000B44 RID: 2884
		private bool _overridenLoop;

		// Token: 0x04000B45 RID: 2885
		private AudioClip _overridenMusicIntro;

		// Token: 0x04000B46 RID: 2886
		private float _overridenLoopTransitionFade;

		// Token: 0x04000B47 RID: 2887
		private IEnumerator _overrideCallback;

		// Token: 0x04000B48 RID: 2888
		private float[] tempData;

		// Token: 0x04000B49 RID: 2889
		private float minFadeTime;

		// Token: 0x04000B4A RID: 2890
		private Coroutine fadeRoutine;

		// Token: 0x04000B4B RID: 2891
		public AudioMixer mixer;

		// Token: 0x04000B4C RID: 2892
		public AudioReverbData prevReverbObj;

		// Token: 0x04000B4D RID: 2893
		public AudioReverbData reverbObj;

		// Token: 0x020002BB RID: 699
		[Serializable]
		public class AmbAndMusic
		{
			// Token: 0x06001433 RID: 5171 RVA: 0x00005D63 File Offset: 0x00003F63
			public void UpdateFade()
			{
			}

			// Token: 0x06001434 RID: 5172 RVA: 0x00005D65 File Offset: 0x00003F65
			public void FadeOut(float fadeOutTime)
			{
			}

			// Token: 0x06001435 RID: 5173 RVA: 0x00005D67 File Offset: 0x00003F67
			public void FadeIn(AudioClip ambClip, float fadeTar, float fadeInTime)
			{
			}

			// Token: 0x06001436 RID: 5174 RVA: 0x00005D69 File Offset: 0x00003F69
			public void AttenuateCurrent(float fadeTar, float fadeInTime)
			{
			}

			// Token: 0x04001107 RID: 4359
			public AudioSource ambMus;

			// Token: 0x04001108 RID: 4360
			public AudioClip clip;

			// Token: 0x04001109 RID: 4361
			public bool isFading;

			// Token: 0x0400110A RID: 4362
			public float fadeTarget;

			// Token: 0x0400110B RID: 4363
			public float fadePerSec;
		}
	}
}
