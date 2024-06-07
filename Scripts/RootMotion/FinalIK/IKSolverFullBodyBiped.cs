using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000049 RID: 73
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000273F File Offset: 0x0000093F
		public IKEffector bodyEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00002742 File Offset: 0x00000942
		public IKEffector leftShoulderEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002745 File Offset: 0x00000945
		public IKEffector rightShoulderEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00002748 File Offset: 0x00000948
		public IKEffector leftThighEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000274B File Offset: 0x0000094B
		public IKEffector rightThighEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000274E File Offset: 0x0000094E
		public IKEffector leftHandEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00002751 File Offset: 0x00000951
		public IKEffector rightHandEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00002754 File Offset: 0x00000954
		public IKEffector leftFootEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00002757 File Offset: 0x00000957
		public IKEffector rightFootEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000275A File Offset: 0x0000095A
		public FBIKChain leftArmChain
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000275D File Offset: 0x0000095D
		public FBIKChain rightArmChain
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00002760 File Offset: 0x00000960
		public IKMappingLimb leftLegMapping
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00002763 File Offset: 0x00000963
		public IKMappingLimb rightLegMapping
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002766 File Offset: 0x00000966
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002769 File Offset: 0x00000969
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000276C File Offset: 0x0000096C
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000276F File Offset: 0x0000096F
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002772 File Offset: 0x00000972
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002775 File Offset: 0x00000975
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002778 File Offset: 0x00000978
		public void SetToReferences(BipedReferences references, Transform rootNode = null)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000277A File Offset: 0x0000097A
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000376C File Offset: 0x0000196C
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0000277D File Offset: 0x0000097D
		public Vector3 pullBodyOffset
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000277F File Offset: 0x0000097F
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002782 File Offset: 0x00000982
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002785 File Offset: 0x00000985
		private static bool Contains(Transform[] array, Transform transform)
		{
			return false;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002788 File Offset: 0x00000988
		protected override void ReadPose()
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000278A File Offset: 0x0000098A
		private void PullBody()
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00003784 File Offset: 0x00001984
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000379C File Offset: 0x0000199C
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000278C File Offset: 0x0000098C
		protected override void ApplyBendConstraints()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000278E File Offset: 0x0000098E
		protected override void WritePose()
		{
		}

		// Token: 0x0400023B RID: 571
		public Transform rootNode;

		// Token: 0x0400023C RID: 572
		[Range(0f, 1f)]
		public float spineStiffness;

		// Token: 0x0400023D RID: 573
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		// Token: 0x0400023E RID: 574
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		// Token: 0x04000240 RID: 576
		private Vector3 offset;
	}
}
