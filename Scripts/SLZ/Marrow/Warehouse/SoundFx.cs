using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	// Token: 0x0200007E RID: 126
	public class SoundFx : DataCard
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0000350F File Offset: 0x0000170F
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00003512 File Offset: 0x00001712
		public MarrowAssetT<AudioClip>[] AudioClips
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00003514 File Offset: 0x00001714
		public override bool IsBundledDataCard()
		{
			return false;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000069AC File Offset: 0x00004BAC
		public UniTask PreloadAssets()
		{
			return default(UniTask);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000069C4 File Offset: 0x00004BC4
		public UniTask<AudioClip> LoadRandomAudioClip(bool noRepeats = true)
		{
			return default(UniTask<AudioClip>);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00003517 File Offset: 0x00001717
		public MarrowAssetT<AudioClip> GetRandomAudioClip(bool noRepeats = true)
		{
			return null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000351A File Offset: 0x0000171A
		private MarrowAssetT<AudioClip> GetRandomAudioClipNoRepeat()
		{
			return null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000351D File Offset: 0x0000171D
		public override void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000351F File Offset: 0x0000171F
		public override List<PackedAsset> ExportPackedAssets()
		{
			return null;
		}

		// Token: 0x0400028E RID: 654
		[SerializeField]
		[Tooltip("AudioClip that represents the sound effect. Add multiple to be used as variation sounds")]
		private MarrowAssetT<AudioClip>[] _audioClips;

		// Token: 0x0400028F RID: 655
		private MarrowAssetT<AudioClip>[] _audioClipsCachedRandom;

		// Token: 0x04000290 RID: 656
		private bool randomFirst;
	}
}
