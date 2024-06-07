using System;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001C1 RID: 449
	public class SlotPosition : MonoBehaviour
	{
		// Token: 0x06000FE6 RID: 4070 RVA: 0x000053F1 File Offset: 0x000035F1
		private void Reset()
		{
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000053F3 File Offset: 0x000035F3
		public void OnEnable()
		{
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x000053F5 File Offset: 0x000035F5
		public void EnableAndSet()
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000053F7 File Offset: 0x000035F7
		public void EnableAndSet(Vector3 position)
		{
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000053F9 File Offset: 0x000035F9
		public void DisableMesh()
		{
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000053FB File Offset: 0x000035FB
		public void SetEquippedPos()
		{
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x000053FD File Offset: 0x000035FD
		public void SetEquippedPos(Vector3 position)
		{
		}

		// Token: 0x04000B9A RID: 2970
		[Header("This is meant to set global shader variable for holographic visor")]
		[SerializeField]
		private MeshRenderer VisorRenderer;

		// Token: 0x04000B9B RID: 2971
		[SerializeField]
		private GameObject HomeTransform;

		// Token: 0x04000B9C RID: 2972
		[SerializeField]
		private Vector3 Offset;

		// Token: 0x04000B9D RID: 2973
		[SerializeField]
		private bool SetOnEnable;

		// Token: 0x04000B9E RID: 2974
		private int id;
	}
}
