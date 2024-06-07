using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003A RID: 58
	[Serializable]
	public class IKConstraintBend
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000025B9 File Offset: 0x000007B9
		// (set) Token: 0x060001EC RID: 492 RVA: 0x000025BC File Offset: 0x000007BC
		public bool initiated
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

		// Token: 0x060001EE RID: 494 RVA: 0x000025C6 File Offset: 0x000007C6
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000025C8 File Offset: 0x000007C8
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000025CA File Offset: 0x000007CA
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000035C4 File Offset: 0x000017C4
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000035DC File Offset: 0x000017DC
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000035F4 File Offset: 0x000017F4
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		// Token: 0x040001A5 RID: 421
		public Transform bone1;

		// Token: 0x040001A6 RID: 422
		public Transform bone2;

		// Token: 0x040001A7 RID: 423
		public Transform bone3;

		// Token: 0x040001A8 RID: 424
		public Transform bendGoal;

		// Token: 0x040001A9 RID: 425
		public Vector3 direction;

		// Token: 0x040001AA RID: 426
		public Quaternion rotationOffset;

		// Token: 0x040001AB RID: 427
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x040001AC RID: 428
		public Vector3 defaultLocalDirection;

		// Token: 0x040001AD RID: 429
		public Vector3 defaultChildDirection;

		// Token: 0x040001AE RID: 430
		[NonSerialized]
		public float clampF;

		// Token: 0x040001AF RID: 431
		private int chainIndex1;

		// Token: 0x040001B0 RID: 432
		private int nodeIndex1;

		// Token: 0x040001B1 RID: 433
		private int chainIndex2;

		// Token: 0x040001B2 RID: 434
		private int nodeIndex2;

		// Token: 0x040001B3 RID: 435
		private int chainIndex3;

		// Token: 0x040001B4 RID: 436
		private int nodeIndex3;

		// Token: 0x040001B6 RID: 438
		private bool limbOrientationsSet;
	}
}
