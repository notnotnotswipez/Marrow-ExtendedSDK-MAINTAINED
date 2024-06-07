using System;
using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.PhysxHelpers
{
	// Token: 0x02000025 RID: 37
	public class PhysxTriggerHelper : MonoBehaviour
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00002CE3 File Offset: 0x00000EE3
		public static ComponentCache<PhysxTriggerHelper> Cache
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002CE6 File Offset: 0x00000EE6
		private void Awake()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002CE8 File Offset: 0x00000EE8
		private void OnDisable()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002CEA File Offset: 0x00000EEA
		private void OnDestroy()
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002CEC File Offset: 0x00000EEC
		public static PhysxTriggerHelper GetHelper(Collider col)
		{
			return null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002CEF File Offset: 0x00000EEF
		public static void AddDisableCallback(Collider col, Action<Collider, Rigidbody> callback)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public static void RemoveDisableCallback(Collider col, Action<Collider, Rigidbody> callback)
		{
		}

		// Token: 0x04000136 RID: 310
		private static ComponentCache<PhysxTriggerHelper> _cache;

		// Token: 0x04000137 RID: 311
		private List<Action<Collider, Rigidbody>> _onDisableActions;

		// Token: 0x04000138 RID: 312
		private Collider _collider;

		// Token: 0x04000139 RID: 313
		private Rigidbody _rigidbody;
	}
}
