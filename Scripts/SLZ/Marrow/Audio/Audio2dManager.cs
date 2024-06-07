using System;
using System.Collections;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Data;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B1 RID: 433
	public class Audio2dManager : MonoBehaviour
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x000051D8 File Offset: 0x000033D8
		private void Awake()
		{
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0000844C File Offset: 0x0000664C
		private UniTaskVoid LoadMixers()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x000051DA File Offset: 0x000033DA
		public void CueOverrideMusic(AudioClip musicClip, float targetVol, float fadeInTime, float fadeOutTime, bool loop = true, bool timedRelease = true)
		{
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000051DC File Offset: 0x000033DC
		public void StopOverrideMusic()
		{
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000051DE File Offset: 0x000033DE
		private IEnumerator OverrideCallback(float releaseTime)
		{
			return null;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000051E1 File Offset: 0x000033E1
		public void CueAmbience(AudioClip ambienceClip, float targetVol = 0.1f, float fadeInTime = 3f, float fadeOutTime = 3f)
		{
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000051E3 File Offset: 0x000033E3
		public void CueAmbience(double timecode, AudioClip ambienceClip, float targetVol = 0.1f, float fadeInTime = 3f, float fadeOutTime = 3f)
		{
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x000051E5 File Offset: 0x000033E5
		public void CueMusic(AudioClip musicClip, float targetVol, float fadeInTime = 1f, float fadeOutTime = 2f, bool loop = true)
		{
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x000051E7 File Offset: 0x000033E7
		public void CueMusic(double timecode, AudioClip musicClip, float targetVol, float fadeInTime = 1f, float fadeOutTime = 2f, bool loop = true)
		{
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x000051E9 File Offset: 0x000033E9
		private void CueMusicInternal(double timecode, AudioClip musicClip, float targetVol, float fadeInTime = 1f, float fadeOutTime = 2f, bool loop = true)
		{
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000051EB File Offset: 0x000033EB
		public void CueMusicLoopWithIntro(AudioClip musicIntro, AudioClip musicLoop, float targetVol, float fadeInTime, float fadeOutTime, float loopTransitionFade)
		{
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000051ED File Offset: 0x000033ED
		public void CueMusicLoopWithIntro(double timecode, AudioClip musicIntro, AudioClip musicLoop, float targetVol, float fadeInTime, float fadeOutTime, float loopTransitionFade)
		{
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x000051EF File Offset: 0x000033EF
		public void StopMusic(float fadeOutTime = 3f)
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000051F1 File Offset: 0x000033F1
		public void StopMusic(double timecode, float fadeOutTime = 3f)
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x000051F3 File Offset: 0x000033F3
		public bool StopSpecificMusic(AudioClip specificClip, double timecode, float fadeOutTime = 3f)
		{
			return false;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000051F6 File Offset: 0x000033F6
		private void Update()
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000051F8 File Offset: 0x000033F8
		private IEnumerator LoopCue(AudioClip loop, float introLength, float tranFade)
		{
			return null;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000051FB File Offset: 0x000033FB
		public float GetParamVal(string name, float value)
		{
			return 0f;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00005202 File Offset: 0x00003402
		public void FadeToNewReverb(AudioReverbData reverbData)
		{
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00005204 File Offset: 0x00003404
		private IEnumerator CoFadeReverbData(float fadeTime)
		{
			return null;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00005207 File Offset: 0x00003407
		private void StopFadeRoutine()
		{
		}

		// Token: 0x04000AF1 RID: 2801
		public AmbAndMusic[] ambAndMusics;

		// Token: 0x04000AF2 RID: 2802
		private int _curAmb;

		// Token: 0x04000AF3 RID: 2803
		private int _curMus;

		// Token: 0x04000AF4 RID: 2804
		private Coroutine _loopPending;

		// Token: 0x04000AF5 RID: 2805
		private bool _isOverride;

		// Token: 0x04000AF6 RID: 2806
		private bool _overridenHasIntro;

		// Token: 0x04000AF7 RID: 2807
		private AudioClip _overridenMusicClip;

		// Token: 0x04000AF8 RID: 2808
		private float _overridenTargetVol;

		// Token: 0x04000AF9 RID: 2809
		private float _overridenFadeInTime;

		// Token: 0x04000AFA RID: 2810
		private float _overridenFadeOutTime;

		// Token: 0x04000AFB RID: 2811
		private bool _overridenLoop;

		// Token: 0x04000AFC RID: 2812
		private AudioClip _overridenMusicIntro;

		// Token: 0x04000AFD RID: 2813
		private float _overridenLoopTransitionFade;

		// Token: 0x04000AFE RID: 2814
		private IEnumerator _overrideCallback;

		// Token: 0x04000AFF RID: 2815
		private double _timecodeMusic;

		// Token: 0x04000B00 RID: 2816
		private double _timecodeAmbience;

		// Token: 0x04000B01 RID: 2817
		private float[] tempData;

		// Token: 0x04000B02 RID: 2818
		private float minFadeTime;

		// Token: 0x04000B03 RID: 2819
		private Coroutine fadeRoutine;

		// Token: 0x04000B04 RID: 2820
		public AudioMixer mixer;

		// Token: 0x04000B05 RID: 2821
		public AudioReverbData prevReverbObj;

		// Token: 0x04000B06 RID: 2822
		public AudioReverbData reverbObj;
	}
}
