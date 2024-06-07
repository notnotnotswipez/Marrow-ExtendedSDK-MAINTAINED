using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	// Token: 0x0200012C RID: 300
	public static class LateReferenceManager
	{
		// Token: 0x06000A85 RID: 2693 RVA: 0x0000448F File Offset: 0x0000268F
		public static bool TryGetIdForObject(UnityEngine.Object obj, out ExportTable exportTable, out string uniqueId)
		{
			exportTable = null;
			uniqueId = null;
			return false;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00004498 File Offset: 0x00002698
		public static bool TryGetObject<T>(LateReference<T> lateReference, out ExportTable exportTable, out T obj) where T : UnityEngine.Object
		{
			exportTable = null;
			obj = default(T);
			return false;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000044A5 File Offset: 0x000026A5
		public static bool FindSuitableExportTableForObject(UnityEngine.Object obj, out ExportTable exportTable)
		{
			exportTable = null;
			return false;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000044AB File Offset: 0x000026AB
		public static void Register(ExportTable exportTable, LateReference lateReference)
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000044AD File Offset: 0x000026AD
		public static void AddSubscription<T>(LateReference<T> lateReference) where T : UnityEngine.Object
		{
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000044AF File Offset: 0x000026AF
		public static void LinkSubscribedLateReferences()
		{
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x000044B1 File Offset: 0x000026B1
		public static int VacuumLinks()
		{
			return 0;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000044B4 File Offset: 0x000026B4
		public static void LoadTable(SceneExportTable exportTable)
		{
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000044B6 File Offset: 0x000026B6
		public static void UnloadTable(SceneExportTable exportTable)
		{
		}

		// Token: 0x04000663 RID: 1635
		private static ExportTable _exportTableOfLastResort;

		// Token: 0x04000664 RID: 1636
		private static readonly Dictionary<string, SceneExportTable> _sceneExportIndex;

		// Token: 0x04000665 RID: 1637
		private static readonly Dictionary<string, UnityEngine.Object> _sceneObjectsById;

		// Token: 0x04000666 RID: 1638
		private static readonly Dictionary<UnityEngine.Object, string> _sceneIdsByObject;

		// Token: 0x04000667 RID: 1639
		private static readonly Dictionary<string, HashSet<LateReference>> _subscriptions;
	}
}
