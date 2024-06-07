using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow.Zones
{
	// Token: 0x0200002A RID: 42
	internal class DisableManager
	{
		// Token: 0x0600021F RID: 543 RVA: 0x00002D2D File Offset: 0x00000F2D
		public void Cleanup()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002D2F File Offset: 0x00000F2F
		public void Register(IDisableCallbackHandler entity)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002D31 File Offset: 0x00000F31
		public void Unregister(IDisableCallbackHandler entity)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002D33 File Offset: 0x00000F33
		public void MarkDisabled(IDisableCallbackHandler disableable, DisableTypes type)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002D35 File Offset: 0x00000F35
		public void UnmarkDisabled(IDisableCallbackHandler disableable, DisableTypes type)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002D37 File Offset: 0x00000F37
		private void ProcessDisabled(ValueTuple<bool, IDisableCallbackHandler, DisableTypes> info)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002D39 File Offset: 0x00000F39
		private void LastPostLateUpdate()
		{
		}

		// Token: 0x0400014C RID: 332
		private readonly Dictionary<IDisableCallbackHandler, DisableCount> _disableCounts;

		// Token: 0x0400014D RID: 333
		private readonly List<IDisableCallbackHandler> _dirtyDisableStates;

		// Token: 0x0400014E RID: 334
		private readonly Queue<ValueTuple<IDisableCallbackHandler, bool>> _queuedDisables;

		// Token: 0x0400014F RID: 335
		private List<ValueTuple<bool, IDisableCallbackHandler, DisableTypes>> _eventBufferA;

		// Token: 0x04000150 RID: 336
		private List<ValueTuple<bool, IDisableCallbackHandler, DisableTypes>> _eventBufferB;

		// Token: 0x04000151 RID: 337
		private int _lastDisableFrame;
	}
}
