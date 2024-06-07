using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000028 RID: 40
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00002440 File Offset: 0x00000640
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002442 File Offset: 0x00000642
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002444 File Offset: 0x00000644
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002446 File Offset: 0x00000646
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002448 File Offset: 0x00000648
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000244A File Offset: 0x0000064A
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000244C File Offset: 0x0000064C
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000244E File Offset: 0x0000064E
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002451 File Offset: 0x00000651
		public bool ReferencesError(ref string errorMessage)
		{
			return false;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002454 File Offset: 0x00000654
		public bool ReferencesWarning(ref string warningMessage)
		{
			return false;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002457 File Offset: 0x00000657
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002459 File Offset: 0x00000659
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		// Token: 0x040000ED RID: 237
		public BipedReferences references;

		// Token: 0x040000EE RID: 238
		public IKSolverFullBodyBiped solver;
	}
}
