using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004D RID: 77
	[Serializable]
	public class IKSolverLookAt : IKSolver
	{
		// Token: 0x060002CB RID: 715 RVA: 0x00002807 File Offset: 0x00000A07
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002809 File Offset: 0x00000A09
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000280B File Offset: 0x00000A0B
		public override void FixTransforms()
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000280D File Offset: 0x00000A0D
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002810 File Offset: 0x00000A10
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002813 File Offset: 0x00000A13
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002816 File Offset: 0x00000A16
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return false;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002819 File Offset: 0x00000A19
		protected override void OnInitiate()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000281B File Offset: 0x00000A1B
		protected override void OnUpdate()
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0000281D File Offset: 0x00000A1D
		private bool spineIsValid
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002820 File Offset: 0x00000A20
		private bool spineIsEmpty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002823 File Offset: 0x00000A23
		private void SolveSpine()
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00002825 File Offset: 0x00000A25
		private bool headIsValid
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00002828 File Offset: 0x00000A28
		private bool headIsEmpty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000282B File Offset: 0x00000A2B
		private void SolveHead()
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000282D File Offset: 0x00000A2D
		private bool eyesIsValid
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00002830 File Offset: 0x00000A30
		private bool eyesIsEmpty
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002833 File Offset: 0x00000A33
		private void SolveEyes()
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002835 File Offset: 0x00000A35
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002838 File Offset: 0x00000A38
		private void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones)
		{
		}

		// Token: 0x04000264 RID: 612
		public Transform target;

		// Token: 0x04000265 RID: 613
		public IKSolverLookAt.LookAtBone[] spine;

		// Token: 0x04000266 RID: 614
		public IKSolverLookAt.LookAtBone head;

		// Token: 0x04000267 RID: 615
		public IKSolverLookAt.LookAtBone[] eyes;

		// Token: 0x04000268 RID: 616
		[Range(0f, 1f)]
		public float bodyWeight;

		// Token: 0x04000269 RID: 617
		[Range(0f, 1f)]
		public float headWeight;

		// Token: 0x0400026A RID: 618
		[Range(0f, 1f)]
		public float eyesWeight;

		// Token: 0x0400026B RID: 619
		[Range(0f, 1f)]
		public float clampWeight;

		// Token: 0x0400026C RID: 620
		[Range(0f, 1f)]
		public float clampWeightHead;

		// Token: 0x0400026D RID: 621
		[Range(0f, 1f)]
		public float clampWeightEyes;

		// Token: 0x0400026E RID: 622
		[Range(0f, 2f)]
		public int clampSmoothing;

		// Token: 0x0400026F RID: 623
		public AnimationCurve spineWeightCurve;

		// Token: 0x04000270 RID: 624
		public Vector3 spineTargetOffset;

		// Token: 0x04000271 RID: 625
		private Vector3[] spineForwards;

		// Token: 0x04000272 RID: 626
		private Vector3[] headForwards;

		// Token: 0x04000273 RID: 627
		private Vector3[] eyeForward;

		// Token: 0x0200008F RID: 143
		[Serializable]
		public class LookAtBone : IKSolver.Bone
		{
			// Token: 0x060004A5 RID: 1189 RVA: 0x00002D35 File Offset: 0x00000F35
			public LookAtBone()
			{
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x00002D3D File Offset: 0x00000F3D
			public LookAtBone(Transform transform)
			{
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x00002D45 File Offset: 0x00000F45
			public void Initiate(Transform root)
			{
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x00002D47 File Offset: 0x00000F47
			public void LookAt(Vector3 direction, float weight)
			{
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00003B94 File Offset: 0x00001D94
			public Vector3 forward
			{
				get
				{
					return default(Vector3);
				}
			}
		}
	}
}
