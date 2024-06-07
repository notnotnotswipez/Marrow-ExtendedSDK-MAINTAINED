using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x0200012E RID: 302
	[Serializable]
	public class BodyGraph<TVert, TEdge> where TVert : class where TEdge : class
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x000044C6 File Offset: 0x000026C6
		public void Clear()
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000044C8 File Offset: 0x000026C8
		public bool AddEdge(TVert vertA, TVert vertB, TEdge edge)
		{
			return false;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000044CB File Offset: 0x000026CB
		public bool RemoveEdge(TVert vertA, TVert vertB, TEdge edge)
		{
			return false;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000044CE File Offset: 0x000026CE
		public bool RemoveVert(TVert vert)
		{
			return false;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000044D1 File Offset: 0x000026D1
		private void BuildCache()
		{
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000044D3 File Offset: 0x000026D3
		public List<TVert> GetSiblingVerts(TVert vert)
		{
			return null;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000044D6 File Offset: 0x000026D6
		public bool HasEdges(TVert vert)
		{
			return false;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000044D9 File Offset: 0x000026D9
		public bool TryGetEdges(TVert vertA, TVert vertB, List<TEdge> edges)
		{
			return false;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000044DC File Offset: 0x000026DC
		public bool TryGetOutEdges(TVert vert, List<TEdge> edges)
		{
			return false;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000044DF File Offset: 0x000026DF
		public bool TryGetInVerts(TVert vert, List<TEdge> edges)
		{
			return false;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000044E2 File Offset: 0x000026E2
		public bool IsConnected(TVert vertA, TVert vertB)
		{
			return false;
		}

		// Token: 0x0400066A RID: 1642
		private List<TVert> _verts;

		// Token: 0x0400066B RID: 1643
		private readonly Dictionary<int, List<TEdge>> _edges;

		// Token: 0x0400066C RID: 1644
		private readonly Dictionary<TVert, HashSet<TVert>> _edgeHashes;

		// Token: 0x0400066D RID: 1645
		private readonly Dictionary<TVert, List<TVert>> _outEdges;

		// Token: 0x0400066E RID: 1646
		private readonly Dictionary<TVert, List<TVert>> _inEdges;

		// Token: 0x0400066F RID: 1647
		private bool _isCacheDirty;

		// Token: 0x04000670 RID: 1648
		private readonly List<HashSet<TVert>> _graphsVertHashes;

		// Token: 0x04000671 RID: 1649
		private readonly List<List<TVert>> _graphsVertLists;

		// Token: 0x04000672 RID: 1650
		private readonly Dictionary<TVert, int> _vertToGraphIdxLookup;

		// Token: 0x04000673 RID: 1651
		private readonly HashSet<TVert> _counted;

		// Token: 0x04000674 RID: 1652
		private readonly HashSet<TVert> _visited;

		// Token: 0x04000675 RID: 1653
		private readonly Queue<TVert> _searchQueue;
	}
}
