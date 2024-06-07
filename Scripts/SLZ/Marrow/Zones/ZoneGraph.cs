using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	// Token: 0x02000040 RID: 64
	public class ZoneGraph<TVert> where TVert : class
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00002E7A File Offset: 0x0000107A
		public void Clear()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002E7C File Offset: 0x0000107C
		public bool AddEdge(TVert vertA, TVert vertB)
		{
			return false;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002E7F File Offset: 0x0000107F
		public bool RemoveEdge(TVert vertA, TVert vertB)
		{
			return false;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002E82 File Offset: 0x00001082
		public bool AddVert(TVert vertA)
		{
			return false;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002E85 File Offset: 0x00001085
		public bool RemoveVert(TVert vert)
		{
			return false;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002E88 File Offset: 0x00001088
		private void BuildCache()
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002E8A File Offset: 0x0000108A
		public List<TVert> GetSiblingVerts(TVert vert)
		{
			return null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002E8D File Offset: 0x0000108D
		public bool HasEdges(TVert vert)
		{
			return false;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002E90 File Offset: 0x00001090
		public bool TryGetOutVerts(TVert vert, List<TVert> verts)
		{
			return false;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002E93 File Offset: 0x00001093
		public bool TryGetInVerts(TVert vert, List<TVert> verts)
		{
			return false;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002E96 File Offset: 0x00001096
		public bool IsConnected(TVert vertA, TVert vertB)
		{
			return false;
		}

		// Token: 0x040001A0 RID: 416
		private List<TVert> _verts;

		// Token: 0x040001A1 RID: 417
		private Dictionary<TVert, HashSet<TVert>> _edgeHashes;

		// Token: 0x040001A2 RID: 418
		private Dictionary<TVert, List<TVert>> _outEdges;

		// Token: 0x040001A3 RID: 419
		private Dictionary<TVert, List<TVert>> _inEdges;

		// Token: 0x040001A4 RID: 420
		private bool _isCacheDirty;

		// Token: 0x040001A5 RID: 421
		private List<HashSet<TVert>> _graphsVertHashes;

		// Token: 0x040001A6 RID: 422
		private List<List<TVert>> _graphsVertLists;

		// Token: 0x040001A7 RID: 423
		private Dictionary<TVert, int> _vertToGraphIdxLookup;

		// Token: 0x040001A8 RID: 424
		private HashSet<TVert> _counted;

		// Token: 0x040001A9 RID: 425
		private HashSet<TVert> _visited;

		// Token: 0x040001AA RID: 426
		private Queue<TVert> _searchQueue;
	}
}
