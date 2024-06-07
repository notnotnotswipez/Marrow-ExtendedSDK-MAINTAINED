using System;
using UnityEngine;

namespace SLZ.Marrow.Data
{
	// Token: 0x0200018D RID: 397
	[CreateAssetMenu(fileName = "NewEnemyPoseData", menuName = "StressLevelZero/EnemyPoseData", order = 2)]
	public class EnemyPoseData : ScriptableObject
	{
		// Token: 0x04000A61 RID: 2657
		public Vector3[] posePositions;

		// Token: 0x04000A62 RID: 2658
		public Quaternion[] poseRotations;
	}
}
