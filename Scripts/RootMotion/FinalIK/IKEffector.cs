using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003B RID: 59
	[Serializable]
	public class IKEffector
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x000025CC File Offset: 0x000007CC
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000025CF File Offset: 0x000007CF
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000025D2 File Offset: 0x000007D2
		public bool isEndEffector
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000025DC File Offset: 0x000007DC
		public bool IsValid(IKSolver solver, ref string message)
		{
			return false;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000025DF File Offset: 0x000007DF
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000025E1 File Offset: 0x000007E1
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000025E3 File Offset: 0x000007E3
		public void SetToTarget()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000025E5 File Offset: 0x000007E5
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000025E7 File Offset: 0x000007E7
		public void OnPostWrite()
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000360C File Offset: 0x0000180C
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000025E9 File Offset: 0x000007E9
		public void Update(IKSolverFullBody solver)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003624 File Offset: 0x00001824
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			planeRotationOffset = default(Quaternion);
			return default(Vector3);
		}

		// Token: 0x040001B7 RID: 439
		public Transform bone;

		// Token: 0x040001B8 RID: 440
		public Transform target;

		// Token: 0x040001B9 RID: 441
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x040001BA RID: 442
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x040001BB RID: 443
		public Vector3 position;

		// Token: 0x040001BC RID: 444
		public Quaternion rotation;

		// Token: 0x040001BD RID: 445
		public Vector3 positionOffset;

		// Token: 0x040001BF RID: 447
		public bool effectChildNodes;

		// Token: 0x040001C0 RID: 448
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		// Token: 0x040001C1 RID: 449
		public Transform[] childBones;

		// Token: 0x040001C2 RID: 450
		public Transform planeBone1;

		// Token: 0x040001C3 RID: 451
		public Transform planeBone2;

		// Token: 0x040001C4 RID: 452
		public Transform planeBone3;

		// Token: 0x040001C5 RID: 453
		public Quaternion planeRotationOffset;

		// Token: 0x040001C6 RID: 454
		private float posW;

		// Token: 0x040001C7 RID: 455
		private float rotW;

		// Token: 0x040001C8 RID: 456
		private Vector3[] localPositions;

		// Token: 0x040001C9 RID: 457
		private bool usePlaneNodes;

		// Token: 0x040001CA RID: 458
		private Quaternion animatedPlaneRotation;

		// Token: 0x040001CB RID: 459
		private Vector3 animatedPosition;

		// Token: 0x040001CC RID: 460
		private bool firstUpdate;

		// Token: 0x040001CD RID: 461
		private int chainIndex;

		// Token: 0x040001CE RID: 462
		private int nodeIndex;

		// Token: 0x040001CF RID: 463
		private int plane1ChainIndex;

		// Token: 0x040001D0 RID: 464
		private int plane1NodeIndex;

		// Token: 0x040001D1 RID: 465
		private int plane2ChainIndex;

		// Token: 0x040001D2 RID: 466
		private int plane2NodeIndex;

		// Token: 0x040001D3 RID: 467
		private int plane3ChainIndex;

		// Token: 0x040001D4 RID: 468
		private int plane3NodeIndex;

		// Token: 0x040001D5 RID: 469
		private int[] childChainIndexes;

		// Token: 0x040001D6 RID: 470
		private int[] childNodeIndexes;
	}
}
