using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000041 RID: 65
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		// Token: 0x06000236 RID: 566 RVA: 0x00002671 File Offset: 0x00000871
		public float GetAngle()
		{
			return 0f;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00003674 File Offset: 0x00001874
		public Vector3 transformAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000368C File Offset: 0x0000188C
		public Vector3 transformPoleAxis
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002678 File Offset: 0x00000878
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000267A File Offset: 0x0000087A
		protected override void OnUpdate()
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000267C File Offset: 0x0000087C
		protected override int minBones
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000267F File Offset: 0x0000087F
		private void Solve()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000036A4 File Offset: 0x000018A4
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002681 File Offset: 0x00000881
		private void RotateToTarget(Vector3 targetPosition, IKSolver.Bone bone, float weight)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600023F RID: 575 RVA: 0x000036BC File Offset: 0x000018BC
		protected override Vector3 localDirection
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x040001FB RID: 507
		public Transform transform;

		// Token: 0x040001FC RID: 508
		public Vector3 axis;

		// Token: 0x040001FD RID: 509
		public Vector3 poleAxis;

		// Token: 0x040001FE RID: 510
		public Vector3 polePosition;

		// Token: 0x040001FF RID: 511
		[Range(0f, 1f)]
		public float poleWeight;

		// Token: 0x04000200 RID: 512
		public Transform poleTarget;

		// Token: 0x04000201 RID: 513
		[Range(0f, 1f)]
		public float clampWeight;

		// Token: 0x04000202 RID: 514
		[Range(0f, 2f)]
		public int clampSmoothing;

		// Token: 0x04000203 RID: 515
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x04000204 RID: 516
		private float step;

		// Token: 0x04000205 RID: 517
		private Vector3 clampedIKPosition;

		// Token: 0x04000206 RID: 518
		private RotationLimit transformLimit;

		// Token: 0x04000207 RID: 519
		private Transform lastTransform;
	}
}
