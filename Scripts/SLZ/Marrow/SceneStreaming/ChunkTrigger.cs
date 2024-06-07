using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Marrow.SceneStreaming
{
	// Token: 0x020000C9 RID: 201
	[RequireComponent(typeof(BoxCollider))]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Levels")]
	[Obsolete("Chunk trigger is now obsolete use the new zone/entity system for this functionality")]
	public class ChunkTrigger : MonoBehaviour
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00007144 File Offset: 0x00005344
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00003B57 File Offset: 0x00001D57
		public StreamStatus Status
		{
			[CompilerGenerated]
			get
			{
				return StreamStatus.NONE;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00003B59 File Offset: 0x00001D59
		private void Reset()
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00003B5B File Offset: 0x00001D5B
		private void Awake()
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00003B5D File Offset: 0x00001D5D
		private void OnDestroy()
		{
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00003B5F File Offset: 0x00001D5F
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00003B61 File Offset: 0x00001D61
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00003B63 File Offset: 0x00001D63
		public void RemoveTracker(ChunkTracker tracker)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00003B65 File Offset: 0x00001D65
		public bool WarmupHasPlayer()
		{
			return false;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00003B68 File Offset: 0x00001D68
		private void HandleTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00003B6A File Offset: 0x00001D6A
		public void OnLoad()
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00003B6C File Offset: 0x00001D6C
		public void OnUnload()
		{
		}

		// Token: 0x0400039D RID: 925
		public Chunk chunk;

		// Token: 0x0400039E RID: 926
		public BoxCollider trigger;

		// Token: 0x0400039F RID: 927
		public bool ignorePlayer;

		// Token: 0x040003A0 RID: 928
		public UnityEvent OnChunkLoaded;

		// Token: 0x040003A1 RID: 929
		public UnityEvent OnChunkUnloaded;

		// Token: 0x040003A2 RID: 930
		[SerializeField]
		private LayerMask _layers;

		// Token: 0x040003A3 RID: 931
		[HideInInspector]
		public bool isActive;

		// Token: 0x040003A4 RID: 932
		private List<ChunkTracker> _trackers;

		// Token: 0x040003A5 RID: 933
		private HashSet<ChunkTracker> _trackersSet;
	}
}
