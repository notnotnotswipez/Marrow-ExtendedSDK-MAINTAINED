using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006C RID: 108
	public class Recoil : OffsetModifier
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00002BD5 File Offset: 0x00000DD5
		public bool isFinished
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002BDA File Offset: 0x00000DDA
		public void Fire(float magnitude)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002BDC File Offset: 0x00000DDC
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002BDE File Offset: 0x00000DDE
		private void AfterFBBIK()
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002BE0 File Offset: 0x00000DE0
		private void AfterAimIK()
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00002BE2 File Offset: 0x00000DE2
		private IKEffector primaryHandEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00002BE5 File Offset: 0x00000DE5
		private IKEffector secondaryHandEffector
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00002BE8 File Offset: 0x00000DE8
		private Transform primaryHand
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00002BEB File Offset: 0x00000DEB
		private Transform secondaryHand
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002BEE File Offset: 0x00000DEE
		protected override void OnDestroy()
		{
		}

		// Token: 0x04000375 RID: 885
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		// Token: 0x04000376 RID: 886
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		// Token: 0x04000377 RID: 887
		[Tooltip("Which hand is holding the weapon?")]
		public Recoil.Handedness handedness;

		// Token: 0x04000378 RID: 888
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		// Token: 0x04000379 RID: 889
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		// Token: 0x0400037A RID: 890
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		// Token: 0x0400037B RID: 891
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		// Token: 0x0400037C RID: 892
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		// Token: 0x0400037D RID: 893
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		// Token: 0x0400037E RID: 894
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public Recoil.RecoilOffset[] offsets;

		// Token: 0x0400037F RID: 895
		[HideInInspector]
		public Quaternion rotationOffset;

		// Token: 0x04000380 RID: 896
		private float magnitudeMlp;

		// Token: 0x04000381 RID: 897
		private float endTime;

		// Token: 0x04000382 RID: 898
		private Quaternion handRotation;

		// Token: 0x04000383 RID: 899
		private Quaternion secondaryHandRelativeRotation;

		// Token: 0x04000384 RID: 900
		private Quaternion randomRotation;

		// Token: 0x04000385 RID: 901
		private float length;

		// Token: 0x04000386 RID: 902
		private bool initiated;

		// Token: 0x04000387 RID: 903
		private float blendWeight;

		// Token: 0x04000388 RID: 904
		private float w;

		// Token: 0x04000389 RID: 905
		private Quaternion primaryHandRotation;

		// Token: 0x0400038A RID: 906
		private bool handRotationsSet;

		// Token: 0x0400038B RID: 907
		private Vector3 aimIKAxis;

		// Token: 0x020000BA RID: 186
		[Serializable]
		public class RecoilOffset
		{
			// Token: 0x06000596 RID: 1430 RVA: 0x0000303D File Offset: 0x0000123D
			public void Start()
			{
			}

			// Token: 0x06000597 RID: 1431 RVA: 0x0000303F File Offset: 0x0000123F
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			// Token: 0x04000598 RID: 1432
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			// Token: 0x04000599 RID: 1433
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			// Token: 0x0400059A RID: 1434
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			// Token: 0x0400059B RID: 1435
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public Recoil.RecoilOffset.EffectorLink[] effectorLinks;

			// Token: 0x0400059C RID: 1436
			private Vector3 additiveOffset;

			// Token: 0x0400059D RID: 1437
			private Vector3 lastOffset;

			// Token: 0x020000C9 RID: 201
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x040005CD RID: 1485
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				// Token: 0x040005CE RID: 1486
				[Tooltip("Weight of using this effector")]
				public float weight;
			}
		}

		// Token: 0x020000BB RID: 187
		[Serializable]
		public enum Handedness
		{
			// Token: 0x0400059F RID: 1439
			Right,
			// Token: 0x040005A0 RID: 1440
			Left
		}
	}
}
