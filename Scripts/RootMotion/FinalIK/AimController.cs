using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000060 RID: 96
	public class AimController : MonoBehaviour
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x00002B20 File Offset: 0x00000D20
		private void Start()
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002B22 File Offset: 0x00000D22
		private void LateUpdate()
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00003A2C File Offset: 0x00001C2C
		private Vector3 pivot
		{
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002B24 File Offset: 0x00000D24
		private void ApplyMinDistance()
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002B26 File Offset: 0x00000D26
		private void RootRotation()
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002B28 File Offset: 0x00000D28
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		// Token: 0x0400032E RID: 814
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		// Token: 0x0400032F RID: 815
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		// Token: 0x04000330 RID: 816
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		// Token: 0x04000331 RID: 817
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		// Token: 0x04000332 RID: 818
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		// Token: 0x04000333 RID: 819
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		// Token: 0x04000334 RID: 820
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		// Token: 0x04000335 RID: 821
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		// Token: 0x04000336 RID: 822
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		// Token: 0x04000337 RID: 823
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		// Token: 0x04000338 RID: 824
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		// Token: 0x04000339 RID: 825
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		// Token: 0x0400033A RID: 826
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Header("RootRotation")]
		public float maxRootAngle;

		// Token: 0x0400033B RID: 827
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		// Token: 0x0400033C RID: 828
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		// Token: 0x0400033D RID: 829
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		// Token: 0x0400033E RID: 830
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		// Token: 0x0400033F RID: 831
		private Transform lastTarget;

		// Token: 0x04000340 RID: 832
		private float switchWeight;

		// Token: 0x04000341 RID: 833
		private float switchWeightV;

		// Token: 0x04000342 RID: 834
		private float weightV;

		// Token: 0x04000343 RID: 835
		private Vector3 lastPosition;

		// Token: 0x04000344 RID: 836
		private Vector3 dir;

		// Token: 0x04000345 RID: 837
		private bool lastSmoothTowardsTarget;

		// Token: 0x04000346 RID: 838
		private bool turningToTarget;

		// Token: 0x04000347 RID: 839
		private float turnToTargetMlp;

		// Token: 0x04000348 RID: 840
		private float turnToTargetMlpV;
	}
}
