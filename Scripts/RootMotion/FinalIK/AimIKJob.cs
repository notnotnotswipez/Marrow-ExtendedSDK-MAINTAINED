using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;

namespace RootMotion.FinalIK
{
	// Token: 0x02000031 RID: 49
	public struct AimIKJob : IAnimationJob
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00002502 File Offset: 0x00000702
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002504 File Offset: 0x00000704
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002506 File Offset: 0x00000706
		private void DisposeRotationLimits()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002508 File Offset: 0x00000708
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000250A File Offset: 0x0000070A
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000250C File Offset: 0x0000070C
		private void Update(AnimationStream s)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000250E File Offset: 0x0000070E
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002510 File Offset: 0x00000710
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return 0f;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000348C File Offset: 0x0000168C
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000034A4 File Offset: 0x000016A4
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002517 File Offset: 0x00000717
		public void Dispose()
		{
		}

		// Token: 0x0400010F RID: 271
		public TransformSceneHandle _target;

		// Token: 0x04000110 RID: 272
		public TransformSceneHandle _poleTarget;

		// Token: 0x04000111 RID: 273
		public TransformStreamHandle _transform;

		// Token: 0x04000112 RID: 274
		public PropertySceneHandle _IKPositionWeight;

		// Token: 0x04000113 RID: 275
		public PropertySceneHandle _poleWeight;

		// Token: 0x04000114 RID: 276
		public PropertySceneHandle _axisX;

		// Token: 0x04000115 RID: 277
		public PropertySceneHandle _axisY;

		// Token: 0x04000116 RID: 278
		public PropertySceneHandle _axisZ;

		// Token: 0x04000117 RID: 279
		public PropertySceneHandle _poleAxisX;

		// Token: 0x04000118 RID: 280
		public PropertySceneHandle _poleAxisY;

		// Token: 0x04000119 RID: 281
		public PropertySceneHandle _poleAxisZ;

		// Token: 0x0400011A RID: 282
		public PropertySceneHandle _clampWeight;

		// Token: 0x0400011B RID: 283
		public PropertySceneHandle _clampSmoothing;

		// Token: 0x0400011C RID: 284
		public PropertySceneHandle _maxIterations;

		// Token: 0x0400011D RID: 285
		public PropertySceneHandle _tolerance;

		// Token: 0x0400011E RID: 286
		public PropertySceneHandle _XY;

		// Token: 0x0400011F RID: 287
		public PropertySceneHandle _useRotationLimits;

		// Token: 0x04000120 RID: 288
		private NativeArray<TransformStreamHandle> bones;

		// Token: 0x04000121 RID: 289
		private NativeArray<PropertySceneHandle> boneWeights;

		// Token: 0x04000122 RID: 290
		private Vector3 lastLocalDirection;

		// Token: 0x04000123 RID: 291
		private float step;

		// Token: 0x04000124 RID: 292
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		// Token: 0x04000125 RID: 293
		private NativeArray<Vector3> limitAxisArray;

		// Token: 0x04000126 RID: 294
		private NativeArray<int> hingeFlags;

		// Token: 0x04000127 RID: 295
		private NativeArray<PropertySceneHandle> hingeMinArray;

		// Token: 0x04000128 RID: 296
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		// Token: 0x04000129 RID: 297
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		// Token: 0x0400012A RID: 298
		private NativeArray<Quaternion> hingeLastRotations;

		// Token: 0x0400012B RID: 299
		private NativeArray<float> hingeLastAngles;

		// Token: 0x0400012C RID: 300
		private NativeArray<int> angleFlags;

		// Token: 0x0400012D RID: 301
		private NativeArray<Vector3> angleSecondaryAxisArray;

		// Token: 0x0400012E RID: 302
		private NativeArray<PropertySceneHandle> angleLimitArray;

		// Token: 0x0400012F RID: 303
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;
	}
}
