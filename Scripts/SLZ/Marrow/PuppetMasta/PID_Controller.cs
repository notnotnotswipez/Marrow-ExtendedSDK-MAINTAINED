using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000E5 RID: 229
	public class PID_Controller : MonoBehaviour
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x00003F5D File Offset: 0x0000215D
		private void FixedUpdate()
		{
		}

		// Token: 0x04000560 RID: 1376
		public Rigidbody rb;

		// Token: 0x04000561 RID: 1377
		public ConfigurableJoint joint;

		// Token: 0x04000562 RID: 1378
		public Transform followTran;

		// Token: 0x04000563 RID: 1379
		public float pGain;

		// Token: 0x04000564 RID: 1380
		public float iGain;

		// Token: 0x04000565 RID: 1381
		public float dGain;

		// Token: 0x04000566 RID: 1382
		private Vector3 _lastError;

		// Token: 0x04000567 RID: 1383
		private Vector3 _errorSum;
	}
}
