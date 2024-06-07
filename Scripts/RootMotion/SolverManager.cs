using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000F RID: 15
	public class SolverManager : MonoBehaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000021CE File Offset: 0x000003CE
		protected virtual void InitiateSolver()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000021D0 File Offset: 0x000003D0
		protected virtual void UpdateSolver()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000021D2 File Offset: 0x000003D2
		protected virtual void FixTransforms()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000021D4 File Offset: 0x000003D4
		private bool animatePhysics
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000021D7 File Offset: 0x000003D7
		public void Initiate()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000021D9 File Offset: 0x000003D9
		private void Update()
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000021DB File Offset: 0x000003DB
		private void FixedUpdate()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000021DD File Offset: 0x000003DD
		private void LateUpdate()
		{
		}

		// Token: 0x0400004A RID: 74
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		// Token: 0x0400004B RID: 75
		public Animator animator;

		// Token: 0x0400004C RID: 76
		private bool updateFrame;

		// Token: 0x0400004D RID: 77
		private bool skipSolverUpdate;
	}
}
