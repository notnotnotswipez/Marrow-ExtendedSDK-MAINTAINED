using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace RootMotion.FinalIK
{
	// Token: 0x02000032 RID: 50
	[RequireComponent(typeof(Animator))]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK Jobs/CCD IKJ")]
	public class CCDIKJ : MonoBehaviour
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002519 File Offset: 0x00000719
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000251C File Offset: 0x0000071C
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

		// Token: 0x060001A9 RID: 425 RVA: 0x0000251E File Offset: 0x0000071E
		private void OnEnable()
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002520 File Offset: 0x00000720
		private void Update()
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002522 File Offset: 0x00000722
		private void OnDisable()
		{
		}

		// Token: 0x04000130 RID: 304
		[Tooltip("The target Transform of this solver.")]
		public Transform target;

		// Token: 0x04000131 RID: 305
		[Tooltip("The master weight of this solver.")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04000132 RID: 306
		[Tooltip("Minimum offset from last reached position. Will stop solving if offset is less than tolerance.If tolerance is zero, will iterate until maxIterations.")]
		public float tolerance;

		// Token: 0x04000133 RID: 307
		[Tooltip("Max solver iterations per frame. If target position offset is less than 'Tolerance', will stop solving.")]
		public int maxIterations;

		// Token: 0x04000134 RID: 308
		[Tooltip("If true, rotation limits (if existing) will be applied on each iteration. Only RotationLimitAngle and RotationLimitHinge can be used with this solver.")]
		public bool useRotationLimits;

		// Token: 0x04000135 RID: 309
		[Tooltip("Useful for 2D games. If true, will solve only in the XY plane.")]
		public bool XY;

		// Token: 0x04000136 RID: 310
		[Tooltip("The list of bones used by the solver. Must be assigned in order of hierarchy. All bones must be in the same hierarchy branch.")]
		public Transform[] bones;

		// Token: 0x04000138 RID: 312
		private Animator animator;

		// Token: 0x04000139 RID: 313
		private PlayableGraph graph;

		// Token: 0x0400013A RID: 314
		private AnimationScriptPlayable IKPlayable;

		// Token: 0x0400013B RID: 315
		private CCDIKJob job;
	}
}
