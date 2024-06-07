using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000DF RID: 223
	[Serializable]
	public class Muscle
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00003E84 File Offset: 0x00002084
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x00003E87 File Offset: 0x00002087
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00003E89 File Offset: 0x00002089
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00003E8C File Offset: 0x0000208C
		public Transform connectedBodyTarget
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

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00007414 File Offset: 0x00005614
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00003E8E File Offset: 0x0000208E
		public Vector3 targetAnimatedPosition
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00003E90 File Offset: 0x00002090
		public Collider[] colliders
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0000742C File Offset: 0x0000562C
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00003E93 File Offset: 0x00002093
		public Quaternion targetRotationRelative
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

		// Token: 0x06000853 RID: 2131 RVA: 0x00003E95 File Offset: 0x00002095
		public bool IsValid(bool log)
		{
			return false;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00003E98 File Offset: 0x00002098
		public void Rebuild()
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00003E9A File Offset: 0x0000209A
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00003E9C File Offset: 0x0000209C
		public void UpdateColliders()
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00003E9E File Offset: 0x0000209E
		public void DisableColliders()
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00003EA0 File Offset: 0x000020A0
		public void EnableColliders()
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00003EA2 File Offset: 0x000020A2
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00003EA4 File Offset: 0x000020A4
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00003EA6 File Offset: 0x000020A6
		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00003EA8 File Offset: 0x000020A8
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00003EAA File Offset: 0x000020AA
		public void FixTargetTransforms()
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00003EAC File Offset: 0x000020AC
		public void FullDeath(float muscleWeight, float muscleDamper, float deadMuscleWeight)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00003EAE File Offset: 0x000020AE
		public void MoveToTarget()
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00003EB0 File Offset: 0x000020B0
		public void Read()
		{
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00003EB2 File Offset: 0x000020B2
		public void ClearVelocities()
		{
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00003EB4 File Offset: 0x000020B4
		public void UpdateAnchor()
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00003EB6 File Offset: 0x000020B6
		public virtual void Update(float muscleWeightMaster, float muscleSpring, float muscleDamper, bool fixedRan, float deltaTime)
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00003EB8 File Offset: 0x000020B8
		public virtual void FixedUpdate(float t)
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00003EBA File Offset: 0x000020BA
		public void Map(float mappingWeightMaster)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00003EBC File Offset: 0x000020BC
		public void CalculateMappedVelocity()
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00003EBE File Offset: 0x000020BE
		private void MusclePdController(bool fixedRan, float deltaTime)
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00003EC0 File Offset: 0x000020C0
		private void MusclePdDrive(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00007444 File Offset: 0x00005644
		private Quaternion ParentRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0000745C File Offset: 0x0000565C
		private Quaternion targetParentRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00007474 File Offset: 0x00005674
		private Quaternion targetLocalRotation
		{
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0000748C File Offset: 0x0000568C
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000074A4 File Offset: 0x000056A4
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000074BC File Offset: 0x000056BC
		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		// Token: 0x0400051B RID: 1307
		[HideInInspector]
		public string name;

		// Token: 0x0400051C RID: 1308
		public Transform target;

		// Token: 0x0400051D RID: 1309
		public Muscle.Props props;

		// Token: 0x0400051E RID: 1310
		public Muscle.State state;

		// Token: 0x0400051F RID: 1311
		[HideInInspector]
		public int[] parentIndexes;

		// Token: 0x04000520 RID: 1312
		[HideInInspector]
		public int[] childIndexes;

		// Token: 0x04000521 RID: 1313
		[HideInInspector]
		public bool[] childFlags;

		// Token: 0x04000522 RID: 1314
		[HideInInspector]
		public int[] kinshipDegrees;

		// Token: 0x04000523 RID: 1315
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		// Token: 0x04000524 RID: 1316
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		// Token: 0x04000525 RID: 1317
		[HideInInspector]
		public Vector3 positionOffset;

		// Token: 0x04000529 RID: 1321
		[HideInInspector]
		public Vector3 mappedVelocity;

		// Token: 0x0400052A RID: 1322
		[HideInInspector]
		public Vector3 mappedAngularVelocity;

		// Token: 0x0400052C RID: 1324
		private Vector3 _defaultConnectedAnchor;

		// Token: 0x0400052D RID: 1325
		public MarrowJoint marrowJoint;

		// Token: 0x0400052E RID: 1326
		public MarrowBody marrowBody;

		// Token: 0x0400052F RID: 1327
		private Quaternion _lastTargetAnimRotation;

		// Token: 0x04000530 RID: 1328
		private Quaternion _targetAnimRotation;

		// Token: 0x04000531 RID: 1329
		private JointDrive slerpDrive;

		// Token: 0x04000532 RID: 1330
		private float _lastSlerpSpring;

		// Token: 0x04000533 RID: 1331
		private float _lastSlerpDamper;

		// Token: 0x04000534 RID: 1332
		private float _lastSlerpMaxF;

		// Token: 0x04000535 RID: 1333
		private Vector3 defaultTargetLocalPosition;

		// Token: 0x04000536 RID: 1334
		private Vector3 lastMappedPosition;

		// Token: 0x04000537 RID: 1335
		private Quaternion toParentSpace;

		// Token: 0x04000538 RID: 1336
		private Quaternion targetAnimatedRotation;

		// Token: 0x04000539 RID: 1337
		private Quaternion rotationRelativeToTarget;

		// Token: 0x0400053A RID: 1338
		private Quaternion defaultTargetLocalRotation;

		// Token: 0x0400053B RID: 1339
		private Quaternion lastMappedRotation;

		// Token: 0x0400053C RID: 1340
		private Transform targetParent;

		// Token: 0x0400053D RID: 1341
		private Transform connectedBodyTransform;

		// Token: 0x0400053E RID: 1342
		private ConfigurableJointMotion angularXMotionDefault;

		// Token: 0x0400053F RID: 1343
		private ConfigurableJointMotion angularYMotionDefault;

		// Token: 0x04000540 RID: 1344
		private ConfigurableJointMotion angularZMotionDefault;

		// Token: 0x04000541 RID: 1345
		private bool directTargetParent;

		// Token: 0x04000542 RID: 1346
		private bool initiated;

		// Token: 0x04000543 RID: 1347
		private float _maxForce;

		// Token: 0x04000544 RID: 1348
		private Collider[] _colliders;

		// Token: 0x04000545 RID: 1349
		private float lastWriteTime;

		// Token: 0x04000546 RID: 1350
		private bool[] disabledColliders;

		// Token: 0x02000246 RID: 582
		[Serializable]
		public enum Group
		{
			// Token: 0x04000ED5 RID: 3797
			Hips,
			// Token: 0x04000ED6 RID: 3798
			Spine,
			// Token: 0x04000ED7 RID: 3799
			Head,
			// Token: 0x04000ED8 RID: 3800
			Arm,
			// Token: 0x04000ED9 RID: 3801
			Hand,
			// Token: 0x04000EDA RID: 3802
			Leg,
			// Token: 0x04000EDB RID: 3803
			Foot,
			// Token: 0x04000EDC RID: 3804
			Tail,
			// Token: 0x04000EDD RID: 3805
			Prop
		}

		// Token: 0x02000247 RID: 583
		[Serializable]
		public class Props
		{
			// Token: 0x06001137 RID: 4407 RVA: 0x00005722 File Offset: 0x00003922
			public Props()
			{
			}

			// Token: 0x06001138 RID: 4408 RVA: 0x0000572A File Offset: 0x0000392A
			public Props(float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Muscle.Group group = Muscle.Group.Hips)
			{
			}

			// Token: 0x04000EDE RID: 3806
			[Tooltip("Which body part does this muscle belong to?")]
			public Muscle.Group group;

			// Token: 0x04000EDF RID: 3807
			[Range(0f, 1f)]
			[Tooltip("The weight (multiplier) of mapping this muscle's target to the muscle.")]
			public float mappingWeight;

			// Token: 0x04000EE0 RID: 3808
			[Range(0f, 1f)]
			[Tooltip("The muscle strength (multiplier).")]
			public float muscleWeight;

			// Token: 0x04000EE1 RID: 3809
			[Range(0f, 1f)]
			[Tooltip("Multiplier of the positionDamper of the ConfigurableJoints' Slerp Drive.")]
			public float muscleDamper;

			// Token: 0x04000EE2 RID: 3810
			[Tooltip("If true, will map the target to the world space position of the muscle. Normally this should be true for only the root muscle (the hips).")]
			public bool mapPosition;

			// Token: 0x04000EE3 RID: 3811
			public int[] ignoredMuscleIndexs;
		}

		// Token: 0x02000248 RID: 584
		public struct State
		{
			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06001139 RID: 4409 RVA: 0x0000889C File Offset: 0x00006A9C
			public static Muscle.State Default
			{
				get
				{
					return default(Muscle.State);
				}
			}

			// Token: 0x04000EE4 RID: 3812
			public float mappingWeightMlp;

			// Token: 0x04000EE5 RID: 3813
			public float muscleWeightMlp;

			// Token: 0x04000EE6 RID: 3814
			public float muscleDamperMlp;

			// Token: 0x04000EE7 RID: 3815
			public float maxForceMlp;

			// Token: 0x04000EE8 RID: 3816
			public float muscleDamperAdd;

			// Token: 0x04000EE9 RID: 3817
			public float immunity;

			// Token: 0x04000EEA RID: 3818
			public float impulseMlp;
		}
	}
}
