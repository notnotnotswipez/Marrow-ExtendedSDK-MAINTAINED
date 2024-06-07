using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;

namespace RootMotion.FinalIK
{
	// Token: 0x02000033 RID: 51
	public struct CCDIKJob : IAnimationJob
	{
		// Token: 0x060001AD RID: 429 RVA: 0x0000252C File Offset: 0x0000072C
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000252E File Offset: 0x0000072E
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002530 File Offset: 0x00000730
		private void DisposeRotationLimits()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002532 File Offset: 0x00000732
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002534 File Offset: 0x00000734
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002536 File Offset: 0x00000736
		private void Update(AnimationStream s)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002538 File Offset: 0x00000738
		private void Read(AnimationStream s)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000253A File Offset: 0x0000073A
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000034BC File Offset: 0x000016BC
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000253C File Offset: 0x0000073C
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return 0f;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000034D4 File Offset: 0x000016D4
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002543 File Offset: 0x00000743
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return false;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002546 File Offset: 0x00000746
		public void Dispose()
		{
		}

		// Token: 0x0400013C RID: 316
		public TransformSceneHandle _target;

		// Token: 0x0400013D RID: 317
		public PropertySceneHandle _IKPositionWeight;

		// Token: 0x0400013E RID: 318
		public PropertySceneHandle _maxIterations;

		// Token: 0x0400013F RID: 319
		public PropertySceneHandle _tolerance;

		// Token: 0x04000140 RID: 320
		public PropertySceneHandle _XY;

		// Token: 0x04000141 RID: 321
		public PropertySceneHandle _useRotationLimits;

		// Token: 0x04000142 RID: 322
		private NativeArray<TransformStreamHandle> bones;

		// Token: 0x04000143 RID: 323
		private NativeArray<PropertySceneHandle> boneWeights;

		// Token: 0x04000144 RID: 324
		private NativeArray<float> boneSqrMags;

		// Token: 0x04000145 RID: 325
		private float chainSqrMag;

		// Token: 0x04000146 RID: 326
		private Vector3 lastLocalDirection;

		// Token: 0x04000147 RID: 327
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		// Token: 0x04000148 RID: 328
		private NativeArray<Vector3> limitAxisArray;

		// Token: 0x04000149 RID: 329
		private NativeArray<int> hingeFlags;

		// Token: 0x0400014A RID: 330
		private NativeArray<PropertySceneHandle> hingeMinArray;

		// Token: 0x0400014B RID: 331
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		// Token: 0x0400014C RID: 332
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		// Token: 0x0400014D RID: 333
		private NativeArray<Quaternion> hingeLastRotations;

		// Token: 0x0400014E RID: 334
		private NativeArray<float> hingeLastAngles;

		// Token: 0x0400014F RID: 335
		private NativeArray<int> angleFlags;

		// Token: 0x04000150 RID: 336
		private NativeArray<Vector3> angleSecondaryAxisArray;

		// Token: 0x04000151 RID: 337
		private NativeArray<PropertySceneHandle> angleLimitArray;

		// Token: 0x04000152 RID: 338
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;
	}
}
