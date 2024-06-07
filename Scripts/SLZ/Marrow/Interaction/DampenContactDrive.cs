using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000145 RID: 325
	[Serializable]
	public struct DampenContactDrive
	{

		// Token: 0x04000730 RID: 1840
		[SerializeField]
		public float positionDamper;

		// Token: 0x04000731 RID: 1841
		[SerializeField]
		public float maximumForce;
	}
}
