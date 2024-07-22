using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000068 RID: 104
	public abstract class OffsetModifier : MonoBehaviour
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00002B8D File Offset: 0x00000D8D
		protected float deltaTime
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000412 RID: 1042
		protected abstract void OnModifyOffset();

		// Token: 0x06000413 RID: 1043 RVA: 0x00002B94 File Offset: 0x00000D94
		protected virtual void Start()
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002B96 File Offset: 0x00000D96
		private IEnumerator Initiate()
		{
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002B99 File Offset: 0x00000D99
		private void ModifyOffset()
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002B9B File Offset: 0x00000D9B
		protected void ApplyLimits(OffsetModifier.OffsetLimits[] limits)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002B9D File Offset: 0x00000D9D
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0400036D RID: 877
		[Tooltip("The master weight")]
		public float weight;

		// Token: 0x0400036E RID: 878
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		// Token: 0x0400036F RID: 879
		protected float lastTime;

		// Token: 0x020000B5 RID: 181
		[Serializable]
		public class OffsetLimits
		{
			// Token: 0x06000580 RID: 1408 RVA: 0x00002FE7 File Offset: 0x000011E7
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x00002FE9 File Offset: 0x000011E9
			private float SpringAxis(float value, float min, float max)
			{
				return 0f;
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x00002FF0 File Offset: 0x000011F0
			private float Spring(float value, float limit, bool negative)
			{
				return 0f;
			}

			// Token: 0x04000579 RID: 1401
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			// Token: 0x0400057A RID: 1402
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			// Token: 0x0400057B RID: 1403
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			// Token: 0x0400057C RID: 1404
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			// Token: 0x0400057D RID: 1405
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			// Token: 0x0400057E RID: 1406
			[Tooltip("The limits")]
			public float minX;

			// Token: 0x0400057F RID: 1407
			[Tooltip("The limits")]
			public float maxX;

			// Token: 0x04000580 RID: 1408
			[Tooltip("The limits")]
			public float minY;

			// Token: 0x04000581 RID: 1409
			[Tooltip("The limits")]
			public float maxY;

			// Token: 0x04000582 RID: 1410
			[Tooltip("The limits")]
			public float minZ;

			// Token: 0x04000583 RID: 1411
			[Tooltip("The limits")]
			public float maxZ;
		}
	}
}
