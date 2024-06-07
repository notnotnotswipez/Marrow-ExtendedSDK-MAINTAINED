using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	// Token: 0x02000128 RID: 296
	public abstract class ExportTable : MonoBehaviour
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00004443 File Offset: 0x00002643
		public IReadOnlyDictionary<string, UnityEngine.Object> Exports
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000A67 RID: 2663
		private protected abstract void Awake();

		// Token: 0x06000A68 RID: 2664
		private protected abstract void OnDestroy();

		// Token: 0x0400065C RID: 1628
		[SerializeField]
		private ExportDictionary _exports;
	}
}
