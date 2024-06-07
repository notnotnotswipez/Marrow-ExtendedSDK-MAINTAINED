using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.Audio
{
	// Token: 0x020001B4 RID: 436
	[Serializable]
	public class ManagedAudioPlayer
	{
		// Token: 0x06000F69 RID: 3945 RVA: 0x000052A0 File Offset: 0x000034A0
		private void PlayAtPointInternal(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume, float pitchFinal, float minDistance, float spatialBlend)
		{
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x000084DC File Offset: 0x000066DC
		private UniTask<AudioPlayer> SpawnAudio()
		{
			return default(UniTask<AudioPlayer>);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x000052A2 File Offset: 0x000034A2
		private void LoopAtPointInternal(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume, float pitchFinal, float minDistance, float spatialBlend)
		{
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000084F4 File Offset: 0x000066F4
		private UniTask<AudioPlayer> SpawnAudioLoop()
		{
			return default(UniTask<AudioPlayer>);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x000052A4 File Offset: 0x000034A4
		private void PlayAtLocalPointInternal(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume, float pitchFinal, float minDistance, float spatialBlend)
		{
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0000850C File Offset: 0x0000670C
		private UniTask<AudioPlayer> SpawnLocalAudio()
		{
			return default(UniTask<AudioPlayer>);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000052A6 File Offset: 0x000034A6
		private void LoopAtLocalPointInternal(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume, float pitchFinal, float minDistance, float spatialBlend)
		{
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00008524 File Offset: 0x00006724
		private UniTask<AudioPlayer> SpawnLocalAudioLoop()
		{
			return default(UniTask<AudioPlayer>);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x000052A8 File Offset: 0x000034A8
		public void PlayAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x000052AA File Offset: 0x000034AA
		public void PlayAtPoint(AudioClip[] clips, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000052AC File Offset: 0x000034AC
		public void PlayAtPoint(AudioClip[] clips, AudioClip[] clipsHalfMo, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000052AE File Offset: 0x000034AE
		public void LoopAtPoint(AudioClip clip, Vector3 position, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000052B0 File Offset: 0x000034B0
		public void PlayAtLocalPoint(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x000052B2 File Offset: 0x000034B2
		public void PlayAtLocalPoint(AudioClip[] clips, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x000052B4 File Offset: 0x000034B4
		public void PlayAtLocalPoint(AudioClip[] clips, AudioClip[] clipsHalfMo, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float? pitchRng = null, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000052B6 File Offset: 0x000034B6
		public void LoopAtLocalPoint(AudioClip clip, Transform parent, Vector3 localPosition, AudioMixerGroup mixerGroup, float volume = 1f, float pitch = 1f, float minDistance = 1f, float spatialBlend = 0.98f)
		{
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000052B8 File Offset: 0x000034B8
		public void Stop()
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x000052BA File Offset: 0x000034BA
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x000052C1 File Offset: 0x000034C1
		public float volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x000052C3 File Offset: 0x000034C3
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x000052CA File Offset: 0x000034CA
		public float pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x000052CC File Offset: 0x000034CC
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x000052D3 File Offset: 0x000034D3
		public float minDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x000052D5 File Offset: 0x000034D5
		public bool isPlaying
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0000853C File Offset: 0x0000673C
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x000052D8 File Offset: 0x000034D8
		public Vector3 localPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x000052DA File Offset: 0x000034DA
		public AudioClip clip
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04000B18 RID: 2840
		private AudioPlayer _ap;

		// Token: 0x04000B19 RID: 2841
		private ulong _Id;

		// Token: 0x04000B1A RID: 2842
		private bool _apIncoming;

		// Token: 0x04000B1B RID: 2843
		private AudioClip _clip;

		// Token: 0x04000B1C RID: 2844
		private AudioMixerGroup _mixerGroup;

		// Token: 0x04000B1D RID: 2845
		private Transform _parent;

		// Token: 0x04000B1E RID: 2846
		private Vector3 _localPosition;

		// Token: 0x04000B1F RID: 2847
		private float _timecode;

		// Token: 0x04000B20 RID: 2848
		private float _volume;

		// Token: 0x04000B21 RID: 2849
		private float _pitch;

		// Token: 0x04000B22 RID: 2850
		private float _minDistance;

		// Token: 0x04000B23 RID: 2851
		private float _spatialBlend;

		// Token: 0x04000B24 RID: 2852
		private bool _looping;
	}
}
