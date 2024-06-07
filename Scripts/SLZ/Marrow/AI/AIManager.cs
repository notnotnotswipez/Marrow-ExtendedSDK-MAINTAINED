using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

namespace SLZ.Marrow.AI
{
	// Token: 0x020001BA RID: 442
	public class AIManager : MonoBehaviour
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00005374 File Offset: 0x00003574
		public static AIManager Instance
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00005377 File Offset: 0x00003577
		private void Awake()
		{
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00005379 File Offset: 0x00003579
		private void LateUpdate()
		{
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0000537B File Offset: 0x0000357B
		public void AddSensorTransform(Transform t, bool isSkipSensorCalc = false)
		{
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0000537D File Offset: 0x0000357D
		public void RemoveSensorTransform(Transform t)
		{
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0000537F File Offset: 0x0000357F
		public void OnDisable()
		{
		}

		// Token: 0x04000B59 RID: 2905
		[Tooltip("Sets the maximum amount of sensors that can be considered for calculation")]
		public int maxSensorCount;

		// Token: 0x04000B5A RID: 2906
		private TransformAccessArray _aiSensorTransforms;

		// Token: 0x04000B5B RID: 2907
		private Dictionary<Transform, int> _aiSensorKeyToIndexMap;

		// Token: 0x04000B5C RID: 2908
		private NativeArray<RaycastCommand> _aiRaycastCommands;

		// Token: 0x04000B5D RID: 2909
		private NativeArray<RaycastHit> _aiRaycastHits;

		// Token: 0x04000B5E RID: 2910
		private NativeArray<AIManager.AICompareInput> _aiInput;

		// Token: 0x04000B5F RID: 2911
		private NativeArray<AIManager.AICompareResult> _aiResults;

		// Token: 0x04000B60 RID: 2912
		private NativeArray<Vector3> _nPostionBuffer;

		// Token: 0x04000B61 RID: 2913
		private NativeArray<Quaternion> _nRotationBuffer;

		// Token: 0x04000B62 RID: 2914
		private static AIManager _instance;

		// Token: 0x04000B63 RID: 2915
		private AIManager.CopyToTransformBufferJob _copySensorTransformJob;

		// Token: 0x04000B64 RID: 2916
		private AIManager.AICompareJob _aiCompareJob;

		// Token: 0x04000B65 RID: 2917
		private JobHandle _copySensorTransformHandle;

		// Token: 0x04000B66 RID: 2918
		private JobHandle _aiCompareJobHandle;

		// Token: 0x04000B67 RID: 2919
		private JobHandle _aiRaycastCommandHandle;

		// Token: 0x020002C1 RID: 705
		public struct AICompareResult
		{
			// Token: 0x04001121 RID: 4385
			public float distance;

			// Token: 0x04001122 RID: 4386
			public float angle;
		}

		// Token: 0x020002C2 RID: 706
		public struct AICompareInput
		{
			// Token: 0x04001123 RID: 4387
			public int isSkipSensorCalc;
		}

		// Token: 0x020002C3 RID: 707
		public struct CopyToTransformBufferJob : IJobParallelForTransform
		{
			// Token: 0x06001451 RID: 5201 RVA: 0x00005DCF File Offset: 0x00003FCF
			public void Execute(int i, TransformAccess transform)
			{
			}

			// Token: 0x04001124 RID: 4388
			public NativeArray<Vector3> positionBuffer;

			// Token: 0x04001125 RID: 4389
			public NativeArray<Quaternion> rotationBuffer;
		}

		// Token: 0x020002C4 RID: 708
		public struct AICompareJob : IJobParallelFor
		{
			// Token: 0x06001452 RID: 5202 RVA: 0x00005DD1 File Offset: 0x00003FD1
			public void Execute(int i)
			{
			}

			// Token: 0x04001126 RID: 4390
			[ReadOnly]
			public NativeArray<Vector3> positionBuffer;

			// Token: 0x04001127 RID: 4391
			[ReadOnly]
			public NativeArray<Quaternion> rotationBuffer;

			// Token: 0x04001128 RID: 4392
			[ReadOnly]
			public int length;

			// Token: 0x04001129 RID: 4393
			public NativeArray<RaycastCommand> aiRaycastCommands;

			// Token: 0x0400112A RID: 4394
			public NativeArray<AIManager.AICompareResult> aiResults;
		}
	}
}
