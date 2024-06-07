using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200001D RID: 29
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderBipedIK : Grounder
	{
		// Token: 0x060000DA RID: 218 RVA: 0x000022FA File Offset: 0x000004FA
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000022FC File Offset: 0x000004FC
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000022FE File Offset: 0x000004FE
		public override void ResetPosition()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002300 File Offset: 0x00000500
		private bool IsReadyToInitiate()
		{
			return false;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002303 File Offset: 0x00000503
		private void Update()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002305 File Offset: 0x00000505
		private void Initiate()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002307 File Offset: 0x00000507
		private void OnDisable()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002309 File Offset: 0x00000509
		private void OnSolverUpdate()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000230B File Offset: 0x0000050B
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000230D File Offset: 0x0000050D
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000230F File Offset: 0x0000050F
		private void OnDestroy()
		{
		}

		// Token: 0x04000093 RID: 147
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		// Token: 0x04000094 RID: 148
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		// Token: 0x04000095 RID: 149
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		// Token: 0x04000096 RID: 150
		private Transform[] feet;

		// Token: 0x04000097 RID: 151
		private Quaternion[] footRotations;

		// Token: 0x04000098 RID: 152
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x04000099 RID: 153
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x0400009A RID: 154
		private Vector3 spineOffset;

		// Token: 0x0400009B RID: 155
		private float lastWeight;
	}
}
