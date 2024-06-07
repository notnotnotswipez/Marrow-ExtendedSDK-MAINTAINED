using System;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	// Token: 0x02000127 RID: 295
	[ExecuteAlways]
	[RequireComponent(typeof(LinkLateReferenceSubscriptions))]
	public class SceneExportTable : ExportTable
	{
		// Token: 0x06000A62 RID: 2658 RVA: 0x00004435 File Offset: 0x00002635
		private protected override void Awake()
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00004437 File Offset: 0x00002637
		private void Reset()
		{
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00004439 File Offset: 0x00002639
		private protected override void OnDestroy()
		{
		}
	}
}
