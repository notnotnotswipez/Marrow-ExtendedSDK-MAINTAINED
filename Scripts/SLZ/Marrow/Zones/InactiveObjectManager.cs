using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200002D RID: 45
	public class InactiveObjectManager
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002D47 File Offset: 0x00000F47
		internal int ApplyCount
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002D4A File Offset: 0x00000F4A
		public InactiveObjectManager(bool isAutoSimulate)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002D52 File Offset: 0x00000F52
		internal void Cleanup()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002D54 File Offset: 0x00000F54
		public void Hide(InactiveStatus ic, bool isInactive = true)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002D56 File Offset: 0x00000F56
		public void Cull(InactiveStatus ic, bool isInactive = true)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002D58 File Offset: 0x00000F58
		public void Despawn(InactiveStatus ic, bool isInactive = true)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002D5A File Offset: 0x00000F5A
		public void Update()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002D5C File Offset: 0x00000F5C
		private void Resolve()
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002D5E File Offset: 0x00000F5E
		private void Apply()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002D60 File Offset: 0x00000F60
		private void Complete()
		{
		}

		// Token: 0x04000158 RID: 344
		private const double ACTIVATE_TIME_THRESHOLD_SECONDS = 0.0005000000237487257;

		// Token: 0x04000159 RID: 345
		private Queue<InactiveStatus> _resolve;

		// Token: 0x0400015A RID: 346
		private Queue<InactiveStatus> _apply;

		// Token: 0x0400015B RID: 347
		private Queue<InactiveStatus> _complete;

		// Token: 0x0400015C RID: 348
		private bool _isAutoSimulate;
	}
}
