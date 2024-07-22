using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace RootMotion.FinalIK
{
	// Token: 0x02000030 RID: 48
	[RequireComponent(typeof(Animator))]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK Jobs/Aim IKJ")]
	public class AimIKJ : MonoBehaviour
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000024EB File Offset: 0x000006EB
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000024EE File Offset: 0x000006EE
		public bool initiated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000345C File Offset: 0x0000165C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000024F0 File Offset: 0x000006F0
		public Vector3 axis
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00003474 File Offset: 0x00001674
		// (set) Token: 0x06000197 RID: 407 RVA: 0x000024F2 File Offset: 0x000006F2
		public Vector3 poleAxis
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000024F4 File Offset: 0x000006F4
		private void OnEnable()
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000024F6 File Offset: 0x000006F6
		private void Update()
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000024F8 File Offset: 0x000006F8
		private void OnDisable()
		{
		}

		// Token: 0x040000F8 RID: 248
		[Tooltip("The target Transform of this solver.")]
		public Transform target;

		// Token: 0x040000F9 RID: 249
		[Tooltip("Optional secondary target for another axis of the 'Aim Transform'. Needs 'Pole Weight' to be greater than 0 to have any effect.")]
		public Transform poleTarget;

		// Token: 0x040000FA RID: 250
		[Tooltip("The transform that you want to be aimed at the target. Needs to be a lineal descendant of the bone hierarchy. For example, if you wish to aim a gun, it should be the gun, one of it's children or the hand bone.")]
		public Transform aimTransform;

		// Token: 0x040000FB RID: 251
		[Tooltip("The X value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		[Space(5f)]
		public float axisX;

		// Token: 0x040000FC RID: 252
		[Tooltip("The Y value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisY;

		// Token: 0x040000FD RID: 253
		[Tooltip("The Z value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisZ;

		// Token: 0x040000FE RID: 254
		[Space(5f)]
		[Tooltip("The X value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisX;

		// Token: 0x040000FF RID: 255
		[Tooltip("The Y value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisY;

		// Token: 0x04000100 RID: 256
		[Tooltip("The Z value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisZ;

		// Token: 0x04000101 RID: 257
		[Tooltip("The master weight of this solver.")]
		[Range(0f, 1f)]
		[Space(5f)]
		public float weight;

		// Token: 0x04000102 RID: 258
		[Tooltip("The weight of the 'Pole Target'")]
		[Range(0f, 1f)]
		public float poleWeight;

		// Token: 0x04000103 RID: 259
		[Tooltip("Minimum angular offset from last reached angle. Will stop solving if offset is less than tolerance.If tolerance is zero, will iterate until maxIterations.")]
		public float tolerance;

		// Token: 0x04000104 RID: 260
		[Tooltip("Max solver iterations per frame. If target position offset is less than 'Tolerance', will stop solving.")]
		public int maxIterations;

		// Token: 0x04000105 RID: 261
		[Range(0f, 1f)]
		[Tooltip("Clamping rotation of the solver. 0 is free rotation, 1 is completely clamped to animated rotation.")]
		public float clampWeight;

		// Token: 0x04000106 RID: 262
		[Range(0f, 2f)]
		[Tooltip("Number of sine smoothing iterations applied on clamping to make the clamping point smoother.")]
		public int clampSmoothing;

		// Token: 0x04000107 RID: 263
		[Tooltip("If true, rotation limits (if existing) will be applied on each iteration. Only RotationLimitAngle and RotationLimitHinge can be used with this solver.")]
		public bool useRotationLimits;

		// Token: 0x04000108 RID: 264
		[Tooltip("Useful for 2D games. If true, will solve only in the XY plane.")]
		public bool XY;

		// Token: 0x04000109 RID: 265
		[Tooltip("The list of bones used by the solver. Must be assigned in order of hierarchy. All bones must be in the same hierarchy branch.")]
		[Space(5f)]
		public Transform[] bones;

		// Token: 0x0400010B RID: 267
		private Animator animator;

		// Token: 0x0400010C RID: 268
		private PlayableGraph graph;

		// Token: 0x0400010D RID: 269
		private AnimationScriptPlayable IKPlayable;

		// Token: 0x0400010E RID: 270
		private AimIKJob job;
	}
}
