using System;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000140 RID: 320
	public class OverlapTrigger : MonoBehaviour
	{
		// Token: 0x06000BA5 RID: 2981 RVA: 0x00004750 File Offset: 0x00002950
		protected void OnDisable()
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00004752 File Offset: 0x00002952
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00004754 File Offset: 0x00002954
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00004756 File Offset: 0x00002956
		public virtual void OnOverlapEnter(GameObject other)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00004758 File Offset: 0x00002958
		public virtual void OnOverlapExit(GameObject other)
		{
		}
	}
}
