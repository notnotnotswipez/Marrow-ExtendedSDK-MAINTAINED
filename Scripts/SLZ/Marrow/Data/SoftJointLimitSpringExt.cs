using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200019B RID: 411
	[Serializable]
	public struct SoftJointLimitSpringExt
	{

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0000838C File Offset: 0x0000658C
		public SoftJointLimitSpring ToUnitySoftJointLimitSpring()
		{
			return default(SoftJointLimitSpring);
		}

		// Token: 0x04000AAB RID: 2731
		public float spring;

		// Token: 0x04000AAC RID: 2732
		public float damper;
	}
}
