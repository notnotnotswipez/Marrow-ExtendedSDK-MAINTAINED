using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200018F RID: 399
	[Serializable]
	public struct JointDriveExt
	{

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00008344 File Offset: 0x00006544
		public JointDrive ToUnityJointDrive()
		{
			return default(JointDrive);
		}

		// Token: 0x04000A70 RID: 2672
		public float positionSpring;

		// Token: 0x04000A71 RID: 2673
		public float positionDamper;

		// Token: 0x04000A72 RID: 2674
		public float maximumForce;
	}
}
