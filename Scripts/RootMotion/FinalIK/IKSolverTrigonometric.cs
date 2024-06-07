using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004E RID: 78
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x00002842 File Offset: 0x00000A42
		public void SetBendPlaneToCurrent()
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002844 File Offset: 0x00000A44
		public void SetIKRotation(Quaternion rotation)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002846 File Offset: 0x00000A46
		public void SetIKRotationWeight(float weight)
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000037FC File Offset: 0x000019FC
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002848 File Offset: 0x00000A48
		public float GetIKRotationWeight()
		{
			return 0f;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000284F File Offset: 0x00000A4F
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002852 File Offset: 0x00000A52
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002855 File Offset: 0x00000A55
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002857 File Offset: 0x00000A57
		public override void FixTransforms()
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002859 File Offset: 0x00000A59
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000285C File Offset: 0x00000A5C
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return false;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000285F File Offset: 0x00000A5F
		protected override void OnInitiate()
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002861 File Offset: 0x00000A61
		private bool IsDirectHierarchy()
		{
			return false;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002864 File Offset: 0x00000A64
		private void InitiateBones()
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002866 File Offset: 0x00000A66
		protected override void OnUpdate()
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002868 File Offset: 0x00000A68
		protected virtual void OnInitiateVirtual()
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000286A File Offset: 0x00000A6A
		protected virtual void OnUpdateVirtual()
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000286C File Offset: 0x00000A6C
		protected virtual void OnPostSolveVirtual()
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00003814 File Offset: 0x00001A14
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		// Token: 0x04000274 RID: 628
		public Transform target;

		// Token: 0x04000275 RID: 629
		[Range(0f, 1f)]
		public float IKRotationWeight;

		// Token: 0x04000276 RID: 630
		public Quaternion IKRotation;

		// Token: 0x04000277 RID: 631
		public Vector3 bendNormal;

		// Token: 0x04000278 RID: 632
		public IKSolverTrigonometric.TrigonometricBone bone1;

		// Token: 0x04000279 RID: 633
		public IKSolverTrigonometric.TrigonometricBone bone2;

		// Token: 0x0400027A RID: 634
		public IKSolverTrigonometric.TrigonometricBone bone3;

		// Token: 0x0400027B RID: 635
		protected Vector3 weightIKPosition;

		// Token: 0x0400027C RID: 636
		protected bool directHierarchy;

		// Token: 0x02000090 RID: 144
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone
		{
			// Token: 0x060004AA RID: 1194 RVA: 0x00002D49 File Offset: 0x00000F49
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x00003BAC File Offset: 0x00001DAC
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			// Token: 0x060004AC RID: 1196 RVA: 0x00003BC4 File Offset: 0x00001DC4
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			// Token: 0x04000445 RID: 1093
			private Quaternion targetToLocalSpace;

			// Token: 0x04000446 RID: 1094
			private Vector3 defaultLocalBendNormal;
		}
	}
}
