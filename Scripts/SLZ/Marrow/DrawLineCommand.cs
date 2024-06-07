using System;
using UnityEngine;

namespace SLZ.Marrow
{
	// Token: 0x02000023 RID: 35
	public struct DrawLineCommand
	{
		// Token: 0x060001FF RID: 511 RVA: 0x00002CC1 File Offset: 0x00000EC1
		public void Draw(Vector3 start, Vector3 end, Color color, float startTime, float duration, bool isDrawOnce)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002CC3 File Offset: 0x00000EC3
		public void CopyToBuffers(int startBufferIndex, in Vector3[] verticies, in Color[] colors, in int[] indicies, ref int vertLength)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public void CopyToCommand(ref DrawLineCommand other)
		{
		}

		// Token: 0x04000130 RID: 304
		public float startTime;

		// Token: 0x04000131 RID: 305
		public float duration;

		// Token: 0x04000132 RID: 306
		public Vector3[] verticies;

		// Token: 0x04000133 RID: 307
		public Color[] colors;

		// Token: 0x04000134 RID: 308
		public int[] indicies;

		// Token: 0x04000135 RID: 309
		public bool isDrawOnce;
	}
}
