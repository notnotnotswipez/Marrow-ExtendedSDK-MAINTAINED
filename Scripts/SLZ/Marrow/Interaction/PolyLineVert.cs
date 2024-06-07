using System;
using Unity.Mathematics;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	// Token: 0x02000148 RID: 328
	[Serializable]
	public class PolyLineVert
	{
		// Token: 0x06000BE9 RID: 3049 RVA: 0x00004868 File Offset: 0x00002A68
		public bool IsPointInDirection(in float3 point, bool useForward)
		{
			return false;
		}

		// Token: 0x0400073C RID: 1852
		[SerializeField]
		public float3 position;

		// Token: 0x0400073D RID: 1853
		[SerializeField]
		public float3 tangent;

		// Token: 0x0400073E RID: 1854
		[SerializeField]
		public float3 normal;

		// Token: 0x0400073F RID: 1855
		[SerializeField]
		public float3 forward;

		// Token: 0x04000740 RID: 1856
		[SerializeField]
		public float3 backward;
	}
}
