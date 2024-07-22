using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000010 RID: 16
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		// Token: 0x06000065 RID: 101 RVA: 0x000021E7 File Offset: 0x000003E7
		private void OnTriggerEnter(Collider collider)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000021E9 File Offset: 0x000003E9
		private void OnTriggerStay(Collider collider)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000021EB File Offset: 0x000003EB
		private void OnTriggerExit(Collider collider)
		{
		}

		// Token: 0x0400004E RID: 78
		public GameObject target;
	}
}
