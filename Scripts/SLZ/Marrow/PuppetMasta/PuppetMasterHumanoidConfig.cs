using System;
using RootMotion;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000E9 RID: 233
	[CreateAssetMenu(fileName = "PuppetMaster Humanoid Config", menuName = "PuppetMaster/Humanoid Config", order = 1)]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x000040AF File Offset: 0x000022AF
		public void ApplyTo(PuppetMaster p)
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000040B1 File Offset: 0x000022B1
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		// Token: 0x040005C7 RID: 1479
		public PuppetMaster.State state;

		// Token: 0x040005C8 RID: 1480
		public PuppetMaster.StateSettings stateSettings;

		// Token: 0x040005C9 RID: 1481
		public PuppetMaster.Mode mode;

		// Token: 0x040005CA RID: 1482
		public float blendTime;

		// Token: 0x040005CB RID: 1483
		public bool fixTargetTransforms;

		// Token: 0x040005CC RID: 1484
		public int solverIterationCount;

		// Token: 0x040005CD RID: 1485
		public bool visualizeTargetPose;

		// Token: 0x040005CE RID: 1486
		[Range(0f, 1f)]
		public float mappingWeight;

		// Token: 0x040005CF RID: 1487
		[Range(0f, 1f)]
		public float muscleWeight;

		// Token: 0x040005D0 RID: 1488
		public float muscleSpring;

		// Token: 0x040005D1 RID: 1489
		public float muscleDamper;

		// Token: 0x040005D2 RID: 1490
		public bool updateJointAnchors;

		// Token: 0x040005D3 RID: 1491
		public bool angularLimits;

		// Token: 0x040005D4 RID: 1492
		public bool internalCollisions;

		// Token: 0x040005D5 RID: 1493
		public PuppetMasterHumanoidConfig.HumanoidMuscle[] muscles;

		// Token: 0x02000252 RID: 594
		[Serializable]
		public class HumanoidMuscle
		{
			// Token: 0x04000F06 RID: 3846
			[HideInInspector]
			[SerializeField]
			public string name;

			// Token: 0x04000F07 RID: 3847
			public HumanBodyBones bone;

			// Token: 0x04000F08 RID: 3848
			public Muscle.Props props;
		}
	}
}
