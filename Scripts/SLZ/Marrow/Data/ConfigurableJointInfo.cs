using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200018B RID: 395
	[Serializable]
	public class ConfigurableJointInfo
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x00005090 File Offset: 0x00003290
		public void CopyTo(ConfigurableJoint joint)
		{
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00005092 File Offset: 0x00003292
		public void CopyFrom(ConfigurableJoint joint)
		{
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0000832C File Offset: 0x0000652C
		public Quaternion GetJointSpace()
		{
			return default(Quaternion);
		}

		// Token: 0x04000A36 RID: 2614
		public Quaternion startRotation;

		// Token: 0x04000A37 RID: 2615
		public Vector3 axis;

		// Token: 0x04000A38 RID: 2616
		public Vector3 secondaryAxis;

		// Token: 0x04000A39 RID: 2617
		public Vector3 anchor;

		// Token: 0x04000A3A RID: 2618
		public Vector3 connectedAnchor;

		// Token: 0x04000A3B RID: 2619
		public bool autoConfigureConnectedAnchor;

		// Token: 0x04000A3C RID: 2620
		public float breakForce;

		// Token: 0x04000A3D RID: 2621
		public float breakTorque;

		// Token: 0x04000A3E RID: 2622
		public bool enableCollision;

		// Token: 0x04000A3F RID: 2623
		public bool enablePreprocessing;

		// Token: 0x04000A40 RID: 2624
		public float massScale;

		// Token: 0x04000A41 RID: 2625
		public float connectedMassScale;

		// Token: 0x04000A42 RID: 2626
		public float projectionAngle;

		// Token: 0x04000A43 RID: 2627
		public float projectionDistance;

		// Token: 0x04000A44 RID: 2628
		public JointProjectionModeExt projectionModeExt;

		// Token: 0x04000A45 RID: 2629
		public JointDriveExt slerpDriveExt;

		// Token: 0x04000A46 RID: 2630
		public JointDriveExt angularYZDriveExt;

		// Token: 0x04000A47 RID: 2631
		public JointDriveExt angularXDriveExt;

		// Token: 0x04000A48 RID: 2632
		public RotationDriveMode rotationDriveMode;

		// Token: 0x04000A49 RID: 2633
		public Vector3 targetAngularVelocity;

		// Token: 0x04000A4A RID: 2634
		public Quaternion targetRotation;

		// Token: 0x04000A4B RID: 2635
		public JointDriveExt zDriveExt;

		// Token: 0x04000A4C RID: 2636
		public JointDriveExt yDriveExt;

		// Token: 0x04000A4D RID: 2637
		public JointDriveExt xDriveExt;

		// Token: 0x04000A4E RID: 2638
		public Vector3 targetVelocity;

		// Token: 0x04000A4F RID: 2639
		public Vector3 targetPosition;

		// Token: 0x04000A50 RID: 2640
		public SoftJointLimitExt angularZLimitExt;

		// Token: 0x04000A51 RID: 2641
		public SoftJointLimitExt angularYLimitExt;

		// Token: 0x04000A52 RID: 2642
		public SoftJointLimitExt highAngularXLimitExt;

		// Token: 0x04000A53 RID: 2643
		public SoftJointLimitExt lowAngularXLimitExt;

		// Token: 0x04000A54 RID: 2644
		public SoftJointLimitExt linearLimitExt;

		// Token: 0x04000A55 RID: 2645
		public SoftJointLimitSpringExt angularYZLimitSpringExt;

		// Token: 0x04000A56 RID: 2646
		public SoftJointLimitSpringExt angularXLimitSpringExt;

		// Token: 0x04000A57 RID: 2647
		public SoftJointLimitSpringExt linearLimitSpringExt;

		// Token: 0x04000A58 RID: 2648
		public ConfigurableJointMotion angularZMotion;

		// Token: 0x04000A59 RID: 2649
		public ConfigurableJointMotion angularYMotion;

		// Token: 0x04000A5A RID: 2650
		public ConfigurableJointMotion angularXMotion;

		// Token: 0x04000A5B RID: 2651
		public ConfigurableJointMotion zMotion;

		// Token: 0x04000A5C RID: 2652
		public ConfigurableJointMotion yMotion;

		// Token: 0x04000A5D RID: 2653
		public ConfigurableJointMotion xMotion;

		// Token: 0x04000A5E RID: 2654
		public bool configuredInWorldSpace;

		// Token: 0x04000A5F RID: 2655
		public bool swapBodies;
	}
}
