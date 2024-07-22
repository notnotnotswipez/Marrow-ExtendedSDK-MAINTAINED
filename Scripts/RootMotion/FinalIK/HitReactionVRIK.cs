using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000065 RID: 101
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00002B65 File Offset: 0x00000D65
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002B67 File Offset: 0x00000D67
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		// Token: 0x04000354 RID: 852
		public AnimationCurve[] offsetCurves;

		// Token: 0x04000355 RID: 853
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReactionVRIK.PositionOffset[] positionOffsets;

		// Token: 0x04000356 RID: 854
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReactionVRIK.RotationOffset[] rotationOffsets;

		// Token: 0x020000B1 RID: 177
		[Serializable]
		public abstract class Offset
		{
			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000567 RID: 1383 RVA: 0x00002F93 File Offset: 0x00001193
			// (set) Token: 0x06000568 RID: 1384 RVA: 0x00002F9A File Offset: 0x0000119A
			private protected float crossFader
			{
				[CompilerGenerated]
				 get
				{
					return 0f;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000569 RID: 1385 RVA: 0x00002F9C File Offset: 0x0000119C
			// (set) Token: 0x0600056A RID: 1386 RVA: 0x00002FA3 File Offset: 0x000011A3
			private protected float timer
			{
				[CompilerGenerated]
				 get
				{
					return 0f;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x0600056B RID: 1387 RVA: 0x00003DF4 File Offset: 0x00001FF4
			// (set) Token: 0x0600056C RID: 1388 RVA: 0x00002FA5 File Offset: 0x000011A5
			private protected Vector3 force
			{
				[CompilerGenerated]
				 get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x0600056D RID: 1389 RVA: 0x00003E0C File Offset: 0x0000200C
			// (set) Token: 0x0600056E RID: 1390 RVA: 0x00002FA7 File Offset: 0x000011A7
			private protected Vector3 point
			{
				[CompilerGenerated]
				 get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x00002FA9 File Offset: 0x000011A9
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00002FAB File Offset: 0x000011AB
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x06000571 RID: 1393
			protected abstract float GetLength(AnimationCurve[] curves);

			// Token: 0x06000572 RID: 1394
			protected abstract void CrossFadeStart();

			// Token: 0x06000573 RID: 1395
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			// Token: 0x0400055E RID: 1374
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x0400055F RID: 1375
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x04000560 RID: 1376
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			// Token: 0x04000565 RID: 1381
			private float length;

			// Token: 0x04000566 RID: 1382
			private float crossFadeSpeed;

			// Token: 0x04000567 RID: 1383
			private float lastTime;
		}

		// Token: 0x020000B2 RID: 178
		[Serializable]
		public class PositionOffset : HitReactionVRIK.Offset
		{
			// Token: 0x06000575 RID: 1397 RVA: 0x00002FB5 File Offset: 0x000011B5
			protected override float GetLength(AnimationCurve[] curves)
			{
				return 0f;
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x00002FBC File Offset: 0x000011BC
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00002FBE File Offset: 0x000011BE
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x04000568 RID: 1384
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			// Token: 0x04000569 RID: 1385
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			// Token: 0x0400056A RID: 1386
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks;

			// Token: 0x020000C5 RID: 197
			[Serializable]
			public class PositionOffsetLink
			{
				// Token: 0x060005A3 RID: 1443 RVA: 0x0000307B File Offset: 0x0000127B
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				// Token: 0x060005A4 RID: 1444 RVA: 0x0000307D File Offset: 0x0000127D
				public void CrossFadeStart()
				{
				}

				// Token: 0x040005C1 RID: 1473
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				// Token: 0x040005C2 RID: 1474
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x040005C3 RID: 1475
				private Vector3 lastValue;

				// Token: 0x040005C4 RID: 1476
				private Vector3 current;
			}
		}

		// Token: 0x020000B3 RID: 179
		[Serializable]
		public class RotationOffset : HitReactionVRIK.Offset
		{
			// Token: 0x06000579 RID: 1401 RVA: 0x00002FC8 File Offset: 0x000011C8
			protected override float GetLength(AnimationCurve[] curves)
			{
				return 0f;
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00002FCF File Offset: 0x000011CF
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00002FD1 File Offset: 0x000011D1
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			// Token: 0x0400056B RID: 1387
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			// Token: 0x0400056C RID: 1388
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks;

			// Token: 0x0400056D RID: 1389
			private Rigidbody rigidbody;

			// Token: 0x020000C6 RID: 198
			[Serializable]
			public class RotationOffsetLink
			{
				// Token: 0x060005A6 RID: 1446 RVA: 0x00003087 File Offset: 0x00001287
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				// Token: 0x060005A7 RID: 1447 RVA: 0x00003089 File Offset: 0x00001289
				public void CrossFadeStart()
				{
				}

				// Token: 0x040005C5 RID: 1477
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				// Token: 0x040005C6 RID: 1478
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				// Token: 0x040005C7 RID: 1479
				private Quaternion lastValue;

				// Token: 0x040005C8 RID: 1480
				private Quaternion current;
			}
		}
	}
}
