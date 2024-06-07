using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000149 RID: 329
	[Serializable]
	public struct SoftSplineJointLimit
	{

		// Token: 0x04000741 RID: 1857
		[SerializeField]
		public float limit;

		// Token: 0x04000742 RID: 1858
		[SerializeField]
		public float bounciness;

		// Token: 0x04000743 RID: 1859
		[SerializeField]
		public float contactDistance;
	}
}
