using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public class Constraints
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x0000229C File Offset: 0x0000049C
		public bool IsValid()
		{
			return false;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000229F File Offset: 0x0000049F
		public void Initiate(Transform transform)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000022A1 File Offset: 0x000004A1
		public void Update()
		{
		}

		// Token: 0x04000074 RID: 116
		public Transform transform;

		// Token: 0x04000075 RID: 117
		public Transform target;

		// Token: 0x04000076 RID: 118
		public Vector3 positionOffset;

		// Token: 0x04000077 RID: 119
		public Vector3 position;

		// Token: 0x04000078 RID: 120
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x04000079 RID: 121
		public Vector3 rotationOffset;

		// Token: 0x0400007A RID: 122
		public Vector3 rotation;

		// Token: 0x0400007B RID: 123
		[Range(0f, 1f)]
		public float rotationWeight;
	}
}
