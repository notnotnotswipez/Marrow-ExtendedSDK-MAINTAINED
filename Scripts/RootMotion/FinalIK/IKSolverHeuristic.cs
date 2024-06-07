using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004A RID: 74
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x00002798 File Offset: 0x00000998
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return false;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000279B File Offset: 0x0000099B
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000279D File Offset: 0x0000099D
		public override void FixTransforms()
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000279F File Offset: 0x0000099F
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000027A2 File Offset: 0x000009A2
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000027A5 File Offset: 0x000009A5
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000027A8 File Offset: 0x000009A8
		protected virtual int minBones
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000027AB File Offset: 0x000009AB
		protected virtual bool boneLengthCanBeZero
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000027AE File Offset: 0x000009AE
		protected virtual bool allowCommonParent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000027B1 File Offset: 0x000009B1
		protected override void OnInitiate()
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000027B3 File Offset: 0x000009B3
		protected override void OnUpdate()
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000027B5 File Offset: 0x000009B5
		protected void InitiateBones()
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x000037B4 File Offset: 0x000019B4
		protected virtual Vector3 localDirection
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000027B7 File Offset: 0x000009B7
		protected float positionOffset
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000037CC File Offset: 0x000019CC
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000027BE File Offset: 0x000009BE
		private bool SingularityDetected()
		{
			return false;
		}

		// Token: 0x04000241 RID: 577
		public Transform target;

		// Token: 0x04000242 RID: 578
		public float tolerance;

		// Token: 0x04000243 RID: 579
		public int maxIterations;

		// Token: 0x04000244 RID: 580
		public bool useRotationLimits;

		// Token: 0x04000245 RID: 581
		public bool XY;

		// Token: 0x04000246 RID: 582
		public IKSolver.Bone[] bones;

		// Token: 0x04000247 RID: 583
		protected Vector3 lastLocalDirection;

		// Token: 0x04000248 RID: 584
		protected float chainLength;
	}
}
