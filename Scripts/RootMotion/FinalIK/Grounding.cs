using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000022 RID: 34
	[Serializable]
	public class Grounding
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000023A9 File Offset: 0x000005A9
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000023AC File Offset: 0x000005AC
		public Grounding.Leg[] legs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000023AE File Offset: 0x000005AE
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000023B1 File Offset: 0x000005B1
		public Grounding.Pelvis pelvis
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000023B3 File Offset: 0x000005B3
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000023B6 File Offset: 0x000005B6
		public bool isGrounded
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000023B8 File Offset: 0x000005B8
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000023BB File Offset: 0x000005BB
		public Transform root
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000033CC File Offset: 0x000015CC
		// (set) Token: 0x06000128 RID: 296 RVA: 0x000023BD File Offset: 0x000005BD
		public RaycastHit rootHit
		{
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000023BF File Offset: 0x000005BF
		public bool rootGrounded
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000033E4 File Offset: 0x000015E4
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000023C2 File Offset: 0x000005C2
		public bool IsValid(ref string errorMessage)
		{
			return false;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000023C5 File Offset: 0x000005C5
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000023C7 File Offset: 0x000005C7
		public void Update()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000033FC File Offset: 0x000015FC
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000023C9 File Offset: 0x000005C9
		public void Reset()
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000023CB File Offset: 0x000005CB
		public void LogWarning(string message)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00003414 File Offset: 0x00001614
		public Vector3 up
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000023CD File Offset: 0x000005CD
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return 0f;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000342C File Offset: 0x0000162C
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000023D4 File Offset: 0x000005D4
		private bool useRootRotation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003444 File Offset: 0x00001644
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		// Token: 0x040000D0 RID: 208
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		// Token: 0x040000D1 RID: 209
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		// Token: 0x040000D2 RID: 210
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		// Token: 0x040000D3 RID: 211
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		// Token: 0x040000D4 RID: 212
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		// Token: 0x040000D5 RID: 213
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		// Token: 0x040000D6 RID: 214
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		// Token: 0x040000D7 RID: 215
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		// Token: 0x040000D8 RID: 216
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		// Token: 0x040000D9 RID: 217
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		// Token: 0x040000DA RID: 218
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		// Token: 0x040000DB RID: 219
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		// Token: 0x040000DC RID: 220
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		// Token: 0x040000DD RID: 221
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		// Token: 0x040000DE RID: 222
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		// Token: 0x040000DF RID: 223
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		// Token: 0x040000E0 RID: 224
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		// Token: 0x040000E1 RID: 225
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Grounding.Quality quality;

		// Token: 0x040000E7 RID: 231
		private bool initiated;

		// Token: 0x0200007F RID: 127
		[Serializable]
		public enum Quality
		{
			// Token: 0x040003D0 RID: 976
			Fastest,
			// Token: 0x040003D1 RID: 977
			Simple,
			// Token: 0x040003D2 RID: 978
			Best
		}

		// Token: 0x02000080 RID: 128
		public class Leg
		{
			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000448 RID: 1096 RVA: 0x00002C2D File Offset: 0x00000E2D
			// (set) Token: 0x06000449 RID: 1097 RVA: 0x00002C30 File Offset: 0x00000E30
			public bool isGrounded
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x00003A8C File Offset: 0x00001C8C
			// (set) Token: 0x0600044B RID: 1099 RVA: 0x00002C32 File Offset: 0x00000E32
			public Vector3 IKPosition
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

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x00002C34 File Offset: 0x00000E34
			// (set) Token: 0x0600044D RID: 1101 RVA: 0x00002C37 File Offset: 0x00000E37
			public bool initiated
			{
				[CompilerGenerated]
				get
				{
					return false;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00002C39 File Offset: 0x00000E39
			// (set) Token: 0x0600044F RID: 1103 RVA: 0x00002C40 File Offset: 0x00000E40
			public float heightFromGround
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

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x00003AA4 File Offset: 0x00001CA4
			// (set) Token: 0x06000451 RID: 1105 RVA: 0x00002C42 File Offset: 0x00000E42
			public Vector3 velocity
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

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x00002C44 File Offset: 0x00000E44
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002C47 File Offset: 0x00000E47
			public Transform transform
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x00002C49 File Offset: 0x00000E49
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002C50 File Offset: 0x00000E50
			public float IKOffset
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

			// Token: 0x06000456 RID: 1110 RVA: 0x00002C52 File Offset: 0x00000E52
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00002C54 File Offset: 0x00000E54
			public void OnEnable()
			{
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x00002C56 File Offset: 0x00000E56
			public void Reset()
			{
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00002C58 File Offset: 0x00000E58
			public void Process()
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x00002C5A File Offset: 0x00000E5A
			public float stepHeightFromGround
			{
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00003ABC File Offset: 0x00001CBC
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x00003AD4 File Offset: 0x00001CD4
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x00003AEC File Offset: 0x00001CEC
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x00002C61 File Offset: 0x00000E61
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x00002C63 File Offset: 0x00000E63
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x00002C65 File Offset: 0x00000E65
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return 0f;
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00002C6C File Offset: 0x00000E6C
			private void RotateFoot()
			{
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00003B04 File Offset: 0x00001D04
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000463 RID: 1123 RVA: 0x00002C6E File Offset: 0x00000E6E
			private float rootYOffset
			{
				get
				{
					return 0f;
				}
			}

			// Token: 0x040003D5 RID: 981
			public Quaternion rotationOffset;

			// Token: 0x040003DB RID: 987
			public bool invertFootCenter;

			// Token: 0x040003DC RID: 988
			private Grounding grounding;

			// Token: 0x040003DD RID: 989
			private float lastTime;

			// Token: 0x040003DE RID: 990
			private float deltaTime;

			// Token: 0x040003DF RID: 991
			private Vector3 lastPosition;

			// Token: 0x040003E0 RID: 992
			private Quaternion toHitNormal;

			// Token: 0x040003E1 RID: 993
			private Quaternion r;

			// Token: 0x040003E2 RID: 994
			private RaycastHit heelHit;

			// Token: 0x040003E3 RID: 995
			private Vector3 up;
		}

		// Token: 0x02000081 RID: 129
		public class Pelvis
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000465 RID: 1125 RVA: 0x00003B1C File Offset: 0x00001D1C
			// (set) Token: 0x06000466 RID: 1126 RVA: 0x00002C7D File Offset: 0x00000E7D
			public Vector3 IKOffset
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

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000467 RID: 1127 RVA: 0x00002C7F File Offset: 0x00000E7F
			// (set) Token: 0x06000468 RID: 1128 RVA: 0x00002C86 File Offset: 0x00000E86
			public float heightOffset
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

			// Token: 0x06000469 RID: 1129 RVA: 0x00002C88 File Offset: 0x00000E88
			public void Initiate(Grounding grounding)
			{
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x00002C8A File Offset: 0x00000E8A
			public void Reset()
			{
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x00002C8C File Offset: 0x00000E8C
			public void OnEnable()
			{
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x00002C8E File Offset: 0x00000E8E
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			// Token: 0x040003E6 RID: 998
			private Grounding grounding;

			// Token: 0x040003E7 RID: 999
			private Vector3 lastRootPosition;

			// Token: 0x040003E8 RID: 1000
			private float damperF;

			// Token: 0x040003E9 RID: 1001
			private bool initiated;

			// Token: 0x040003EA RID: 1002
			private float lastTime;
		}
	}
}
