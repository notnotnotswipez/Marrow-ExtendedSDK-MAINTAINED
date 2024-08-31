using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace SLZ.Bonelab.VoidLogic
{
	[BurstCompile]
	public struct ClosestTransformJob : IJobParallelForTransform
	{
		public void Execute(int index, TransformAccess transform)
		{
		}

		[ReadOnly]
		public float3 targetPosition;

		public NativeArray<float> distances;
	}
}
