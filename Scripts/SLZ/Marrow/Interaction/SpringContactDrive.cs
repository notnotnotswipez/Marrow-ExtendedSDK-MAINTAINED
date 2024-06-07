using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x0200014C RID: 332
	[Serializable]
	public struct SpringContactDrive
	{
		// Token: 0x04000760 RID: 1888
		[SerializeField]
		public float positionSpring;

		// Token: 0x04000761 RID: 1889
		[SerializeField]
		public float positionDamper;

		// Token: 0x04000762 RID: 1890
		[SerializeField]
		public float maximumForce;
	}
}
