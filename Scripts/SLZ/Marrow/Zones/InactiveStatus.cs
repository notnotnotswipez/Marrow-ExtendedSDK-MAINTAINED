using System;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public class InactiveStatus
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00002D62 File Offset: 0x00000F62
		[MethodImpl(256)]
		internal bool IsActive()
		{
			return false;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002D65 File Offset: 0x00000F65
		[MethodImpl(256)]
		internal bool IsCulled()
		{
			return false;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002D68 File Offset: 0x00000F68
		[MethodImpl(256)]
		internal bool IsHidden()
		{
			return false;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002D6B File Offset: 0x00000F6B
		[MethodImpl(256)]
		internal bool IsDespawned()
		{
			return false;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002D6E File Offset: 0x00000F6E
		internal void Hide(bool isInactive = true)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002D70 File Offset: 0x00000F70
		internal void Cull(bool isInactive = true)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002D72 File Offset: 0x00000F72
		internal void Despawn(bool isInactive = true)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002D74 File Offset: 0x00000F74
		internal void Clear()
		{
		}

		// Token: 0x04000163 RID: 355
		internal Action<InactiveStatus, bool> OnHideResolve;

		// Token: 0x04000164 RID: 356
		internal Action<InactiveStatus, bool> OnCullResolve;

		// Token: 0x04000165 RID: 357
		internal Action<InactiveStatus, bool> OnDespawnResolve;

		// Token: 0x04000166 RID: 358
		internal Action<InactiveStatus, bool> OnHideApply;

		// Token: 0x04000167 RID: 359
		internal Action<InactiveStatus, bool> OnCullApply;

		// Token: 0x04000168 RID: 360
		internal Action<InactiveStatus, bool> OnDespawnApply;

		// Token: 0x04000169 RID: 361
		internal InactiveStates request;

		// Token: 0x0400016A RID: 362
		internal InactiveStates resolved;

		// Token: 0x0400016B RID: 363
		internal InactiveStates applied;

		// Token: 0x0400016C RID: 364
		internal InactiveStates completed;
	}
}
