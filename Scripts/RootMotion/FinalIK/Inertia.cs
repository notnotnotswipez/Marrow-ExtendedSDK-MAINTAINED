using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000066 RID: 102
	public class Inertia : OffsetModifier
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00002B71 File Offset: 0x00000D71
		public void ResetBodies()
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002B73 File Offset: 0x00000D73
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x04000357 RID: 855
		[Tooltip("The array of Bodies")]
		public Inertia.Body[] bodies;

		// Token: 0x04000358 RID: 856
		[Tooltip("The array of OffsetLimits")]
		public OffsetModifier.OffsetLimits[] limits;

		// Token: 0x020000B4 RID: 180
		[Serializable]
		public class Body
		{
			// Token: 0x0600057D RID: 1405 RVA: 0x00002FDB File Offset: 0x000011DB
			public void Reset()
			{
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x00002FDD File Offset: 0x000011DD
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			// Token: 0x0400056E RID: 1390
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			// Token: 0x0400056F RID: 1391
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public Inertia.Body.EffectorLink[] effectorLinks;

			// Token: 0x04000570 RID: 1392
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			// Token: 0x04000571 RID: 1393
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			// Token: 0x04000572 RID: 1394
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity;

			// Token: 0x04000573 RID: 1395
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			// Token: 0x04000574 RID: 1396
			private Vector3 delta;

			// Token: 0x04000575 RID: 1397
			private Vector3 lazyPoint;

			// Token: 0x04000576 RID: 1398
			private Vector3 direction;

			// Token: 0x04000577 RID: 1399
			private Vector3 lastPosition;

			// Token: 0x04000578 RID: 1400
			private bool firstUpdate;

			// Token: 0x020000C7 RID: 199
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040005C9 RID: 1481
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040005CA RID: 1482
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
