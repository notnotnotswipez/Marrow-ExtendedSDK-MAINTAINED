using System;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000C5 RID: 197
	[CreateAssetMenu(fileName = "Stream Chunk", menuName = "StressLevelZero/StreamChunk", order = 1)]
	public class Chunk : ScriptableObject
	{
		// Token: 0x0400038B RID: 907
		public MarrowScene[] sceneLayers;

		// Token: 0x0400038C RID: 908
		public Chunk[] linkedChunks;
	}
}
