using System;
using SLZ.Marrow.Pool;
using UnityEngine;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000C7 RID: 199
	[Obsolete("Chunk tracker is now obsolete use the new zone/entity system for this functionality")]
	public class ChunkTracker : SpawnEvents
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00003B34 File Offset: 0x00001D34
		public bool IsFrozen
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00003B37 File Offset: 0x00001D37
		protected override void Awake()
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00003B39 File Offset: 0x00001D39
		private void OnDestroy()
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00003B3B File Offset: 0x00001D3B
		public void Freeze()
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00003B3D File Offset: 0x00001D3D
		public void Unfreeze()
		{
		}

		// Token: 0x04000398 RID: 920
		private int _freezeCount;

		// Token: 0x04000399 RID: 921
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x0400039A RID: 922
		[SerializeField]
		private ChunkTrackerGroup _parentGroup;
	}
}
