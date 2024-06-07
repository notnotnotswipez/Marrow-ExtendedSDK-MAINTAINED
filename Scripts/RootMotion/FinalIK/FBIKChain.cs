using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000039 RID: 57
	[Serializable]
	public class FBIKChain
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00002599 File Offset: 0x00000799
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000259B File Offset: 0x0000079B
		public int GetNodeIndex(Transform boneTransform)
		{
			return 0;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000259E File Offset: 0x0000079E
		public bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000025A1 File Offset: 0x000007A1
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000025A3 File Offset: 0x000007A3
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000025A5 File Offset: 0x000007A5
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000025A7 File Offset: 0x000007A7
		public void Reach(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000357C File Offset: 0x0000177C
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000025A9 File Offset: 0x000007A9
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000025AB File Offset: 0x000007AB
		public void Stage1(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000025AD File Offset: 0x000007AD
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000025AF File Offset: 0x000007AF
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00003594 File Offset: 0x00001794
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000035AC File Offset: 0x000017AC
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000025B1 File Offset: 0x000007B1
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000025B3 File Offset: 0x000007B3
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000025B5 File Offset: 0x000007B5
		public void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000025B7 File Offset: 0x000007B7
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x0400018E RID: 398
		[Range(0f, 1f)]
		public float pin;

		// Token: 0x0400018F RID: 399
		[Range(0f, 1f)]
		public float pull;

		// Token: 0x04000190 RID: 400
		[Range(0f, 1f)]
		public float push;

		// Token: 0x04000191 RID: 401
		[Range(-1f, 1f)]
		public float pushParent;

		// Token: 0x04000192 RID: 402
		[Range(0f, 1f)]
		public float reach;

		// Token: 0x04000193 RID: 403
		public FBIKChain.Smoothing reachSmoothing;

		// Token: 0x04000194 RID: 404
		public FBIKChain.Smoothing pushSmoothing;

		// Token: 0x04000195 RID: 405
		public IKSolver.Node[] nodes;

		// Token: 0x04000196 RID: 406
		public int[] children;

		// Token: 0x04000197 RID: 407
		public FBIKChain.ChildConstraint[] childConstraints;

		// Token: 0x04000198 RID: 408
		public IKConstraintBend bendConstraint;

		// Token: 0x04000199 RID: 409
		private float rootLength;

		// Token: 0x0400019A RID: 410
		private bool initiated;

		// Token: 0x0400019B RID: 411
		private float length;

		// Token: 0x0400019C RID: 412
		private float distance;

		// Token: 0x0400019D RID: 413
		private IKSolver.Point p;

		// Token: 0x0400019E RID: 414
		private float reachForce;

		// Token: 0x0400019F RID: 415
		private float pullParentSum;

		// Token: 0x040001A0 RID: 416
		private float[] crossFades;

		// Token: 0x040001A1 RID: 417
		private float sqrMag1;

		// Token: 0x040001A2 RID: 418
		private float sqrMag2;

		// Token: 0x040001A3 RID: 419
		private float sqrMagDif;

		// Token: 0x040001A4 RID: 420
		private const float maxLimbLength = 0.99999f;

		// Token: 0x02000084 RID: 132
		[Serializable]
		public class ChildConstraint
		{
			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x00002CBB File Offset: 0x00000EBB
			// (set) Token: 0x06000477 RID: 1143 RVA: 0x00002CC2 File Offset: 0x00000EC2
			public float nominalDistance
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x00002CC4 File Offset: 0x00000EC4
			// (set) Token: 0x06000479 RID: 1145 RVA: 0x00002CC7 File Offset: 0x00000EC7
			public bool isRigid
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

			// Token: 0x0600047A RID: 1146 RVA: 0x00002CC9 File Offset: 0x00000EC9
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00002CD1 File Offset: 0x00000ED1
			public void Initiate(IKSolverFullBody solver)
			{
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00002CD3 File Offset: 0x00000ED3
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x00002CD5 File Offset: 0x00000ED5
			public void Solve(IKSolverFullBody solver)
			{
			}

			// Token: 0x04000404 RID: 1028
			public float pushElasticity;

			// Token: 0x04000405 RID: 1029
			public float pullElasticity;

			// Token: 0x04000406 RID: 1030
			[SerializeField]
			private Transform bone1;

			// Token: 0x04000407 RID: 1031
			[SerializeField]
			private Transform bone2;

			// Token: 0x0400040A RID: 1034
			private float crossFade;

			// Token: 0x0400040B RID: 1035
			private float inverseCrossFade;

			// Token: 0x0400040C RID: 1036
			private int chain1Index;

			// Token: 0x0400040D RID: 1037
			private int chain2Index;
		}

		// Token: 0x02000085 RID: 133
		[Serializable]
		public enum Smoothing
		{
			// Token: 0x0400040F RID: 1039
			None,
			// Token: 0x04000410 RID: 1040
			Exponential,
			// Token: 0x04000411 RID: 1041
			Cubic
		}
	}
}
