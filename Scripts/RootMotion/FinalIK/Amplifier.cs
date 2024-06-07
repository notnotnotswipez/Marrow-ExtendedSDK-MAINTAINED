using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000062 RID: 98
	public class Amplifier : OffsetModifier
	{
		// Token: 0x060003FC RID: 1020 RVA: 0x00002B40 File Offset: 0x00000D40
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x0400034B RID: 843
		[Tooltip("The amplified bodies.")]
		public Amplifier.Body[] bodies;

		// Token: 0x020000AD RID: 173
		[Serializable]
		public class Body
		{
			// Token: 0x0600054E RID: 1358 RVA: 0x00002F3E File Offset: 0x0000113E
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			// Token: 0x04000545 RID: 1349
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			// Token: 0x04000546 RID: 1350
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			// Token: 0x04000547 RID: 1351
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public Amplifier.Body.EffectorLink[] effectorLinks;

			// Token: 0x04000548 RID: 1352
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			// Token: 0x04000549 RID: 1353
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			// Token: 0x0400054A RID: 1354
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			// Token: 0x0400054B RID: 1355
			private Vector3 lastRelativePos;

			// Token: 0x0400054C RID: 1356
			private Vector3 smoothDelta;

			// Token: 0x0400054D RID: 1357
			private bool firstUpdate;

			// Token: 0x020000C2 RID: 194
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040005B7 RID: 1463
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040005B8 RID: 1464
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}
	}
}
