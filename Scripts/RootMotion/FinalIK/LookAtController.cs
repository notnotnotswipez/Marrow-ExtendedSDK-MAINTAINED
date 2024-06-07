using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000067 RID: 103
	public class LookAtController : MonoBehaviour
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x00002B7D File Offset: 0x00000D7D
		private void Start()
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002B7F File Offset: 0x00000D7F
		private void LateUpdate()
		{
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00003A44 File Offset: 0x00001C44
		private Vector3 pivot
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002B81 File Offset: 0x00000D81
		private void ApplyMinDistance()
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002B83 File Offset: 0x00000D83
		private void RootRotation()
		{
		}

		// Token: 0x04000359 RID: 857
		public LookAtIK ik;

		// Token: 0x0400035A RID: 858
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		// Token: 0x0400035B RID: 859
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x0400035C RID: 860
		public Vector3 offset;

		// Token: 0x0400035D RID: 861
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		// Token: 0x0400035E RID: 862
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		// Token: 0x0400035F RID: 863
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		// Token: 0x04000360 RID: 864
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		// Token: 0x04000361 RID: 865
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		// Token: 0x04000362 RID: 866
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		// Token: 0x04000363 RID: 867
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		// Token: 0x04000364 RID: 868
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		// Token: 0x04000365 RID: 869
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		// Token: 0x04000366 RID: 870
		private Transform lastTarget;

		// Token: 0x04000367 RID: 871
		private float switchWeight;

		// Token: 0x04000368 RID: 872
		private float switchWeightV;

		// Token: 0x04000369 RID: 873
		private float weightV;

		// Token: 0x0400036A RID: 874
		private Vector3 lastPosition;

		// Token: 0x0400036B RID: 875
		private Vector3 dir;

		// Token: 0x0400036C RID: 876
		private bool lastSmoothTowardsTarget;
	}
}
