using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000125 RID: 293
	public class UtilitySpawnables : MonoBehaviour
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x0000441D File Offset: 0x0000261D
		private void Awake()
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0000441F File Offset: 0x0000261F
		private void OnDestroy()
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00004421 File Offset: 0x00002621
		public static void SpawnAudioPlayer(Vector3 position = default(Vector3), Action<GameObject> callback = null)
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00007B34 File Offset: 0x00005D34
		public static UniTask<GameObject> SpawnAudioPlayerAsync(Vector3 position = default(Vector3))
		{
			return default(UniTask<GameObject>);
		}

		// Token: 0x0400065B RID: 1627
		private static UtilitySpawnables _instance;
	}
}
