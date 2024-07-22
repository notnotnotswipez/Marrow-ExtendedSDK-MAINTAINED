using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		// Token: 0x06000216 RID: 534 RVA: 0x0000262A File Offset: 0x0000082A
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return false;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002635 File Offset: 0x00000835
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002637 File Offset: 0x00000837
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002639 File Offset: 0x00000839
		public void FixTransforms()
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000263B File Offset: 0x0000083B
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000263D File Offset: 0x0000083D
		private bool UseFABRIK()
		{
			return false;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002640 File Offset: 0x00000840
		public void ReadPose()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002642 File Offset: 0x00000842
		public void WritePose(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002644 File Offset: 0x00000844
		public void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002646 File Offset: 0x00000846
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002648 File Offset: 0x00000848
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}

		// Token: 0x040001E4 RID: 484
		public Transform[] spineBones;

		// Token: 0x040001E5 RID: 485
		public Transform leftUpperArmBone;

		// Token: 0x040001E6 RID: 486
		public Transform rightUpperArmBone;

		// Token: 0x040001E7 RID: 487
		public Transform leftThighBone;

		// Token: 0x040001E8 RID: 488
		public Transform rightThighBone;

		// Token: 0x040001E9 RID: 489
		[Range(1f, 3f)]
		public int iterations;

		// Token: 0x040001EA RID: 490
		[Range(0f, 1f)]
		public float twistWeight;

		// Token: 0x040001EB RID: 491
		private int rootNodeIndex;

		// Token: 0x040001EC RID: 492
		private IKMapping.BoneMap[] spine;

		// Token: 0x040001ED RID: 493
		private IKMapping.BoneMap leftUpperArm;

		// Token: 0x040001EE RID: 494
		private IKMapping.BoneMap rightUpperArm;

		// Token: 0x040001EF RID: 495
		private IKMapping.BoneMap leftThigh;

		// Token: 0x040001F0 RID: 496
		private IKMapping.BoneMap rightThigh;

		// Token: 0x040001F1 RID: 497
		private bool useFABRIK;
	}
}
