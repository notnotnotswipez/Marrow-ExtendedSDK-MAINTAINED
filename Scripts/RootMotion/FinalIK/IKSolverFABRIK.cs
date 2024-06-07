using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000044 RID: 68
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		// Token: 0x06000250 RID: 592 RVA: 0x000026B8 File Offset: 0x000008B8
		public void SolveForward(Vector3 position)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000026BA File Offset: 0x000008BA
		public void SolveBackward(Vector3 position)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000036D4 File Offset: 0x000018D4
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000026BC File Offset: 0x000008BC
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000026BE File Offset: 0x000008BE
		protected override void OnUpdate()
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000026C0 File Offset: 0x000008C0
		protected override bool boneLengthCanBeZero
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000036EC File Offset: 0x000018EC
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000026C3 File Offset: 0x000008C3
		private void OnPreSolve()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000026C5 File Offset: 0x000008C5
		private void OnPostSolve()
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000026C7 File Offset: 0x000008C7
		private void Solve(Vector3 targetPosition)
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000026C9 File Offset: 0x000008C9
		private void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000026CB File Offset: 0x000008CB
		private void SolverMove(int index, Vector3 offset)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000026CD File Offset: 0x000008CD
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000026CF File Offset: 0x000008CF
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000026D1 File Offset: 0x000008D1
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00003704 File Offset: 0x00001904
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000371C File Offset: 0x0000191C
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00003734 File Offset: 0x00001934
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			changed = default(bool);
			return default(Quaternion);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000026D3 File Offset: 0x000008D3
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000026D5 File Offset: 0x000008D5
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000026D7 File Offset: 0x000008D7
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000026D9 File Offset: 0x000008D9
		private void BackwardReachLimited(Vector3 position)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000026DB File Offset: 0x000008DB
		private void MapToSolverPositions()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000026DD File Offset: 0x000008DD
		private void MapToSolverPositionsLimited()
		{
		}

		// Token: 0x04000214 RID: 532
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x04000215 RID: 533
		private bool[] limitedBones;

		// Token: 0x04000216 RID: 534
		private Vector3[] solverLocalPositions;
	}
}
