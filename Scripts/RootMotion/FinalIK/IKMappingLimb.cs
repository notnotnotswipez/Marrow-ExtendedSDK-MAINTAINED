using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003E RID: 62
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		// Token: 0x0600020D RID: 525 RVA: 0x00002610 File Offset: 0x00000810
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return false;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002613 File Offset: 0x00000813
		public IKMapping.BoneMap GetBoneMap(IKMappingLimb.BoneMapType boneMap)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000261E File Offset: 0x0000081E
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002620 File Offset: 0x00000820
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002622 File Offset: 0x00000822
		public void FixTransforms()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002624 File Offset: 0x00000824
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002626 File Offset: 0x00000826
		public void ReadPose()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002628 File Offset: 0x00000828
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}

		// Token: 0x040001DA RID: 474
		public Transform parentBone;

		// Token: 0x040001DB RID: 475
		public Transform bone1;

		// Token: 0x040001DC RID: 476
		public Transform bone2;

		// Token: 0x040001DD RID: 477
		public Transform bone3;

		// Token: 0x040001DE RID: 478
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x040001DF RID: 479
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x040001E0 RID: 480
		private IKMapping.BoneMap boneMapParent;

		// Token: 0x040001E1 RID: 481
		private IKMapping.BoneMap boneMap1;

		// Token: 0x040001E2 RID: 482
		private IKMapping.BoneMap boneMap2;

		// Token: 0x040001E3 RID: 483
		private IKMapping.BoneMap boneMap3;

		// Token: 0x02000087 RID: 135
		[Serializable]
		public enum BoneMapType
		{
			// Token: 0x04000429 RID: 1065
			Parent,
			// Token: 0x0400042A RID: 1066
			Bone1,
			// Token: 0x0400042B RID: 1067
			Bone2,
			// Token: 0x0400042C RID: 1068
			Bone3
		}
	}
}
