using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200005A RID: 90
	[RequireComponent(typeof(Animator))]
	public class RagdollUtility : MonoBehaviour
	{
		// Token: 0x060003AC RID: 940 RVA: 0x00002A80 File Offset: 0x00000C80
		public void EnableRagdoll()
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002A82 File Offset: 0x00000C82
		public void DisableRagdoll()
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002A84 File Offset: 0x00000C84
		public void Start()
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002A86 File Offset: 0x00000C86
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002A89 File Offset: 0x00000C89
		private void Update()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002A8B File Offset: 0x00000C8B
		private void FixedUpdate()
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002A8D File Offset: 0x00000C8D
		private void LateUpdate()
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002A8F File Offset: 0x00000C8F
		private void AfterLastIK()
		{
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002A91 File Offset: 0x00000C91
		private void AfterAnimation()
		{
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002A93 File Offset: 0x00000C93
		private void OnFinalPose()
		{
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002A95 File Offset: 0x00000C95
		private void RagdollEnabler()
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00002A97 File Offset: 0x00000C97
		private bool isRagdoll
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002A9A File Offset: 0x00000C9A
		private void RecordVelocities()
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00002A9C File Offset: 0x00000C9C
		private bool ikUsed
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002A9F File Offset: 0x00000C9F
		private void StoreLocalState()
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002AA1 File Offset: 0x00000CA1
		private void FixTransforms(float weight)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002AA3 File Offset: 0x00000CA3
		private void OnDestroy()
		{
		}

		// Token: 0x0400030A RID: 778
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		// Token: 0x0400030B RID: 779
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		// Token: 0x0400030C RID: 780
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		// Token: 0x0400030D RID: 781
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		// Token: 0x0400030E RID: 782
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		// Token: 0x0400030F RID: 783
		private Animator animator;

		// Token: 0x04000310 RID: 784
		private RagdollUtility.Rigidbone[] rigidbones;

		// Token: 0x04000311 RID: 785
		private RagdollUtility.Child[] children;

		// Token: 0x04000312 RID: 786
		private bool enableRagdollFlag;

		// Token: 0x04000313 RID: 787
		private AnimatorUpdateMode animatorUpdateMode;

		// Token: 0x04000314 RID: 788
		private IK[] allIKComponents;

		// Token: 0x04000315 RID: 789
		private bool[] fixTransforms;

		// Token: 0x04000316 RID: 790
		private float ragdollWeight;

		// Token: 0x04000317 RID: 791
		private float ragdollWeightV;

		// Token: 0x04000318 RID: 792
		private bool fixedFrame;

		// Token: 0x04000319 RID: 793
		private bool[] disabledIKComponents;

		// Token: 0x020000A6 RID: 166
		public class Rigidbone
		{
			// Token: 0x06000532 RID: 1330 RVA: 0x00002EDA File Offset: 0x000010DA
			public Rigidbone(Rigidbody r)
			{
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x00002EE2 File Offset: 0x000010E2
			public void RecordVelocity()
			{
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x00002EE4 File Offset: 0x000010E4
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}

			// Token: 0x04000525 RID: 1317
			public Rigidbody r;

			// Token: 0x04000526 RID: 1318
			public Transform t;

			// Token: 0x04000527 RID: 1319
			public Collider collider;

			// Token: 0x04000528 RID: 1320
			public Joint joint;

			// Token: 0x04000529 RID: 1321
			public Rigidbody c;

			// Token: 0x0400052A RID: 1322
			public bool updateAnchor;

			// Token: 0x0400052B RID: 1323
			public Vector3 deltaPosition;

			// Token: 0x0400052C RID: 1324
			public Quaternion deltaRotation;

			// Token: 0x0400052D RID: 1325
			public float deltaTime;

			// Token: 0x0400052E RID: 1326
			public Vector3 lastPosition;

			// Token: 0x0400052F RID: 1327
			public Quaternion lastRotation;
		}

		// Token: 0x020000A7 RID: 167
		public class Child
		{
			// Token: 0x06000535 RID: 1333 RVA: 0x00002EE6 File Offset: 0x000010E6
			public Child(Transform transform)
			{
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x00002EEE File Offset: 0x000010EE
			public void FixTransform(float weight)
			{
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x00002EF0 File Offset: 0x000010F0
			public void StoreLocalState()
			{
			}

			// Token: 0x04000530 RID: 1328
			public Transform t;

			// Token: 0x04000531 RID: 1329
			public Vector3 localPosition;

			// Token: 0x04000532 RID: 1330
			public Quaternion localRotation;
		}
	}
}
