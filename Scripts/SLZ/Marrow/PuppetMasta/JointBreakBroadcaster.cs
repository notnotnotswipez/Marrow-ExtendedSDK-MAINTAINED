using System;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000DE RID: 222
	public class JointBreakBroadcaster : MonoBehaviour
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x00003E7A File Offset: 0x0000207A
		private void OnJointBreak()
		{
		}

		// Token: 0x04000519 RID: 1305
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		// Token: 0x0400051A RID: 1306
		[SerializeField]
		[HideInInspector]
		public int muscleIndex;
	}
}
