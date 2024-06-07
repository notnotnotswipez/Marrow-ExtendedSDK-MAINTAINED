using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002A RID: 42
	public class IKExecutionOrder : MonoBehaviour
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00002471 File Offset: 0x00000671
		private bool animatePhysics
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002474 File Offset: 0x00000674
		private void Start()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002476 File Offset: 0x00000676
		private void Update()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002478 File Offset: 0x00000678
		private void FixedUpdate()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000247A File Offset: 0x0000067A
		private void LateUpdate()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000247C File Offset: 0x0000067C
		private void FixTransforms()
		{
		}

		// Token: 0x040000EF RID: 239
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		// Token: 0x040000F0 RID: 240
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		// Token: 0x040000F1 RID: 241
		private bool fixedFrame;
	}
}
