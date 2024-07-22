using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000038 RID: 56
	public class FBBIKHeadEffector : MonoBehaviour
	{
		// Token: 0x060001CA RID: 458 RVA: 0x0000256F File Offset: 0x0000076F
		private void Start()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002571 File Offset: 0x00000771
		private void OnStoreDefaultLocalState()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002573 File Offset: 0x00000773
		private void OnFixTransforms()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002575 File Offset: 0x00000775
		private void OnPreRead()
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002577 File Offset: 0x00000777
		private void SpineBend()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002579 File Offset: 0x00000779
		private void CCDPass()
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000257B File Offset: 0x0000077B
		private void Iterate(int iteration)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000257D File Offset: 0x0000077D
		private void OnPostUpdate()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000257F File Offset: 0x0000077F
		private void ChestDirection()
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002581 File Offset: 0x00000781
		private void PostStretching()
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002583 File Offset: 0x00000783
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002585 File Offset: 0x00000785
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002587 File Offset: 0x00000787
		private void OnDestroy()
		{
		}

		// Token: 0x04000160 RID: 352
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		// Token: 0x04000161 RID: 353
		[LargeHeader("Position")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		public float positionWeight;

		// Token: 0x04000162 RID: 354
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		// Token: 0x04000163 RID: 355
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		// Token: 0x04000164 RID: 356
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		// Token: 0x04000165 RID: 357
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x04000166 RID: 358
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		// Token: 0x04000167 RID: 359
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		// Token: 0x04000168 RID: 360
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		// Token: 0x04000169 RID: 361
		[Tooltip("The bones to use for bending.")]
		public FBBIKHeadEffector.BendBone[] bendBones;

		// Token: 0x0400016A RID: 362
		[Range(0f, 1f)]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		public float CCDWeight;

		// Token: 0x0400016B RID: 363
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		// Token: 0x0400016C RID: 364
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		// Token: 0x0400016D RID: 365
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		// Token: 0x0400016E RID: 366
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		[LargeHeader("Stretching")]
		public float postStretchWeight;

		// Token: 0x0400016F RID: 367
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		// Token: 0x04000170 RID: 368
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		// Token: 0x04000171 RID: 369
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		// Token: 0x04000172 RID: 370
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		// Token: 0x04000173 RID: 371
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		// Token: 0x04000174 RID: 372
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		// Token: 0x04000175 RID: 373
		public Transform[] chestBones;

		// Token: 0x04000176 RID: 374
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		// Token: 0x04000177 RID: 375
		private Vector3 offset;

		// Token: 0x04000178 RID: 376
		private Vector3 headToBody;

		// Token: 0x04000179 RID: 377
		private Vector3 shoulderCenterToHead;

		// Token: 0x0400017A RID: 378
		private Vector3 headToLeftThigh;

		// Token: 0x0400017B RID: 379
		private Vector3 headToRightThigh;

		// Token: 0x0400017C RID: 380
		private Vector3 leftShoulderPos;

		// Token: 0x0400017D RID: 381
		private Vector3 rightShoulderPos;

		// Token: 0x0400017E RID: 382
		private float shoulderDist;

		// Token: 0x0400017F RID: 383
		private float leftShoulderDist;

		// Token: 0x04000180 RID: 384
		private float rightShoulderDist;

		// Token: 0x04000181 RID: 385
		private Quaternion chestRotation;

		// Token: 0x04000182 RID: 386
		private Quaternion headRotationRelativeToRoot;

		// Token: 0x04000183 RID: 387
		private Quaternion[] ccdDefaultLocalRotations;

		// Token: 0x04000184 RID: 388
		private Vector3 headLocalPosition;

		// Token: 0x04000185 RID: 389
		private Quaternion headLocalRotation;

		// Token: 0x04000186 RID: 390
		private Vector3[] stretchLocalPositions;

		// Token: 0x04000187 RID: 391
		private Quaternion[] stretchLocalRotations;

		// Token: 0x04000188 RID: 392
		private Vector3[] chestLocalPositions;

		// Token: 0x04000189 RID: 393
		private Quaternion[] chestLocalRotations;

		// Token: 0x0400018A RID: 394
		private int bendBonesCount;

		// Token: 0x0400018B RID: 395
		private int ccdBonesCount;

		// Token: 0x0400018C RID: 396
		private int stretchBonesCount;

		// Token: 0x0400018D RID: 397
		private int chestBonesCount;

		// Token: 0x02000083 RID: 131
		[Serializable]
		public class BendBone
		{
			// Token: 0x06000474 RID: 1140 RVA: 0x00002CB7 File Offset: 0x00000EB7
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x00002CB9 File Offset: 0x00000EB9
			public void FixTransforms()
			{
			}

			// Token: 0x04000401 RID: 1025
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			// Token: 0x04000402 RID: 1026
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			// Token: 0x04000403 RID: 1027
			private Quaternion defaultLocalRotation;
		}
	}
}
