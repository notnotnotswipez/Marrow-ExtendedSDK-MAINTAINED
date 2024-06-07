using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000021 RID: 33
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00002388 File Offset: 0x00000588
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000238A File Offset: 0x0000058A
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000238C File Offset: 0x0000058C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000238E File Offset: 0x0000058E
		public override void ResetPosition()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002390 File Offset: 0x00000590
		private bool IsReadyToInitiate()
		{
			return false;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002393 File Offset: 0x00000593
		private void Update()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002395 File Offset: 0x00000595
		private void Initiate()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002397 File Offset: 0x00000597
		private void OnSolverUpdate()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002399 File Offset: 0x00000599
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000239B File Offset: 0x0000059B
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000239D File Offset: 0x0000059D
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000239F File Offset: 0x0000059F
		private void OnDestroy()
		{
		}

		// Token: 0x040000CE RID: 206
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		// Token: 0x040000CF RID: 207
		private Transform[] feet;
	}
}
