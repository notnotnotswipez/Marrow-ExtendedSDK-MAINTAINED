using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000064 RID: 100
	public class HitReaction : OffsetModifier
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00002B56 File Offset: 0x00000D56
		public bool inProgress
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002B59 File Offset: 0x00000D59
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002B5B File Offset: 0x00000D5B
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		// Token: 0x04000352 RID: 850
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReaction.HitPointEffector[] effectorHitPoints;

		// Token: 0x04000353 RID: 851
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReaction.HitPointBone[] boneHitPoints;

		// Token: 0x020000AE RID: 174
		[Serializable]
		public abstract class HitPoint
		{
			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000550 RID: 1360 RVA: 0x00002F48 File Offset: 0x00001148
			public bool inProgress
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000551 RID: 1361 RVA: 0x00002F4B File Offset: 0x0000114B
			// (set) Token: 0x06000552 RID: 1362 RVA: 0x00002F52 File Offset: 0x00001152
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

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000553 RID: 1363 RVA: 0x00002F54 File Offset: 0x00001154
			// (set) Token: 0x06000554 RID: 1364 RVA: 0x00002F5B File Offset: 0x0000115B
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

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000555 RID: 1365 RVA: 0x00003DC4 File Offset: 0x00001FC4
			// (set) Token: 0x06000556 RID: 1366 RVA: 0x00002F5D File Offset: 0x0000115D
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

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000557 RID: 1367 RVA: 0x00003DDC File Offset: 0x00001FDC
			// (set) Token: 0x06000558 RID: 1368 RVA: 0x00002F5F File Offset: 0x0000115F
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

			// Token: 0x06000559 RID: 1369 RVA: 0x00002F61 File Offset: 0x00001161
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x00002F63 File Offset: 0x00001163
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x0600055B RID: 1371
			protected abstract float GetLength();

			// Token: 0x0600055C RID: 1372
			protected abstract void CrossFadeStart();

			// Token: 0x0600055D RID: 1373
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			// Token: 0x0400054E RID: 1358
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x0400054F RID: 1359
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x04000550 RID: 1360
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			// Token: 0x04000555 RID: 1365
			private float length;

			// Token: 0x04000556 RID: 1366
			private float crossFadeSpeed;

			// Token: 0x04000557 RID: 1367
			private float lastTime;
		}

		// Token: 0x020000AF RID: 175
		[Serializable]
		public class HitPointEffector : HitReaction.HitPoint
		{
			// Token: 0x0600055F RID: 1375 RVA: 0x00002F6D File Offset: 0x0000116D
			protected override float GetLength()
			{
				return 0f;
			}

			// Token: 0x06000560 RID: 1376 RVA: 0x00002F74 File Offset: 0x00001174
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x00002F76 File Offset: 0x00001176
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x04000558 RID: 1368
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			// Token: 0x04000559 RID: 1369
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			// Token: 0x0400055A RID: 1370
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public HitReaction.HitPointEffector.EffectorLink[] effectorLinks;

			// Token: 0x020000C3 RID: 195
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x0600059D RID: 1437 RVA: 0x00003063 File Offset: 0x00001263
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				// Token: 0x0600059E RID: 1438 RVA: 0x00003065 File Offset: 0x00001265
				public void CrossFadeStart()
				{
				}

				// Token: 0x040005B9 RID: 1465
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				// Token: 0x040005BA RID: 1466
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x040005BB RID: 1467
				private Vector3 lastValue;

				// Token: 0x040005BC RID: 1468
				private Vector3 current;
			}
		}

		// Token: 0x020000B0 RID: 176
		[Serializable]
		public class HitPointBone : HitReaction.HitPoint
		{
			// Token: 0x06000563 RID: 1379 RVA: 0x00002F80 File Offset: 0x00001180
			protected override float GetLength()
			{
				return 0f;
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x00002F87 File Offset: 0x00001187
			protected override void CrossFadeStart()
			{
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x00002F89 File Offset: 0x00001189
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			// Token: 0x0400055B RID: 1371
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			// Token: 0x0400055C RID: 1372
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReaction.HitPointBone.BoneLink[] boneLinks;

			// Token: 0x0400055D RID: 1373
			private Rigidbody rigidbody;

			// Token: 0x020000C4 RID: 196
			[Serializable]
			public class BoneLink
			{
				// Token: 0x060005A0 RID: 1440 RVA: 0x0000306F File Offset: 0x0000126F
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				// Token: 0x060005A1 RID: 1441 RVA: 0x00003071 File Offset: 0x00001271
				public void CrossFadeStart()
				{
				}

				// Token: 0x040005BD RID: 1469
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				// Token: 0x040005BE RID: 1470
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				// Token: 0x040005BF RID: 1471
				private Quaternion lastValue;

				// Token: 0x040005C0 RID: 1472
				private Quaternion current;
			}
		}
	}
}
