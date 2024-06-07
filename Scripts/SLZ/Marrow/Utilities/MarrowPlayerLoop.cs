using System;
using System.Text;
using UnityEngine.LowLevel;

namespace SLZ.Marrow.Utilities
{
	// Token: 0x02000111 RID: 273
	public class MarrowPlayerLoop
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x000042CC File Offset: 0x000024CC
		public void RegisterLoopAction(UpdateLoopActions loopAction, Action action)
		{
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000042CE File Offset: 0x000024CE
		public void UnregisterLoopAction(UpdateLoopActions loopAction, Action action)
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000042D0 File Offset: 0x000024D0
		private void Setup()
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000042D2 File Offset: 0x000024D2
		private void AddLoopSystem<CustomSystemT, SubSystemT>(PlayerLoopSystem system, int subSysIdx, PlayerLoopSystem.UpdateFunction Callback, bool isBefore = false)
		{
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000042D4 File Offset: 0x000024D4
		private void OnPostTimeUpdate()
		{
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000042D6 File Offset: 0x000024D6
		private void OnStartFrame()
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000042D8 File Offset: 0x000024D8
		private void OnPreNewInputUpdate()
		{
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000042DA File Offset: 0x000024DA
		private void OnPostNewInputUpdate()
		{
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000042DC File Offset: 0x000024DC
		private void OnEarlyUpdate()
		{
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000042DE File Offset: 0x000024DE
		private void OnUpdate()
		{
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000042E0 File Offset: 0x000024E0
		private void OnPreFixedUpdate()
		{
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000042E2 File Offset: 0x000024E2
		private void OnPostFixedUpdate()
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000042E4 File Offset: 0x000024E4
		private void OnEndFrame()
		{
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000042E6 File Offset: 0x000024E6
		private void PlayerLoopPrint()
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000042E8 File Offset: 0x000024E8
		private void RecursivePlayerLoopPrint(PlayerLoopSystem plSystem, StringBuilder sb, int depth)
		{
		}

		// Token: 0x04000636 RID: 1590
		private Action _postTimeUpdateDelegate;

		// Token: 0x04000637 RID: 1591
		private Action _startFrameDelegate;

		// Token: 0x04000638 RID: 1592
		private Action _preNewInputUpdateDelegate;

		// Token: 0x04000639 RID: 1593
		private Action _postNewInputUpdateDelegate;

		// Token: 0x0400063A RID: 1594
		private Action _earlyUpdateDelegate;

		// Token: 0x0400063B RID: 1595
		private Action _updateDelegate;

		// Token: 0x0400063C RID: 1596
		private Action _preFixedUpdate;

		// Token: 0x0400063D RID: 1597
		private Action _postFixedUpdate;

		// Token: 0x0400063E RID: 1598
		private Action _endFrameDelegate;
	}
}
