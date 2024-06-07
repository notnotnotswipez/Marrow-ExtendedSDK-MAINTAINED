using System;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x0200012F RID: 303
	public class DisabledJointInfo
	{
		// Token: 0x06000A9E RID: 2718 RVA: 0x000044ED File Offset: 0x000026ED
		public void CopyFrom(ConfigurableJoint j)
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000044EF File Offset: 0x000026EF
		public void CopyTo(ConfigurableJoint j)
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000044F1 File Offset: 0x000026F1
		public void Clear(ConfigurableJoint j)
		{
		}

		// Token: 0x04000676 RID: 1654
		private bool _hasBeenCopied;

		// Token: 0x04000677 RID: 1655
		private Rigidbody _attachedBody;

		// Token: 0x04000678 RID: 1656
		private ConfigurableJointMotion _xMotion;

		// Token: 0x04000679 RID: 1657
		private ConfigurableJointMotion _yMotion;

		// Token: 0x0400067A RID: 1658
		private ConfigurableJointMotion _zMotion;

		// Token: 0x0400067B RID: 1659
		private ConfigurableJointMotion _angXMotion;

		// Token: 0x0400067C RID: 1660
		private ConfigurableJointMotion _angYMotion;

		// Token: 0x0400067D RID: 1661
		private ConfigurableJointMotion _angZMotion;

		// Token: 0x0400067E RID: 1662
		private JointDriveExt _xDrive;

		// Token: 0x0400067F RID: 1663
		private JointDriveExt _yDrive;

		// Token: 0x04000680 RID: 1664
		private JointDriveExt _zDrive;

		// Token: 0x04000681 RID: 1665
		private JointDriveExt _angXDrive;

		// Token: 0x04000682 RID: 1666
		private JointDriveExt _angYZDrive;

		// Token: 0x04000683 RID: 1667
		private JointDriveExt _slerpDrive;
	}
}
