using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004C RID: 76
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x000027E8 File Offset: 0x000009E8
		public void MaintainRotation()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000027EA File Offset: 0x000009EA
		public void MaintainBend()
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000027EC File Offset: 0x000009EC
		protected override void OnInitiateVirtual()
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000027EE File Offset: 0x000009EE
		protected override void OnUpdateVirtual()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000027F0 File Offset: 0x000009F0
		protected override void OnPostSolveVirtual()
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000027F2 File Offset: 0x000009F2
		public IKSolverLimb()
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000027FA File Offset: 0x000009FA
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00002802 File Offset: 0x00000A02
		private IKSolverLimb.AxisDirection[] axisDirections
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002805 File Offset: 0x00000A05
		private void StoreAxisDirections(ref IKSolverLimb.AxisDirection[] axisDirections)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000037E4 File Offset: 0x000019E4
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}

		// Token: 0x04000254 RID: 596
		public AvatarIKGoal goal;

		// Token: 0x04000255 RID: 597
		public IKSolverLimb.BendModifier bendModifier;

		// Token: 0x04000256 RID: 598
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x04000257 RID: 599
		[Range(0f, 1f)]
		public float bendModifierWeight;

		// Token: 0x04000258 RID: 600
		public Transform bendGoal;

		// Token: 0x04000259 RID: 601
		private bool maintainBendFor1Frame;

		// Token: 0x0400025A RID: 602
		private bool maintainRotationFor1Frame;

		// Token: 0x0400025B RID: 603
		private Quaternion defaultRootRotation;

		// Token: 0x0400025C RID: 604
		private Quaternion parentDefaultRotation;

		// Token: 0x0400025D RID: 605
		private Quaternion bone3RotationBeforeSolve;

		// Token: 0x0400025E RID: 606
		private Quaternion maintainRotation;

		// Token: 0x0400025F RID: 607
		private Quaternion bone3DefaultRotation;

		// Token: 0x04000260 RID: 608
		private Vector3 _bendNormal;

		// Token: 0x04000261 RID: 609
		private Vector3 animationNormal;

		// Token: 0x04000262 RID: 610
		private IKSolverLimb.AxisDirection[] axisDirectionsLeft;

		// Token: 0x04000263 RID: 611
		private IKSolverLimb.AxisDirection[] axisDirectionsRight;

		// Token: 0x0200008D RID: 141
		[Serializable]
		public enum BendModifier
		{
			// Token: 0x0400043D RID: 1085
			Animation,
			// Token: 0x0400043E RID: 1086
			Target,
			// Token: 0x0400043F RID: 1087
			Parent,
			// Token: 0x04000440 RID: 1088
			Arm,
			// Token: 0x04000441 RID: 1089
			Goal
		}

		// Token: 0x0200008E RID: 142
		[Serializable]
		public struct AxisDirection
		{

			// Token: 0x04000442 RID: 1090
			public Vector3 direction;

			// Token: 0x04000443 RID: 1091
			public Vector3 axis;

			// Token: 0x04000444 RID: 1092
			public float dot;
		}
	}
}
