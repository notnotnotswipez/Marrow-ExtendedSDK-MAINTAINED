using System;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001C0 RID: 448
	public class RoamArea : MonoBehaviour
	{
		// Token: 0x06000FE3 RID: 4067 RVA: 0x000085B4 File Offset: 0x000067B4
		public Vector3 GetRoamTarget()
		{
			return default(Vector3);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000085CC File Offset: 0x000067CC
		public Vector3 GetRoamTarget3D()
		{
			return default(Vector3);
		}

		// Token: 0x04000B94 RID: 2964
		private Color gizmoColorRoam;

		// Token: 0x04000B95 RID: 2965
		public Vector2 roamScale;

		// Token: 0x04000B96 RID: 2966
		public Vector3 roamScale3D;

		// Token: 0x04000B97 RID: 2967
		public float uniformScale;

		// Token: 0x04000B98 RID: 2968
		[HideInInspector]
		public bool roamScaleVis;

		// Token: 0x04000B99 RID: 2969
		[HideInInspector]
		public bool roamScale3DVis;
	}
}
