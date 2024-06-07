using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000139 RID: 313
	[Serializable]
	public class MarrowJoint : MonoBehaviour
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000046C0 File Offset: 0x000028C0
		public MarrowBody BodyA
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x000046C3 File Offset: 0x000028C3
		public MarrowBody BodyB
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000046C6 File Offset: 0x000028C6
		public bool SwapBodies
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x000046C9 File Offset: 0x000028C9
		public bool ConfiguredInWorld
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00007BDC File Offset: 0x00005DDC
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x000046CC File Offset: 0x000028CC
		public Quaternion StartRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00007BF4 File Offset: 0x00005DF4
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x000046CE File Offset: 0x000028CE
		public Quaternion ToJointSpace
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00007C0C File Offset: 0x00005E0C
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x000046D0 File Offset: 0x000028D0
		public Quaternion ToJointSpaceInv
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00007C24 File Offset: 0x00005E24
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x000046D2 File Offset: 0x000028D2
		public Quaternion ToJointSpaceFromDefault
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x000046D6 File Offset: 0x000028D6
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x000046D4 File Offset: 0x000028D4
		public bool IsCreatedAtRuntime
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

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x000046D9 File Offset: 0x000028D9
		public bool HasConfigJoint
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000046DC File Offset: 0x000028DC
		private void Awake()
		{
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000046DE File Offset: 0x000028DE
		public void CreateJoint(ConfigurableJointInfo configJointInfo, MarrowBody bodyA, MarrowBody bodyB)
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000046E0 File Offset: 0x000028E0
		private void OnDestroy()
		{
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000046E2 File Offset: 0x000028E2
		public void Destroy()
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000046E4 File Offset: 0x000028E4
		private void OnJointBreak(float breakForce)
		{
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00007C3C File Offset: 0x00005E3C
		private UniTaskVoid JointCleanupCheckAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000046E6 File Offset: 0x000028E6
		public bool TryGetConfigurableJoint(out ConfigurableJoint joint)
		{
			joint = null;
			return false;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000046EC File Offset: 0x000028EC
		internal void SetFromDefaultConfig()
		{
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000046EE File Offset: 0x000028EE
		public void SetToDefaultConfig()
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000046F0 File Offset: 0x000028F0
		private void Build(ConfigurableJointInfo info)
		{
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x000046F2 File Offset: 0x000028F2
		private void ReadJointSpace()
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000046F4 File Offset: 0x000028F4
		private void WriteJointSpace()
		{
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000046F6 File Offset: 0x000028F6
		private void RestoreStartRotation()
		{
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x000046F8 File Offset: 0x000028F8
		internal void OnBodyEnable()
		{
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x000046FA File Offset: 0x000028FA
		internal void OnBodyDisable()
		{
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000046FC File Offset: 0x000028FC
		public void RegisterOnBreakEvent(Action<MarrowJoint> jointBreakAction)
		{
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000046FE File Offset: 0x000028FE
		public void UnregisterOnBreakEvent(Action<MarrowJoint> jointBreakAction)
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00007C54 File Offset: 0x00005E54
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00004700 File Offset: 0x00002900
		public JointDrive xDriveBase
		{
			[CompilerGenerated]
			get
			{
				return default(JointDrive);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00007C6C File Offset: 0x00005E6C
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00004702 File Offset: 0x00002902
		public JointDrive yDriveBase
		{
			[CompilerGenerated]
			get
			{
				return default(JointDrive);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00007C84 File Offset: 0x00005E84
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00004704 File Offset: 0x00002904
		public JointDrive zDriveBase
		{
			[CompilerGenerated]
			get
			{
				return default(JointDrive);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00007C9C File Offset: 0x00005E9C
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00004706 File Offset: 0x00002906
		public JointDrive angularXDriveBase
		{
			[CompilerGenerated]
			get
			{
				return default(JointDrive);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00007CB4 File Offset: 0x00005EB4
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00004708 File Offset: 0x00002908
		public JointDrive angularYZDriveBase
		{
			[CompilerGenerated]
			get
			{
				return default(JointDrive);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00007CCC File Offset: 0x00005ECC
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x0000470A File Offset: 0x0000290A
		public JointDrive slerpDriveBase
		{
			[CompilerGenerated]
			get
			{
				return default(JointDrive);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0000470C File Offset: 0x0000290C
		public void SetXDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0000470E File Offset: 0x0000290E
		public void SetYDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00004710 File Offset: 0x00002910
		public void SetZDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00004712 File Offset: 0x00002912
		public void SetAngularXDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00004714 File Offset: 0x00002914
		public void SetAngularYZDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00004716 File Offset: 0x00002916
		public void SetSlerpDrive(float springMult, float damperMult, float maxForceMult)
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00004718 File Offset: 0x00002918
		public void SetXDriveBase(float spring, float damper, float maxForce)
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0000471A File Offset: 0x0000291A
		public void SetYDriveBase(float spring, float damper, float maxForce)
		{
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0000471C File Offset: 0x0000291C
		public void SetZDriveBase(float spring, float damper, float maxForce)
		{
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0000471E File Offset: 0x0000291E
		public void SetAngularXDriveBase(float spring, float damper, float maxForce)
		{
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00004720 File Offset: 0x00002920
		public void SetAngularYZDriveBase(float spring, float damper, float maxForce)
		{
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00004722 File Offset: 0x00002922
		public void SetSlerpDriveBase(float spring, float damper, float maxForce)
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00007CE4 File Offset: 0x00005EE4
		private JointDrive ComputeJointDrive(JointDrive driveBase, float springMult, float damperMult, float maxForceMult)
		{
			return default(JointDrive);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00004724 File Offset: 0x00002924
		public void FreeAllConstraints()
		{
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00007CFC File Offset: 0x00005EFC
		public JointDrive SetJointDrive(float spring, float damper, float maxForce)
		{
			return default(JointDrive);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00004726 File Offset: 0x00002926
		public void SetJointLimitsAll(float linearLimit, Vector4 angularLimits)
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00004728 File Offset: 0x00002928
		private void Validate(ConfigurableJoint cj, MarrowEntity entity)
		{
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0000472A File Offset: 0x0000292A
		private void CopyJointInfo(ConfigurableJoint cj)
		{
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0000472C File Offset: 0x0000292C
		public void SetEntity(MarrowEntity marrowEntity)
		{
		}

		// Token: 0x040006D4 RID: 1748
		[SerializeField]
		private MarrowBody _bodyA;

		// Token: 0x040006D5 RID: 1749
		[SerializeField]
		private MarrowBody _bodyB;

		// Token: 0x040006D6 RID: 1750
		[SerializeField]
		private ConfigurableJoint _configurableJoint;

		// Token: 0x040006D7 RID: 1751
		[SerializeField]
		private MarrowEntity _entity;

		// Token: 0x040006D8 RID: 1752
		[SerializeField]
		[ReadOnly(false)]
		private ConfigurableJointInfo _defaultConfigJointInfo;

		// Token: 0x040006D9 RID: 1753
		private SimpleTransform _jointSpace;

		// Token: 0x040006DA RID: 1754
		private readonly ConfigurableJointInfo _cjTempInfo;

		// Token: 0x040006DB RID: 1755
		private bool _doResetConnectedAnchor;

		// Token: 0x040006E0 RID: 1760
		private bool _hasBeenEnabled;

		// Token: 0x040006E2 RID: 1762
		private DisabledJointInfo _disableJointInfo;

		// Token: 0x040006E3 RID: 1763
		private List<Action<MarrowJoint>> _jointBreakActions;
	}
}
