using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000136 RID: 310
	[MarrowPlugin("SLZ.Marrow", "CollisionManager", "0.0.1")]
	public class MarrowCollisionManager : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		// Token: 0x06000AF4 RID: 2804 RVA: 0x00007BAC File Offset: 0x00005DAC
		 UniTask SLZ.Marrow.Plugins.IMarrowPluginLevelCallbacks.OnAfterLevelUnload()
		{
			return default(UniTask);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000045B7 File Offset: 0x000027B7
		public static void ManagedIgnore(Collider colliderA, Collider colliderB, bool doIgnore = true)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000045B9 File Offset: 0x000027B9
		public static bool IsIgnored(Collider colliderA, Collider colliderB)
		{
			return false;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000045BC File Offset: 0x000027BC
		[MethodImpl(256)]
		private static int GetHashForPair(Collider colliderA, Collider colliderB)
		{
			return 0;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000045BF File Offset: 0x000027BF
		public static void ClearManagedIgnoresFor(Collider colliderA)
		{
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000045C1 File Offset: 0x000027C1
		private static void CacheLookups(Collider colliderA, Collider colliderB)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000045C3 File Offset: 0x000027C3
		private static void ClearLookups(Collider colliderA, Collider colliderB)
		{
		}

		// Token: 0x040006AE RID: 1710
		private static readonly Dictionary<int, int> _ignoreCounts;

		// Token: 0x040006AF RID: 1711
		private static readonly Dictionary<Collider, HashSet<Collider>> _colliderToColliderMap;

		// Token: 0x040006B0 RID: 1712
		private static readonly List<Collider> _colBsToRemove;
	}
}
