using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	// Token: 0x0200004F RID: 79
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x00002876 File Offset: 0x00000A76
		public void SetToReferences(VRIK.References references)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002878 File Offset: 0x00000A78
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000287A File Offset: 0x00000A7A
		public void DefaultAnimationCurves()
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000287C File Offset: 0x00000A7C
		public void AddPositionOffset(IKSolverVR.PositionOffset positionOffset, Vector3 value)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000287E File Offset: 0x00000A7E
		public void AddRotationOffset(IKSolverVR.RotationOffset rotationOffset, Quaternion value)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002880 File Offset: 0x00000A80
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002882 File Offset: 0x00000A82
		public override void FixTransforms()
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002884 File Offset: 0x00000A84
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002887 File Offset: 0x00000A87
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000288A File Offset: 0x00000A8A
		public override bool IsValid(ref string message)
		{
			return false;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000382C File Offset: 0x00001A2C
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00003844 File Offset: 0x00001A44
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000288D File Offset: 0x00000A8D
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002890 File Offset: 0x00000A90
		private void UpdateSolverTransforms()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002892 File Offset: 0x00000A92
		protected override void OnInitiate()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002894 File Offset: 0x00000A94
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002896 File Offset: 0x00000A96
		private void WriteTransforms()
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002898 File Offset: 0x00000A98
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000289A File Offset: 0x00000A9A
		private void Solve()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000385C File Offset: 0x00001A5C
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003874 File Offset: 0x00001A74
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000289C File Offset: 0x00000A9C
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000289F File Offset: 0x00000A9F
		[HideInInspector]
		public IKSolverVR.VirtualBone rootBone
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

		// Token: 0x0600030B RID: 779 RVA: 0x000028A1 File Offset: 0x00000AA1
		private void Write()
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000388C File Offset: 0x00001A8C
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		// Token: 0x0400027D RID: 637
		private Transform[] solverTransforms;

		// Token: 0x0400027E RID: 638
		private bool hasChest;

		// Token: 0x0400027F RID: 639
		private bool hasNeck;

		// Token: 0x04000280 RID: 640
		private bool hasShoulders;

		// Token: 0x04000281 RID: 641
		private bool hasToes;

		// Token: 0x04000282 RID: 642
		private bool hasLegs;

		// Token: 0x04000283 RID: 643
		private Vector3[] readPositions;

		// Token: 0x04000284 RID: 644
		private Quaternion[] readRotations;

		// Token: 0x04000285 RID: 645
		private Vector3[] solvedPositions;

		// Token: 0x04000286 RID: 646
		private Quaternion[] solvedRotations;

		// Token: 0x04000287 RID: 647
		private Quaternion[] defaultLocalRotations;

		// Token: 0x04000288 RID: 648
		private Vector3[] defaultLocalPositions;

		// Token: 0x04000289 RID: 649
		private Vector3 rootV;

		// Token: 0x0400028A RID: 650
		private Vector3 rootVelocity;

		// Token: 0x0400028B RID: 651
		private Vector3 bodyOffset;

		// Token: 0x0400028C RID: 652
		private int supportLegIndex;

		// Token: 0x0400028D RID: 653
		[Tooltip("If true, will keep the toes planted even if head target is out of reach.")]
		public bool plantFeet;

		// Token: 0x0400028F RID: 655
		[Tooltip("The spine solver.")]
		public IKSolverVR.Spine spine;

		// Token: 0x04000290 RID: 656
		[Tooltip("The left arm solver.")]
		public IKSolverVR.Arm leftArm;

		// Token: 0x04000291 RID: 657
		[Tooltip("The right arm solver.")]
		public IKSolverVR.Arm rightArm;

		// Token: 0x04000292 RID: 658
		[Tooltip("The left leg solver.")]
		public IKSolverVR.Leg leftLeg;

		// Token: 0x04000293 RID: 659
		[Tooltip("The right leg solver.")]
		public IKSolverVR.Leg rightLeg;

		// Token: 0x04000294 RID: 660
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public IKSolverVR.Locomotion locomotion;

		// Token: 0x04000295 RID: 661
		private IKSolverVR.Leg[] legs;

		// Token: 0x04000296 RID: 662
		private IKSolverVR.Arm[] arms;

		// Token: 0x04000297 RID: 663
		private Vector3 headPosition;

		// Token: 0x04000298 RID: 664
		private Vector3 headDeltaPosition;

		// Token: 0x04000299 RID: 665
		private Vector3 raycastOriginPelvis;

		// Token: 0x0400029A RID: 666
		private Vector3 lastOffset;

		// Token: 0x0400029B RID: 667
		private Vector3 debugPos1;

		// Token: 0x0400029C RID: 668
		private Vector3 debugPos2;

		// Token: 0x0400029D RID: 669
		private Vector3 debugPos3;

		// Token: 0x0400029E RID: 670
		private Vector3 debugPos4;

		// Token: 0x02000091 RID: 145
		[Serializable]
		public class Arm : IKSolverVR.BodyPart
		{
			// Token: 0x1700006A RID: 106
			// (get) Token: 0x060004AE RID: 1198 RVA: 0x00003BDC File Offset: 0x00001DDC
			// (set) Token: 0x060004AF RID: 1199 RVA: 0x00002D53 File Offset: 0x00000F53
			public Vector3 position
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

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00003BF4 File Offset: 0x00001DF4
			// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00002D55 File Offset: 0x00000F55
			public Quaternion rotation
			{
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00002D57 File Offset: 0x00000F57
			private IKSolverVR.VirtualBone shoulder
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00002D5A File Offset: 0x00000F5A
			private IKSolverVR.VirtualBone upperArm
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00002D5D File Offset: 0x00000F5D
			private IKSolverVR.VirtualBone forearm
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00002D60 File Offset: 0x00000F60
			private IKSolverVR.VirtualBone hand
			{
				get
				{
					return null;
				}
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x00002D63 File Offset: 0x00000F63
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x00002D65 File Offset: 0x00000F65
			public override void PreSolve()
			{
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x00002D67 File Offset: 0x00000F67
			public override void ApplyOffsets()
			{
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x00002D69 File Offset: 0x00000F69
			private void Stretching()
			{
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x00002D6B File Offset: 0x00000F6B
			public void Solve(bool isLeft)
			{
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x00002D6D File Offset: 0x00000F6D
			public override void ResetOffsets()
			{
			}

			// Token: 0x060004BC RID: 1212 RVA: 0x00002D6F File Offset: 0x00000F6F
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x060004BD RID: 1213 RVA: 0x00002D71 File Offset: 0x00000F71
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return 0f;
			}

			// Token: 0x060004BE RID: 1214 RVA: 0x00003C0C File Offset: 0x00001E0C
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			// Token: 0x04000447 RID: 1095
			[Tooltip("The hand target")]
			public Transform target;

			// Token: 0x04000448 RID: 1096
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			// Token: 0x04000449 RID: 1097
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target.")]
			public float positionWeight;

			// Token: 0x0400044A RID: 1098
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the hand target")]
			public float rotationWeight;

			// Token: 0x0400044B RID: 1099
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public IKSolverVR.Arm.ShoulderRotationMode shoulderRotationMode;

			// Token: 0x0400044C RID: 1100
			[Range(0f, 1f)]
			[Tooltip("The weight of shoulder rotation")]
			public float shoulderRotationWeight;

			// Token: 0x0400044D RID: 1101
			[Range(0f, 1f)]
			[Tooltip("The weight of twisting the shoulders back when arms are lifted up.")]
			public float shoulderTwistWeight;

			// Token: 0x0400044E RID: 1102
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			// Token: 0x0400044F RID: 1103
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			// Token: 0x04000450 RID: 1104
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation.")]
			public Vector3 wristToPalmAxis;

			// Token: 0x04000451 RID: 1105
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation.")]
			public Vector3 palmToThumbAxis;

			// Token: 0x04000452 RID: 1106
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the arm shorter/longer.")]
			public float armLengthMlp;

			// Token: 0x04000453 RID: 1107
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length).")]
			public AnimationCurve stretchCurve;

			// Token: 0x04000454 RID: 1108
			[HideInInspector]
			[NonSerialized]
			public Vector3 IKPosition;

			// Token: 0x04000455 RID: 1109
			[HideInInspector]
			[NonSerialized]
			public Quaternion IKRotation;

			// Token: 0x04000456 RID: 1110
			[HideInInspector]
			[NonSerialized]
			public Vector3 bendDirection;

			// Token: 0x04000457 RID: 1111
			[HideInInspector]
			[NonSerialized]
			public Vector3 handPositionOffset;

			// Token: 0x0400045A RID: 1114
			private bool hasShoulder;

			// Token: 0x0400045B RID: 1115
			private Vector3 chestForwardAxis;

			// Token: 0x0400045C RID: 1116
			private Vector3 chestUpAxis;

			// Token: 0x0400045D RID: 1117
			private Quaternion chestRotation;

			// Token: 0x0400045E RID: 1118
			private Vector3 chestForward;

			// Token: 0x0400045F RID: 1119
			private Vector3 chestUp;

			// Token: 0x04000460 RID: 1120
			private Quaternion forearmRelToUpperArm;

			// Token: 0x04000461 RID: 1121
			private const float yawOffsetAngle = 45f;

			// Token: 0x04000462 RID: 1122
			private const float pitchOffsetAngle = -30f;

			// Token: 0x020000BF RID: 191
			[Serializable]
			public enum ShoulderRotationMode
			{
				// Token: 0x040005A7 RID: 1447
				YawPitch,
				// Token: 0x040005A8 RID: 1448
				FromTo
			}
		}

		// Token: 0x02000092 RID: 146
		[Serializable]
		public abstract class BodyPart
		{
			// Token: 0x060004C0 RID: 1216
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			// Token: 0x060004C1 RID: 1217
			public abstract void PreSolve();

			// Token: 0x060004C2 RID: 1218
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			// Token: 0x060004C3 RID: 1219
			public abstract void ApplyOffsets();

			// Token: 0x060004C4 RID: 1220
			public abstract void ResetOffsets();

			// Token: 0x17000070 RID: 112
			// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00002D80 File Offset: 0x00000F80
			private float sqrMag
			{
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00002D82 File Offset: 0x00000F82
			// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00002D89 File Offset: 0x00000F89
			public float mag
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

			// Token: 0x060004C8 RID: 1224 RVA: 0x00002D8B File Offset: 0x00000F8B
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x060004C9 RID: 1225 RVA: 0x00002D8D File Offset: 0x00000F8D
			public void MovePosition(Vector3 position)
			{
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x00002D8F File Offset: 0x00000F8F
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x00002D91 File Offset: 0x00000F91
			public void RotateTo(IKSolverVR.VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			// Token: 0x04000465 RID: 1125
			[HideInInspector]
			public IKSolverVR.VirtualBone[] bones;

			// Token: 0x04000466 RID: 1126
			protected bool initiated;

			// Token: 0x04000467 RID: 1127
			protected Vector3 rootPosition;

			// Token: 0x04000468 RID: 1128
			protected Quaternion rootRotation;

			// Token: 0x04000469 RID: 1129
			protected int index;
		}

		// Token: 0x02000093 RID: 147
		[Serializable]
		public class Footstep
		{
			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060004CD RID: 1229 RVA: 0x00002D9B File Offset: 0x00000F9B
			public bool isStepping
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060004CE RID: 1230 RVA: 0x00002D9E File Offset: 0x00000F9E
			// (set) Token: 0x060004CF RID: 1231 RVA: 0x00002DA5 File Offset: 0x00000FA5
			public float stepProgress
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

			// Token: 0x060004D0 RID: 1232 RVA: 0x00002DA7 File Offset: 0x00000FA7
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x00002DAF File Offset: 0x00000FAF
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x00002DB1 File Offset: 0x00000FB1
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x00002DB3 File Offset: 0x00000FB3
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x00002DB5 File Offset: 0x00000FB5
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00002DB7 File Offset: 0x00000FB7
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}

			// Token: 0x0400046A RID: 1130
			public float stepSpeed;

			// Token: 0x0400046B RID: 1131
			public Vector3 characterSpaceOffset;

			// Token: 0x0400046C RID: 1132
			public Vector3 position;

			// Token: 0x0400046D RID: 1133
			public Quaternion rotation;

			// Token: 0x0400046E RID: 1134
			public Quaternion stepToRootRot;

			// Token: 0x0400046F RID: 1135
			public bool isSupportLeg;

			// Token: 0x04000471 RID: 1137
			public Vector3 stepFrom;

			// Token: 0x04000472 RID: 1138
			public Vector3 stepTo;

			// Token: 0x04000473 RID: 1139
			public Quaternion stepFromRot;

			// Token: 0x04000474 RID: 1140
			public Quaternion stepToRot;

			// Token: 0x04000475 RID: 1141
			private Quaternion footRelativeToRoot;

			// Token: 0x04000476 RID: 1142
			private float supportLegW;

			// Token: 0x04000477 RID: 1143
			private float supportLegWV;
		}

		// Token: 0x02000094 RID: 148
		[Serializable]
		public class Leg : IKSolverVR.BodyPart
		{
			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00003C24 File Offset: 0x00001E24
			// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00002DB9 File Offset: 0x00000FB9
			public Vector3 position
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

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00003C3C File Offset: 0x00001E3C
			// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00002DBB File Offset: 0x00000FBB
			public Quaternion rotation
			{
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060004DA RID: 1242 RVA: 0x00002DBD File Offset: 0x00000FBD
			// (set) Token: 0x060004DB RID: 1243 RVA: 0x00002DC0 File Offset: 0x00000FC0
			public bool hasToes
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

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060004DC RID: 1244 RVA: 0x00002DC2 File Offset: 0x00000FC2
			public IKSolverVR.VirtualBone thigh
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060004DD RID: 1245 RVA: 0x00002DC5 File Offset: 0x00000FC5
			private IKSolverVR.VirtualBone calf
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060004DE RID: 1246 RVA: 0x00002DC8 File Offset: 0x00000FC8
			private IKSolverVR.VirtualBone foot
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x00002DCB File Offset: 0x00000FCB
			private IKSolverVR.VirtualBone toes
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00002DCE File Offset: 0x00000FCE
			public IKSolverVR.VirtualBone lastBone
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00003C54 File Offset: 0x00001E54
			// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00002DD1 File Offset: 0x00000FD1
			public Vector3 thighRelativeToPelvis
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

			// Token: 0x060004E3 RID: 1251 RVA: 0x00002DD3 File Offset: 0x00000FD3
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x00002DD5 File Offset: 0x00000FD5
			public override void PreSolve()
			{
			}

			// Token: 0x060004E5 RID: 1253 RVA: 0x00002DD7 File Offset: 0x00000FD7
			public override void ApplyOffsets()
			{
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x00002DD9 File Offset: 0x00000FD9
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x00002DDB File Offset: 0x00000FDB
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x00002DDD File Offset: 0x00000FDD
			public void Solve(bool stretch)
			{
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x00002DDF File Offset: 0x00000FDF
			private void Stretching()
			{
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x00002DE1 File Offset: 0x00000FE1
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x00002DE3 File Offset: 0x00000FE3
			public override void ResetOffsets()
			{
			}

			// Token: 0x04000478 RID: 1144
			[Tooltip("The toe/foot target.")]
			public Transform target;

			// Token: 0x04000479 RID: 1145
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			// Token: 0x0400047A RID: 1146
			[Tooltip("Positional weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			// Token: 0x0400047B RID: 1147
			[Tooltip("Rotational weight of the toe/foot target.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			// Token: 0x0400047C RID: 1148
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			// Token: 0x0400047D RID: 1149
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the knee bending direction.")]
			public float swivelOffset;

			// Token: 0x0400047E RID: 1150
			[Range(0f, 1f)]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			public float bendToTargetWeight;

			// Token: 0x0400047F RID: 1151
			[Tooltip("Use this to make the leg shorter/longer.")]
			[Range(0.01f, 2f)]
			public float legLengthMlp;

			// Token: 0x04000480 RID: 1152
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length).")]
			public AnimationCurve stretchCurve;

			// Token: 0x04000481 RID: 1153
			[HideInInspector]
			[NonSerialized]
			public Vector3 IKPosition;

			// Token: 0x04000482 RID: 1154
			[HideInInspector]
			[NonSerialized]
			public Quaternion IKRotation;

			// Token: 0x04000483 RID: 1155
			[HideInInspector]
			[NonSerialized]
			public Vector3 footPositionOffset;

			// Token: 0x04000484 RID: 1156
			[HideInInspector]
			[NonSerialized]
			public Vector3 heelPositionOffset;

			// Token: 0x04000485 RID: 1157
			[HideInInspector]
			[NonSerialized]
			public Quaternion footRotationOffset;

			// Token: 0x04000486 RID: 1158
			[HideInInspector]
			[NonSerialized]
			public float currentMag;

			// Token: 0x0400048B RID: 1163
			private Vector3 footPosition;

			// Token: 0x0400048C RID: 1164
			private Quaternion footRotation;

			// Token: 0x0400048D RID: 1165
			private Vector3 bendNormal;

			// Token: 0x0400048E RID: 1166
			private Quaternion calfRelToThigh;

			// Token: 0x0400048F RID: 1167
			private Quaternion thighRelToFoot;

			// Token: 0x04000490 RID: 1168
			private Vector3 bendNormalRelToPelvis;

			// Token: 0x04000491 RID: 1169
			private Vector3 bendNormalRelToTarget;
		}

		// Token: 0x02000095 RID: 149
		[Serializable]
		public class Locomotion
		{
			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060004ED RID: 1261 RVA: 0x00003C6C File Offset: 0x00001E6C
			// (set) Token: 0x060004EE RID: 1262 RVA: 0x00002DED File Offset: 0x00000FED
			public Vector3 centerOfMass
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

			// Token: 0x060004EF RID: 1263 RVA: 0x00002DEF File Offset: 0x00000FEF
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			// Token: 0x060004F0 RID: 1264 RVA: 0x00003C84 File Offset: 0x00001E84
			public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Spine spine, IKSolverVR.Leg leftLeg, IKSolverVR.Leg rightLeg, IKSolverVR.Arm leftArm, IKSolverVR.Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
				leftFootPosition = default(Vector3);
				rightFootPosition = default(Vector3);
				leftFootRotation = default(Quaternion);
				rightFootRotation = default(Quaternion);
				leftFootOffset = 0f;
				rightFootOffset = 0f;
				leftHeelOffset = 0f;
				rightHeelOffset = 0f;
			}

			// Token: 0x060004F1 RID: 1265 RVA: 0x00002DF1 File Offset: 0x00000FF1
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return false;
			}

			// Token: 0x060004F2 RID: 1266 RVA: 0x00002DF4 File Offset: 0x00000FF4
			private bool CanStep()
			{
				return false;
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x00002DF7 File Offset: 0x00000FF7
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return false;
			}

			// Token: 0x04000492 RID: 1170
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			// Token: 0x04000493 RID: 1171
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			// Token: 0x04000494 RID: 1172
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			// Token: 0x04000495 RID: 1173
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			// Token: 0x04000496 RID: 1174
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			// Token: 0x04000497 RID: 1175
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			// Token: 0x04000498 RID: 1176
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			// Token: 0x04000499 RID: 1177
			[Range(0.9f, 1f)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			// Token: 0x0400049A RID: 1178
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			// Token: 0x0400049B RID: 1179
			[Tooltip("The speed of steps.")]
			public float stepSpeed;

			// Token: 0x0400049C RID: 1180
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			// Token: 0x0400049D RID: 1181
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			// Token: 0x0400049E RID: 1182
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			// Token: 0x0400049F RID: 1183
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			// Token: 0x040004A0 RID: 1184
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			// Token: 0x040004A1 RID: 1185
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			// Token: 0x040004A2 RID: 1186
			[HideInInspector]
			public bool blockingEnabled;

			// Token: 0x040004A3 RID: 1187
			[HideInInspector]
			public LayerMask blockingLayers;

			// Token: 0x040004A4 RID: 1188
			[HideInInspector]
			public float raycastRadius;

			// Token: 0x040004A5 RID: 1189
			[HideInInspector]
			public float raycastHeight;

			// Token: 0x040004A6 RID: 1190
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			// Token: 0x040004A7 RID: 1191
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			// Token: 0x040004A9 RID: 1193
			private IKSolverVR.Footstep[] footsteps;

			// Token: 0x040004AA RID: 1194
			private Vector3 lastComPosition;

			// Token: 0x040004AB RID: 1195
			private Vector3 comVelocity;

			// Token: 0x040004AC RID: 1196
			private int leftFootIndex;

			// Token: 0x040004AD RID: 1197
			private int rightFootIndex;
		}

		// Token: 0x02000096 RID: 150
		[Serializable]
		public class Spine : IKSolverVR.BodyPart
		{
			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00002E02 File Offset: 0x00001002
			public IKSolverVR.VirtualBone pelvis
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00002E05 File Offset: 0x00001005
			public IKSolverVR.VirtualBone chest
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00002E08 File Offset: 0x00001008
			public IKSolverVR.VirtualBone head
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00003CD4 File Offset: 0x00001ED4
			// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00002E0B File Offset: 0x0000100B
			public Quaternion anchorRotation
			{
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x00002E0D File Offset: 0x0000100D
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x00002E0F File Offset: 0x0000100F
			public override void PreSolve()
			{
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x00002E11 File Offset: 0x00001011
			public override void ApplyOffsets()
			{
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x00002E13 File Offset: 0x00001013
			private void CalculateChestTargetRotation(IKSolverVR.VirtualBone rootBone, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x00002E15 File Offset: 0x00001015
			public void Solve(IKSolverVR.VirtualBone rootBone, IKSolverVR.Leg[] legs, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x00002E17 File Offset: 0x00001017
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x00002E19 File Offset: 0x00001019
			private void SolvePelvis()
			{
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x00002E1B File Offset: 0x0000101B
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x00002E1D File Offset: 0x0000101D
			public override void ResetOffsets()
			{
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x00002E1F File Offset: 0x0000101F
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, IKSolverVR.Arm[] arms)
			{
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x00002E21 File Offset: 0x00001021
			public void InverseTranslateToHead(IKSolverVR.Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x00002E23 File Offset: 0x00001023
			private void TranslatePelvis(IKSolverVR.Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			// Token: 0x06000506 RID: 1286 RVA: 0x00003CEC File Offset: 0x00001EEC
			private Vector3 LimitPelvisPosition(IKSolverVR.Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x00002E25 File Offset: 0x00001025
			private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x00002E27 File Offset: 0x00001027
			private void Bend(IKSolverVR.VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			// Token: 0x040004AE RID: 1198
			[Tooltip("The head target.")]
			public Transform headTarget;

			// Token: 0x040004AF RID: 1199
			[Tooltip("The pelvis target, useful with seated rigs.")]
			public Transform pelvisTarget;

			// Token: 0x040004B0 RID: 1200
			[Tooltip("Positional weight of the head target.")]
			[Range(0f, 1f)]
			public float positionWeight;

			// Token: 0x040004B1 RID: 1201
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the head target.")]
			public float rotationWeight;

			// Token: 0x040004B2 RID: 1202
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target.")]
			public float pelvisPositionWeight;

			// Token: 0x040004B3 RID: 1203
			[Tooltip("Rotational weight of the pelvis target.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			// Token: 0x040004B4 RID: 1204
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			// Token: 0x040004B5 RID: 1205
			[Tooltip("Rotational weight of the chest target.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			// Token: 0x040004B6 RID: 1206
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			// Token: 0x040004B7 RID: 1207
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			public float bodyPosStiffness;

			// Token: 0x040004B8 RID: 1208
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			// Token: 0x040004B9 RID: 1209
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			// Token: 0x040004BA RID: 1210
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			// Token: 0x040004BB RID: 1211
			[Tooltip("Clamps chest rotation.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			// Token: 0x040004BC RID: 1212
			[Tooltip("Clamps head rotation.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			// Token: 0x040004BD RID: 1213
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			// Token: 0x040004BE RID: 1214
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition;

			// Token: 0x040004BF RID: 1215
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			// Token: 0x040004C0 RID: 1216
			[HideInInspector]
			[NonSerialized]
			public Vector3 IKPositionHead;

			// Token: 0x040004C1 RID: 1217
			[HideInInspector]
			[NonSerialized]
			public Quaternion IKRotationHead;

			// Token: 0x040004C2 RID: 1218
			[HideInInspector]
			[NonSerialized]
			public Vector3 IKPositionPelvis;

			// Token: 0x040004C3 RID: 1219
			[HideInInspector]
			[NonSerialized]
			public Quaternion IKRotationPelvis;

			// Token: 0x040004C4 RID: 1220
			[HideInInspector]
			[NonSerialized]
			public Vector3 goalPositionChest;

			// Token: 0x040004C5 RID: 1221
			[HideInInspector]
			[NonSerialized]
			public Vector3 pelvisPositionOffset;

			// Token: 0x040004C6 RID: 1222
			[HideInInspector]
			[NonSerialized]
			public Vector3 chestPositionOffset;

			// Token: 0x040004C7 RID: 1223
			[HideInInspector]
			[NonSerialized]
			public Vector3 headPositionOffset;

			// Token: 0x040004C8 RID: 1224
			[HideInInspector]
			[NonSerialized]
			public Quaternion pelvisRotationOffset;

			// Token: 0x040004C9 RID: 1225
			[HideInInspector]
			[NonSerialized]
			public Quaternion chestRotationOffset;

			// Token: 0x040004CA RID: 1226
			[HideInInspector]
			[NonSerialized]
			public Quaternion headRotationOffset;

			// Token: 0x040004CB RID: 1227
			[HideInInspector]
			[NonSerialized]
			public Vector3 faceDirection;

			// Token: 0x040004CC RID: 1228
			[HideInInspector]
			[NonSerialized]
			public Vector3 locomotionHeadPositionOffset;

			// Token: 0x040004CD RID: 1229
			[HideInInspector]
			[NonSerialized]
			public Vector3 headPosition;

			// Token: 0x040004CF RID: 1231
			private Quaternion headRotation;

			// Token: 0x040004D0 RID: 1232
			private Quaternion pelvisRotation;

			// Token: 0x040004D1 RID: 1233
			private Quaternion anchorRelativeToHead;

			// Token: 0x040004D2 RID: 1234
			private Quaternion anchorRelativeToPelvis;

			// Token: 0x040004D3 RID: 1235
			private Quaternion pelvisRelativeRotation;

			// Token: 0x040004D4 RID: 1236
			private Quaternion chestRelativeRotation;

			// Token: 0x040004D5 RID: 1237
			private Vector3 headDeltaPosition;

			// Token: 0x040004D6 RID: 1238
			private Quaternion pelvisDeltaRotation;

			// Token: 0x040004D7 RID: 1239
			private Quaternion chestTargetRotation;

			// Token: 0x040004D8 RID: 1240
			private int pelvisIndex;

			// Token: 0x040004D9 RID: 1241
			private int spineIndex;

			// Token: 0x040004DA RID: 1242
			private int chestIndex;

			// Token: 0x040004DB RID: 1243
			private int neckIndex;

			// Token: 0x040004DC RID: 1244
			private int headIndex;

			// Token: 0x040004DD RID: 1245
			private float length;

			// Token: 0x040004DE RID: 1246
			private bool hasChest;

			// Token: 0x040004DF RID: 1247
			private bool hasNeck;

			// Token: 0x040004E0 RID: 1248
			private bool hasLegs;

			// Token: 0x040004E1 RID: 1249
			private float headHeight;

			// Token: 0x040004E2 RID: 1250
			private float sizeMlp;

			// Token: 0x040004E3 RID: 1251
			private Vector3 chestForward;
		}

		// Token: 0x02000097 RID: 151
		[Serializable]
		public enum PositionOffset
		{
			// Token: 0x040004E5 RID: 1253
			Pelvis,
			// Token: 0x040004E6 RID: 1254
			Chest,
			// Token: 0x040004E7 RID: 1255
			Head,
			// Token: 0x040004E8 RID: 1256
			LeftHand,
			// Token: 0x040004E9 RID: 1257
			RightHand,
			// Token: 0x040004EA RID: 1258
			LeftFoot,
			// Token: 0x040004EB RID: 1259
			RightFoot,
			// Token: 0x040004EC RID: 1260
			LeftHeel,
			// Token: 0x040004ED RID: 1261
			RightHeel
		}

		// Token: 0x02000098 RID: 152
		[Serializable]
		public enum RotationOffset
		{
			// Token: 0x040004EF RID: 1263
			Pelvis,
			// Token: 0x040004F0 RID: 1264
			Chest,
			// Token: 0x040004F1 RID: 1265
			Head
		}

		// Token: 0x02000099 RID: 153
		[Serializable]
		public class VirtualBone
		{
			// Token: 0x0600050A RID: 1290 RVA: 0x00002E31 File Offset: 0x00001031
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x00002E39 File Offset: 0x00001039
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x00002E3B File Offset: 0x0000103B
			public static void SwingRotation(IKSolverVR.VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x00002E3D File Offset: 0x0000103D
			public static float PreSolve(ref IKSolverVR.VirtualBone[] bones)
			{
				return 0f;
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x00002E44 File Offset: 0x00001044
			public static void RotateAroundPoint(IKSolverVR.VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x00002E46 File Offset: 0x00001046
			public static void RotateBy(IKSolverVR.VirtualBone[] bones, Quaternion rotation)
			{
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x00002E48 File Offset: 0x00001048
			public static void SolveTrigonometric(IKSolverVR.VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x00003D04 File Offset: 0x00001F04
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x00002E4A File Offset: 0x0000104A
			public static void SolveFABRIK(IKSolverVR.VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x00003D1C File Offset: 0x00001F1C
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			// Token: 0x040004F2 RID: 1266
			public Vector3 readPosition;

			// Token: 0x040004F3 RID: 1267
			public Quaternion readRotation;

			// Token: 0x040004F4 RID: 1268
			public Vector3 solverPosition;

			// Token: 0x040004F5 RID: 1269
			public Quaternion solverRotation;

			// Token: 0x040004F6 RID: 1270
			public float length;

			// Token: 0x040004F7 RID: 1271
			public float sqrMag;

			// Token: 0x040004F8 RID: 1272
			public Vector3 axis;
		}
	}
}
