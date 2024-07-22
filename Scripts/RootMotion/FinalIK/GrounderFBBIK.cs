using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200001E RID: 30
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00002319 File Offset: 0x00000519
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000231B File Offset: 0x0000051B
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000231D File Offset: 0x0000051D
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000231F File Offset: 0x0000051F
		public override void ResetPosition()
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002321 File Offset: 0x00000521
		private bool IsReadyToInitiate()
		{
			return false;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002324 File Offset: 0x00000524
		private void Update()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002326 File Offset: 0x00000526
		private void FixedUpdate()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002328 File Offset: 0x00000528
		private void LateUpdate()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000232A File Offset: 0x0000052A
		private void Initiate()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000232C File Offset: 0x0000052C
		private void OnSolverUpdate()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000232E File Offset: 0x0000052E
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002330 File Offset: 0x00000530
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002332 File Offset: 0x00000532
		private void OnDestroy()
		{
		}

		// Token: 0x0400009C RID: 156
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		// Token: 0x0400009D RID: 157
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		// Token: 0x0400009E RID: 158
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		// Token: 0x0400009F RID: 159
		public GrounderFBBIK.SpineEffector[] spine;

		// Token: 0x040000A0 RID: 160
		private Transform[] feet;

		// Token: 0x040000A1 RID: 161
		private Vector3 spineOffset;

		// Token: 0x040000A2 RID: 162
		private bool firstSolve;

		// Token: 0x0200007D RID: 125
		[Serializable]
		public class SpineEffector
		{
			// Token: 0x040003C8 RID: 968
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			// Token: 0x040003C9 RID: 969
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			// Token: 0x040003CA RID: 970
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;
		}
	}
}
