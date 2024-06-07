using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Plugins;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000141 RID: 321
	[MarrowPlugin("SLZ.Marrow.Plugins", "Overlap Trigger", "0.0.1")]
	public class OverlapTriggerManager : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00004762 File Offset: 0x00002962
		public static OverlapTriggerManager Instance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0000476D File Offset: 0x0000296D
		protected void Finalize()
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0000476F File Offset: 0x0000296F
		public void AddOverlapEnterPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00004771 File Offset: 0x00002971
		public void AddOverlapExitPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00004773 File Offset: 0x00002973
		public void DisableOverlap(GameObject overlapObject)
		{
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00004775 File Offset: 0x00002975
		private void ClearPair(OverlapTrigger trigger, GameObject otherGameObject)
		{
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00004777 File Offset: 0x00002977
		private void AddHelper(GameObject triggerGameObject, GameObject otherGameObject)
		{
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00004779 File Offset: 0x00002979
		private void RemoveHelper(GameObject triggerGameObject, GameObject otherGameObject)
		{
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0000477B File Offset: 0x0000297B
		private void OnMarrowUpdate()
		{
		}

		// Token: 0x04000710 RID: 1808
		private static OverlapTriggerManager _manager;

		// Token: 0x04000711 RID: 1809
		private readonly Dictionary<GameObject, Dictionary<GameObject, int>> _overlapCounts;

		// Token: 0x04000712 RID: 1810
		private readonly Dictionary<GameObject, HashSet<GameObject>> _helperPairLookup;

		// Token: 0x04000713 RID: 1811
		private readonly Queue<ValueTuple<OverlapTriggerManager.EventType, OverlapTrigger, GameObject>> _triggerEvents;

		// Token: 0x04000714 RID: 1812
		private readonly List<OverlapTrigger> _getComponentsTriggerCache;

		// Token: 0x02000271 RID: 625
		private enum EventType
		{
			// Token: 0x04000FBF RID: 4031
			TriggerEnter,
			// Token: 0x04000FC0 RID: 4032
			TriggerExit
		}
	}
}
