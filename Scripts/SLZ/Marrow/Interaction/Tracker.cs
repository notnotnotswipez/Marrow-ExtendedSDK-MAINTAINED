using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000135 RID: 309
	public class Tracker : MonoBehaviour
	{
		// Token: 0x06000AE5 RID: 2789 RVA: 0x0000458C File Offset: 0x0000278C
		private bool CanUpdateValues(Vector3 orignal, Vector3 updated)
		{
			return false;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000458F File Offset: 0x0000278F
		private bool CanUpdateValues(float original, float updated)
		{
			return false;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00004592 File Offset: 0x00002792
		internal void Validate(TrackerSettings settings, MarrowBody body, MarrowEntity entity)
		{
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00004594 File Offset: 0x00002794
		public static ComponentCache<Tracker> Cache
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00004597 File Offset: 0x00002797
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x0000459A File Offset: 0x0000279A
		public bool HasBody
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x0000459C File Offset: 0x0000279C
		public MarrowEntity Entity
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0000459F File Offset: 0x0000279F
		public MarrowBody Body
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x000045A2 File Offset: 0x000027A2
		public Collider Collider
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000045A5 File Offset: 0x000027A5
		private void Awake()
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000045A7 File Offset: 0x000027A7
		private void OnDestroy()
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x000045A9 File Offset: 0x000027A9
		internal void OnDeactivate()
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x000045AB File Offset: 0x000027AB
		public void AddDisableCallback(Action<Collider> callback)
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000045AD File Offset: 0x000027AD
		public void RemoveDisableCallback(Action<Collider> callback)
		{
		}

		// Token: 0x040006A8 RID: 1704
		private static ComponentCache<Tracker> _cache;

		// Token: 0x040006A9 RID: 1705
		[SerializeField]
		private MarrowEntity _entity;

		// Token: 0x040006AA RID: 1706
		[SerializeField]
		private MarrowBody _body;

		// Token: 0x040006AB RID: 1707
		[SerializeField]
		private Collider _collider;

		// Token: 0x040006AD RID: 1709
		private List<Action<Collider>> _onDisableActions;
	}
}
