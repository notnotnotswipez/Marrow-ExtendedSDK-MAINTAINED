using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006B RID: 107
	public class PenetrationAvoidance : OffsetModifier
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x00002BCB File Offset: 0x00000DCB
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x04000374 RID: 884
		[Tooltip("Definitions of penetration avoidances.")]
		public PenetrationAvoidance.Avoider[] avoiders;

		// Token: 0x020000B9 RID: 185
		[Serializable]
		public class Avoider
		{
			// Token: 0x06000592 RID: 1426 RVA: 0x00003033 File Offset: 0x00001233
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x06000593 RID: 1427 RVA: 0x00003E24 File Offset: 0x00002024
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x00003E3C File Offset: 0x0000203C
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			// Token: 0x0400058E RID: 1422
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			// Token: 0x0400058F RID: 1423
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			// Token: 0x04000590 RID: 1424
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			// Token: 0x04000591 RID: 1425
			[Tooltip("Linking this to FBBIK effectors.")]
			public PenetrationAvoidance.Avoider.EffectorLink[] effectors;

			// Token: 0x04000592 RID: 1426
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			// Token: 0x04000593 RID: 1427
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			// Token: 0x04000594 RID: 1428
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			// Token: 0x04000595 RID: 1429
			private Vector3 offset;

			// Token: 0x04000596 RID: 1430
			private Vector3 offsetTarget;

			// Token: 0x04000597 RID: 1431
			private Vector3 offsetV;

			// Token: 0x020000C8 RID: 200
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040005CB RID: 1483
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				// Token: 0x040005CC RID: 1484
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;
			}
		}
	}
}
